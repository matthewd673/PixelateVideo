namespace PixelateVideo
{
    partial class Main
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
            this.videoLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pixelatorLabel = new System.Windows.Forms.Label();
            this.videoInput = new System.Windows.Forms.TextBox();
            this.outputInput = new System.Windows.Forms.TextBox();
            this.pixelatorInput = new System.Windows.Forms.TextBox();
            this.argumentsLabel = new System.Windows.Forms.Label();
            this.argumentInput = new System.Windows.Forms.TextBox();
            this.pixelateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoLabel
            // 
            this.videoLabel.AutoSize = true;
            this.videoLabel.Location = new System.Drawing.Point(12, 15);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(62, 13);
            this.videoLabel.TabIndex = 0;
            this.videoLabel.Text = "Video Path:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 37);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(99, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output Folder Path:";
            // 
            // pixelatorLabel
            // 
            this.pixelatorLabel.AutoSize = true;
            this.pixelatorLabel.Location = new System.Drawing.Point(12, 63);
            this.pixelatorLabel.Name = "pixelatorLabel";
            this.pixelatorLabel.Size = new System.Drawing.Size(75, 13);
            this.pixelatorLabel.TabIndex = 2;
            this.pixelatorLabel.Text = "Pixelator Path:";
            // 
            // videoInput
            // 
            this.videoInput.Location = new System.Drawing.Point(121, 8);
            this.videoInput.Name = "videoInput";
            this.videoInput.Size = new System.Drawing.Size(202, 20);
            this.videoInput.TabIndex = 3;
            // 
            // outputInput
            // 
            this.outputInput.Location = new System.Drawing.Point(121, 34);
            this.outputInput.Name = "outputInput";
            this.outputInput.Size = new System.Drawing.Size(202, 20);
            this.outputInput.TabIndex = 4;
            // 
            // pixelatorInput
            // 
            this.pixelatorInput.Location = new System.Drawing.Point(121, 60);
            this.pixelatorInput.Name = "pixelatorInput";
            this.pixelatorInput.Size = new System.Drawing.Size(202, 20);
            this.pixelatorInput.TabIndex = 5;
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.argumentsLabel.Location = new System.Drawing.Point(12, 89);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(103, 13);
            this.argumentsLabel.TabIndex = 6;
            this.argumentsLabel.Text = "Pixelator Arguments:";
            // 
            // argumentInput
            // 
            this.argumentInput.Location = new System.Drawing.Point(121, 86);
            this.argumentInput.Name = "argumentInput";
            this.argumentInput.Size = new System.Drawing.Size(202, 20);
            this.argumentInput.TabIndex = 7;
            // 
            // pixelateButton
            // 
            this.pixelateButton.Location = new System.Drawing.Point(110, 112);
            this.pixelateButton.Name = "pixelateButton";
            this.pixelateButton.Size = new System.Drawing.Size(118, 49);
            this.pixelateButton.TabIndex = 8;
            this.pixelateButton.Text = "Pixelate!";
            this.pixelateButton.UseVisualStyleBackColor = true;
            this.pixelateButton.Click += new System.EventHandler(this.pixelateButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 167);
            this.Controls.Add(this.pixelateButton);
            this.Controls.Add(this.argumentInput);
            this.Controls.Add(this.argumentsLabel);
            this.Controls.Add(this.pixelatorInput);
            this.Controls.Add(this.outputInput);
            this.Controls.Add(this.videoInput);
            this.Controls.Add(this.pixelatorLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.videoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PixelateVideo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label pixelatorLabel;
        private System.Windows.Forms.TextBox videoInput;
        private System.Windows.Forms.TextBox outputInput;
        private System.Windows.Forms.TextBox pixelatorInput;
        private System.Windows.Forms.Label argumentsLabel;
        private System.Windows.Forms.TextBox argumentInput;
        private System.Windows.Forms.Button pixelateButton;
    }
}

