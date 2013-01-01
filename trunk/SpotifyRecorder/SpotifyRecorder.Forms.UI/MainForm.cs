using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SpotifyRecorder.Forms.UI
{
    public partial class MainForm : Form
    {
        private IWaveIn waveIn;
        private WaveFileWriter writer;
        private Timer songTicker;

        public MainForm()
        {
            InitializeComponent();

            //check if it is windows 7
            if (Environment.OSVersion.Version.Major < 6)
            {
                MessageBox.Show("This application is optimized for windows 7");
                Close();
            }

            Load += OnLoad;
            Closing += OnClosing;
        }

        /// <summary>
        /// After the form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void OnLoad(object sender, EventArgs eventArgs)
        {
            //load the available devices
            LoadWasapiDevicesCombo();

            //load the different bitrates
            LoadBitrateCombo();

            //check if spotify title is changing
            songTicker = new Timer { Interval = 100 };
            songTicker.Tick += songTicker_Tick;
            songTicker.Start();

            //set the default output to the music directory
            outputFolderTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "SpotifyRecorder");
            if (!Directory.Exists(outputFolderTextBox.Text))
                Directory.CreateDirectory(outputFolderTextBox.Text);

            //set the change event if song is 
            songLabel.Text = string.Empty;
            songLabel.TextChanged += songLabel_TextChanged;

            versionLabel.Text = string.Format("Version {0}",Application.ProductVersion);
        }

        /// <summary>
        /// When the application is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cancelEventArgs"></param>
        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            StopRecording(songLabel.Text);
        }

        void songTicker_Tick(object sender, EventArgs e)
        {
            //get the current title from spotify
            string song = GetSpotifySong();

            if (!songLabel.Text.Equals(song))
            {
                if (songLabel.Text.Trim().Length > 0)
                {
                    StopRecording(songLabel.Text);
                }
                songLabel.Text = song;
            }
        }

        void songLabel_TextChanged(object sender, EventArgs e)
        {
            RecordSong(songLabel.Text);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxRecordings.SelectedItem != null)
            {
                Process.Start(CreateOutputFile((string)listBoxRecordings.SelectedItem,"mp3"));
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecordings.SelectedItem != null)
            {
                try
                {
                    File.Delete(CreateOutputFile((string)listBoxRecordings.SelectedItem, "mp3"));
                    listBoxRecordings.Items.Remove(listBoxRecordings.SelectedItem);
                    if (listBoxRecordings.Items.Count > 0)
                    {
                        listBoxRecordings.SelectedIndex = 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not delete recording");
                }
            }
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(outputFolderTextBox.Text);
        }

        private void buttonStartRecording_Click(object sender, EventArgs e)
        {
            buttonStartRecording.Enabled = false;
            RecordSong(songLabel.Text);
        }

        private void buttonStopRecording_Click(object sender, EventArgs e)
        {
            buttonStartRecording.Enabled = true;
            StopRecording(songLabel.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBoxRecordings.Items.Clear();
        }

        private string CreateOutputFile(string song, string extension)
        {
            //todo:escape
            return Path.Combine(outputFolderTextBox.Text, string.Format("{0}.{1}", song, extension));

        }
        private void RecordSong(string song)
        {
            if (!buttonStartRecording.Enabled)
            {
                if (songLabel.Text.Length > 0)
                {
                    // can't set WaveFormat as WASAPI doesn't support SRC
                    var device = (MMDevice)deviceListBox.SelectedItem;
                    waveIn = new WasapiCapture(device);
                    writer = new WaveFileWriter(CreateOutputFile(song, "wav"), waveIn.WaveFormat);
                    waveIn.DataAvailable += OnDataAvailable;
                    //waveIn.RecordingStopped += OnRecordingStopped;
                    waveIn.StartRecording();
                }
            }
        }

        private Mp3Tag ExtractMp3Tag(string song)
        {
            string[] split = song.Split(new []{"-"}, 2, StringSplitOptions.RemoveEmptyEntries);
            Mp3Tag tag = new Mp3Tag(
                split.Length>1?split[1]:string.Empty,
                split[0]
                );
            return tag;
        }

        private void ConvertToMp3(string song, int bitrate)
        {
            //Thread.Sleep(500);
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Mp3Tag tag = ExtractMp3Tag(song);

            process.StartInfo.FileName = "lame.exe";
            process.StartInfo.Arguments = string.Format("-b {2} --tt \"{3}\" --ta \"{4}\"  \"{0}\" \"{1}\"", 
                CreateOutputFile(song,"wav"), 
                CreateOutputFile(song,"mp3"),
                bitrate,
                tag.Title,
                tag.Artist);

            process.StartInfo.WorkingDirectory = new FileInfo(Application.ExecutablePath).DirectoryName;
            process.Start();
            process.WaitForExit(20000);
            if (!process.HasExited)
                process.Kill();
            File.Delete(CreateOutputFile(song,"wav"));
        }

        private void LoadWasapiDevicesCombo()
        {
            var deviceEnum = new MMDeviceEnumerator();
            var devices = deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();

            deviceListBox.DataSource = devices;
            deviceListBox.DisplayMember = "FriendlyName";
        }
        private void LoadBitrateCombo()
        {
            List<int> bitrate = new List<int> { 96, 128, 160, 192, 320 };

            bitrateComboBox.DataSource = bitrate;
            bitrateComboBox.SelectedItem = 128;
        }

        private string GetSpotifySong()
        {
            string song = Process.GetProcessesByName("spotify")[0].MainWindowTitle;
            return song.Length > 7 ? song.Substring(10).Trim() : string.Empty;

        }

        private void PostProcessing(string song)
        {
            Task t = new Task(() => ConvertToMp3(song,(int)bitrateComboBox.SelectedItem));
            t.Start();
            //convert to MP3
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                if (writer != null)
                    writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void StopRecording(string song)
        {
            int newItemIndex = listBoxRecordings.Items.Add(song);
            listBoxRecordings.SelectedIndex = newItemIndex;
            PostProcessing(song);

            if (waveIn != null) // working around problem with double raising of RecordingStopped
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }
            if (writer != null)
            {
                writer.Close();
                writer = null;
            }

        }

        private void donateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("http://www.google.com/");
            MessageBox.Show("Donations for the work done and future work are welcome.\r\nMy paypal account is paypal@atriumstede.nl",
                "Donation");
        }
    }
}
