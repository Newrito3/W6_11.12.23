using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;




namespace W6_11._12._23
{
    public partial class Lab_Exercise_9 : Form
    {
        public Lab_Exercise_9()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> imageInput;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(openFile.FileName);
                pictureBoxInput.Image = imageInput.ToBitmap();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|BMP files (*.bmp)|*.bmp";
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOutput.Image.Save(saveImage.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            pictureBoxOutput.Image = imageInput.Dilate(1).ToBitmap();
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            pictureBoxOutput.Image = imageInput.Erode(1).ToBitmap();
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }

            StructuringElementEx element2 = new StructuringElementEx(new int[3, 3]
            { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } }, 1, 1);

            pictureBoxOutput.Image = imageInput.MorphologyEx(element2, CvEnum.CV_MORPH_OP.CV_MOP_OPEN, 2).ToBitmap();

        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            StructuringElementEx element2 = new StructuringElementEx(new int[3, 3]
            { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } }, 1, 1);
            pictureBoxOutput.Image = imageInput.MorphologyEx(element2, CvEnum.CV_MORPH_OP.CV_MOP_CLOSE, 1).ToBitmap();


        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }

            StructuringElementEx element2 = new StructuringElementEx(new int[3, 3]
            { { 0, 1, 0 },{ 1, 0, 1 }, { 0, 1, 0 } }, 1, 1);
            pictureBoxOutput.Image = imageInput.MorphologyEx(element2, CvEnum.CV_MORPH_OP.CV_MOP_GRADIENT, 1).ToBitmap();

        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }

            StructuringElementEx element2 = new StructuringElementEx(new int[3, 3]
            { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } }, 1, 1);
            pictureBoxOutput.Image = imageInput.MorphologyEx(element2, CvEnum.CV_MORPH_OP.CV_MOP_TOPHAT, 1).ToBitmap();

        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            StructuringElementEx element2 = new StructuringElementEx(new int[3, 3]
            { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } }, 1, 1);

            pictureBoxOutput.Image = imageInput.MorphologyEx(element2, CvEnum.CV_MORPH_OP.CV_MOP_BLACKHAT, 1).ToBitmap();

        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            pictureBoxOutput.Image = imageInput.Convert<Gray,
            byte>().ThresholdBinary(new Gray(150),
            new Gray(255)).Dilate(1).ToBitmap();
        }

        private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                return;
            }
            pictureBoxOutput.Image = imageInput.Convert<Gray,
            byte>().ThresholdBinary(new Gray(150),
            new Gray(255)).Erode(1).ToBitmap();

        }
    }

    internal class StructuringElementEx
    {
        public StructuringElementEx(int[,] ints, int v1, int v2)
        {
        }
    }
}
