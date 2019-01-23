using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Passport.DataClasses;
using System.Data.SqlClient;
using Passport.DataClasses;

namespace Passport.AdminForms
{
    public partial class fileUpdate : Form
    {
        public fileUpdate()
        {
            InitializeComponent();
        }
        string regID;
        private void adjustCustCntrls(bool gbx, bool del)
        {
            gbxFile.Enabled = gbx;
            btnDelete.Enabled = del;
        }
        private void fileUpdate_Load(object sender, EventArgs e)
        {
            cbxFStatus.SelectedIndex = 0;
            adjustCustCntrls(false, false);
            conOpen.getConnected();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conOpen.ConnectionString))
            {

                var _tbBinded = (from c in db.CustomerFiles
                                  
                                 where c.FileStatus == cbxFStatus.SelectedItem.ToString()
                                 select c).ToList();
                if (_tbBinded.Count<0)
                { MessageBox.Show("File not found.Please try again."); dgvFam.DataSource = null;  }
                else { dgvFam.DataSource = null; dgvFam.DataSource = _tbBinded; hidedgv(); }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string del = "Delete * from Kin where RegID=" + txtNatID.Text.Trim();
            //SqlConnection con = new SqlConnection(conOpen.ConnectionString);
            //SqlCommand cmd = new SqlCommand(del, con);
            //try
            //{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Deleted ...");
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("" + ex.Message);
            //}

                #region db
            using (EmbassyDataDataContext db = new EmbassyDataDataContext(conOpen.ConnectionString))
            {
                var _tbDelet = (from c in db.GetTable<CustomerFile>() where c.RegID == txtNatID.Text.Trim() select c).Single<CustomerFile>();   
             try
                {
                    db.GetTable<CustomerFile>().DeleteOnSubmit(_tbDelet);
                    db.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                    MessageBox.Show("Data Deleted successfully.");

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
                #endregion
            


        }

        private void dgvFam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            regID = dgvFam.CurrentRow.Cells[0].Value.ToString();
            txtFileNo.Text = dgvFam.CurrentRow.Cells[22].Value.ToString(); ;
            txtNatID.Text = dgvFam.CurrentRow.Cells[0].Value.ToString();
            btnDelete.Enabled = true;
        }
        private void hidedgv()
        {
            for (int i = 0; i < dgvFam.ColumnCount;i++ )
            {
                dgvFam.Columns[i].Visible = false;
            }
            dgvFam.Columns[0].Visible = true;
            dgvFam.Columns[1].Visible = true;
            dgvFam.Columns[2].Visible = true;
            dgvFam.Columns[3].Visible = true;
            dgvFam.Columns[22].Visible = true;
        }
    }
}
