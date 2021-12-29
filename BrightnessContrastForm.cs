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
    public partial class BrightnessContrastForm : Form
    {
        private MainForm _parent;
        public Image<Bgr, byte> inputImage { get; set; }
        public Image<Bgr, byte> outputImage { get; set; }

        public BrightnessContrastForm(MainForm mForm, Image<Bgr, byte> pic)
        {
            InitializeComponent();

            _parent = mForm;
            inputImage = pic;
            outputImage = pic;
            PictureBox.Image = pic.AsBitmap();
        }

        private void AdjustContrastBrightness()
        {
            try
            {
                outputImage = (inputImage.Mul(double.Parse(CurrentContrastLabel.Text)) + double.Parse(CurrentBrightnessLabel.Text) - 50);
                PictureBox.Image = outputImage.AsBitmap();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            CurrentContrastLabel.Text = (ContrastTrackBar.Value / 10.0).ToString();
            AdjustContrastBrightness();
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            CurrentBrightnessLabel.Text = BrightnessTrackBar.Value.ToString();
            AdjustContrastBrightness();
        }

        private void BrightnessContrastForm_Close(object sender, EventArgs e)
        {
            _parent.ApplyResult(outputImage);
        }
    }
}
