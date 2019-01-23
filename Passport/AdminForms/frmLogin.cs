using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using EMIS.GlobalClasses;

namespace EMIS.GeneralForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void logIntoSystem()
        {
            var userBL = new EMIS.BLL.Users();
            BLL.Users x = new BLL.Users();

            EMISModule.ServerName = txtServer.Text;
            EMISModule.LogName = txtUserName.Text;
            EMISModule.DatabaseName = txtDatabase.Text;
            EMISModule.Password = txtPassword.Text;

            // MessageBox.Show(EMISModule.GetConnectionString());
            try
            {
                if (EMISModule.GetConnected())
                {
                    Properties.Settings.Default.ServerName = EMISModule.ServerName;
                    Properties.Settings.Default.LogginName = EMISModule.LogName;
                    Properties.Settings.Default.DBName = EMISModule.DatabaseName;
                    Properties.Settings.Default.Save();                   
                    //Program.userECenterID = x.GetECenterID((int)Program.loggedUser.StaffId);
                    //Program.loggedUser = userBL.GetUser_byName(EMISModule.LogName, (int)Program.userECenterID);
                    Program.loggedUser = userBL.GetUser_byName(EMISModule.LogName);
                    if (Program.loggedUser != null)
                    {
                        Program.userECenterID = Program.loggedUser.Staff.EducationCenter.ECenterId;
                        //Program.userECenterID = x.GetECenterID((int)Program.loggedUser.StaffId);
                       // byte[] bb = userBL.GetPassByte(Program.loggedUser.Password);
                        MessageBox.Show(BitConverter.ToString((Program.loggedUser.Password.ToArray())));
                        byte[] bb = userBL.GetPassByte(txtPassword.Text.Trim());
                        MessageBox.Show(BitConverter.ToString((userBL.GetPassByte(txtPassword.Text.Trim()))));
                        EMISModule.ValidateUser(txtPassword.Text.Trim(), Program.loggedUser.Password.ToArray());
                        EMISModule.openMain = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No user exists with the same logname. check your logname or contact the administrator please .", EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                    MessageBox.Show("not connected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,EMISModule.MessageTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }// log into system
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            btnOption.Text = "Options >>";
            this.ClientSize = new System.Drawing.Size(368, 127);

            string winLogName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            char[] remvChars = { '\\' };
            string[] parts = winLogName.Split(remvChars);
            txtUserName.Text = parts.ElementAt(1);
            txtDatabase.Text = Properties.Settings.Default.DBName;
            txtServer.Text = Properties.Settings.Default.ServerName;
            ///
            Cursor = Cursors.Default;
            //
            #region data source options
            if (txtUserName.Text.ToLower() == "minase")
            {
                btnOption.Show();
                gboDataSource.Show();
            }
            else
            {
                btnOption.Hide();
                gboDataSource.Hide();
            }
            #endregion
        }       

        private void btnOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logIntoSystem();
            Cursor = Cursors.Default;
        }
        

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtServer_Enter(object sender, EventArgs e)
        {
            txtServer.SelectAll();
        }       

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;
                logIntoSystem();
                Cursor = Cursors.Default;
            }//if
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;
                logIntoSystem();
                Cursor = Cursors.Default;
            }//if
        }

        private void txtDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;
                logIntoSystem();
                Cursor = Cursors.Default;
            }//if
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void btnOption_Click_1(object sender, EventArgs e)
        {
            if (btnOption.Text == "Options >>")
            {
                this.ClientSize = new System.Drawing.Size(368, 246);
                btnOption.Text = "<< Options";
            }
            else
            {
                btnOption.Text = "Options >>"; this.ClientSize = new System.Drawing.Size(368, 127);
            }
        }      

       
    }
}
