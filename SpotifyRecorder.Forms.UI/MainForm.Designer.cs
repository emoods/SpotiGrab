namespace SpotifyRecorder.Forms.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.listBoxRecordings = new System.Windows.Forms.ListBox();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.buttonStartRecording = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bitrateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.browseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thresholdCheckBox = new System.Windows.Forms.CheckBox();
            this.openMixerButton = new System.Windows.Forms.Button();
            this.thresholdTextBox = new System.Windows.Forms.NumericUpDown();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter2 = new NAudio.Gui.VolumeMeter();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(587, 226);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 17;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolderClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(587, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Location = new System.Drawing.Point(587, 168);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 16;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlayClick);
            // 
            // listBoxRecordings
            // 
            this.listBoxRecordings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecordings.FormattingEnabled = true;
            this.listBoxRecordings.Location = new System.Drawing.Point(12, 168);
            this.listBoxRecordings.Name = "listBoxRecordings";
            this.listBoxRecordings.ScrollAlwaysVisible = true;
            this.listBoxRecordings.Size = new System.Drawing.Size(569, 108);
            this.listBoxRecordings.TabIndex = 15;
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Location = new System.Drawing.Point(123, 139);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(105, 23);
            this.buttonStopRecording.TabIndex = 11;
            this.buttonStopRecording.Text = "Stop Recording";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            this.buttonStopRecording.Click += new System.EventHandler(this.ButtonStopRecordingClick);
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Location = new System.Drawing.Point(12, 139);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(105, 23);
            this.buttonStartRecording.TabIndex = 12;
            this.buttonStartRecording.Text = "Start Recording";
            this.buttonStartRecording.UseVisualStyleBackColor = true;
            this.buttonStartRecording.Click += new System.EventHandler(this.ButtonStartRecordingClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output folder";
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderTextBox.Enabled = false;
            this.outputFolderTextBox.Location = new System.Drawing.Point(158, 12);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(423, 20);
            this.outputFolderTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bitrate";
            // 
            // bitrateComboBox
            // 
            this.bitrateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitrateComboBox.FormattingEnabled = true;
            this.bitrateComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "320"});
            this.bitrateComboBox.Location = new System.Drawing.Point(158, 46);
            this.bitrateComboBox.Name = "bitrateComboBox";
            this.bitrateComboBox.Size = new System.Drawing.Size(101, 21);
            this.bitrateComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Song";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(157, 111);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(30, 13);
            this.songLabel.TabIndex = 1;
            this.songLabel.Text = "song";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(587, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 294);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(35, 13);
            this.versionLabel.TabIndex = 21;
            this.versionLabel.Text = "label5";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(431, 294);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(231, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SpotiGrab is a fork of codepley SpotifyRecorder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLinkClicked);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(587, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Skip songs below threshhold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "threshold in seconds ( for skipping commercials )";
            // 
            // thresholdCheckBox
            // 
            this.thresholdCheckBox.AutoSize = true;
            this.thresholdCheckBox.Location = new System.Drawing.Point(160, 76);
            this.thresholdCheckBox.Name = "thresholdCheckBox";
            this.thresholdCheckBox.Size = new System.Drawing.Size(15, 14);
            this.thresholdCheckBox.TabIndex = 27;
            this.thresholdCheckBox.UseVisualStyleBackColor = true;
            // 
            // openMixerButton
            // 
            this.openMixerButton.Location = new System.Drawing.Point(234, 139);
            this.openMixerButton.Name = "openMixerButton";
            this.openMixerButton.Size = new System.Drawing.Size(105, 23);
            this.openMixerButton.TabIndex = 11;
            this.openMixerButton.Text = "Open Sound Mixer";
            this.openMixerButton.UseVisualStyleBackColor = false;
            this.openMixerButton.Click += new System.EventHandler(this.OpenMixerButtonClick);
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(181, 74);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(78, 20);
            this.thresholdTextBox.TabIndex = 28;
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.AllowDrop = true;
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.Location = new System.Drawing.Point(616, 46);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(20, 100);
            this.volumeMeter1.TabIndex = 29;
            // 
            // volumeMeter2
            // 
            this.volumeMeter2.Amplitude = 0F;
            this.volumeMeter2.Location = new System.Drawing.Point(642, 46);
            this.volumeMeter2.MaxDb = 18F;
            this.volumeMeter2.MinDb = -60F;
            this.volumeMeter2.Name = "volumeMeter2";
            this.volumeMeter2.Size = new System.Drawing.Size(20, 100);
            this.volumeMeter2.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 322);
            this.Controls.Add(this.thresholdTextBox);
            this.Controls.Add(this.thresholdCheckBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxRecordings);
            this.Controls.Add(this.openMixerButton);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bitrateComboBox);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.volumeMeter2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SpotiGrab https://github.com/emoods/SpotiGrab";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.ListBox listBoxRecordings;
        private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.Button buttonStartRecording;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bitrateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox thresholdCheckBox;
        private System.Windows.Forms.Button openMixerButton;
        private System.Windows.Forms.NumericUpDown thresholdTextBox;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.VolumeMeter volumeMeter2;

    }
}

