namespace W6_11._12._23
{
    partial class Lab_Exercise_5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            simpleThresoldToolStripMenuItem = new ToolStripMenuItem();
            binaryToolStripMenuItem = new ToolStripMenuItem();
            binaryInvertToolStripMenuItem = new ToolStripMenuItem();
            oTSuToolStripMenuItem = new ToolStripMenuItem();
            adaptiveThresoldToolStripMenuItem = new ToolStripMenuItem();
            gussainToolStripMenuItem = new ToolStripMenuItem();
            meanToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxOrigin = new PictureBox();
            pictureBoxOutput = new PictureBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Location = new Point(0, 49);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2288, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(40, 40);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(2288, 49);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, simpleThresoldToolStripMenuItem, adaptiveThresoldToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(424, 54);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // simpleThresoldToolStripMenuItem
            // 
            simpleThresoldToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { binaryToolStripMenuItem, binaryInvertToolStripMenuItem, oTSuToolStripMenuItem });
            simpleThresoldToolStripMenuItem.Name = "simpleThresoldToolStripMenuItem";
            simpleThresoldToolStripMenuItem.Size = new Size(424, 54);
            simpleThresoldToolStripMenuItem.Text = "Simple Thresold";
            // 
            // binaryToolStripMenuItem
            // 
            binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            binaryToolStripMenuItem.Size = new Size(348, 54);
            binaryToolStripMenuItem.Text = "Binary";
            binaryToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
            // 
            // binaryInvertToolStripMenuItem
            // 
            binaryInvertToolStripMenuItem.Name = "binaryInvertToolStripMenuItem";
            binaryInvertToolStripMenuItem.Size = new Size(348, 54);
            binaryInvertToolStripMenuItem.Text = "Binary Invert";
            binaryInvertToolStripMenuItem.Click += binaryInvertToolStripMenuItem_Click;
            // 
            // oTSuToolStripMenuItem
            // 
            oTSuToolStripMenuItem.Name = "oTSuToolStripMenuItem";
            oTSuToolStripMenuItem.Size = new Size(348, 54);
            oTSuToolStripMenuItem.Text = "OT'Su";
            oTSuToolStripMenuItem.Click += oTSuToolStripMenuItem_Click;
            // 
            // adaptiveThresoldToolStripMenuItem
            // 
            adaptiveThresoldToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gussainToolStripMenuItem, meanToolStripMenuItem });
            adaptiveThresoldToolStripMenuItem.Name = "adaptiveThresoldToolStripMenuItem";
            adaptiveThresoldToolStripMenuItem.Size = new Size(424, 54);
            adaptiveThresoldToolStripMenuItem.Text = "Adaptive Thresold";
            // 
            // gussainToolStripMenuItem
            // 
            gussainToolStripMenuItem.Name = "gussainToolStripMenuItem";
            gussainToolStripMenuItem.Size = new Size(302, 54);
            gussainToolStripMenuItem.Text = "Guassian";
            gussainToolStripMenuItem.Click += gussainToolStripMenuItem_Click;
            // 
            // meanToolStripMenuItem
            // 
            meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            meanToolStripMenuItem.Size = new Size(302, 54);
            meanToolStripMenuItem.Text = "Mean";
            meanToolStripMenuItem.Click += meanToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(424, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // pictureBoxOrigin
            // 
            pictureBoxOrigin.Location = new Point(35, 76);
            pictureBoxOrigin.Name = "pictureBoxOrigin";
            pictureBoxOrigin.Size = new Size(1074, 1095);
            pictureBoxOrigin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOrigin.TabIndex = 2;
            pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            pictureBoxOutput.Location = new Point(1175, 76);
            pictureBoxOutput.Name = "pictureBoxOutput";
            pictureBoxOutput.Size = new Size(1074, 1095);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOutput.TabIndex = 3;
            pictureBoxOutput.TabStop = false;
            // 
            // Lab_Exercise_5
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2288, 1211);
            Controls.Add(pictureBoxOutput);
            Controls.Add(pictureBoxOrigin);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Lab_Exercise_5";
            Text = "ບົດຝຶກຫັດ 5_Image_Binarization";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrigin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem simpleThresoldToolStripMenuItem;
        private ToolStripMenuItem binaryToolStripMenuItem;
        private ToolStripMenuItem binaryInvertToolStripMenuItem;
        private ToolStripMenuItem oTSuToolStripMenuItem;
        private ToolStripMenuItem adaptiveThresoldToolStripMenuItem;
        private ToolStripMenuItem gussainToolStripMenuItem;
        private ToolStripMenuItem meanToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox pictureBoxOrigin;
        private PictureBox pictureBoxOutput;
    }
}
