namespace W6_11._12._23
{
    partial class Lab_Exercise_9
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
            morphologyToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem = new ToolStripMenuItem();
            erosionToolStripMenuItem = new ToolStripMenuItem();
            openingToolStripMenuItem = new ToolStripMenuItem();
            closingToolStripMenuItem = new ToolStripMenuItem();
            gradientToolStripMenuItem = new ToolStripMenuItem();
            topHatToolStripMenuItem = new ToolStripMenuItem();
            blackHatToolStripMenuItem = new ToolStripMenuItem();
            morphologicalBinaryToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem1 = new ToolStripMenuItem();
            erosionToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBoxInput = new PictureBox();
            pictureBoxOutput = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, morphologyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2521, 49);
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
            // morphologyToolStripMenuItem
            // 
            morphologyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem, erosionToolStripMenuItem, openingToolStripMenuItem, closingToolStripMenuItem, gradientToolStripMenuItem, topHatToolStripMenuItem, blackHatToolStripMenuItem, morphologicalBinaryToolStripMenuItem });
            morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            morphologyToolStripMenuItem.Size = new Size(208, 45);
            morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dilationToolStripMenuItem
            // 
            dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            dilationToolStripMenuItem.Size = new Size(467, 54);
            dilationToolStripMenuItem.Text = "Dilation";
            dilationToolStripMenuItem.Click += dilationToolStripMenuItem_Click;
            // 
            // erosionToolStripMenuItem
            // 
            erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            erosionToolStripMenuItem.Size = new Size(467, 54);
            erosionToolStripMenuItem.Text = "Erosion";
            erosionToolStripMenuItem.Click += erosionToolStripMenuItem_Click;
            // 
            // openingToolStripMenuItem
            // 
            openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            openingToolStripMenuItem.Size = new Size(467, 54);
            openingToolStripMenuItem.Text = "Opening";
            openingToolStripMenuItem.Click += openingToolStripMenuItem_Click;
            // 
            // closingToolStripMenuItem
            // 
            closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            closingToolStripMenuItem.Size = new Size(467, 54);
            closingToolStripMenuItem.Text = "Closing";
            closingToolStripMenuItem.Click += closingToolStripMenuItem_Click;
            // 
            // gradientToolStripMenuItem
            // 
            gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            gradientToolStripMenuItem.Size = new Size(467, 54);
            gradientToolStripMenuItem.Text = "Gradient";
            gradientToolStripMenuItem.Click += gradientToolStripMenuItem_Click;
            // 
            // topHatToolStripMenuItem
            // 
            topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            topHatToolStripMenuItem.Size = new Size(467, 54);
            topHatToolStripMenuItem.Text = "Top Hat";
            topHatToolStripMenuItem.Click += topHatToolStripMenuItem_Click;
            // 
            // blackHatToolStripMenuItem
            // 
            blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            blackHatToolStripMenuItem.Size = new Size(467, 54);
            blackHatToolStripMenuItem.Text = "Black Hat";
            blackHatToolStripMenuItem.Click += blackHatToolStripMenuItem_Click;
            // 
            // morphologicalBinaryToolStripMenuItem
            // 
            morphologicalBinaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem1, erosionToolStripMenuItem1 });
            morphologicalBinaryToolStripMenuItem.Name = "morphologicalBinaryToolStripMenuItem";
            morphologicalBinaryToolStripMenuItem.Size = new Size(467, 54);
            morphologicalBinaryToolStripMenuItem.Text = "Morphological Binary";
            // 
            // dilationToolStripMenuItem1
            // 
            dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
            dilationToolStripMenuItem1.Size = new Size(448, 54);
            dilationToolStripMenuItem1.Text = "Dilation";
            dilationToolStripMenuItem1.Click += dilationToolStripMenuItem1_Click;
            // 
            // erosionToolStripMenuItem1
            // 
            erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
            erosionToolStripMenuItem1.Size = new Size(448, 54);
            erosionToolStripMenuItem1.Text = "Erosion";
            erosionToolStripMenuItem1.Click += erosionToolStripMenuItem1_Click;
            // 
            // pictureBoxInput
            // 
            pictureBoxInput.Location = new Point(33, 105);
            pictureBoxInput.Name = "pictureBoxInput";
            pictureBoxInput.Size = new Size(1215, 1065);
            pictureBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInput.TabIndex = 1;
            pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            pictureBoxOutput.Location = new Point(1269, 105);
            pictureBoxOutput.Name = "pictureBoxOutput";
            pictureBoxOutput.Size = new Size(1215, 1065);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOutput.TabIndex = 2;
            pictureBoxOutput.TabStop = false;
            // 
            // Lab_Exercise_9
            // 
            AutoScaleDimensions = new SizeF(23F, 58F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2521, 1182);
            Controls.Add(pictureBoxOutput);
            Controls.Add(pictureBoxInput);
            Controls.Add(menuStrip1);
            Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Lab_Exercise_9";
            Text = "Exercise_9";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem morphologyToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem;
        private ToolStripMenuItem erosionToolStripMenuItem;
        private ToolStripMenuItem openingToolStripMenuItem;
        private ToolStripMenuItem closingToolStripMenuItem;
        private ToolStripMenuItem gradientToolStripMenuItem;
        private ToolStripMenuItem topHatToolStripMenuItem;
        private ToolStripMenuItem blackHatToolStripMenuItem;
        private ToolStripMenuItem morphologicalBinaryToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem1;
        private ToolStripMenuItem erosionToolStripMenuItem1;
        private PictureBox pictureBoxInput;
        private PictureBox pictureBoxOutput;
    }
}