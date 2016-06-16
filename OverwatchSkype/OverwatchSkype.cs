using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;
using System.IO;

namespace OverwatchSkype
{
    public partial class OverwatchSkype : Form
    {
        private Skype client = new Skype();
        private Call currentCall = null;

        public OverwatchSkype()
        {
            InitializeComponent();

            try
            {
                client.Attach(5, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed To Connect!", "Message");
            }

            DirectoryInfo dir = new DirectoryInfo("sounds");
            int count = 0;
            int rows = 1;
            foreach (var file in dir.GetFiles("*.wav"))
            {
                int row = count / 4;
                int col = count % 4;
                int x = col * 85;
                int y = row * 35;
                Button b = new Button();
                b.Width = 80;
                b.Height = 30;
                b.Text = file.Name.ToLower().Replace(".wav", "").ToUpper();
                b.Location = new Point(x, y);
                b.Click += (s, e) => PlaySound(file.FullName);
                this.Controls.Add(b);
                count++;
                Console.Write(row + " " + col + "\n");
                if (row > rows)
                    rows = row;
            }

            this.ClientSize = new Size(4 * 85 - 5, (rows + 1) * 35 - 5);
        }

        private void PlaySound(string file)
        {
            currentCall = client.ActiveCalls[1];
            currentCall.set_InputDevice(TCallIoDeviceType.callIoDeviceTypeFile, file);
            System.Threading.Thread.Sleep(5000);
            currentCall.set_InputDevice(TCallIoDeviceType.callIoDeviceTypeFile, "");
        }
    }
}
