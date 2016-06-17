using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace OverwatchSkype
{
    public partial class OverwatchSkype : Form
    {
        public OverwatchSkype()
        {
            InitializeComponent();

            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                selDevice.Items.Add(deviceInfo.ProductName);
                if (deviceInfo.ProductName.StartsWith("VoiceMeeter"))
                    selDevice.SelectedIndex = selDevice.Items.Count - 1;
            }

            DirectoryInfo dir = new DirectoryInfo("sounds");
            int count = 0;
            int rows = 1;
            foreach (var file in dir.GetFiles("*.wav"))
            {
                int row = count / 4;
                int col = count % 4;
                int x = col * 85;
                int y = row * 35 + 25;
                Button b = new Button();
                b.Width = 80;
                b.Height = 30;
                b.Text = file.Name.ToLower().Replace(".wav", "").ToUpper();
                b.Location = new Point(x, y);
                b.Click += (s, e) => PlaySound(file.FullName);
                this.Controls.Add(b);
                count++;
                if (row > rows)
                    rows = row;
            }

            this.ClientSize = new Size(4 * 85 - 5, (rows + 1) * 35 - 5 + 25);
        }

        private void PlaySound(string file)
        {
            var waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = selDevice.SelectedIndex;

            waveOut.Init(new NAudio.Wave.WaveFileReader(file));
            waveOut.Play();
        }
    }
}
