namespace W6_11._12._23
{
    partial class Lab_Exercise_6
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
            imgInput = new Emgu.CV.UI.ImageBox();
            imgBinary = new Emgu.CV.UI.ImageBox();
            imgGray = new Emgu.CV.UI.ImageBox();
            btnOpen = new Button();
            btnSave = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBinary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgGray).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imgInput
            // 
            imgInput.Location = new Point(27, 21);
            imgInput.Name = "imgInput";
            imgInput.Size = new Size(730, 550);
            imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgInput.TabIndex = 2;
            imgInput.TabStop = false;
            imgInput.Click += imgInput_Click;
            // 
            // imgBinary
            // 
            imgBinary.Location = new Point(853, 21);
            imgBinary.Name = "imgBinary";
            imgBinary.Size = new Size(730, 550);
            imgBinary.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBinary.TabIndex = 3;
            imgBinary.TabStop = false;
            // 
            // imgGray
            // 
            imgGray.Location = new Point(27, 662);
            imgGray.Name = "imgGray";
            imgGray.Size = new Size(730, 550);
            imgGray.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGray.TabIndex = 4;
            imgGray.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(853, 674);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(232, 86);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1123, 674);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(232, 86);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1409, 674);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(232, 86);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(886, 872);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 155);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thresholding";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Binary Invert", "OT’Su", "Guassian", "Mean" });
            comboBox1.Location = new Point(21, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(670, 66);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lab_Exercise_6
            // 
            AutoScaleDimensions = new SizeF(23F, 58F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 1264);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(imgGray);
            Controls.Add(imgBinary);
            Controls.Add(imgInput);
            Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Lab_Exercise_6";
            Text = "ບົດຝຶກຫັດ  6 Get_Binary_Image_from_Input_Image";
            Load += Lab_Exercise_6_Load;
            ((System.ComponentModel.ISupportInitialize)imgInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBinary).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgGray).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgBinary;
        private Emgu.CV.UI.ImageBox imgGray;
        private Button btnOpen;
        private Button btnSave;
        private Button btnClose;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}