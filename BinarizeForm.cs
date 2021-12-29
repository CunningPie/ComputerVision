using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace ComputerVision
{
    public partial class BinarizeForm : Form
    {
        private MainForm _parent;
        public Image<Bgr, byte> inputImage { get; set; }
        public Image<Bgr, byte> outputImage { get; set; }

        public BinarizeForm(MainForm mForm, Image<Bgr, byte> pic)
        {
            InitializeComponent();

            _parent = mForm;
            inputImage = pic;
            outputImage = pic;
            PictureBox.Image = pic.AsBitmap();
        }

        private void AdjustThreshold()
        {
            try
            {
                var thr = double.Parse(CurrentThresholdLabel.Text);
                var max = double.Parse(CurrentColorLabel.Text);

                outputImage = inputImage.ThresholdBinary(new Bgr(thr, thr, thr), new Bgr(max, max, max));
                PictureBox.Image = outputImage.AsBitmap();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MaxTrackBar_Scroll(object sender, EventArgs e)
        {
            CurrentColorLabel.Text = MaxTrackBar.Value.ToString();
            AdjustThreshold();
        }

        private void ThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            CurrentThresholdLabel.Text = ThresholdTrackBar.Value.ToString();
            AdjustThreshold();
        }

        private void BinarizeForm_Close(object sender, EventArgs e)
        {
            _parent.ApplyResult(outputImage);
        }
    }
}
