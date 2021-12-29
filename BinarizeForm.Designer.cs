namespace ComputerVision
{
    partial class BinarizeForm
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
            this.CurrentColorLabel = new System.Windows.Forms.Label();
            this.MaxColorLabel = new System.Windows.Forms.Label();
            this.MinColorLabel = new System.Windows.Forms.Label();
            this.MaxTrackBar = new System.Windows.Forms.TrackBar();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Brightness = new System.Windows.Forms.GroupBox();
            this.CurrentThresholdLabel = new System.Windows.Forms.Label();
            this.MaxThresholdLabel = new System.Windows.Forms.Label();
            this.MinThresholdLabel = new System.Windows.Forms.Label();
            this.ThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Brightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).BeginInit();
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
            this.groupBox1.Controls.Add(this.CurrentColorLabel);
            this.groupBox1.Controls.Add(this.MaxColorLabel);
            this.groupBox1.Controls.Add(this.MinColorLabel);
            this.groupBox1.Controls.Add(this.MaxTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max";
            // 
            // CurrentColorLabel
            // 
            this.CurrentColorLabel.AutoSize = true;
            this.CurrentColorLabel.Location = new System.Drawing.Point(42, 190);
            this.CurrentColorLabel.Name = "CurrentColorLabel";
            this.CurrentColorLabel.Size = new System.Drawing.Size(28, 16);
            this.CurrentColorLabel.TabIndex = 3;
            this.CurrentColorLabel.Text = "127";
            // 
            // MaxColorLabel
            // 
            this.MaxColorLabel.AutoSize = true;
            this.MaxColorLabel.Location = new System.Drawing.Point(28, 22);
            this.MaxColorLabel.Name = "MaxColorLabel";
            this.MaxColorLabel.Size = new System.Drawing.Size(28, 16);
            this.MaxColorLabel.TabIndex = 2;
            this.MaxColorLabel.Text = "255";
            // 
            // MinColorLabel
            // 
            this.MinColorLabel.AutoSize = true;
            this.MinColorLabel.Location = new System.Drawing.Point(34, 355);
            this.MinColorLabel.Name = "MinColorLabel";
            this.MinColorLabel.Size = new System.Drawing.Size(14, 16);
            this.MinColorLabel.TabIndex = 1;
            this.MinColorLabel.Text = "0";
            // 
            // MaxTrackBar
            // 
            this.MaxTrackBar.Location = new System.Drawing.Point(0, 21);
            this.MaxTrackBar.Maximum = 255;
            this.MaxTrackBar.Name = "MaxTrackBar";
            this.MaxTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MaxTrackBar.Size = new System.Drawing.Size(56, 351);
            this.MaxTrackBar.TabIndex = 0;
            this.MaxTrackBar.Value = 127;
            this.MaxTrackBar.Scroll += new System.EventHandler(this.MaxTrackBar_Scroll);
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
            this.Brightness.Controls.Add(this.CurrentThresholdLabel);
            this.Brightness.Controls.Add(this.MaxThresholdLabel);
            this.Brightness.Controls.Add(this.MinThresholdLabel);
            this.Brightness.Controls.Add(this.ThresholdTrackBar);
            this.Brightness.Location = new System.Drawing.Point(3, 387);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(597, 86);
            this.Brightness.TabIndex = 1;
            this.Brightness.TabStop = false;
            this.Brightness.Text = "Threshold";
            // 
            // CurrentThresholdLabel
            // 
            this.CurrentThresholdLabel.AutoSize = true;
            this.CurrentThresholdLabel.Location = new System.Drawing.Point(286, 60);
            this.CurrentThresholdLabel.Name = "CurrentThresholdLabel";
            this.CurrentThresholdLabel.Size = new System.Drawing.Size(21, 16);
            this.CurrentThresholdLabel.TabIndex = 3;
            this.CurrentThresholdLabel.Text = "50";
            // 
            // MaxThresholdLabel
            // 
            this.MaxThresholdLabel.AutoSize = true;
            this.MaxThresholdLabel.Location = new System.Drawing.Point(559, 60);
            this.MaxThresholdLabel.Name = "MaxThresholdLabel";
            this.MaxThresholdLabel.Size = new System.Drawing.Size(28, 16);
            this.MaxThresholdLabel.TabIndex = 2;
            this.MaxThresholdLabel.Text = "255";
            // 
            // MinThresholdLabel
            // 
            this.MinThresholdLabel.AutoSize = true;
            this.MinThresholdLabel.Location = new System.Drawing.Point(9, 60);
            this.MinThresholdLabel.Name = "MinThresholdLabel";
            this.MinThresholdLabel.Size = new System.Drawing.Size(14, 16);
            this.MinThresholdLabel.TabIndex = 1;
            this.MinThresholdLabel.Text = "0";
            // 
            // ThresholdTrackBar
            // 
            this.ThresholdTrackBar.Location = new System.Drawing.Point(-3, 21);
            this.ThresholdTrackBar.Maximum = 255;
            this.ThresholdTrackBar.Name = "ThresholdTrackBar";
            this.ThresholdTrackBar.Size = new System.Drawing.Size(600, 56);
            this.ThresholdTrackBar.TabIndex = 0;
            this.ThresholdTrackBar.Value = 50;
            this.ThresholdTrackBar.Scroll += new System.EventHandler(this.ThresholdTrackBar_Scroll);
            // 
            // BinarizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BinarizeForm";
            this.Text = "Binarize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BinarizeForm_Close);
            this.Panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Brightness.ResumeLayout(false);
            this.Brightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox Brightness;
        private System.Windows.Forms.TrackBar ThresholdTrackBar;
        private System.Windows.Forms.Label CurrentThresholdLabel;
        private System.Windows.Forms.Label MaxThresholdLabel;
        private System.Windows.Forms.Label MinThresholdLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CurrentColorLabel;
        private System.Windows.Forms.Label MaxColorLabel;
        private System.Windows.Forms.Label MinColorLabel;
        private System.Windows.Forms.TrackBar MaxTrackBar;
    }
}