namespace W6_11._12._23
{
    partial class Lab_Exercise_7
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
            components = new System.ComponentModel.Container();
            imgBoxInput = new Emgu.CV.UI.ImageBox();
            ImgBoxOutput = new Emgu.CV.UI.ImageBox();
            htgBeforeE = new Emgu.CV.UI.HistogramBox();
            htgAfterE = new Emgu.CV.UI.HistogramBox();
            btnLoadImage = new Button();
            btnEqualization = new Button();
            btnGuassian = new Button();
            btnMedian = new Button();
            btnSaveImage = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgBoxOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)htgBeforeE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)htgAfterE).BeginInit();
            SuspendLayout();
            // 
            // imgBoxInput
            // 
            imgBoxInput.Location = new Point(26, 22);
            imgBoxInput.Name = "imgBoxInput";
            imgBoxInput.Size = new Size(694, 573);
            imgBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxInput.TabIndex = 2;
            imgBoxInput.TabStop = false;
            // 
            // ImgBoxOutput
            // 
            ImgBoxOutput.Location = new Point(26, 642);
            ImgBoxOutput.Name = "ImgBoxOutput";
            ImgBoxOutput.Size = new Size(694, 573);
            ImgBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgBoxOutput.TabIndex = 3;
            ImgBoxOutput.TabStop = false;
            // 
            // htgBeforeE
            // 
            htgBeforeE.Location = new Point(757, 22);
            htgBeforeE.Name = "htgBeforeE";
            htgBeforeE.Size = new Size(1053, 584);
            htgBeforeE.SizeMode = PictureBoxSizeMode.StretchImage;
            htgBeforeE.TabIndex = 2;
            htgBeforeE.TabStop = false;
            // 
            // htgAfterE
            // 
            htgAfterE.Location = new Point(757, 642);
            htgAfterE.Name = "htgAfterE";
            htgAfterE.Size = new Size(1053, 584);
            htgAfterE.SizeMode = PictureBoxSizeMode.StretchImage;
            htgAfterE.TabIndex = 4;
            htgAfterE.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(1869, 44);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(386, 73);
            btnLoadImage.TabIndex = 5;
            btnLoadImage.Text = "Laod Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnEqualization
            // 
            btnEqualization.AllowDrop = true;
            btnEqualization.Location = new Point(1869, 149);
            btnEqualization.Name = "btnEqualization";
            btnEqualization.Size = new Size(386, 146);
            btnEqualization.TabIndex = 6;
            btnEqualization.Text = "Histogram Equalization";
            btnEqualization.UseVisualStyleBackColor = true;
            btnEqualization.Click += btnEqualization_Click;
            // 
            // btnGuassian
            // 
            btnGuassian.Location = new Point(1869, 333);
            btnGuassian.Name = "btnGuassian";
            btnGuassian.Size = new Size(386, 73);
            btnGuassian.TabIndex = 7;
            btnGuassian.Text = "Guassian Filter";
            btnGuassian.UseVisualStyleBackColor = true;
            btnGuassian.Click += btnGuassian_Click;
            // 
            // btnMedian
            // 
            btnMedian.Location = new Point(1869, 436);
            btnMedian.Name = "btnMedian";
            btnMedian.Size = new Size(384, 73);
            btnMedian.TabIndex = 8;
            btnMedian.Text = "Median Filter";
            btnMedian.UseVisualStyleBackColor = true;
            btnMedian.Click += btnMedian_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(1869, 533);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(384, 73);
            btnSaveImage.TabIndex = 9;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1869, 642);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(384, 73);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Lab_Exercise_7
            // 
            AutoScaleDimensions = new SizeF(23F, 58F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2293, 1250);
            Controls.Add(btnExit);
            Controls.Add(btnSaveImage);
            Controls.Add(btnMedian);
            Controls.Add(btnGuassian);
            Controls.Add(btnEqualization);
            Controls.Add(btnLoadImage);
            Controls.Add(htgAfterE);
            Controls.Add(htgBeforeE);
            Controls.Add(ImgBoxOutput);
            Controls.Add(imgBoxInput);
            Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Lab_Exercise_7";
            Text = "ບົດຝຶກຫັດ 7_Histogram_Equalization_and_Image_Filtering";
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgBoxOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)htgBeforeE).EndInit();
            ((System.ComponentModel.ISupportInitialize)htgAfterE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBoxInput;
        private Emgu.CV.UI.ImageBox ImgBoxOutput;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private Button btnLoadImage;
        private Button btnEqualization;
        private Button btnGuassian;
        private Button btnMedian;
        private Button btnSaveImage;
        private Button btnExit;
    }
}