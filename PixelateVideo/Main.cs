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
using System.Threading;

namespace PixelateVideo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Thread pixelateThread;
        Loading loadingForm;

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
            if (videoInput.Text == "" || outputInput.Text == "" || pixelatorInput.Text == "" || argumentInput.Text == "")
                MessageBox.Show("Can't pixelate with missing information! Please fill out all necessary information.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                loadingForm = new Loading();
                loadingForm.Show();

                pixelateThread = new Thread(pixelate);
                pixelateThread.Start();
                
            }
        }

        delegate void hideDelegate();

        delegate void labelDelegate(string labelText);

        void pixelate()
        {

            //set up delegates
            hideDelegate hide = loadingForm.Hide;
            labelDelegate output = loadingForm.changeLabel;

            Invoke(output, "Getting ready");

            //create splitout folder if one doesn't exist
            if (!Directory.Exists("splitout"))
                Directory.CreateDirectory("splitout");

            Invoke(output, "Preparing to split");

            //prep split command
            string ffmpegCommand = "-i " + videoInput.Text + " splitout\\temp%03d.png";

            ProcessStartInfo ffmpegStartInfo = new ProcessStartInfo();
            ffmpegStartInfo.FileName = "ffmpeg.exe";
            ffmpegStartInfo.Arguments = ffmpegCommand;
            ffmpegStartInfo.UseShellExecute = false;
            ffmpegStartInfo.CreateNoWindow = true;

            Process ffmpeg = new Process();
            ffmpeg.StartInfo = ffmpegStartInfo;

            Invoke(output, "Splitting video");

            //split
            ffmpeg.Start();
            ffmpeg.WaitForExit();

            Invoke(output, "Preparing to pixelate");

            //prep pixelate command
            string pixelateCommand = "\"{0}\" \"{1}\" " + argumentInput.Text;

            ProcessStartInfo pixelateStartInfo = new ProcessStartInfo();
            pixelateStartInfo.FileName = pixelatorInput.Text;
            pixelateStartInfo.Arguments = pixelateCommand;
            pixelateStartInfo.UseShellExecute = false;
            pixelateStartInfo.CreateNoWindow = true;

            Process pixelate = new Process();
            pixelate.StartInfo = pixelateStartInfo;

            Invoke(output, "Pixelating");

            //pixelate one by one
            string[] fileArray = Directory.GetFiles("splitout");

            for (int i = 0; i < fileArray.Length; i++)
            {

                Invoke(output, "Pixelating (" + i.ToString() + "/" + (fileArray.Length - 1).ToString() + ")");

                string inputFilePath = fileArray[i];
                string outputFilePath = outputInput.Text + i.ToString() + ".png";
                string fixedCommand = String.Format(pixelateCommand, inputFilePath, outputFilePath);

                pixelate.StartInfo.Arguments = fixedCommand;
                pixelate.Start();
                pixelate.WaitForExit();

                File.Delete(inputFilePath);
            }

            Invoke(output, "Cleaning output directory");

            string[] outputFileArray = Directory.GetFiles(outputInput.Text);

            for(int i = 0; i < outputFileArray.Length; i++)
            {
                if (outputFileArray[i].EndsWith(".png_original"))
                    File.Delete(outputFileArray[i]);
            }

            Invoke(output, "Finishing up");

            Invoke(hide);
        }
    }
}
