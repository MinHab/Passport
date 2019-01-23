namespace EMIS.AdminForms
{
    partial class frmUsers
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
            this.cmbLogName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPsw = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbStaffNotUser = new System.Windows.Forms.ComboBox();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gboAddEditUser = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.chkbActive = new System.Windows.Forms.CheckBox();
            this.ckbPswReset = new System.Windows.Forms.CheckBox();
            this.gboPsw = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditMPermit = new System.Windows.Forms.Button();
            this.btnSaveMPermit = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.dgvUsersMenu = new System.Windows.Forms.DataGridView();
            this.cmbMenuItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserPermit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gboAddEditUser.SuspendLayout();
            this.gboPsw.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLogName
            // 
            this.cmbLogName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbLogName.FormattingEnabled = true;
            this.cmbLogName.Location = new System.Drawing.Point(71, 30);
            this.cmbLogName.Name = "cmbLogName";
            this.cmbLogName.Size = new System.Drawing.Size(195, 21);
            this.cmbLogName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password :";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 503);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
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
            this.btnEdit.Location = new System.Drawing.Point(111, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(198, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(22, 451);
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
            this.groupBox4.Location = new System.Drawing.Point(10, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 133);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 19);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(542, 107);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbStaffNotUser);
            this.groupBox3.Controls.Add(this.txtRegID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(9, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 82);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Staff";
            // 
            // cmbStaffNotUser
            // 
            this.cmbStaffNotUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffNotUser.FormattingEnabled = true;
            this.cmbStaffNotUser.Location = new System.Drawing.Point(86, 22);
            this.cmbStaffNotUser.Name = "cmbStaffNotUser";
            this.cmbStaffNotUser.Size = new System.Drawing.Size(298, 21);
            this.cmbStaffNotUser.TabIndex = 14;
            this.cmbStaffNotUser.SelectedIndexChanged += new System.EventHandler(this.cmbStaffNotUser_SelectedIndexChanged);
            // 
            // txtRegID
            // 
            this.txtRegID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRegID.Location = new System.Drawing.Point(86, 56);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.ReadOnly = true;
            this.txtRegID.Size = new System.Drawing.Size(121, 20);
            this.txtRegID.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(13, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Reg ID";
            // 
            // txtTitle
            // 
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitle.Location = new System.Drawing.Point(263, 56);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(121, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(230, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Staff Name";
            // 
            // gboAddEditUser
            // 
            this.gboAddEditUser.Controls.Add(this.label4);
            this.gboAddEditUser.Controls.Add(this.txtRegName);
            this.gboAddEditUser.Controls.Add(this.chkbActive);
            this.gboAddEditUser.Controls.Add(this.ckbPswReset);
            this.gboAddEditUser.Controls.Add(this.gboPsw);
            this.gboAddEditUser.Controls.Add(this.cmbLogName);
            this.gboAddEditUser.Controls.Add(this.label1);
            this.gboAddEditUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboAddEditUser.Location = new System.Drawing.Point(9, 245);
            this.gboAddEditUser.Name = "gboAddEditUser";
            this.gboAddEditUser.Size = new System.Drawing.Size(272, 198);
            this.gboAddEditUser.TabIndex = 16;
            this.gboAddEditUser.TabStop = false;
            this.gboAddEditUser.Text = "Add / Edit User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Full Name";
            // 
            // txtRegName
            // 
            this.txtRegName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRegName.Location = new System.Drawing.Point(71, 61);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.ReadOnly = true;
            this.txtRegName.Size = new System.Drawing.Size(195, 20);
            this.txtRegName.TabIndex = 32;
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
            this.ckbPswReset.Size = new System.Drawing.Size(130, 17);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu Permission";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(71, 74);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(195, 21);
            this.cmbMenu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Menu Name";
            // 
            // btnEditMPermit
            // 
            this.btnEditMPermit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditMPermit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditMPermit.Location = new System.Drawing.Point(180, 173);
            this.btnEditMPermit.Name = "btnEditMPermit";
            this.btnEditMPermit.Size = new System.Drawing.Size(75, 25);
            this.btnEditMPermit.TabIndex = 20;
            this.btnEditMPermit.Text = "&Edit";
            this.btnEditMPermit.UseVisualStyleBackColor = true;
            // 
            // btnSaveMPermit
            // 
            this.btnSaveMPermit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveMPermit.Location = new System.Drawing.Point(91, 175);
            this.btnSaveMPermit.Name = "btnSaveMPermit";
            this.btnSaveMPermit.Size = new System.Drawing.Size(69, 23);
            this.btnSaveMPermit.TabIndex = 21;
            this.btnSaveMPermit.Text = "&Save";
            this.btnSaveMPermit.UseVisualStyleBackColor = true;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.dgvUsersMenu);
            this.groupbox.Location = new System.Drawing.Point(7, 19);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(565, 156);
            this.groupbox.TabIndex = 22;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Users";
            // 
            // dgvUsersMenu
            // 
            this.dgvUsersMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersMenu.Location = new System.Drawing.Point(5, 19);
            this.dgvUsersMenu.Name = "dgvUsersMenu";
            this.dgvUsersMenu.Size = new System.Drawing.Size(553, 131);
            this.dgvUsersMenu.TabIndex = 0;
            // 
            // cmbMenuItem
            // 
            this.cmbMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMenuItem.FormattingEnabled = true;
            this.cmbMenuItem.Location = new System.Drawing.Point(71, 125);
            this.cmbMenuItem.Name = "cmbMenuItem";
            this.cmbMenuItem.Size = new System.Drawing.Size(195, 21);
            this.cmbMenuItem.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(1, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Menu Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(1, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Full Name";
            // 
            // txtUserPermit
            // 
            this.txtUserPermit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserPermit.Location = new System.Drawing.Point(71, 33);
            this.txtUserPermit.Name = "txtUserPermit";
            this.txtUserPermit.ReadOnly = true;
            this.txtUserPermit.Size = new System.Drawing.Size(195, 20);
            this.txtUserPermit.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditMPermit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUserPermit);
            this.groupBox1.Controls.Add(this.cmbMenu);
            this.groupBox1.Controls.Add(this.cmbMenuItem);
            this.groupBox1.Controls.Add(this.btnSaveMPermit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 271);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUsers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gboAddEditUser.ResumeLayout(false);
            this.gboAddEditUser.PerformLayout();
            this.gboPsw.ResumeLayout(false);
            this.gboPsw.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLogName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPsw;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gboAddEditUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gboPsw;
        private System.Windows.Forms.CheckBox ckbPswReset;
        private System.Windows.Forms.ComboBox cmbStaffNotUser;
        private System.Windows.Forms.CheckBox chkbActive;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditMPermit;
        private System.Windows.Forms.Button btnSaveMPermit;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.DataGridView dgvUsersMenu;
        private System.Windows.Forms.ComboBox cmbMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUserPermit;

    }
}