
namespace Vi.Mu.In
{
    partial class Drum_pad
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
            this.components = new System.ComponentModel.Container();
            this.btnDrum = new System.Windows.Forms.Button();
            this.btnSnare = new System.Windows.Forms.Button();
            this.btnBass = new System.Windows.Forms.Button();
            this.btnDrum1 = new System.Windows.Forms.Button();
            this.btnSnare2 = new System.Windows.Forms.Button();
            this.btnBass2 = new System.Windows.Forms.Button();
            this.btnCymbal1 = new System.Windows.Forms.Button();
            this.btnCymbal2 = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.lblRecordingStatus = new System.Windows.Forms.Label();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.recordingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDrum
            // 
            this.btnDrum.Location = new System.Drawing.Point(12, 12);
            this.btnDrum.Name = "btnDrum";
            this.btnDrum.Size = new System.Drawing.Size(130, 120);
            this.btnDrum.TabIndex = 0;
            this.btnDrum.Text = "Kick 1";
            this.btnDrum.UseVisualStyleBackColor = true;
            this.btnDrum.Click += new System.EventHandler(this.btnDrum_Click);
            this.btnDrum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnSnare
            // 
            this.btnSnare.Location = new System.Drawing.Point(148, 12);
            this.btnSnare.Name = "btnSnare";
            this.btnSnare.Size = new System.Drawing.Size(130, 120);
            this.btnSnare.TabIndex = 0;
            this.btnSnare.Text = "Snare 1";
            this.btnSnare.UseVisualStyleBackColor = true;
            this.btnSnare.Click += new System.EventHandler(this.btnSnare_Click);
            this.btnSnare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnBass
            // 
            this.btnBass.Location = new System.Drawing.Point(284, 12);
            this.btnBass.Name = "btnBass";
            this.btnBass.Size = new System.Drawing.Size(130, 120);
            this.btnBass.TabIndex = 0;
            this.btnBass.Text = "Bass 1";
            this.btnBass.UseVisualStyleBackColor = true;
            this.btnBass.Click += new System.EventHandler(this.btnBass_Click);
            this.btnBass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnDrum1
            // 
            this.btnDrum1.Location = new System.Drawing.Point(12, 138);
            this.btnDrum1.Name = "btnDrum1";
            this.btnDrum1.Size = new System.Drawing.Size(130, 120);
            this.btnDrum1.TabIndex = 0;
            this.btnDrum1.Text = "Kick 2";
            this.btnDrum1.UseVisualStyleBackColor = true;
            this.btnDrum1.Click += new System.EventHandler(this.btnDrum1_Click);
            this.btnDrum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnSnare2
            // 
            this.btnSnare2.Location = new System.Drawing.Point(148, 138);
            this.btnSnare2.Name = "btnSnare2";
            this.btnSnare2.Size = new System.Drawing.Size(130, 120);
            this.btnSnare2.TabIndex = 0;
            this.btnSnare2.Text = "Snare 2";
            this.btnSnare2.UseVisualStyleBackColor = true;
            this.btnSnare2.Click += new System.EventHandler(this.btnSnare2_Click);
            this.btnSnare2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnBass2
            // 
            this.btnBass2.Location = new System.Drawing.Point(284, 138);
            this.btnBass2.Name = "btnBass2";
            this.btnBass2.Size = new System.Drawing.Size(130, 120);
            this.btnBass2.TabIndex = 0;
            this.btnBass2.Text = "Bass 2";
            this.btnBass2.UseVisualStyleBackColor = true;
            this.btnBass2.Click += new System.EventHandler(this.btnBass2_Click);
            this.btnBass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnCymbal1
            // 
            this.btnCymbal1.Location = new System.Drawing.Point(420, 12);
            this.btnCymbal1.Name = "btnCymbal1";
            this.btnCymbal1.Size = new System.Drawing.Size(130, 120);
            this.btnCymbal1.TabIndex = 0;
            this.btnCymbal1.Text = "Cymbal 1";
            this.btnCymbal1.UseVisualStyleBackColor = true;
            this.btnCymbal1.Click += new System.EventHandler(this.btnCymbal1_Click);
            this.btnCymbal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnCymbal2
            // 
            this.btnCymbal2.Location = new System.Drawing.Point(420, 138);
            this.btnCymbal2.Name = "btnCymbal2";
            this.btnCymbal2.Size = new System.Drawing.Size(130, 120);
            this.btnCymbal2.TabIndex = 0;
            this.btnCymbal2.Text = "Cymbal 2";
            this.btnCymbal2.UseVisualStyleBackColor = true;
            this.btnCymbal2.Click += new System.EventHandler(this.btnCymbal2_Click);
            this.btnCymbal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(12, 297);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(130, 35);
            this.btnStartRecording.TabIndex = 2;
            this.btnStartRecording.Text = "Record";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // lblRecordingStatus
            // 
            this.lblRecordingStatus.AutoSize = true;
            this.lblRecordingStatus.Location = new System.Drawing.Point(230, 306);
            this.lblRecordingStatus.Name = "lblRecordingStatus";
            this.lblRecordingStatus.Size = new System.Drawing.Size(99, 17);
            this.lblRecordingStatus.TabIndex = 3;
            this.lblRecordingStatus.Text = "Not Recording";
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(435, 297);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(115, 35);
            this.btnStopRecording.TabIndex = 4;
            this.btnStopRecording.Text = "Stop";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // recordingTimer
            // 
            this.recordingTimer.Interval = 1000;
            // 
            // Drum_pad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 366);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.lblRecordingStatus);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.btnCymbal2);
            this.Controls.Add(this.btnBass2);
            this.Controls.Add(this.btnCymbal1);
            this.Controls.Add(this.btnBass);
            this.Controls.Add(this.btnSnare2);
            this.Controls.Add(this.btnDrum1);
            this.Controls.Add(this.btnSnare);
            this.Controls.Add(this.btnDrum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Drum_pad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drum Pad";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drum_pad_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrum;
        private System.Windows.Forms.Button btnSnare;
        private System.Windows.Forms.Button btnBass;
        private System.Windows.Forms.Button btnDrum1;
        private System.Windows.Forms.Button btnSnare2;
        private System.Windows.Forms.Button btnBass2;
        private System.Windows.Forms.Button btnCymbal1;
        private System.Windows.Forms.Button btnCymbal2;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Label lblRecordingStatus;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.Timer recordingTimer;
    }
}