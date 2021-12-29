namespace ComputerVision
{
    partial class BrightnessContrastForm
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentContrastLabel = new System.Windows.Forms.Label();
            this.MaxContrastLabel = new System.Windows.Forms.Label();
            this.MinContrastLabel = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Brightness = new System.Windows.Forms.GroupBox();
            this.CurrentBrightnessLabel = new System.Windows.Forms.Label();
            this.MaxBrightnessLabel = new System.Windows.Forms.Label();
            this.MinBrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Brightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.groupBox1);
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Controls.Add(this.Brightness);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(607, 475);
            this.Panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentContrastLabel);
            this.groupBox1.Controls.Add(this.MaxContrastLabel);
            this.groupBox1.Controls.Add(this.MinContrastLabel);
            this.groupBox1.Controls.Add(this.ContrastTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrast";
            // 
            // CurrentContrastLabel
            // 
            this.CurrentContrastLabel.AutoSize = true;
            this.CurrentContrastLabel.Location = new System.Drawing.Point(40, 242);
            this.CurrentContrastLabel.Name = "CurrentContrastLabel";
            this.CurrentContrastLabel.Size = new System.Drawing.Size(16, 17);
            this.CurrentContrastLabel.TabIndex = 3;
            this.CurrentContrastLabel.Text = "1";
            // 
            // MaxContrastLabel
            // 
            this.MaxContrastLabel.AutoSize = true;
            this.MaxContrastLabel.Location = new System.Drawing.Point(28, 22);
            this.MaxContrastLabel.Name = "MaxContrastLabel";
            this.MaxContrastLabel.Size = new System.Drawing.Size(16, 17);
            this.MaxContrastLabel.TabIndex = 2;
            this.MaxContrastLabel.Text = "3";
            // 
            // MinContrastLabel
            // 
            this.MinContrastLabel.AutoSize = true;
            this.MinContrastLabel.Location = new System.Drawing.Point(34, 355);
            this.MinContrastLabel.Name = "MinContrastLabel";
            this.MinContrastLabel.Size = new System.Drawing.Size(16, 17);
            this.MinContrastLabel.TabIndex = 1;
            this.MinContrastLabel.Text = "0";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Location = new System.Drawing.Point(0, 21);
            this.ContrastTrackBar.Maximum = 30;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ContrastTrackBar.Size = new System.Drawing.Size(56, 351);
            this.ContrastTrackBar.TabIndex = 0;
            this.ContrastTrackBar.Value = 10;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(89, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(511, 378);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Brightness
            // 
            this.Brightness.Controls.Add(this.CurrentBrightnessLabel);
            this.Brightness.Controls.Add(this.MaxBrightnessLabel);
            this.Brightness.Controls.Add(this.MinBrightnessLabel);
            this.Brightness.Controls.Add(this.BrightnessTrackBar);
            this.Brightness.Location = new System.Drawing.Point(3, 387);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(597, 86);
            this.Brightness.TabIndex = 1;
            this.Brightness.TabStop = false;
            this.Brightness.Text = "Brightness";
            // 
            // CurrentBrightnessLabel
            // 
            this.CurrentBrightnessLabel.AutoSize = true;
            this.CurrentBrightnessLabel.Location = new System.Drawing.Point(286, 60);
            this.CurrentBrightnessLabel.Name = "CurrentBrightnessLabel";
            this.CurrentBrightnessLabel.Size = new System.Drawing.Size(24, 17);
            this.CurrentBrightnessLabel.TabIndex = 3;
            this.CurrentBrightnessLabel.Text = "50";
            // 
            // MaxBrightnessLabel
            // 
            this.MaxBrightnessLabel.AutoSize = true;
            this.MaxBrightnessLabel.Location = new System.Drawing.Point(559, 60);
            this.MaxBrightnessLabel.Name = "MaxBrightnessLabel";
            this.MaxBrightnessLabel.Size = new System.Drawing.Size(32, 17);
            this.MaxBrightnessLabel.TabIndex = 2;
            this.MaxBrightnessLabel.Text = "100";
            // 
            // MinBrightnessLabel
            // 
            this.MinBrightnessLabel.AutoSize = true;
            this.MinBrightnessLabel.Location = new System.Drawing.Point(9, 60);
            this.MinBrightnessLabel.Name = "MinBrightnessLabel";
            this.MinBrightnessLabel.Size = new System.Drawing.Size(16, 17);
            this.MinBrightnessLabel.TabIndex = 1;
            this.MinBrightnessLabel.Text = "0";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(-3, 21);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(600, 56);
            this.BrightnessTrackBar.TabIndex = 0;
            this.BrightnessTrackBar.Value = 50;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.BrightnessTrackBar_Scroll);
            // 
            // BrightnessContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BrightnessContrastForm";
            this.Text = "Brightness/Contrast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrightnessContrastForm_Close);
            this.Panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Brightness.ResumeLayout(false);
            this.Brightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox Brightness;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label CurrentContrastLabel;
        private System.Windows.Forms.Label MaxContrastLabel;
        private System.Windows.Forms.Label MinContrastLabel;
        private System.Windows.Forms.Label CurrentBrightnessLabel;
        private System.Windows.Forms.Label MaxBrightnessLabel;
        private System.Windows.Forms.Label MinBrightnessLabel;
    }
}