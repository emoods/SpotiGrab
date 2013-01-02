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
            this.label1 = new System.Windows.Forms.Label();
            this.deviceListBox = new System.Windows.Forms.ComboBox();
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
            this.donateLink = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device";
            // 
            // deviceListBox
            // 
            this.deviceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.Location = new System.Drawing.Point(112, 12);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(542, 21);
            this.deviceListBox.TabIndex = 0;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(579, 217);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 17;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(579, 188);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Location = new System.Drawing.Point(579, 159);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 16;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // listBoxRecordings
            // 
            this.listBoxRecordings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecordings.FormattingEnabled = true;
            this.listBoxRecordings.Location = new System.Drawing.Point(12, 159);
            this.listBoxRecordings.Name = "listBoxRecordings";
            this.listBoxRecordings.ScrollAlwaysVisible = true;
            this.listBoxRecordings.Size = new System.Drawing.Size(561, 108);
            this.listBoxRecordings.TabIndex = 15;
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Location = new System.Drawing.Point(123, 130);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(105, 23);
            this.buttonStopRecording.TabIndex = 11;
            this.buttonStopRecording.Text = "Stop Recording";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Location = new System.Drawing.Point(12, 130);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(105, 23);
            this.buttonStartRecording.TabIndex = 12;
            this.buttonStartRecording.Text = "Start Recording";
            this.buttonStartRecording.UseVisualStyleBackColor = true;
            this.buttonStartRecording.Click += new System.EventHandler(this.buttonStartRecording_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output folder";
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderTextBox.Location = new System.Drawing.Point(112, 46);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(542, 20);
            this.outputFolderTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bitrate";
            // 
            // bitrateComboBox
            // 
            this.bitrateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateComboBox.FormattingEnabled = true;
            this.bitrateComboBox.Location = new System.Drawing.Point(112, 72);
            this.bitrateComboBox.Name = "bitrateComboBox";
            this.bitrateComboBox.Size = new System.Drawing.Size(542, 21);
            this.bitrateComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Song";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(109, 103);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(30, 13);
            this.songLabel.TabIndex = 1;
            this.songLabel.Text = "song";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(579, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(15, 427);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(35, 13);
            this.versionLabel.TabIndex = 21;
            this.versionLabel.Text = "label5";
            // 
            // donateLink
            // 
            this.donateLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.donateLink.AutoSize = true;
            this.donateLink.BackColor = System.Drawing.SystemColors.Control;
            this.donateLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.donateLink.Location = new System.Drawing.Point(557, 430);
            this.donateLink.Name = "donateLink";
            this.donateLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.donateLink.Size = new System.Drawing.Size(100, 13);
            this.donateLink.TabIndex = 22;
            this.donateLink.TabStop = true;
            this.donateLink.Text = "Donate with PayPal";
            this.donateLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.donateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donateLink_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 286);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(642, 138);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.donateLink);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxRecordings);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitrateComboBox);
            this.Controls.Add(this.deviceListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Spotify Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceListBox;
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
        private System.Windows.Forms.LinkLabel donateLink;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
    }
}

