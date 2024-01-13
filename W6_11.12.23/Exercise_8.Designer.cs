namespace W6_11._12._23
{
    partial class Lab_Exercise_8
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            cannyToolStripMenuItem = new ToolStripMenuItem();
            sobelToolStripMenuItem = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            imgInput = new PictureBox();
            imgOutput = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, edgeDetectionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2045, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(258, 54);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(258, 54);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(258, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cannyToolStripMenuItem, sobelToolStripMenuItem, laplacianToolStripMenuItem });
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(246, 45);
            edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // cannyToolStripMenuItem
            // 
            cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            cannyToolStripMenuItem.Size = new Size(306, 54);
            cannyToolStripMenuItem.Text = "Canny";
            cannyToolStripMenuItem.Click += cannyToolStripMenuItem_Click;
            // 
            // sobelToolStripMenuItem
            // 
            sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            sobelToolStripMenuItem.Size = new Size(306, 54);
            sobelToolStripMenuItem.Text = "Sobel";
            sobelToolStripMenuItem.Click += sobelToolStripMenuItem_Click;
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(306, 54);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // imgInput
            // 
            imgInput.Location = new Point(24, 103);
            imgInput.Name = "imgInput";
            imgInput.Size = new Size(980, 1025);
            imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgInput.TabIndex = 1;
            imgInput.TabStop = false;
            // 
            // imgOutput
            // 
            imgOutput.Location = new Point(1043, 103);
            imgOutput.Name = "imgOutput";
            imgOutput.Size = new Size(980, 1025);
            imgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgOutput.TabIndex = 2;
            imgOutput.TabStop = false;
            // 
            // Lab_Exercise_8
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2045, 1166);
            Controls.Add(imgOutput);
            Controls.Add(imgInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Lab_Exercise_8";
            Text = "ບົດຝຶກຫັດ 8 ການຊອກຫາເສັັ້ນຂອບຂອງພາບ (Edge Detection)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem cannyToolStripMenuItem;
        private ToolStripMenuItem sobelToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private PictureBox imgInput;
        private PictureBox imgOutput;
    }
}