using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;
using System.Data.SqlClient;


namespace GayaSoftHRForum
{
    

    public partial class frmUploadDocument : Form
    {
        string Full_Name, Email_ID, Gender, Contact_No, Address, Experience,en,Flag;
        int Qualification_ID, Specialization_ID, City_ID,Candidate_ID;
        DateTime DOB, Registration_Date;
       

        //For location of documents
        string ResumeLocation = "";
        string PhotoLocation = "";
        string SSCMarkLocation = "";
        string HSCMarkLocation = "";
        string DiplomaMarkLocation = "";
        string GraduationMarkLocation = "";
        string PostGraduationMarkLocation = "";
        string PanLocation = "";
        string AadharLocation = "";
        string ChequeLocation = "";

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public string ErrorMessage { get; set; }
        public decimal filesize { get; set; }
        private void btn12thMarksheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog objHSCMark = new OpenFileDialog();
            objHSCMark.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objHSCMark.ShowDialog() == DialogResult.OK)
            {
                HSCMarkLocation = objHSCMark.FileName.ToString();
                lbl12MarkLink.Text = HSCMarkLocation;
            }
            
        
        }
         
        private void btnDiplomaMarksheet_Click(object sender, EventArgs e)
        {

            OpenFileDialog objDiplomaMark = new OpenFileDialog();
            objDiplomaMark.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objDiplomaMark.ShowDialog() == DialogResult.OK)
            {
                DiplomaMarkLocation = objDiplomaMark.FileName.ToString();
                lblDiplomaMarklink.Text = DiplomaMarkLocation;
            }
            
        }

        private void btnGraduationMarksheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog objGraduationMark = new OpenFileDialog();
            objGraduationMark.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objGraduationMark.ShowDialog() == DialogResult.OK)
            {
                GraduationMarkLocation = objGraduationMark.FileName.ToString();
                lblGraduationLink.Text = GraduationMarkLocation;
            }
            
        }

        private void btnPostGraduationMarksheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog objPGMark = new OpenFileDialog();
            objPGMark.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objPGMark.ShowDialog() == DialogResult.OK)
            {
                PostGraduationMarkLocation = objPGMark.FileName.ToString();
                lblPGMarkLink.Text = PostGraduationMarkLocation;
            }
           
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            OpenFileDialog objPan = new OpenFileDialog();
            objPan.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objPan.ShowDialog() == DialogResult.OK)
            {
                PanLocation = objPan.FileName.ToString();
                lblPanLink.Text = PanLocation;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog objCheque = new OpenFileDialog();
            objCheque.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objCheque.ShowDialog() == DialogResult.OK)
            {
                ChequeLocation = objCheque.FileName.ToString();
                lblChequeLink.Text = ChequeLocation;
            }
            
        }

        private void lbl12thMarksheet_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {

            if (btnSaveDocument.Text == "Cancel")
            {
                this.Close();
                FrmCandidateList obj = new FrmCandidateList();
                obj.Show();
            }
            if (btnSaveDocument.Text == "Next")
            {
                string fileextension = System.IO.Path.GetExtension(lblAadharLink.Text);
                if (fileextension.ToLower() != ".pdf" && fileextension.ToLower() != ".doc")
                {
                    lblAadharLink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension1 = System.IO.Path.GetExtension(lblChequeLink.Text);
                if (fileextension1.ToLower() != ".pdf" && fileextension1.ToLower() != ".doc")
                {
                    lblChequeLink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension2 = System.IO.Path.GetExtension(lblPanLink.Text);
                if (fileextension2.ToLower() != ".pdf" && fileextension2.ToLower() != ".doc")
                {
                    lblPanLink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension3 = System.IO.Path.GetExtension(lbl10Marklink.Text);
                if (fileextension3.ToLower() != ".pdf" && fileextension3.ToLower() != ".doc")
                {
                    lbl10Marklink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension4 = System.IO.Path.GetExtension(lblResumelink.Text);
                if (fileextension4.ToLower() != ".pdf" && fileextension4.ToLower() != ".doc")
                {
                    lblResumelink.Text = "Allows only .pdf and .doc";
                    return;
                }
                if (PhotoLocation == "PNG" || PhotoLocation == "png" || PhotoLocation == "jpg" || PhotoLocation == "JPG" || PhotoLocation == "JPEG" || PhotoLocation == "jpeg")
                {
                    MessageBox.Show("Upload only .png,.jpg,.jpeg extension files...!!!");
                    return;
                }
                string fileextension5 = System.IO.Path.GetExtension(lblPGMarkLink.Text);
                if (fileextension5.ToLower() != ".pdf" && fileextension5.ToLower() != ".doc")
                {
                    lblPGMarkLink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension6 = System.IO.Path.GetExtension(lblGraduationLink.Text);
                if (fileextension6.ToLower() != ".pdf" && fileextension6.ToLower() != ".doc")
                {
                    lblGraduationLink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension7 = System.IO.Path.GetExtension(lblDiplomaMarklink.Text);
                if (fileextension7.ToLower() != ".pdf" && fileextension7.ToLower() != ".doc")
                {
                    lblDiplomaMarklink.Text = "Allows only .pdf and .doc";
                    return;
                }
                string fileextension8 = System.IO.Path.GetExtension(lbl12MarkLink.Text);
                if (fileextension8.ToLower() != ".pdf" && fileextension8.ToLower() != ".doc")
                {
                    lbl12MarkLink.Text = "Allows only .pdf and .doc and only Choose below 2 MB File Size";
                    return;
                }


                frmEmploymentDetails objEmploymee = new frmEmploymentDetails(Flag,Full_Name, Email_ID, Gender, Contact_No, DOB, City_ID, Address, Qualification_ID, Specialization_ID, Experience, lblResumelink.Text, picbxphoto.ImageLocation, lbl10Marklink.Text, lbl12MarkLink.Text, lblDiplomaMarklink.Text, lblGraduationLink.Text, lblPGMarkLink.Text, lblPanLink.Text, lblAadharLink.Text, lblChequeLink.Text);
                objEmploymee.Show();
                this.Hide();
            }

        }

        private void btnUpdatePI_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objUpdateUpDoc = new ClsCandidateRegistration(Candidate_ID, lblResumelink.Text, lblPhotoLink.Text, lbl10Marklink.Text, lbl12MarkLink.Text, lblDiplomaMarklink.Text, lblGraduationLink.Text, lblPGMarkLink.Text, lblPanLink.Text, lblAadharLink.Text, lblChequeLink.Text);
            objUpdateUpDoc.UpdateUpDocInfo();
            frmEmploymentDetails objED=new frmEmploymentDetails(Flag,Candidate_ID);
            objED.Show();
            this.Hide();


        }

        private void btn10thMarksheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog objSSCMark = new OpenFileDialog();
            objSSCMark.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objSSCMark.ShowDialog() == DialogResult.OK)
            {
                SSCMarkLocation = objSSCMark.FileName.ToString();
                lbl10Marklink.Text = SSCMarkLocation;
            }
            

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog objResume = new OpenFileDialog();
            objResume.Filter = "pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objResume.ShowDialog() == DialogResult.OK)
            {
                ResumeLocation = objResume.FileName.ToString();
                lblResumelink.Text = ResumeLocation;
            }
           

        }

        
        
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog objPhoto = new OpenFileDialog();
            objPhoto.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg";
            if (objPhoto.ShowDialog() == DialogResult.OK)
            {
                PhotoLocation = objPhoto.FileName.ToString();
                picbxphoto.ImageLocation = PhotoLocation;
                lblPhotoLink.Text = PhotoLocation;
            }
            

        

        }

        private void btnAadhar_Click(object sender, EventArgs e)
        {
            OpenFileDialog objAadhar = new OpenFileDialog();
            objAadhar.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf|All files(*.*)|*.*";
            if (objAadhar.ShowDialog() == DialogResult.OK)
            {
                AadharLocation = objAadhar.FileName.ToString();
                lblAadharLink.Text = AadharLocation;
            }
            
        }          
        public frmUploadDocument()
        {
            InitializeComponent();
        }
        public frmUploadDocument(string flag1,int cid)
        {
            InitializeComponent();
            Candidate_ID = cid;
            Flag = flag1;
        }
        
        public frmUploadDocument(string flag,string FullName, string EmailID, string gender, string ContactNo, DateTime dateTimeDob, int city, string address,int qualification,int specialization,string experience)
        {
            InitializeComponent();
            Flag = flag;
            Full_Name = FullName;
            Email_ID = EmailID;
            Gender = gender;
            Contact_No = ContactNo;
            DOB = dateTimeDob;
            City_ID = city;
            Address = address;
            Qualification_ID = qualification;
            Specialization_ID = specialization;
            Experience = experience;

        }

        private void frmUploadDocument_Load(object sender, EventArgs e)
        {
            if (Flag == "PI")
            {
                btnUpdatePI.Hide();

            }

            if (Flag == "EditPI")
            {
                btnSaveDocument.Text = "Cancel";

            }
            else
            {
                btnSaveDocument.Text = "Next";
            }
            ClsCandidateRegistration objUD=new ClsCandidateRegistration(Candidate_ID);
            SqlDataReader dr;
            dr = objUD.UpdatePI();
            if (dr.Read())
            {
                lbl12MarkLink.Text = dr["Marksheet_12th"].ToString();
                lbl10Marklink.Text = dr["Marksheet_10th"].ToString();
                lblResumelink.Text = dr["Resume"].ToString();
                
                lblDiplomaMarklink.Text =  dr["Diploma_Marksheet"].ToString(); 
                lblGraduationLink.Text =  dr["Graduation_Marksheet"].ToString();
                lblPGMarkLink.Text =  dr["Post_Graduation_Marksheet"].ToString();
                lblPanLink.Text =  dr["PAN_Card"].ToString();
                lblAadharLink.Text =  dr["Aadhar"].ToString();
                lblChequeLink.Text =  dr["Cheque"].ToString();
                lblPhotoLink.Text = dr["Photo"].ToString();
                en = dr["Photo"].ToString();
                picbxphoto.Image = Image.FromFile(en);
            }


        }
    }
}
