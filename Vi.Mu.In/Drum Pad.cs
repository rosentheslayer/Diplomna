using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace Vi.Mu.In
{
    public partial class Drum_pad : Form

    {
        private AudioRecorder recorder;
        private DateTime recordingStartTime;
        private readonly List<WaveOutEvent> outputDevices = new List<WaveOutEvent>();

        public Drum_pad()
        {
            InitializeComponent();
            recorder = new AudioRecorder();
        }

        private void btnDrum_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Kick1.wav");
            sp.Play();
        }

        private void btnDrum1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Kick2.wav");
            sp.Play();
        }

        private void btnSnare_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Snare1.wav");
            sp.Play();
        }

        private void btnSnare2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Snare2.wav");
            sp.Play();
        }

        private void btnBass_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bass1.wav");
            sp.Play();
        }

        private void btnBass2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bass2.wav");
            sp.Play();
        }

        private void btnCymbal1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Cymbal1.wav");
            sp.Play();
        }

        private void btnCymbal2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Cymbal2.wav");
            sp.Play();
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

        private void RecordingTimer_Tick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - recordingStartTime;
            lblRecordingStatus.Text = $"Recording... {elapsed:hh\\:mm\\:ss}";
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            recorder.StopRecording();
            btnStartRecording.Enabled = true;
            btnStopRecording.Enabled = false;
            lblRecordingStatus.Text = "Not Recording";
            recordingTimer.Stop();
        }

        private void Drum_pad_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Kick1.wav");
                    break;
                case 'w':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Kick2.wav");
                    break;
                case 'e':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Snare1.wav");
                    break;
                case 'r':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Snare2.wav");
                    break;
                case 't':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bass1.wav");
                    break;
                case 'y':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Bass2.wav");
                    break;
                case 'u':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Cymbal1.wav");
                    break;
                case 'i':
                    PlaySound(@"D:\diplom\Vi.Mu.In\Vi.Mu.In\Resources\Cymbal2.wav");
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
    }
}
