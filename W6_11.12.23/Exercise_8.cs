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
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
namespace W6_11._12._23
{
    public partial class Lab_Exercise_8 : Form
    {
        Image<Bgr, byte> inputImage;
        Image<Gray, byte> outputImage;
        Image<Gray, float> sobelImage, laplacianImage;
        public Lab_Exercise_8()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(opf.FileName);
                imgInput.Image = inputImage.ToBitmap();
            }

        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                outputImage = inputImage.Convert<Gray, byte>().Canny(150, 10);
                imgOutput.Image = outputImage.ToBitmap();
            }
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                laplacianImage = inputImage.Convert<Gray, float>().Laplace(5);
                imgOutput.Image = laplacianImage.ToBitmap();
            }

        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                sobelImage = inputImage.Convert<Gray, float>().Sobel(1, 1, 5);
                imgOutput.Image = sobelImage.ToBitmap();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (outputImage != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|All files|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file extension from the filter
                    string extension = System.IO.Path.GetExtension(sfd.FileName);

                    // Save the image based on the selected format
                    switch (extension.ToLower())
                    {
                        case ".jpg":
                            outputImage.ToBitmap().Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".png":
                            outputImage.ToBitmap().Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".bmp":
                            outputImage.ToBitmap().Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        default:
                            // Save as BMP by default if the selected format is not recognized
                            outputImage.ToBitmap().Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
