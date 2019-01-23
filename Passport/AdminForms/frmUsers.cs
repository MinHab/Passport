using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.DirectoryServices;
//using System.DirectoryServices.AccountManagement;
//using EMIS.DAL.Generic_Classes;
//using EMIS.DAL.Data_Classes;
//using EMIS.BLL;

namespace EMIS.AdminForms
{

    public partial class frmUsers : Form
    {
        //Staff _userStaff = new Staff();
        //public  List<Staff> _userStaffs = new List<Staff>();
        //Staff _notUserStaff = new Staff();
        //List<Staff> _notUserStaffs = new List<Staff>();
        //Opr _opr = new Opr();
        //public List<Opr> _oprs = new List<Opr>();
        //Code _code = new Code();
        //List<Code> _codes = new List<Code>();
        //Staff _Staff = new Staff();
        //public List<Staff> _Staffs = new List<Staff>();
       
        public frmUsers()
        {
            InitializeComponent();
        }
        private enum mode
        { 
            None=0,
            Edit=1,
            Save=2
        }
        private int status = (int)mode.None;

        private void GetADUsers()
        {
            using (var ctx = new PrincipalContext(ContextType.Domain))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(ctx)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        if (((de.Properties["givenName"].Value != null) && (de.Properties["sn"].Value != null)))
                            //MessageBox.Show( "DispN:" + de.Properties["DisplayName"].Value + "--" + "Domain Name:" + de.Properties["DistinguishedName"].Value + "--" + "First Name :" + de.Properties["givenName"].Value + "---" + "Lname :" + de.Properties["sn"].Value + "---" + "acc Name :" + de.Properties["samAccountName"].Value + "---" + "log on name ||user principal name :" + de.Properties["userPrincipalName"].Value);
                            cmbLogName.Items.Add(de.Properties["samAccountName"].Value);
                    }

                }

            } 
        }

        private void LoadStaffUsers()
        {
            _userStaff = new Staff();
            staffBL x = new staffBL();
            _userStaffs = x.GetStaffs((int)Program.userECenterID);
            if (_userStaffs.Count > 0) 
                _userStaff = _userStaffs.FirstOrDefault<Staff>();
        }
        private void LoadStaff_notUser()
        {
            _notUserStaff = new Staff();
            staffBL x = new staffBL();
           _notUserStaffs = x.GetStaff_notUser((int)Program.userECenterID);
           //_Staffs = x.GetStaff_User((int)Program.userECenterID);
           //_notUserStaffs = (_userStaffs.Except(_Staffs).ToList());
            if (_notUserStaffs.Count > 0)
                _notUserStaff = _notUserStaffs.FirstOrDefault<Staff>();
        }
        private void LoadUsers()
        {
            Users x = new Users();
            _oprs = x.GetUsers((int)Program.userECenterID);            
            if(_oprs.Count > 0)
                _opr = _oprs.FirstOrDefault<Opr>();
        }
        private void PopulateGrid()
        {
            var _user = (from u in _oprs select new 
                        {
                          UserID = u.OprId,
                          StaffID = u.StaffId,
                          LogName = u.LogName,
                          StartDate = u.StartDate,
                          EndDate = u.EndDate,
                          Active = u.Active                          
                        }
                       ).ToList();
            dgvUsers.DataSource = _user;
            if (_user.Count > 0)
            {
                _opr = _oprs.SingleOrDefault<Opr>(u => u.OprId == (int)dgvUsers.CurrentRow.Cells[0].Value);
                FillControls(_opr);
            }
        }
        private void FillControls(Opr uzr)
        {
            txtRegName.Text = uzr.Staff.Reg.FirstName + " " + uzr.Staff.Reg.MFname + " " + uzr.Staff.Reg.LastName;
            cmbLogName.Text = uzr.LogName;
            if ((bool)uzr.Active)
                chkbActive.Checked = true;
            else chkbActive.Checked = false;
        }
        private void BindStaffs(List<Staff> sf)
        {
            cmbStaffNotUser.DataSource = null;
            cmbStaffNotUser.Items.Clear();
            if (sf.Count > 0)
            {
                var staff = (from s in sf
                             select new
                                 {
                                     RegID = s.RegId,
                                     RegName = s.Reg.FirstName +" " + s.Reg.MFname +" " + s.Reg.LastName,
                                     Title = s.Title
                                 }).ToList();
                cmbStaffNotUser.DataSource = staff;
                cmbStaffNotUser.ValueMember = "RegID";
                cmbStaffNotUser.DisplayMember = "RegName";                
            }
        }
        private void LoadCodes()
        {
            CodeBL x = new CodeBL();
            _codes = x.GetCodes("Title","User");
        }
        private void HideDgvCells()
        { 
          dgvUsers.Columns[0].Visible=false;
          dgvUsers.Columns[1].Visible = false;
        }
        private void RefreshEdit()
        {
            LoadUsers();           
            PopulateGrid();
            HideDgvCells();
        }
        private void RefreshSave()
        {
            LoadUsers();
            LoadStaffUsers();
            LoadStaff_notUser();
            //PopulateGrid();
            BindStaffs(_notUserStaffs);
        }
        private void ValidateI()
        {
            if (status == (int)mode.Save)
            {
                gboPsw.Enabled = true; ckbPswReset.Checked = true;
                if (cmbStaffNotUser.Text.Trim() == "")
                    throw new Exception("Select the Staff name please.");
                if (cmbLogName.Text.Trim() == "")
                    throw new Exception("select the User logname please.");
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
        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
           // LoadCodes();
            LoadUsers();
            //GetADUsers();
            LoadStaffUsers();
            LoadStaff_notUser();
            PopulateGrid();
            BindStaffs(_notUserStaffs);
            HideDgvCells();
            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the operation?", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
              // BindStaffs(_notUserStaffs);
               ClearControls();
            }
        }
        private void ClearControls()
        {
            txtRegID.Clear();
            txtTitle.Clear();
            txtPassword.Clear();
            txtConfirmPsw.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //BindStaffs(_notUserStaffs);            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            status = (int)mode.Save;
            try
            {
               ValidateI();              
               if (chkLogName())
               {
                MessageBox.Show("user logon name already exists.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               }           
               
                bool done = false;
                Users x = new Users();
                Opr tbSaved = new Opr();
                _userStaff = _userStaffs.SingleOrDefault<Staff>(s => s.RegId == cmbStaffNotUser.SelectedValue.ToString());
                tbSaved.StaffId = _userStaff.StaffId;
                tbSaved.StartDate = DateTime.Today;
                tbSaved.LogName = cmbLogName.Text;
                tbSaved.Active = chkbActive.Checked;
                tbSaved.Password = x.GetPassByte(txtPassword.Text.Trim());
                done = x.SaveUser(tbSaved);
                if (done)
                {
                    MessageBox.Show("You have saved data successfuly.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSave();
                }
                else 
                {
                    MessageBox.Show("There is some error saving your data.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private bool chkLogName()
        {
            
            Users x = new Users();      
            Opr logName = x.GetUser_byName(cmbLogName.SelectedItem.ToString());           
            if (logName!=null)                
                return true;
            else return false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            status = (int)mode.Edit;
            try
            {
                ValidateI();
                bool _changePSW = false;
                bool done = false;

                Opr tbSaved = new Opr();
                Users x = new Users();

                tbSaved = _oprs.SingleOrDefault<Opr>(u => u.OprId == (int)dgvUsers.CurrentRow.Cells[0].Value);                
                tbSaved.StartDate = DateTime.Today;
                tbSaved.LogName = cmbLogName.Text;
                tbSaved.Active = chkbActive.Checked;

                if(!((bool)tbSaved.Active))
                  tbSaved.EndDate = DateTime.Today;

                if (gboPsw.Enabled)
                {
                    tbSaved.Password = x.GetPassByte(txtPassword.Text.Trim());
                    MessageBox.Show(tbSaved.Password.ToString());
                    _changePSW = true;
                }
                done = x.UpdateUser(tbSaved,_changePSW);
                if (done)
                {
                    MessageBox.Show("You have saved data successfuly.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshEdit();
                }
                else 
                {
                    MessageBox.Show("There is some error saving your data.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindStaffs(_notUserStaffs);
            if (_oprs.Count > 0)
            {
                _opr = _oprs.SingleOrDefault<Opr>(u => u.OprId == (int)dgvUsers.CurrentRow.Cells[0].Value);
                FillControls(_opr);
            }
        }          

        private void cmbStaffNotUser_SelectedIndexChanged(object sender, EventArgs e)
        {           
            _notUserStaff = _notUserStaffs.SingleOrDefault<Staff>(s => s.RegId == cmbStaffNotUser.SelectedValue.ToString());            
            if (_notUserStaff == null )
                return;
           // _code = _codes.SingleOrDefault<Code>(c => c.CodeId == (int)_notUserStaff.Title);
            txtRegID.Text = _notUserStaff.RegId;
            txtTitle.Text = _notUserStaff.Code.CodeName;
            //txtTitle.Text = _code.CodeName;
            //txtTitle.Text = x.GetCodeNames((int)_notUserStaff.Title);
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
