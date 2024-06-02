using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace Vi.Mu.In
{
    public partial class Piano : Form
    {
        private AudioRecorder recorder;
        private DateTime recordingStartTime;
        private readonly List<WaveOutEvent> outputDevices = new List<WaveOutEvent>();
        public Piano()
        {
            InitializeComponent();
            recorder = new AudioRecorder();
            
        }

       

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Wave files (*.wav)|*.wav",
                DefaultExt = "wav",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                recorder.StartRecording(saveFileDialog.FileName);
                btnStartRecording.Enabled = false;
                btnStopRecording.Enabled = true;
                lblRecordingStatus.Text = "Recording... 00:00:00";
                recordingStartTime = DateTime.Now;
                recordingTimer.Start();
            }
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            recorder.StopRecording();
            btnStartRecording.Enabled = true;
            btnStopRecording.Enabled = false;
            lblRecordingStatus.Text = "Not Recording";
            recordingTimer.Stop();
        }

        private void RecordingTimer_Tick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - recordingStartTime;
            lblRecordingStatus.Text = $"Recording... {elapsed:hh\\:mm\\:ss}";
        }

        private void btnMusicNoteC_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C.wav");
        }

        private void btnMusicNoteCS_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C_s.wav");
        }

        private void btnMusicNoteD_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D.wav");
        }

        private void btnMusicNoteDS_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D_s.wav");
        }

        private void btnMusicNoteE_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\E.wav");
        }

        private void btnMusicNoteF_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F.wav");
        }

        private void btnMusicNoteFS_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F_s.wav");
        }

        private void btnMusicNoteG_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\G.wav");
        }

        private void btnMusicNoteGS_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\G_s.wav");
        }

        private void btnMusicNoteA_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\A.wav");
        }

        private void btnMusicNoteBS_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bb.wav");
        }

        private void btnMusicNoteB_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\B.wav");
        }

        private void btnMusicNoteC1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C1.wav");
        }

        private void btnMusicNoteCS1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C_s1.wav");
        }

        private void btnMusicNoteD1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D1.wav");
        }

        private void btnMusicNoteDS1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D_s1.wav");
        }

        private void btnMusicNoteE1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\E1.wav");
        }

        private void btnMusicNoteF1_Click(object sender, EventArgs e)
        {
            PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F1.wav");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C.wav");
                    break;
                case 'w':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C_s.wav");
                    break;
                case 'e':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D.wav");
                    break;
                case 'r':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D_s.wav");
                    break;
                case 't':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\E.wav");
                    break;
                case 'y':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F.wav");
                    break;
                case 'u':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F_s.wav");
                    break;
                case 'i':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\G.wav");
                    break;
                case 'o':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\G_s.wav");
                    break;
                case 'p':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\A.wav");
                    break;
                case 'a':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bb.wav");
                    break;
                case 's':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\B.wav");
                    break;
                case 'd':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C1.wav");
                    break;
                case 'f':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\C_s1.wav");
                    break;
                case 'g':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D1.wav");
                    break;
                case 'h':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\D_s1.wav");
                    break;
                case 'j':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\E1.wav");
                    break;
                case 'k':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\F1.wav");
                    break;
            }
        }

        private void PlaySound(string filePath)
        {
            var audioFile = new AudioFileReader(filePath);
            var outputDevice = new WaveOutEvent();

            outputDevices.Add(outputDevice);

            outputDevice.Init(audioFile);
            outputDevice.Play();

            outputDevice.PlaybackStopped += (sender, e) =>
            {
                outputDevice.Dispose();
                outputDevices.Remove(outputDevice);
                audioFile.Dispose();
            };
        }

        // Add the AudioRecorder class here or in a separate file as needed
        public class AudioRecorder
        {
            private WasapiLoopbackCapture capture;
            private WaveFileWriter writer;
            private string outputFilePath;

            public void StartRecording(string outputFilePath)
            {
                this.outputFilePath = outputFilePath;
                capture = new WasapiLoopbackCapture();
                capture.DataAvailable += OnDataAvailable;

                writer = new WaveFileWriter(outputFilePath, capture.WaveFormat);
                capture.StartRecording();
            }

            public void StopRecording()
            {
                capture.StopRecording();
            }

            private void OnDataAvailable(object sender, WaveInEventArgs e)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
            }

            private void OnRecordingStopped(object sender, StoppedEventArgs e)
            {
                writer?.Dispose();
                writer = null;
                capture?.Dispose();
                capture = null;
            }

        }

        private void Piano_MouseDown(object sender, MouseEventArgs e)
        {
            Button btnMusicNote = sender as Button;
            btnMusicNote.BackColor = Color.Gray;
        }

        private void Piano_MouseUp(object sender, MouseEventArgs e)
        {
            // Превръщаме sender в бутон
            Button btnMusicNote = sender as Button;

            // Проверка дали е черен бутон (например има "S" в името)
            if (btnMusicNote.Name.Contains("S"))
            {
                btnMusicNote.BackColor = Color.Black;
            }
            else
            {
                btnMusicNote.BackColor = Color.White;
            }
        }


        private void Piano_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    btnMusicNoteC.BackColor = Color.Gray;
                    break;
                case Keys.W:
                    btnMusicNoteCS.BackColor = Color.Gray;
                    break;
                case Keys.E:
                    btnMusicNoteD.BackColor = Color.Gray;
                    break;
                case Keys.R:
                    btnMusicNoteDS.BackColor = Color.Gray;
                    break;
                case Keys.T:
                    btnMusicNoteE.BackColor = Color.Gray;
                    break;
                case Keys.Y:
                    btnMusicNoteF.BackColor = Color.Gray;
                    break;
                case Keys.U:
                    btnMusicNoteFS.BackColor = Color.Gray;
                    break;
                case Keys.I:
                    btnMusicNoteG.BackColor = Color.Gray;
                    break;
                case Keys.O:
                    btnMusicNoteGS.BackColor = Color.Gray;
                    break;
                case Keys.P:
                    btnMusicNoteA.BackColor = Color.Gray;
                    break;
                case Keys.A:
                    btnMusicNoteBS.BackColor = Color.Gray;
                    break;
                case Keys.S:
                    btnMusicNoteB.BackColor = Color.Gray;
                    break;
                case Keys.D:
                    btnMusicNoteC1.BackColor = Color.Gray;
                    break;
                case Keys.F:
                    btnMusicNoteCS1.BackColor = Color.Gray;
                    break;
                case Keys.G:
                    btnMusicNoteD1.BackColor = Color.Gray;
                    break;
                case Keys.H:
                    btnMusicNoteDS1.BackColor = Color.Gray;
                    break;
                case Keys.J:
                    btnMusicNoteE1.BackColor = Color.Gray;
                    break;
                case Keys.K:
                    btnMusicNoteF1.BackColor = Color.Gray;
                    break;
            }

        }

        private void Piano_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    btnMusicNoteC.BackColor = Color.White;
                    break;
                case Keys.W:
                    btnMusicNoteCS.BackColor = Color.Black;
                    break;
                case Keys.E:
                    btnMusicNoteD.BackColor = Color.White;
                    break;
                case Keys.R:
                    btnMusicNoteDS.BackColor = Color.Black;
                    break;
                case Keys.T:
                    btnMusicNoteE.BackColor = Color.White;
                    break;
                case Keys.Y:
                    btnMusicNoteF.BackColor = Color.White;
                    break;
                case Keys.U:
                    btnMusicNoteFS.BackColor = Color.Black;
                    break;
                case Keys.I:
                    btnMusicNoteG.BackColor = Color.White;
                    break;
                case Keys.O:
                    btnMusicNoteGS.BackColor = Color.Black;
                    break;
                case Keys.P:
                    btnMusicNoteA.BackColor = Color.White;
                    break;
                case Keys.A:
                    btnMusicNoteBS.BackColor = Color.Black;
                    break;
                case Keys.S:
                    btnMusicNoteB.BackColor = Color.White;
                    break;
                case Keys.D:
                    btnMusicNoteC1.BackColor = Color.White;
                    break;
                case Keys.F:
                    btnMusicNoteCS1.BackColor = Color.Black;
                    break;
                case Keys.G:
                    btnMusicNoteD1.BackColor = Color.White;
                    break;
                case Keys.H:
                    btnMusicNoteDS1.BackColor = Color.Black;
                    break;
                case Keys.J:
                    btnMusicNoteE1.BackColor = Color.White;
                    break;
                case Keys.K:
                    btnMusicNoteF1.BackColor = Color.White;
                    break;
            }
        }
    }
}
