namespace Passport
{
    partial class frmStuPhoto
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
            this.gbxPhoto = new System.Windows.Forms.GroupBox();
            this.btngoResize = new System.Windows.Forms.Button();
            this.lblPhotoReg = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.lblStuImgChk = new System.Windows.Forms.Label();
            this.txtRegId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseRegId = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImgSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUD = new System.Windows.Forms.NumericUpDown();
            this.picBxResize = new System.Windows.Forms.PictureBox();
            this.btnFlipImg = new System.Windows.Forms.Button();
            this.picBxPhoto = new System.Windows.Forms.PictureBox();
            this.gbxPhoto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPhoto
            // 
            this.gbxPhoto.Controls.Add(this.btnFlipImg);
            this.gbxPhoto.Controls.Add(this.btngoResize);
            this.gbxPhoto.Controls.Add(this.lblPhotoReg);
            this.gbxPhoto.Controls.Add(this.btnAddPhoto);
            this.gbxPhoto.Controls.Add(this.btnSelectPhoto);
            this.gbxPhoto.Controls.Add(this.picBxPhoto);
            this.gbxPhoto.Controls.Add(this.lblStuImgChk);
            this.gbxPhoto.Location = new System.Drawing.Point(42, 61);
            this.gbxPhoto.Name = "gbxPhoto";
            this.gbxPhoto.Size = new System.Drawing.Size(202, 238);
            this.gbxPhoto.TabIndex = 175;
            this.gbxPhoto.TabStop = false;
            // 
            // btngoResize
            // 
            this.btngoResize.Location = new System.Drawing.Point(101, 203);
            this.btngoResize.Name = "btngoResize";
            this.btngoResize.Size = new System.Drawing.Size(52, 23);
            this.btngoResize.TabIndex = 198;
            this.btngoResize.Text = "Resize";
            this.btngoResize.UseVisualStyleBackColor = true;
            this.btngoResize.Click += new System.EventHandler(this.btngoResize_Click);
            // 
            // lblPhotoReg
            // 
            this.lblPhotoReg.AutoSize = true;
            this.lblPhotoReg.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPhotoReg.ForeColor = System.Drawing.Color.Black;
            this.lblPhotoReg.Location = new System.Drawing.Point(74, 161);
            this.lblPhotoReg.Name = "lblPhotoReg";
            this.lblPhotoReg.Size = new System.Drawing.Size(36, 13);
            this.lblPhotoReg.TabIndex = 197;
            this.lblPhotoReg.Text = "RegId";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(45, 203);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(43, 23);
            this.btnAddPhoto.TabIndex = 196;
            this.btnAddPhoto.Text = "Add";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(58, 34);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(106, 23);
            this.btnSelectPhoto.TabIndex = 7;
            this.btnSelectPhoto.Text = "Select  photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // lblStuImgChk
            // 
            this.lblStuImgChk.AutoSize = true;
            this.lblStuImgChk.ForeColor = System.Drawing.Color.Red;
            this.lblStuImgChk.Location = new System.Drawing.Point(7, 186);
            this.lblStuImgChk.Name = "lblStuImgChk";
            this.lblStuImgChk.Size = new System.Drawing.Size(35, 13);
            this.lblStuImgChk.TabIndex = 9;
            this.lblStuImgChk.Text = "photo";
            // 
            // txtRegId
            // 
            this.txtRegId.Location = new System.Drawing.Point(87, 25);
            this.txtRegId.MaxLength = 11;
            this.txtRegId.Name = "txtRegId";
            this.txtRegId.Size = new System.Drawing.Size(119, 20);
            this.txtRegId.TabIndex = 177;
            this.txtRegId.TextChanged += new System.EventHandler(this.txtRegId_TextChanged);
            this.txtRegId.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "Reg Id";
            // 
            // btnBrowseRegId
            // 
            this.btnBrowseRegId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRegId.Location = new System.Drawing.Point(216, 23);
            this.btnBrowseRegId.Name = "btnBrowseRegId";
            this.btnBrowseRegId.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseRegId.TabIndex = 178;
            this.btnBrowseRegId.Text = ". . .";
            this.btnBrowseRegId.UseVisualStyleBackColor = true;
            this.btnBrowseRegId.Click += new System.EventHandler(this.btnBrowseRegId_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(40, 200);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(79, 23);
            this.btnResize.TabIndex = 198;
            this.btnResize.Text = "compress";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImgSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUD);
            this.groupBox1.Controls.Add(this.picBxResize);
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Location = new System.Drawing.Point(293, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 235);
            this.groupBox1.TabIndex = 200;
            this.groupBox1.TabStop = false;
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblImgSize.ForeColor = System.Drawing.Color.Black;
            this.lblImgSize.Location = new System.Drawing.Point(94, 42);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(13, 13);
            this.lblImgSize.TabIndex = 199;
            this.lblImgSize.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 202;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 201;
            this.label2.Text = "quality";
            // 
            // numericUD
            // 
            this.numericUD.Location = new System.Drawing.Point(92, 19);
            this.numericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUD.Name = "numericUD";
            this.numericUD.Size = new System.Drawing.Size(42, 20);
            this.numericUD.TabIndex = 200;
            this.numericUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // picBxResize
            // 
            this.picBxResize.Location = new System.Drawing.Point(34, 61);
            this.picBxResize.Name = "picBxResize";
            this.picBxResize.Size = new System.Drawing.Size(100, 119);
            this.picBxResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxResize.TabIndex = 199;
            this.picBxResize.TabStop = false;
            // 
            // btnFlipImg
            // 
            this.btnFlipImg.BackgroundImage = global::Passport.Properties.Resources.index;
            this.btnFlipImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlipImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlipImg.Location = new System.Drawing.Point(167, 202);
            this.btnFlipImg.Name = "btnFlipImg";
            this.btnFlipImg.Size = new System.Drawing.Size(29, 26);
            this.btnFlipImg.TabIndex = 203;
            this.btnFlipImg.UseVisualStyleBackColor = true;
            this.btnFlipImg.Click += new System.EventHandler(this.btnFlipImg_Click);
            // 
            // picBxPhoto
            // 
            this.picBxPhoto.Location = new System.Drawing.Point(56, 64);
            this.picBxPhoto.Name = "picBxPhoto";
            this.picBxPhoto.Size = new System.Drawing.Size(107, 113);
            this.picBxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPhoto.TabIndex = 8;
            this.picBxPhoto.TabStop = false;
            // 
            // frmStuPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRegId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseRegId);
            this.Controls.Add(this.gbxPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStuPhoto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStuPhoto_Load);
            this.gbxPhoto.ResumeLayout(false);
            this.gbxPhoto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPhoto;
        private System.Windows.Forms.Label lblPhotoReg;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox picBxPhoto;
        private System.Windows.Forms.Label lblStuImgChk;
        private System.Windows.Forms.TextBox txtRegId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseRegId;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btngoResize;
        private System.Windows.Forms.PictureBox picBxResize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImgSize;
        private System.Windows.Forms.Button btnFlipImg;
    }
}