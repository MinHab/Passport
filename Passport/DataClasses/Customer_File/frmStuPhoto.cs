using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Passport.Generic_Class;


namespace Passport
{
    //using EMIS.DAL.Generic_Classes;
    //using EMIS.BLL;
    public partial class frmStuPhoto : Form
    {
        public frmStuPhoto()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=MINASE\SQLEXPRESS;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True";
        string path;
        bool IsMyTextChanged = false;       
        string fileName;
        
        private void frmStuPhoto_Load(object sender, EventArgs e)
        {
            picBxPhoto.Image = Passport.Properties.Resources.nophoto;
            btnFlipImg.BackgroundImage = Passport.Properties.Resources.index;
            lblStuImgChk.Text = " ";
            lblPhotoReg.Text = " ";
            gbxPhoto.Enabled = false;
            this.Size = new Size(287, 336);
            lblImgSize.Text = "";
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            this.Size = new Size(287, 336);
            btnResize.Enabled = true;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files(jpg/jpeg/png/gif)|*.jpg;*.jpeg;*.png;*.gif";
                dlg.Title = "Embassy Eritrea Management System";
                
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.FileName;
                    fileName = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);
                    if (!validatePhoto(dlg))
                    {
                        picBxPhoto.Image = Passport.Properties.Resources.nophoto;
                    }
                }
            }
        }
        #region validate photo functions
        private bool validatePhoto(OpenFileDialog dlg)
        {
            bool validPhoto = false;
            long maxsize = 512000;
            long photoSize;
            string fExtension;
            
            FileInfo fInfo = new FileInfo(dlg.FileName);
            photoSize = fInfo.Length;
            fExtension = fInfo.Extension.ToLower();
            
                if (photoSize < maxsize)
                {
                    if (fExtension == ".jpg" || fExtension == ".jpeg")
                    {
                        picBxPhoto.Image = null;
                        picBxPhoto.Image = Image.FromFile(dlg.FileName);
                        picBxResize.Image = Image.FromFile(dlg.FileName);
                        lblStuImgChk.Text = " ";
                        btnAddPhoto.Enabled = true;
                        btngoResize.Enabled = true;
                        validPhoto = true;                        
                    }
                    else
                    {
                        lblStuImgChk.Text = "Image extension must be jpeg.";
                    }
                }
                else
                {
                    lblStuImgChk.Text = "Image size is larger than 512 KB ";
                    btngoResize.Enabled = true;
                    picBxResize.Image= Image.FromFile(dlg.FileName);
                }            
            return validPhoto;
        }      
        #endregion

        private void btnBrowseRegId_Click(object sender, EventArgs e)
        {
            using (EmbassyDataDataContext imgdb = new EmbassyDataDataContext(conStr))
            {
               List<Generic_Class. CustomerFile> _img = imgdb.CustomerFiles.Where(p=>p.RegID == txtRegId.Text).ToList();

               if (_img.Count > 0)
               {
                   byte[] pic = _img.SingleOrDefault().Photo.ToArray();
                   MemoryStream ms = new MemoryStream(pic);
                   gbxPhoto.Enabled = true;                  
                   picBxPhoto.Image = null;
                   picBxPhoto.Image = Image.FromStream(ms);
                  // picBxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                   lblPhotoReg.Text = txtRegId.Text;
                   btnAddPhoto.Enabled = false;
                   btngoResize.Enabled = false;
               }
               else 
               { MessageBox.Show("National Id not available.");                   
                   gbxPhoto.Enabled = false; 
                   lblPhotoReg.Text = ""; 
                   btnAddPhoto.Enabled = false;
                   btngoResize.Enabled = false;
                   picBxPhoto.Image = Passport.Properties.Resources.nophoto;
               }
            }
        }

        private void txtRegId_Validating(object sender, CancelEventArgs e)
        {
            //if(txtRegId.Text.Trim()==" ")
            //{ return; }

            //if (txtRegId.Text.Length == 11)
            //{
            //    txtRegId.Text = txtRegId.Text.ToUpper();
            //    if (EMISGlobal.CheckRegIDPrefix(txtRegId.Text.Substring(0, 3)) && EMISGlobal.IsNumeric(txtRegId.Text.Substring(3)))
            //    {
            //        e.Cancel = false;
            //        btnBrowseRegId.Enabled = true;                   
            //    }
            //}
            //else { MessageBox.Show("Invalid Reg Id.", EMIS.GlobalClasses.EMISModule.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btnBrowseRegId.Enabled = false;
            //    gbxPhoto.Enabled = false;
            //    picBxPhoto.Image = EMIS.Properties.Resources.nophoto1;
            //    lblPhotoReg.Text = " ";
            //}
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            using(EmbassyDataDataContext sphoto = new EmbassyDataDataContext(conStr))
            {
                try
                {
                    //FileStream fs = new FileStream(@fileName, FileMode.Open, FileAccess.Read);
                    //byte[] pic = new byte [fs.Length];
                    //fs.Read(pic,0,Convert.ToInt32(fs.Length));                   

                    Generic_Class.CustomerFile _adphoto = sphoto.CustomerFiles.Single(u=>u.RegID==txtRegId.Text);
                    _adphoto.Photo = File.ReadAllBytes(path);                                 

                    sphoto.SubmitChanges();
                    //RegBL x = new RegBL();
                    bool done = true;
                    if (done)
                    {
                        MessageBox.Show("you have saved data successfuly.");
                    }
                    else { MessageBox.Show("There is some problem with saving data."); }
                }
                catch (Exception ex) { MessageBox.Show("There is some problem with saving data."); }
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {                         
            FileInfo finf = new FileInfo(path);
            if(finf.Exists)
            saveCompressedImg();        
        }
       
        private  void saveCompressedImg()
        {
            FileStream fs = null;
            MemoryStream ms = null ;
            //load the image
            Image img = Image.FromFile(path);
            long quality =(long) numericUD.Value; //qulity level compression
            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // Jpeg image codec 
            ImageCodecInfo jpegCodec = getEncoderInfo("image/jpeg");
            if (jpegCodec == null)
            {
                MessageBox.Show("image format not supported");
                return;
            }
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            try
            {
                ms = new MemoryStream();
                //save image to memory stream
                img.Save(ms, jpegCodec, encoderParams);
                fs = new FileStream(@"C:\Users\Public\Pictures\Sample Pictures\" + fileName + 0 + ".jpeg", FileMode.Create, FileAccess.ReadWrite);
                
                byte[] mstoarr = ms.ToArray();
                //save the image file with FileStream
                fs.Write(mstoarr, 0, mstoarr.Length);
                //
                double siz = (mstoarr.Length)/1000;
                double imgsize = Math.Round(siz,3,MidpointRounding.AwayFromZero);
                lblImgSize.Text = imgsize + "KB";
                if (mstoarr.Length > 512000)
                {
                    MessageBox.Show("Image size is larger than 512 KB . please reduce quality.");
                    btngoResize.Enabled = true;
                }
                else if (((mstoarr.Length <= 512000) && (mstoarr.Length > 300000)))
                {                  
                    picBxPhoto.Image = (Image)img.Clone();
                   // btnResize.Enabled = false;
                    lblStuImgChk.Text = " ";
                    btngoResize.Enabled = false;
                    btnAddPhoto.Enabled = true;
                    lblImgSize.Text = "";
                }
                else { MessageBox.Show("image should be between 512 KB and 300 KB"); }
                //MemoryStream ms = new MemoryStream();
                //picBxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); 
                //byte[]
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured in compressing the picture ");
                btnAddPhoto.Enabled = false;
            }
            finally 
            {
                ms.Close();
                fs.Close();
            }
        }
        private static ImageCodecInfo getEncoderInfo(string mimType)
        {
            //get img codec 4 all img formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            //find the correct img codec
            for (int i = 0; i < codecs.Length; i++)
            
                if (codecs[i].MimeType == mimType)
                
                    return codecs[i];                
            
            return null;
        }
       
        private void btngoResize_Click(object sender, EventArgs e)
        {
            if (this.Width == 287)
            {
                lblImgSize.Text = "";               
                this.Size = new Size(518, 336);               
            }
        }       
       
        private void txtRegId_TextChanged(object sender, EventArgs e)
        {
            if (IsMyTextChanged)
                return; // Recursive!  We can bail quickly.  

            IsMyTextChanged = true; // Prevent recursion when we change it.
            int selectionStart = txtRegId.SelectionStart;
            int selectionLength = txtRegId.SelectionLength;
            string originalText = txtRegId.Text;
            string newText = originalText.ToUpper();
            if (newText != originalText)
            {
                txtRegId.Text = newText; // Will cause a new TextChanged event.
                // Set the selection back *after* the assignment, which has reset them.
                txtRegId.SelectionStart = selectionStart;
                txtRegId.SelectionLength = selectionLength;
            }
            IsMyTextChanged = false; // Allow it for next time.
        }

        private void btnFlipImg_Click(object sender, EventArgs e)
        {
            if(picBxPhoto.Image != null)
            {
              Image img = picBxPhoto.Image;
              img.RotateFlip(RotateFlipType.Rotate90FlipNone);
              picBxPhoto.Image = img;
            }
        }
    }
}
