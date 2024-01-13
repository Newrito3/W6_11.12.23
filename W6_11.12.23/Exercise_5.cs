using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using System.Threading;

namespace W6_11._12._23

{
    public partial class Lab_Exercise_5 : Form
    {
        public Lab_Exercise_5()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> imageInput;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageBinarize;
        Image<Bgr, byte> Bitmap;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(openFile.FileName);
                pictureBoxOrigin.Image = imageInput.ToBitmap();

            }

        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height,
            new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255,
            ThresholdType.Binary );
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void binaryInvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height,
            new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255,
            ThresholdType.BinaryInv );
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void oTSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height,
            new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255,
            ThresholdType.Otsu );
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void gussainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            //binarization Adaptive Thresolding
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0),
            AdaptiveThresholdType.GaussianC,
           ThresholdType.Binary, 3, new Gray(0.0));
            pictureBoxOutput.Image = imageBinarize.ToBitmap();

        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            //binarization Adaptive Thresolding
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0),
            AdaptiveThresholdType.MeanC,
            ThresholdType.Binary, 3, new Gray(0.0));
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
