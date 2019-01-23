namespace Passport.AdminForms
{
    partial class fileUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileUpdate));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxFStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFam = new System.Windows.Forms.DataGridView();
            this.gbxFile = new System.Windows.Forms.GroupBox();
            this.txtFileNo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNatID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFam)).BeginInit();
            this.gbxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cbxFStatus);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 53);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 12);
            this.label20.TabIndex = 44;
            this.label20.Text = "File Status";
            // 
            // cbxFStatus
            // 
            this.cbxFStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFStatus.FormattingEnabled = true;
            this.cbxFStatus.Items.AddRange(new object[] {
            "Accepted",
            "Pending",
            "Rejected",
            "Void"});
            this.cbxFStatus.Location = new System.Drawing.Point(91, 20);
            this.cbxFStatus.Name = "cbxFStatus";
            this.cbxFStatus.Size = new System.Drawing.Size(98, 19);
            this.cbxFStatus.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSearch.Location = new System.Drawing.Point(247, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(415, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvFam
            // 
            this.dgvFam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFam.Location = new System.Drawing.Point(12, 78);
            this.dgvFam.Name = "dgvFam";
            this.dgvFam.Size = new System.Drawing.Size(343, 105);
            this.dgvFam.TabIndex = 40;
            this.dgvFam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFam_CellDoubleClick);
            // 
            // gbxFile
            // 
            this.gbxFile.Controls.Add(this.txtFileNo);
            this.gbxFile.Controls.Add(this.label21);
            this.gbxFile.Controls.Add(this.txtNatID);
            this.gbxFile.Controls.Add(this.label19);
            this.gbxFile.Location = new System.Drawing.Point(13, 198);
            this.gbxFile.Name = "gbxFile";
            this.gbxFile.Size = new System.Drawing.Size(342, 96);
            this.gbxFile.TabIndex = 41;
            this.gbxFile.TabStop = false;
            // 
            // txtFileNo
            // 
            this.txtFileNo.Location = new System.Drawing.Point(94, 58);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.ReadOnly = true;
            this.txtFileNo.Size = new System.Drawing.Size(100, 20);
            this.txtFileNo.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "File No";
            // 
            // txtNatID
            // 
            this.txtNatID.Location = new System.Drawing.Point(94, 23);
            this.txtNatID.Name = "txtNatID";
            this.txtNatID.ReadOnly = true;
            this.txtNatID.Size = new System.Drawing.Size(100, 20);
            this.txtNatID.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "NATIONAL ID";
            // 
            // fileUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 301);
            this.Controls.Add(this.gbxFile);
            this.Controls.Add(this.dgvFam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fileUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.fileUpdate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFam)).EndInit();
            this.gbxFile.ResumeLayout(false);
            this.gbxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxFStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFam;
        private System.Windows.Forms.GroupBox gbxFile;
        private System.Windows.Forms.TextBox txtFileNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNatID;
        private System.Windows.Forms.Label label19;
    }
}