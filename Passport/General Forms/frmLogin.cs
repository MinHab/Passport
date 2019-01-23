using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Passport.DataClasses;
using Passport.DataClasses;


namespace Passport
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
            
       
        private void logIntoSystem()
        {
            //string conStr =@"Server='"+txtServer.Text+"';Database='"+txtDatabase.Text+"';Integrated Security=true";
            if (txtPassword.Text == ""|| txtUserName.Text=="")
            {
                MessageBox.Show("Please fill both fields.");
                return;
            }
            conOpen.DatabaseName = txtDatabase.Text.Trim();
            conOpen.ServerName = txtServer.Text.Trim();

            try
            {
                if (conOpen.getConnected())
                {
                    Properties.Settings.Default.ServerName = txtServer.Text;
                    Properties.Settings.Default.LogginName = txtUserName.Text;
                    Properties.Settings.Default.DBName = txtDatabase.Text;
                    Properties.Settings.Default.Save();

                    //string userName = Environment.UserName;
                    bool oprExist = true;
                    byte[] pswArr = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text.Trim());

                    using (EmbassyDataDataContext db = new EmbassyDataDataContext(conOpen.ConnectionString))
                    {
                        Opr _user = db.Oprs.SingleOrDefault(u => u.FullName == txtUserName.Text);
                        if (_user != null)
                        {
                            byte[] dbpsw = _user.Password.ToArray();
                            for (int i = 0; i < pswArr.Length; i++)
                            {
                                if (!(dbpsw[i] == pswArr[i]))
                                { oprExist = false; }
                            }
                            if (oprExist)
                            {
                                Program.openMain = true;
                                Close();
                            }

                            else
                            { MessageBox.Show("Incorrect Password. Please try again or contact the administrator."); }
                        }
                        else { MessageBox.Show("User Name does not exist.Please contact the administrator."); }
                    }
                }
                else
                {
                    MessageBox.Show("not connected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// log into system
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Environment.UserName;
            this.ClientSize = new Size(340, 127);
            btnOption.Text = "Option >>";

            txtDatabase.Text = Properties.Settings.Default.DBName;
            txtServer.Text = Properties.Settings.Default.ServerName;
            txtPassword.Focus();
            txtPassword.SelectAll();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            logIntoSystem();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            if (btnOption.Text == "Option >>")
            {
                this.ClientSize = new Size(340, 248);
                btnOption.Text = "<< Option";
            }
            else 
            {
                this.ClientSize = new Size(340,137);
                btnOption.Text = "Option >>";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logIntoSystem();
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logIntoSystem();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
