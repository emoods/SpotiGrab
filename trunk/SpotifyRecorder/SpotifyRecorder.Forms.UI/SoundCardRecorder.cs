using System;
using System.Diagnostics;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.MediaFoundation;

namespace SpotifyRecorder.Forms.UI
{
    public class SoundCardRecorder : IDisposable
    {
        #region Constants

        #endregion

        #region Private Properties

        private MMDevice Device { get; set; }
        private IWaveIn _waveIn;
        private WaveFileWriter _writer;
        private Stopwatch _stopwatch = new Stopwatch();


        #endregion

        #region Public Properties

        public string FilePath { get; set; }
        public string Song { get; set; }
        public TimeSpan Duration { get { return _stopwatch.Elapsed; } }
        public MeteringSampleProvider PostVolumeMeter { get; set; }
        private BufferedWaveProvider _buffer;

        #endregion

        #region Constructor

        public SoundCardRecorder(string filePath, string song)
        {
            FilePath = filePath;
            Song = song;

            _waveIn = new WasapiLoopbackCapture();
            _waveIn.DataAvailable += OnDataAvailable;
            _buffer = new BufferedWaveProvider(_waveIn.WaveFormat);
            _writer = new WaveFileWriter(filePath, _waveIn.WaveFormat);

            var sampleChannel = new SampleChannel(_buffer, true);
            PostVolumeMeter = new MeteringSampleProvider(sampleChannel, _waveIn.WaveFormat.SampleRate / 4);

        }

        public void Dispose()
        {
            if (_waveIn != null)
            {
                _waveIn.StopRecording();
                _waveIn.Dispose();
                _waveIn = null;
            }
            if (_writer != null)
            {
                _writer.Close();
                _writer = null;
            }
        }

        #endregion

        private float[] stupidBuffer = new float[0];

        #region Events
        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
             if(_buffer != null) {
                //dynamicaly increase the stupidBuffer
                if(stupidBuffer.Length < e.BytesRecorded)
                {
                    stupidBuffer = new float[e.BytesRecorded];
                }

				//we push and read from the buffer - due to we need to otherwise the volumemeters will not be pushed with data
                _buffer.AddSamples(e.Buffer, 0, e.BytesRecorded);
                PostVolumeMeter.Read(stupidBuffer, 0, _buffer.BufferedBytes);
            }

            if (_writer != null)
                _writer.Write(e.Buffer, 0, e.BytesRecorded);

        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        public void Start()
        {
            _waveIn.StartRecording();
            _stopwatch.Reset();
            _stopwatch.Start();
        }

        public void Stop()
        {
            if (_waveIn != null)
            {
                _waveIn.StopRecording();
                _waveIn.Dispose();
                _waveIn = null;
            }
            if (_writer != null)
            {
                _writer.Close();
                _writer = null;
            }
        }

        #endregion
    }
}