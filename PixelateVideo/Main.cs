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
using System.Diagnostics;

namespace PixelateVideo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("FFMPEG is missing! Please read the instructions provided in the README.md document packaged with this software to install it, then try again.", "FFMPEG Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void pixelateButton_Click(object sender, EventArgs e)
        {
            if (videoInput.Text == "" || outputInput.Text == "" || pixelatorInput.Text == "" || splitInput.Text == "")
                MessageBox.Show("Can't pixelate with missing information! Please fill out all necessary information.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "ffmpeg.exe";
                startInfo.Arguments = "-h";
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;

                Process p = new Process();
                p.StartInfo = startInfo;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                MessageBox.Show(output);

            }
        }
    }
}
