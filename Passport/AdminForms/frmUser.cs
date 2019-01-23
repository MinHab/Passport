using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Passport.DataClasses;


namespace Passport
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=MINASE\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";    
        Opr _opr = new Opr();
        public List<Opr> _oprs = new List<Opr>();
        
        private enum mode
        {
            None = 0,
            Edit = 1,
            Save = 2
        }
        private int status = (int)mode.None;
       
        private void LoadUsers()
        {
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conStr))
            {

                try
                {
                     _oprs = db.Oprs.ToList();
                    if (_oprs.Count > 0)
                        _opr = _oprs.FirstOrDefault<Opr>();
                }
           
            catch(Exception ex){MessageBox.Show(ex.Message);}
            }
        }
        private void PopulateGrid()
        {
            var _user = (from u in _oprs
                         select new
                         {
                             UserID = u.OprID,                            
                             FullName = u.FullName,
                             StartDate = u.StartDate,
                             EndDate = u.EndDate,
                             Active = u.Active
                         }
                       ).ToList();
            dgvUsers.DataSource = _user;
            //MessageBox.Show(""+_user.Count);
            if (_user.Count > 0)
            {
                _opr = _oprs.SingleOrDefault<Opr>(u => u.OprID == dgvUsers.CurrentRow.Cells[0].Value.ToString());
                FillControls(_opr);
            }
        }
        private void FillControls(Opr uzr)
        {
            txtRegID.Text = uzr.OprID;
            txtFullName.Text = uzr.FullName;
            if ((bool)uzr.Active)
                chkbActive.Checked = true;
            else chkbActive.Checked = false;
        }
              
       
        
       
        private void HideDgvCells()
        {
            //dgvUsers.Columns[0].Visible = false;
            //dgvUsers.Columns[1].Visible = false;
        }
        private void RefreshEdit()
        {
            LoadUsers();
            PopulateGrid();
            //HideDgvCells();
        }
        private void RefreshSave()
        {
            LoadUsers();
            //LoadStaffUsers();
            //LoadStaff_notUser();
            PopulateGrid();
            //BindStaffs(_notUserStaffs);
        }
        private void ValidateI()
        {
            if (status == (int)mode.Save)
            {
                //gboPsw.Enabled = true; ckbPswReset.Checked = true;
                //if (cmbStaffNotUser.Text.Trim() == "")
                //    throw new Exception("Select the Staff name please.");
                if (txtRegID.Text.Trim() == "")
                    throw new Exception("Enter the User logname please.");
            }
            if (((status == (int)mode.Save) || (status == (int)mode.Edit)))
            {
                if (gboPsw.Enabled)
                {
                    if (txtPassword.Text.Trim() == "")
                        throw new Exception("Enter password please.");
                    if (txtConfirmPsw.Text.Trim() == "")
                        throw new Exception("Enter the password again please.");
                    if (txtPassword.Text.Trim() != "" && txtConfirmPsw.Text.Trim() != "")
                        if (!(txtPassword.Text.Trim().ToString().Equals(txtConfirmPsw.Text.Trim().ToString())))
                            throw new Exception("The passwords are different. Please enter again.");
                }
            }
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
           // GetADUsers();
            
            //LoadStaffUsers();
            //LoadStaff_notUser();
            PopulateGrid();
            //BindStaffs(_notUserStaffs);
            HideDgvCells();
            btnEdit.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
                ValidateI();
                if (chkLogName())
                {
                    MessageBox.Show("user logon name already exists.");
                    return;
                }

                bool done = false;
                Opr tbSaved = new Opr();
                tbSaved.OprID = txtRegID.Text;
                tbSaved.StartDate = DateTime.Today;
                tbSaved.FullName = txtFullName.Text;
                tbSaved.Active = chkbActive.Checked;
                tbSaved.Password = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text); 
               // tbSaved.Password = txtPassword.Text.Trim();
               using (EmbassyDataDataContext db = new EmbassyDataDataContext(conStr))
               {
                try
                {
                    if (db.Connection.State == System.Data.ConnectionState.Closed)
                    { db.Connection.Open(); }
                    db.Oprs.InsertOnSubmit(tbSaved);
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    MessageBox.Show("You have saved data successfuly.");
                    RefreshSave();
                }
               catch(Exception ex)
                {
                    MessageBox.Show("There is some error saving your data.");
                }
               
               }

        }
        private bool chkLogName()
        {           
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conStr))
            {
              List<Opr> _users = (from o in db.Oprs where o.OprID==txtRegID.Text select o).ToList();
                if (_users.Count > 0)
                    return true;
                else return false;  
            }
                    

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmbassyDataDataContext db = new EmbassyDataDataContext(conStr);

            status = (int)mode.Edit;
            try
            {
                ValidateI();
                bool _changePSW = false;
                bool done = false;

                Opr tbSaved = new Opr();
               // DataClasses.UserDB x = new DataClasses.UserDB();

                tbSaved = _oprs.SingleOrDefault<Opr>(u => u.OprID == dgvUsers.CurrentRow.Cells[0].Value.ToString());
                //tbSaved.StartDate = DateTime.Today;
                tbSaved.FullName = txtFullName.Text;
                tbSaved.Active = chkbActive.Checked;

                if (!((bool)tbSaved.Active))                
                    tbSaved.EndDate = DateTime.Today;                
                

                if (gboPsw.Enabled)
                {
                    //tbSaved.Password = x.GetPassByte(txtPassword.Text.Trim());
                    tbSaved.Password = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
                    _changePSW = true;
                }
                //done = x.UpdateUser(tbSaved, _changePSW);
                db.SubmitChanges();
                
                    MessageBox.Show("You have saved data successfuly.");
                    btnEdit.Enabled = false;
                    RefreshEdit();
                
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is some error saving your data.");
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_oprs.Count > 0)
            {
                btnEdit.Enabled = true;
                _opr = _oprs.SingleOrDefault<Opr>(u => u.OprID == dgvUsers.CurrentRow.Cells[0].Value);
                FillControls(_opr);
            }
        }

       
        private void ckbPswReset_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPswReset.Checked)
                gboPsw.Enabled = true;
            else
                gboPsw.Enabled = false;
        }
    }
}
