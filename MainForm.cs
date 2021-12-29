using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        Bitmap srcImage;
        Image<Bgr, byte> _rslImage;
        Image<Gray, byte> _rslGrayImage;
        bool _isGray = false;

        public bool IsGray
        {
            get { return _isGray; }
            set {
                _isGray = value;
                grayscaleToolStripMenuItem.Checked = value;
            }
        }

        public Bitmap Res { 
            get {
                return IsGray ? _rslGrayImage.AsBitmap() : _rslImage.AsBitmap(); 
            }
            set { 
                _rslImage = value.ToImage<Bgr, byte>();
                _rslGrayImage = value.ToImage<Gray, byte>(); 
            } 
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Toolbox_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(ofd.FileName);

                srcImage = bitmap;
                Res = bitmap;
                Main_SourcePicture.Image = bitmap;
                Main_ResultPicture.Image = bitmap;
            }
        }

        private void Main_Toolbox_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Main_ResultPicture.Image.Save(sfd.FileName);
            }
        }

        private void adjustBrightnesscontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main_ResultPicture.Image != null)
            {
                BrightnessContrastForm bcf = new BrightnessContrastForm(this, _rslImage);

                bcf.ShowDialog();
            }
            else
                MessageBox.Show("Open image first!");

        }

        public void ApplyResult(Image<Bgr, byte> res)
        {
            Res = res.AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsGray = !IsGray;
            Main_ResultPicture.Image = Res;
        }

        private void rotateImage45DegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res = _rslImage.Rotate(45, new Bgr(255, 255, 255), false).AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void reflectVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res = _rslImage.Flip(Emgu.CV.CvEnum.FlipType.Vertical).AsBitmap();
            Main_ResultPicture.Image = Res;
        }


        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res = _rslImage.Flip(Emgu.CV.CvEnum.FlipType.Vertical).AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res = _rslImage.Flip(Emgu.CV.CvEnum.FlipType.Horizontal).AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void binarizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main_ResultPicture.Image != null)
            {
                BinarizeForm bf = new BinarizeForm(this, _rslImage);

                bf.ShowDialog();
            }
            else
                MessageBox.Show("Open image first!");
        }

        private void erodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _rslImage = _rslImage.Erode(1);
            Res = _rslImage.AsBitmap();

            Main_ResultPicture.Image = Res;
        }

        private void dilateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _rslImage = _rslImage.Dilate(1);
            Res = _rslImage.AsBitmap();

            Main_ResultPicture.Image = Res;
        }

        private void binarizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imgOutput = _rslGrayImage.ThresholdBinary(new Gray(100), new Gray(255));

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();

            CvInvoke.FindContours(imgOutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            CvInvoke.DrawContours(_rslImage, contours, -1, new MCvScalar(0, 0, 255));
            Res = _rslImage.AsBitmap();

            Main_ResultPicture.Image = Res;
        }

        private void cannyEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsGray = true;

            Res = _rslImage.Canny(20, 50).AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imgSobel = _rslGrayImage.Sobel(1, 0, 3);
            IsGray = true;

            Res = imgSobel.AsBitmap();
            Main_ResultPicture.Image = Res;
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imgLaplasian = _rslGrayImage.Laplace(7);
            IsGray = true;

            Res = imgLaplasian.AsBitmap();
            Main_ResultPicture.Image = Res;
        }
    }
}
