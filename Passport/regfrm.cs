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
using System.Transactions;
using System.IO;
using CrystalDecisions.CrystalReports;


namespace Passport
{
   
    public partial class regfrm : Form
    {
        public regfrm()
        {
            InitializeComponent();
        }
        //declare objects
        string strCon = @"Data Source=MINASE\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con;
        SqlDataAdapter daObj;
        DataSet dsObj;
        SqlCommand cmdObj;
        string path,fileName;
        int familyID;
        List<Family> _famlies = new List<Family>();
        Family _famly = new Family();
        //functions
       
        #region validate photo functions
        //private bool validatePhoto(OpenFileDialog dlg)
        //{
        //    bool validPhoto = false;
        //    long maxsize = 512000;
        //    long photoSize;
        //    string fExtension;

        //    FileInfo fInfo = new FileInfo(dlg.FileName);
        //    photoSize = fInfo.Length;
        //    fExtension = fInfo.Extension.ToLower();

        //    if (photoSize < maxsize)
        //    {
        //        if (fExtension == ".jpg" || fExtension == ".jpeg")
        //        {
        //            picBxPhoto.Image = null;
        //            picBxPhoto.Image = Image.FromFile(dlg.FileName);
        //            picBxResize.Image = Image.FromFile(dlg.FileName);
        //            lblStuImgChk.Text = " ";
        //            btnAddPhoto.Enabled = true;
        //            btngoResize.Enabled = true;
        //            validPhoto = true;
        //        }
        //        else
        //        {
        //            lblStuImgChk.Text = "Image extension must be jpeg.";
        //        }
        //    }
        //    else
        //    {
        //        lblStuImgChk.Text = "Image size is larger than 512 KB ";
        //        btngoResize.Enabled = true;
        //        picBxResize.Image = Image.FromFile(dlg.FileName);
        //    }
        //    return validPhoto;
        //}
        #endregion
        private void fillControls(Family _cf)
        {
            txtFFullName.Text = _cf.Name; txtFBPlace.Text = _cf.BPlace; dtpFBDate.Value = DateTime.Parse(_cf.BDate.ToString());
            cbxFamilySex.Text = _cf.Sex; cbxFRelationship.Text = _cf.Relationship;
        }
        private void adjustCustCntrls(bool gbx,bool add,bool save,bool edit)
        {
            gbxApplicant.Enabled = gbx;
            btnEdit.Enabled = edit;
            btnAdd.Enabled = add;
            btnSave.Enabled = save;         
        }
        private void adjustFamlyCntrls(bool gbx, bool add, bool save, bool edit)
        {

            gbxFamily.Enabled = gbx;
            btnFEdit.Enabled = edit;
            btnFAdd.Enabled = true;
            btnFSave.Enabled = save;
            
        }
        //convert systwm.drawing.Image to binary
        private byte[] imgtobyte(Image picbxImage)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picbxImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void regfrm_Load(object sender, EventArgs e)
        {
            conOpen.getConnected();

            cbxEducation.SelectedIndex = 0;            
            cbxFStatus.SelectedIndex = 1;
            cbxHomeExit.SelectedIndex = 0;
            cbxKinRship.SelectedIndex = 0;
            cbxMaritalStatus.SelectedIndex = 0;
            cbxWPermit.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            cbxFRelationship.SelectedIndex = 0;
            cbxFamilySex.SelectedIndex = 0;
            gbxFamily.Enabled = false;
            adjustCustCntrls(false, false, false, false);
            adjustFamlyCntrls(false, true, false, false);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            byte[] _photo;
            MemoryStream _ms ;
            if (txtNatID.Text == "") { MessageBox.Show("Please enter National ID."); return; }
            using (EmbassyDataDataContext db= new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                var _cf = (from c in db.CustomerFiles
                           where c.RegID == txtNatID.Text.Trim()
                           select new 
                           { 
                             FirstName=c.FName,
                             MiddleName=c.MName,
                             LastName=c.LName,
                             FileNo=c.FileNo,
                             FileStatus=c.FileStatus,
                             BPlace=c.BPlace,
                             BDate=c.BDate,
                             Sex=c.Sex,
                             Phone=c.Phone,
                             Photo=c.Photo,
                             Occupation=c.Occupation,
                             Proffession=c.Profession,
                             DateToUganda=c.DateToUganda,
                             DateFromEritrea=c.DateFromEritrea,
                             WorkPermit=c.WorkPermit,
                             HomeExit=c.ExitMeans,
                             Education=c.Education,
                             MotherName=c.MotherName,
                             Email=c.Email,
                             PassportNo=c.PassportNo,
                             Address=c.Address,
                             MaritalStatus=c.MaritalStatus,
                             KinName=c.Kin.Name,
                             KinPhone=c.Kin.Phone,
                             kinaddress=c.Kin.Address,
                             KinRelationship=c.Kin.Relationship
                           }
                    ).ToList();
                if (_cf.Count > 0)
                {
                    foreach (var c in _cf)
                    {
                        txtFName.Text = c.FirstName; txtMName.Text = c.MiddleName; txtLName.Text = c.LastName; txtBPlace.Text = c.BPlace;
                        dtpBDate.Value = DateTime.Parse(c.BDate.ToString()); cmbSex.Text = c.Sex; cbxFStatus.Text = c.FileStatus; txtFileNo.Text = c.FileNo.ToString();
                        cbxHomeExit.Text = c.HomeExit; cbxMaritalStatus.Text = c.MaritalStatus; cbxEducation.Text = c.Education; cbxWPermit.Text = c.WorkPermit;
                        dtpArrival.Value = DateTime.Parse(c.DateToUganda.ToString()); dtpDeparture.Value = DateTime.Parse(c.DateFromEritrea.ToString());
                        txtPassportNo.Text = c.PassportNo; txtAddress.Text = c.Address; txtEmail.Text = c.Email; txtMFullName.Text = c.MotherName;
                        txtOccupation.Text = c.Occupation; txtProfession.Text = c.Proffession; txtPhone1.Text = c.Phone;
                        txtRFullName.Text = c.KinName; txtKinAddress.Text = c.kinaddress; txtKinPhoneNo.Text = c.KinPhone; cbxKinRship.Text = c.KinRelationship;
                        _photo = c.Photo.ToArray();
                        _ms = new MemoryStream(_photo);
                        picBxPhoto.Image = null;
                        picBxPhoto.Image = Image.FromStream(_ms);
                        //
                        adjustCustCntrls(true,false, false, true);
                    }
                }
                else { MessageBox.Show("File not available"); adjustCustCntrls(true, true, false, false); }
            }
         }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (path == null) { MessageBox.Show("Please choose a photo."); return; }
            using (EmbassyDataDataContext db= new EmbassyDataDataContext(conOpen.ConnectionString))
            {
            DataClasses.CustomerFile _cf = new DataClasses.CustomerFile();
                _cf.RegID = txtNatID.Text;
                _cf.FName = txtFName.Text;
                _cf.MName = txtMName.Text;
                _cf.LName = txtLName.Text;
                _cf.BDate = dtpBDate.Value;
                _cf.BPlace = txtBPlace.Text;
                _cf.DateFromEritrea = dtpDeparture.Value;
                _cf.DateToUganda = dtpArrival.Value;
                _cf.Education = cbxEducation.SelectedItem.ToString();
                _cf.Sex = cmbSex.SelectedItem.ToString();
                _cf.Email = txtEmail.Text;
                _cf.ExitMeans = cbxHomeExit.SelectedItem.ToString();
                _cf.FileNo = int.Parse(txtFileNo.Text);
                _cf.FileStatus = cbxFStatus.SelectedItem.ToString();
                _cf.Address = txtAddress.Text;
                _cf.Occupation = txtOccupation.Text;
                _cf.Profession = txtProfession.Text;
                _cf.PassportNo = txtPassportNo.Text;
                _cf.Phone = txtPhone1.Text;
                _cf.Officer = rtxtOfficerSug.Text;
                _cf.WorkPermit = cbxWPermit.SelectedItem.ToString();
                _cf.MotherName = txtMFullName.Text ;
                _cf.MaritalStatus = cbxMaritalStatus.SelectedItem.ToString();                
                _cf.RegDate = DateTime.Today;
                _cf.Photo = File.ReadAllBytes(path); ;
                _cf.OprID = Program.loggedOpr;
               
                //Kin
                Kin _kn = new Kin();
                _kn.RegID = txtNatID.Text;
                _kn.Name = txtRFullName.Text ;
                _kn.Phone = txtKinPhoneNo.Text;
                _kn.Address = txtKinAddress.Text;
                _kn.Relationship = cbxKinRship.SelectedItem.ToString();

                // fill customerFile table
                try
                {
                    if (db.Connection.State == ConnectionState.Closed) { db.Connection.Open(); }
                    db.Transaction = db.Connection.BeginTransaction();
                    db.CustomerFiles.InsertOnSubmit(_cf);
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    //save data to Kin table
                    db.Kins.InsertOnSubmit(_kn);
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    //commit tran
                    db.Transaction.Commit();
                    MessageBox.Show("Data saved successfully.");
                    adjustCustCntrls(false, false, false, false);
                }
                catch(Exception ex)
                {
                    db.Transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (db.Connection.State == System.Data.ConnectionState.Open)
                        db.Connection.Close();
                }
            }
        }

        private void btnPhoto_Click_1(object sender, EventArgs e)
        {
            //frmStuPhoto _frmPhoto = new frmStuPhoto();
            //_frmPhoto.Show();
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files(jpg/jpeg/png/gif)|*.jpg;*.jpeg;*.png;*.gif";
                dlg.Title = "Eritrean Embassy Management System";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.FileName;
                    fileName = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);
                    picBxPhoto.Image = null;
                    picBxPhoto.Image = Image.FromFile(dlg.FileName);
                  
                    //if (!validatePhoto(dlg))
                    //{
                    //    picBxPhoto.Image = Passport.Properties.Resources.nophoto;
                    //}
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (txtNatID.Text == "") { MessageBox.Show("Please enter National ID."); return; }
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                System.Data.Linq.Binary binaryImg;
                var _tbEdited = (from cf in db.CustomerFiles
                                 join kn in db.Kins
                                on cf.RegID equals kn.RegID where cf.RegID == txtNatID.Text.Trim() select new { cf, kn }).Single();
                if (_tbEdited == null)
                { MessageBox.Show("National ID not found.Please try again."); return; }
                    //_tbEdited.cf.RegID = txtNatID.Text;
                    _tbEdited.cf.FName = txtFName.Text;
                    _tbEdited.cf.MName = txtMName.Text;
                    _tbEdited.cf.LName = txtLName.Text;
                    _tbEdited.cf.BDate = dtpBDate.Value;
                    _tbEdited.cf.BPlace = txtBPlace.Text;
                    _tbEdited.cf.DateFromEritrea = dtpDeparture.Value;
                    _tbEdited.cf.DateToUganda = dtpArrival.Value;
                    _tbEdited.cf.Education = cbxEducation.SelectedItem.ToString();
                    _tbEdited.cf.Sex = cmbSex.SelectedItem.ToString();
                    _tbEdited.cf.Email = txtEmail.Text;
                    _tbEdited.cf.ExitMeans = cbxHomeExit.SelectedItem.ToString();
                    _tbEdited.cf.FileNo = int.Parse(txtFileNo.Text);
                    _tbEdited.cf.FileStatus = cbxFStatus.SelectedItem.ToString();
                    _tbEdited.cf.Address = txtAddress.Text;
                    _tbEdited.cf.Occupation = txtOccupation.Text;
                    _tbEdited.cf.Profession = txtProfession.Text;
                    _tbEdited.cf.PassportNo = txtPassportNo.Text;
                    _tbEdited.cf.Phone = txtPhone1.Text;
                    _tbEdited.cf.Officer = rtxtOfficerSug.Text;
                    _tbEdited.cf.WorkPermit = cbxWPermit.SelectedItem.ToString();
                    _tbEdited.cf.MotherName = txtMFullName.Text;
                    _tbEdited.cf.MaritalStatus = cbxMaritalStatus.SelectedItem.ToString();
                    _tbEdited.cf.RegDate = DateTime.Today;
                    //convert  array binary to linq binary
                    binaryImg = new System.Data.Linq.Binary(imgtobyte(picBxPhoto.Image));
                    _tbEdited.cf.Photo = binaryImg;
                    _tbEdited.cf.OprID = Program.loggedOpr; 
                    //update kin
                   // _tbEdited.kn.RegID = txtNatID.Text;
                    _tbEdited.kn.Name = txtRFullName.Text;
                    _tbEdited.kn.Phone = txtKinPhoneNo.Text;
                    _tbEdited.kn.Address = txtKinAddress.Text;
                    _tbEdited.kn.Relationship = cbxKinRship.SelectedItem.ToString();          

               
                try
                {                   
                    
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                    MessageBox.Show("Data Updated successfully."); adjustCustCntrls(false, false, false, false);
                    
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (db.Connection.State == System.Data.ConnectionState.Open)
                        db.Connection.Close();
                }
            }
        }
        #region Family
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.gbxApplicant.Controls.OfType<TextBox>())
            {
                tb.Clear();
                tb.Text.ToUpper();
            }
            adjustCustCntrls(true, false, true, false);
            txtPhone1.Text = "00";
            txtFName.Select(); txtFName.Focus();
            txtAddress.Text = "KAMPALA, UGANDA";
            txtOccupation.Text = "___";
            txtProfession.Text = "___";
            txtPassportNo.Text = "___";
            txtRFullName.Text = "___";
            txtKinPhoneNo.Text = "___";
            picBxPhoto.Image = Properties.Resources.nophoto;
        }
        //Family form
        private void btnFSearch_Click(object sender, EventArgs e)
        {

            if (txtFamilyID.Text == "") { MessageBox.Show("Please enter National ID."); return; }
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                _famlies  = (from f in db.Families
                             where f.RegID == txtFamilyID.Text.Trim()
                           select f ).ToList();
                if (_famlies.Count>0)
                {                    
                    dgvFamily.DataSource = null;
                    dgvFamily.DataSource = _famlies;
                    hideDGVcol();
                    adjustFamlyCntrls(false, false, false, false);
                 }
                
                else 
                {
                    dgvFamily.DataSource = null;
                   DialogResult res= MessageBox.Show("Family not available. Do you want to add new.","Embassy Eri System",MessageBoxButtons.YesNo);
                   if (res.ToString() == "Yes")
                   {
                       adjustFamlyCntrls(false, true, false, false);
                   }
                   else { adjustFamlyCntrls(false, false, false, false); }
                }
            }
        }

        private void btnFSave_Click(object sender, EventArgs e)
        {
            using(EmbassyDataDataContext db= new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                Family _tbSaved = new Family();
                _tbSaved.RegID = txtFamilyID.Text.Trim();
                _tbSaved.Name = txtFFullName.Text;
                _tbSaved.BPlace = txtFBPlace.Text;
                _tbSaved.BDate = dtpFBDate.Value;
                _tbSaved.Relationship = cbxFRelationship.SelectedItem.ToString();
                _tbSaved.OprID = Program.loggedOpr;
                try
                {
                    db.Families.InsertOnSubmit(_tbSaved);
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                    MessageBox.Show("Family Data Saved.","Eri Embassy System.");
                    adjustFamlyCntrls(false, true, false, false);
                }
                catch(Exception ex)
                {
                 MessageBox.Show (ex.Message.ToString());
                }
            }
        }

        private void btnFEdit_Click(object sender, EventArgs e)
        {
            using(EmbassyDataDataContext db =new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                Family _tbEdited = new Family();
               _tbEdited = db.Families.SingleOrDefault(f => f.FamilyID == (int)dgvFamily.CurrentRow.Cells[0].Value);
               //_tbEdited = _famlies.SingleOrDefault <Family>(f => f.FamilyID == (int)dgvFamily.CurrentRow.Cells[0].Value); 

              _tbEdited.RegID = txtFamilyID.Text.Trim();
              _tbEdited.Name = txtFFullName.Text;
              _tbEdited.BPlace = txtFBPlace.Text;
              _tbEdited.BDate = dtpFBDate.Value;
              _tbEdited.Relationship = cbxFRelationship.SelectedItem.ToString();
              _tbEdited.Sex = cbxFamilySex.SelectedItem.ToString();
              _tbEdited.OprID = Program.loggedOpr;
              try
              {                 
                  db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                  MessageBox.Show("Family Data Updated.", "Eri Embassy System.");
                  adjustFamlyCntrls(false, false, false, false);
                 
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message.ToString());
              }
            }
        }

        private void dgvFamily_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _famly = _famlies.Single<Family>(f=>f.FamilyID==(int)dgvFamily.CurrentRow.Cells[0].Value);
            fillControls(_famly);
            adjustFamlyCntrls(true, false, false, true);
        }
        private void hideDGVcol()
        {
            dgvFamily.Columns[0].Visible = false;
            dgvFamily.Columns[1].Visible = false;
            dgvFamily.Columns[6].Visible = false;
            dgvFamily.Columns[8].Visible = false;
            dgvFamily.Columns[9].Visible = false;
            dgvFamily.Columns["Name"].HeaderText = "Full Name";
            dgvFamily.Columns["BDate"].HeaderText= "Birth Date";
            dgvFamily.Columns["BPlace"].HeaderText = "Birth Place";
            //dgvFamily.Columns["Relationship"].HeaderText = "Birth Date";
        }      

        private void btnFAdd_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.gbxFamily.Controls.OfType<TextBox>())
            {
                tb.Clear();
                tb.Text.ToUpper();
            }
            adjustFamlyCntrls(true, false, true, false);
           
        }
        #endregion

        private void btnRprt_Click(object sender, EventArgs e)
        {
            if ( txtNatIDRprt.Text != "")
            {
                this.Cursor = Cursors.WaitCursor;              

                daObj = null;
                con = null;
                Reports.CR cr = new Reports.CR();
                ReportData.DataSet1 dsCF = new ReportData.DataSet1();
                con = new SqlConnection(conOpen.ConnectionString);
                daObj = new SqlDataAdapter("selCF", con);
                daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
                daObj.SelectCommand.CommandTimeout = 0;
                daObj.SelectCommand.Parameters.Add("NationalID", SqlDbType.Char).Value = txtNatIDRprt.Text;               
                try
                {
                    con.Open();
                    daObj.Fill(dsCF, "dtCFile");
                    cr.SetDataSource(dsCF.Tables[0]);
                    cRV.ReportSource = cr;
                    cRV.Refresh();
                    con.Close();
                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    //cr=null;
                }
                this.Cursor = Cursors.Default;
               
            }
            else { MessageBox.Show("Please enter National ID to report."); }
        }
    }
}
