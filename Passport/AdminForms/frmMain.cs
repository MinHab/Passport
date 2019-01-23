using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Passport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void switchUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            //frmMain _main = (frmMain)Application.OpenForms["frmMain"];
            //_main.Hide();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //interaction.Shell("Control TimeDate.cpl");
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("timedate.cpl");
            p.StartInfo.UseShellExecute = true;
            p.Start(); 
           // Shell("Control TimeDate.cpl");
        }

        private void regionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Process p = new Process();
             p.StartInfo = new ProcessStartInfo("control");
             //p.StartInfo = new ProcessStartInfo("printui");
             //p.StartInfo = new ProcessStartInfo("taskmgr");
            p.StartInfo.UseShellExecute = true;
            p.Start(); 
        }      

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (true)
            //{
            //    custromerToolStripMenuItem.Visible = false;
            //    systemConfigurationToolStripMenuItem.Visible = false;
            //}
        }

        private void passportRegToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var _pfrm = new passportAppFrm { MdiParent=this};
            _pfrm.Show();
        }

        private void cFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var _rfrm = new regfrm { MdiParent=this};
            
            _rfrm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _user = new frmUser { MdiParent=this};
            _user.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AdminForms.fileUpdate _uFile = new AdminForms.fileUpdate();
           
            //_uFile.Show();
            var _uFile = new AdminForms.fileUpdate { MdiParent=this};
            _uFile.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
       
    }
}
