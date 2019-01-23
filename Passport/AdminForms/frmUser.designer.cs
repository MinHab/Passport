namespace Passport
{
    partial class frmUser
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gboAddEditUser = new System.Windows.Forms.GroupBox();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.chkbActive = new System.Windows.Forms.CheckBox();
            this.ckbPswReset = new System.Windows.Forms.CheckBox();
            this.gboPsw = new System.Windows.Forms.GroupBox();
            this.txtConfirmPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gboAddEditUser.SuspendLayout();
            this.gboPsw.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.gboAddEditUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(279, 352);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(190, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvUsers);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 133);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(14, 16);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(542, 107);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // gboAddEditUser
            // 
            this.gboAddEditUser.Controls.Add(this.txtRegID);
            this.gboAddEditUser.Controls.Add(this.label4);
            this.gboAddEditUser.Controls.Add(this.txtFullName);
            this.gboAddEditUser.Controls.Add(this.chkbActive);
            this.gboAddEditUser.Controls.Add(this.ckbPswReset);
            this.gboAddEditUser.Controls.Add(this.gboPsw);
            this.gboAddEditUser.Controls.Add(this.label1);
            this.gboAddEditUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboAddEditUser.Location = new System.Drawing.Point(98, 148);
            this.gboAddEditUser.Name = "gboAddEditUser";
            this.gboAddEditUser.Size = new System.Drawing.Size(272, 198);
            this.gboAddEditUser.TabIndex = 16;
            this.gboAddEditUser.TabStop = false;
            this.gboAddEditUser.Text = "Add / Edit User";
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(71, 33);
            this.txtRegID.MaxLength = 20;
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(195, 20);
            this.txtRegID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "User Name";
            // 
            // txtFullName
            // 
            this.txtFullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFullName.Location = new System.Drawing.Point(71, 61);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(195, 20);
            this.txtFullName.TabIndex = 32;
            // 
            // chkbActive
            // 
            this.chkbActive.AutoSize = true;
            this.chkbActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbActive.Location = new System.Drawing.Point(71, 90);
            this.chkbActive.Name = "chkbActive";
            this.chkbActive.Size = new System.Drawing.Size(56, 17);
            this.chkbActive.TabIndex = 31;
            this.chkbActive.Text = "Active";
            this.chkbActive.UseVisualStyleBackColor = true;
            // 
            // ckbPswReset
            // 
            this.ckbPswReset.AutoSize = true;
            this.ckbPswReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbPswReset.Location = new System.Drawing.Point(141, 90);
            this.ckbPswReset.Name = "ckbPswReset";
            this.ckbPswReset.Size = new System.Drawing.Size(129, 17);
            this.ckbPswReset.TabIndex = 30;
            this.ckbPswReset.Text = "Set / Reset Password";
            this.ckbPswReset.UseVisualStyleBackColor = true;
            this.ckbPswReset.CheckedChanged += new System.EventHandler(this.ckbPswReset_CheckedChanged);
            // 
            // gboPsw
            // 
            this.gboPsw.Controls.Add(this.txtConfirmPsw);
            this.gboPsw.Controls.Add(this.label2);
            this.gboPsw.Controls.Add(this.label3);
            this.gboPsw.Controls.Add(this.txtPassword);
            this.gboPsw.Enabled = false;
            this.gboPsw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboPsw.Location = new System.Drawing.Point(6, 112);
            this.gboPsw.Name = "gboPsw";
            this.gboPsw.Size = new System.Drawing.Size(260, 81);
            this.gboPsw.TabIndex = 29;
            this.gboPsw.TabStop = false;
            this.gboPsw.Text = "Password";
            // 
            // txtConfirmPsw
            // 
            this.txtConfirmPsw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPsw.Location = new System.Drawing.Point(127, 55);
            this.txtConfirmPsw.MaxLength = 15;
            this.txtConfirmPsw.Name = "txtConfirmPsw";
            this.txtConfirmPsw.PasswordChar = '*';
            this.txtConfirmPsw.Size = new System.Drawing.Size(121, 20);
            this.txtConfirmPsw.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(127, 19);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "National ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 503);
            this.tabControl1.TabIndex = 10;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 416);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gboAddEditUser.ResumeLayout(false);
            this.gboAddEditUser.PerformLayout();
            this.gboPsw.ResumeLayout(false);
            this.gboPsw.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gboAddEditUser;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.CheckBox chkbActive;
        private System.Windows.Forms.CheckBox ckbPswReset;
        private System.Windows.Forms.GroupBox gboPsw;
        private System.Windows.Forms.TextBox txtConfirmPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;

    }
}