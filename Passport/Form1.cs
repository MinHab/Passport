using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Linq;


namespace Passport
{
    public partial class passportAppFrm : Form
    {
        public passportAppFrm()
        {
            InitializeComponent();
        }
        string strcon;
        SqlConnection con;
        DataSet dsObj;
        SqlCommand cmd;
        SqlDataAdapter daObj;
        CrystalReport1 cr;
        SqlCommand cmdObj;

        string embassyCode;
        string filterSel,filterBY;
        private void changeCntrl(bool gbx,bool edit,bool add,bool save)
        {
            gbxApplicant.Enabled = gbx;
            btnEdit.Enabled = edit;
            btnAdd.Enabled = add;
            btnSave.Enabled = save;
        }

        private void passportAppFrm_Load(object sender, EventArgs e)
        {
           //strcon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";
            //strcon = @"Data Source=MINASE\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";
             strcon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";
            txtUserName.Text = Properties.Settings.Default.UserName;            
            embassyCode="EMBASSY 708";
            cmbOPassportTyp.SelectedIndex = 0;
            //cmbHeight.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            cmbOPassportTyp.SelectedIndex = 0;
            cmbCountry.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 1;
            cbxPasStatus.SelectedIndex = 0;
            changeCntrl(false,false,false,false);
            gbxPrint.Hide();
            btnFind.Enabled = false;
            for (int i = 100; i <= 250;i++ )
              cmbHeight.Items.Add((decimal)i/100);
            
             cmbHeight.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = txtUserName.Text;
            Properties.Settings.Default.Save();

            int res = 0;
            con = new SqlConnection(strcon);
            cmd = new SqlCommand("insertInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            cmd.Parameters.Add("@NationalID", SqlDbType.Char).Value = txtNatID.Text.ToUpper();
            cmd.Parameters.Add("@FName", SqlDbType.NVarChar).Value = txtFName.Text.ToUpper();
            cmd.Parameters.Add("@MNAme", SqlDbType.NVarChar).Value = txtMName.Text.ToUpper();
            cmd.Parameters.Add("@LName", SqlDbType.NVarChar).Value = txtLName.Text.ToUpper();
            cmd.Parameters.Add("@BPlace", SqlDbType.NVarChar).Value = txtBPlace.Text.ToUpper();
            cmd.Parameters.Add("@BDate", SqlDbType.Date).Value = dtpBDate.Text;
            cmd.Parameters.Add("@Sex", SqlDbType.Char).Value = cmbSex.Text.ToUpper();
            cmd.Parameters.Add("@Height", SqlDbType.VarChar).Value = cmbHeight.Text.Trim().ToUpper();
            cmd.Parameters.Add("@UAgeFName", SqlDbType.NVarChar).Value = txtUFName.Text.ToUpper();
            cmd.Parameters.Add("@UAgeMName", SqlDbType.NVarChar).Value = txtUMName.Text.ToUpper();
            cmd.Parameters.Add("@UAgeLName", SqlDbType.NVarChar).Value = txtULName.Text.ToUpper();
            cmd.Parameters.Add("@EriPassportNo", SqlDbType.Char).Value = txtPassportNo.Text.ToUpper();
            cmd.Parameters.Add("@EriPassportType", SqlDbType.VarChar).Value = cmbOPassportTyp.Text.ToUpper();
            cmd.Parameters.Add("@OtherPassportNo", SqlDbType.VarChar).Value = txtOPassNo.Text.ToUpper();
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.SelectedItem.ToString().ToUpper();
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = cmbOPassportTyp.Text.ToUpper();
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.ToUpper();
            
            cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = txtPhone.Text;
            cmd.Parameters.Add("@FaxNo", SqlDbType.Char).Value = txtFax.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text.ToUpper();
            cmd.Parameters.Add("@User",SqlDbType.VarChar).Value= txtUserName.Text.ToUpper();
            cmd.Parameters.Add("@EEO",SqlDbType.VarChar).Value= embassyCode.ToUpper();
            //cmd.Parameters.Add("@Amount", SqlDbType.VarChar).Value = txtAmount.Text;
           

            try
            {
                con.Open();
                res = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException err) { MessageBox.Show("" + err.Message); }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                daObj = null;
                cmd = null;
                con = null;
            }
            if (res > 0)
            { MessageBox.Show("Data Saved Succesfuly"); changeCntrl(false, false, false, false); }//if res
            else { MessageBox.Show("Error occured saving data."); }
        }

        //private void btnReport_Click(object sender, EventArgs e)
        //{
            
        //    if (txtNatIDRprt.Text != "")
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        daObj = null;
        //        con = null;
        //        cr = new CrystalReport1();
        //        DataSet1 ds = new DataSet1();
        //        con = new SqlConnection(strcon);
        //        daObj = new SqlDataAdapter("selRprt",con);
        //        daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        daObj.SelectCommand.Parameters.Add("NationalID",SqlDbType.Char).Value = txtNatIDRprt.Text;
        //        try 
        //        {
        //          con.Open();
        //            daObj.Fill(ds,"DataTable1");
        //            cr.SetDataSource(ds.Tables[0]);
        //            crystalReportViewer1.ReportSource = cr;
        //            crystalReportViewer1.Refresh();
        //            con.Close();
        //        }
        //        catch(SqlException er)
        //        {
        //            MessageBox.Show(er.Message.ToString());
        //        }
        //        finally
        //        {
        //          if(con.State==ConnectionState.Open)
        //          con.Close();
        //            //cr=null;
        //        }
        //        this.Cursor = Cursors.Default;         
        //   }
        //}

        //private void btnExPdf_Click(object sender, EventArgs e)
        //{
        //    //ExportOptions exOpt;
        //    //DiskFileDestinationOptions crFileDestination = new DiskFileDestinationOptions();
        //    //PdfRtfWordFormatOptions fileFormat = new PdfRtfWordFormatOptions();
        //    //crFileDestination.DiskFileName = "C:\\passportExportC#.pdf";
        //    try
        //    {
        //        //if (File.Exists(@"D:\" + reg_number + ".pdf"))
        //        //    File.Delete(@"D:\" + reg_number + ".pdf");
        //        cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "D:\\passportExportC#.pdf");
        //        MessageBox.Show("Exported Successfuly.");
        //    }
        //    catch(Exception er)
        //    {
        //        MessageBox.Show("An Error occured exporting to PDF");
        //    }
        //    finally{cr=null;}
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtNatID.Text != "")
            {
                picbxLoading.Visible = true;

               // string sel = "Select * from Customer where NationalID="+ txtNatID.Text;
                con = new SqlConnection(strcon);
                daObj = new SqlDataAdapter("selSearch",con);
                daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
                daObj.SelectCommand.Parameters.Add("NationalID", SqlDbType.Char).Value = txtNatID.Text.Trim();
                daObj.SelectCommand.CommandTimeout = 0;
                dsObj= new DataSet();
                try
                {
                    con.Open();
                    daObj.Fill(dsObj);
                    con.Close();
                }
                catch (SqlException er) { MessageBox.Show(er.Message.ToString()); picbxLoading.Visible = false; }
                if(dsObj.Tables[0].Rows.Count >0)
                {
                    txtFName.Text = dsObj.Tables[0].Rows[0][1].ToString();
                    txtMName.Text = dsObj.Tables[0].Rows[0][2].ToString();
                    txtLName.Text = dsObj.Tables[0].Rows[0][3].ToString();
                    txtBPlace.Text = dsObj.Tables[0].Rows[0][4].ToString();
                    dtpBDate.Value = DateTime.Parse(dsObj.Tables[0].Rows[0][5].ToString());
                    cmbSex.Text = dsObj.Tables[0].Rows[0][6].ToString();
                    cmbHeight.Text = dsObj.Tables[0].Rows[0][7].ToString();
                    txtUFName.Text = dsObj.Tables[0].Rows[0][8].ToString();
                    txtUMName.Text = dsObj.Tables[0].Rows[0][9].ToString();
                    txtULName.Text = dsObj.Tables[0].Rows[0][10].ToString();
                    txtPassportNo.Text = dsObj.Tables[0].Rows[0][11].ToString();
                    
                    txtOPassNo.Text = dsObj.Tables[0].Rows[0][13].ToString();
                    cmbCountry.Text = dsObj.Tables[0].Rows[0][14].ToString();
                    cmbOPassportTyp.Text = dsObj.Tables[0].Rows[0][15].ToString();
                    txtAddress.Text = dsObj.Tables[0].Rows[0][16].ToString();
                    txtPhone.Text = dsObj.Tables[0].Rows[0][17].ToString();
                    txtFax.Text = dsObj.Tables[0].Rows[0][18].ToString();
                    txtEmail.Text = dsObj.Tables[0].Rows[0][19].ToString();
                    txtUserName.Text= dsObj.Tables[0].Rows[0][21].ToString();
                    txtDinNo.Text = dsObj.Tables[0].Rows[0][24].ToString();
                   // txtAmount.Text = dsObj.Tables[0].Rows[0][22].ToString();

                    changeCntrl(true, true, false, false);
                    picbxLoading.Visible = false;
                }
                else 
                {
                   DialogResult dlgRes= MessageBox.Show("Customer ID not registered.Do you want to register?","Register Customer",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                   if (dlgRes == DialogResult.Yes)
                   {
                       changeCntrl(false, false, true, false);
                       btnAdd.Select(); btnAdd.Focus();
                   }
                   else { changeCntrl(false, false, false, false); }
                   picbxLoading.Visible = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           // string change = "UPDATE Customer SET FName= @FName,MName= @MName, LName=@LName,BPlace= @BPlace,BDate= @BDate,Sex= @Sex, Height=@Height, UAgeFName=@UAgeFName,UAgeMName= @UAgeMName, UAgeLName=@UAgeLName,EriPassportNo= @EriPassportNo,OtherPassportNo= @OtherPassportNo,Country= @Country,Type= @Type,Address=@Address,PhoneNo= @PhoneNo, FaxNo=@FaxNo, emailAdd=@email,UserName=@User,Status=@Status,StatusDate=@StatusDate  WHERE NationalID = " + txtNatID.Text.Trim();
            Properties.Settings.Default.UserName = txtUserName.Text;
            Properties.Settings.Default.Save();
            con = new SqlConnection(strcon);
            cmdObj = new SqlCommand("UpdateCustomer", con);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.CommandTimeout = 0;
            cmdObj.Parameters.Add("@NationalID", SqlDbType.Char).Value = txtNatID.Text.Trim();
            cmdObj.Parameters.Add("@FName", SqlDbType.NVarChar).Value = txtFName.Text.ToUpper();
            cmdObj.Parameters.Add("@MName", SqlDbType.NVarChar).Value = txtMName.Text.ToUpper();
            cmdObj.Parameters.Add("@LName", SqlDbType.NVarChar).Value = txtLName.Text.ToUpper();
            cmdObj.Parameters.Add("@BPlace", SqlDbType.NVarChar).Value = txtBPlace.Text.ToUpper();
            cmdObj.Parameters.Add("@BDate", SqlDbType.Date).Value = dtpBDate.Value;
            cmdObj.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = cmbSex.SelectedItem;
            cmdObj.Parameters.Add("@Height", SqlDbType.VarChar).Value = cmbHeight.SelectedItem;
            cmdObj.Parameters.Add("@UAgeFName", SqlDbType.NVarChar).Value = txtUFName.Text.ToUpper();
            cmdObj.Parameters.Add("@UAgeMName", SqlDbType.NVarChar).Value = txtUMName.Text.ToUpper();
            cmdObj.Parameters.Add("@UAgeLName", SqlDbType.NVarChar).Value = txtULName.Text.ToUpper();
            cmdObj.Parameters.Add("@EriPassportNo", SqlDbType.Char).Value = txtPassportNo.Text;
            cmdObj.Parameters.Add("@OtherPassportNo", SqlDbType.VarChar).Value = txtOPassNo.Text;
            cmdObj.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.SelectedItem;
            cmdObj.Parameters.Add("@Type", SqlDbType.VarChar).Value = cmbOPassportTyp.SelectedItem;
            cmdObj.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.ToUpper();
            cmdObj.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = txtPhone.Text;
            cmdObj.Parameters.Add("@FaxNo", SqlDbType.Char).Value = txtFax.Text;
            cmdObj.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
            cmdObj.Parameters.Add("@User",SqlDbType.VarChar).Value=txtUserName.Text.ToUpper();
            cmdObj.Parameters.Add("@Status", SqlDbType.VarChar).Value = cbxStatus.SelectedItem;
            cmdObj.Parameters.Add("@DINNo", SqlDbType.VarChar).Value = txtDinNo.Text;
           // cmdObj.Parameters.Add("@EEO", SqlDbType.VarChar).Value = DateTime.Now;

            try
            {
                con.Open();
                cmdObj.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data modified succesfully.");
                changeCntrl(false, false, false, false);
            }
            catch (SqlException ex) { MessageBox.Show("Error occured modifying data."); }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                 cmdObj = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
               foreach (TextBox tb in this.gbxApplicant.Controls.OfType<TextBox>())
                {
                    tb.Clear();
                    tb.Text.ToUpper();
                }
               changeCntrl(true,false,false,true);
               txtPhone.Text = "00";
               txtFName.Select(); txtFName.Focus();
               txtUserName.Text = "ELSA GHEBREHIWOT";
               txtAddress.Text = "KAMPALA, UGANDA";
               txtFax.Text = "+";
               txtPhone.Text = "+";
               txtDinNo.Text = "0";
              
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            if (txtNatIDRprt.Text != "")
            {
                //this.Cursor = Cursors.WaitCursor;
                picBxLoadCR.Visible = true;

                daObj = null;
                con = null;
                cr = new CrystalReport1();
                DataSet1 ds = new DataSet1();
                con = new SqlConnection(strcon);
                daObj = new SqlDataAdapter("selRprt", con);
                daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
                daObj.SelectCommand.Parameters.Add("NationalID", SqlDbType.Char).Value = txtNatIDRprt.Text;
                try
                {
                    con.Open();
                    daObj.Fill(ds, "DataTable1");
                    cr.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();
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
                //this.Cursor = Cursors.Default;
                picBxLoadCR.Visible = false;
            }
            else { MessageBox.Show("Please enter National ID to report."); }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized )
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            //activate the window
            this.Activate();
            this.Focus();
        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (txtNatIDRprt.Text != "")
            {
                //this.Cursor = Cursors.WaitCursor;
                picBxLoadCR.Visible = true;

                daObj = null;
                con = null;
                cr = new CrystalReport1();
                DataSet1 ds = new DataSet1();
                con = new SqlConnection(strcon);
                daObj = new SqlDataAdapter("selRprt", con);
                daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
                daObj.SelectCommand.CommandTimeout = 0;
                daObj.SelectCommand.Parameters.Add("NationalID", SqlDbType.Char).Value = txtNatIDRprt.Text;
                daObj.SelectCommand.Parameters.Add("UnderAge",SqlDbType.Bit).Value = (bool)(cbxRprt.Checked);
                try
                {
                    con.Open();
                    daObj.Fill(ds, "DataTable1");
                    cr.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();
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
                //this.Cursor = Cursors.Default;
                picBxLoadCR.Visible = false;
            }
            else { MessageBox.Show("Please enter National ID to report."); }
        }

        private void btnShowPrint_Click(object sender, EventArgs e)
        {

            if (gbxPrint.Visible == true)
                gbxPrint.Hide();
            else { gbxPrint.Show(); }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            daObj = null;
            con = null;
            dsObj = null;
           // dgvFilter.DataSource = null;
            dsObj = new DataSet();
            con = new SqlConnection(strcon);
            daObj = new SqlDataAdapter("filter", con);
            daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
            daObj.SelectCommand.CommandTimeout = 0;
            daObj.SelectCommand.Parameters.Add("Date", SqlDbType.Date).Value = DateTime.Parse( dtpFilterByAge.Value.ToShortDateString());
            daObj.SelectCommand.Parameters.Add("Status", SqlDbType.VarChar).Value = cbxPasStatus.SelectedItem.ToString();
           
            try
            {
                con.Open();
                daObj.Fill(dsObj);
                dgvFilter.DataSource = dsObj.Tables[0];
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
            // change dgvSelectPgm column header text 
            //dgvFilter.Columns["NationalID"].HeaderText = "National ID";
           
            ////dgvFilter.Columns["programID"].Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindNatID.Text == "")
            {
                MessageBox.Show("Please fill the field with a Correct value.");
                return;
            }
            daObj = null;
            con = null;          
            DataSet  dsOb = new DataSet();
            con = new SqlConnection(strcon);
            daObj = new SqlDataAdapter(filterSel, con);
            //daObj.SelectCommand.CommandType = CommandType.StoredProcedure;
            daObj.SelectCommand.CommandTimeout = 0;
            daObj.SelectCommand.Parameters.Add("@NationalID", SqlDbType.Char).Value = txtFindNatID.Text.Trim().ToUpper();
            
            try
            {
                con.Open();
                daObj.Fill(dsOb);
                dgvFilter.DataSource = dsOb.Tables[0];
                btnFind.Enabled = false;
                con.Close();
                
                //if (dsOb.Tables[0].Rows.Count == 0)
                //{ MessageBox.Show(filterBY + " " + "not available. Please try again.", "Customer Search");}
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
               
            }
                  
        }

        private void rbtnDinNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDinNo.Checked)
            {
                btnFind.Text = "Find DIN No";
                filterSel = "SELECT NationalID,DinNO,FName, MName, LName , BPlace, BDate, Sex, Height, EriPassportNo,Address, PhoneNo, FaxNo, emailAdd,UserName,Status,StatusDate FROM  Customer WHERE DinNO =@NationalID";
                txtFindNatID.Focus();
                btnFind.Enabled = true;
             }
        }

        private void rbtnNationalID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNationalID.Checked)
            {
                btnFind.Text = "Find ID";
                filterSel = "SELECT NationalID,DinNO,FName, MName, LName , BPlace, BDate, Sex, Height, EriPassportNo,Address, PhoneNo, FaxNo, emailAdd,UserName,Status,StatusDate FROM  Customer WHERE NationalID =@NationalID";
                txtFindNatID.Focus();
                btnFind.Enabled = true;
                
            }
        }

        private void rbtnFName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFName.Checked)
            {
                btnFind.Text = "Find Name";
                filterSel = "SELECT NationalID,DinNO,FName, MName, LName , BPlace, BDate, Sex, Height, EriPassportNo,Address, PhoneNo, FaxNo, emailAdd,UserName,Status,StatusDate FROM  Customer WHERE FName =@NationalID";
                txtFindNatID.Focus();
                btnFind.Enabled = true;
                
            }
        }

                 
                        
    }
}
