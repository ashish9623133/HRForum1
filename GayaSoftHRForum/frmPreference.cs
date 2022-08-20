using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;
using System.Text.RegularExpressions;

namespace GayaSoftHRForum
{
    public partial class frmPreferrence : Form
    {
        string Flag, Full_Name, Email_ID, Gender, Contact_No, Address, Experience, Photo, Resume, Marksheet_10th, Marksheet_12th, Diploma_Marksheet, Graduation_Marksheet, Post_Graduation_Marksheet, Pan_Card, Aadhar, Cheque,Last_Organization,Current_Employee_Status,Current_CTC,Expected_CTC,Currency,Notice_Period,Relevant_Experience,Position;

        private void cmbbxPLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblWillingToRelocate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeCandidateRegistraionDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRating_TextChanged(object sender, EventArgs e)
        {
            ClsCandidateRegistration objFetchStaff = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objFetchStaff.FetchRegisterStaff();

            cmbbxRegisterStaff.ValueMember = "Staff_Register_ID";
            cmbbxRegisterStaff.DisplayMember = "Full_Name";
            cmbbxRegisterStaff.DataSource = dt;
        }

        private void cmbbxRegisterStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateAndSubmit_Click(object sender, EventArgs e)
        {
            int staff_id = Convert.ToInt32(cmbbxRegisterStaff.SelectedValue.ToString());
            DateTime RegistrationDate = Convert.ToDateTime(dateTimeCandidateRegistraionDate.Text);
            ClsCandidateRegistration objUpdatePre=new ClsCandidateRegistration(Candidate_ID,staff_id, cmbbxWillingToRelocate.Text, cmbbxPLocation.SelectedItem.ToString(), txtSkills.Text, cmbbxWorkPreferType.Text, cmbbxReadyToWorkInShift.Text, cmbbxReadyForFieldWork.Text, txtFacebook.Text, txtLinkedin.Text, txtGitHub.Text, txtComment.Text, RegistrationDate, Convert.ToInt32(txtRating.Text));
            objUpdatePre.UpdatePrefInfo();
            MessageBox.Show("Candidate Data Updated Successfully...!!! ");
            FrmCandidateList objlist = new FrmCandidateList();
            objlist.Show();
            this.Hide();
        }

        private void lblUploadDocument_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuestionAnswer_Click(object sender, EventArgs e)
        {
            frmQueAns objQueAns=new frmQueAns();
            objQueAns.Show();
        }

        int Qualification_ID, Specialization_ID, City_ID, Job_Stream_ID,Candidate_ID, Staff_Register_ID;
        DateTime DOB;
        private void lblComment_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public frmPreferrence()
        {
            InitializeComponent();
        }
        public frmPreferrence(string flag,int cid)
        {
            InitializeComponent();
            Candidate_ID = cid;
            Flag = flag;
        }
        public frmPreferrence(string flag1, string FullName, string EmailID, string gender, string ContactNo, DateTime dateTimeDob, int city, string address, int qualification, int specialization, string experience, string resume, string photo, string SSCMarksheet, string HSCMarksheet, string DiplomaMarksheet, string GraduationMarksheet, string PGMarksheet, string PanCard, string AadharCard, string cheque, string LastOrganization, string CurrentEmployeeStatus, string CurrentCTC, string ExpectedCtc, string currency, string NoticePeriod, string RelevantExperience, string position, int JobStreamID)
        {
            InitializeComponent();
            Flag = flag1;
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
            Resume = resume;
            Photo = photo;
            Marksheet_10th = SSCMarksheet;
            Marksheet_12th = HSCMarksheet;
            Diploma_Marksheet = DiplomaMarksheet;
            Graduation_Marksheet = GraduationMarksheet;
            Post_Graduation_Marksheet = PGMarksheet;
            Pan_Card = PanCard;
            Aadhar = AadharCard;
            Cheque = cheque;
            Last_Organization = LastOrganization;
            Current_Employee_Status = CurrentEmployeeStatus;
            Current_CTC = CurrentCTC;
            Expected_CTC = ExpectedCtc;
            Currency = currency;
            Notice_Period = NoticePeriod;
            Relevant_Experience = RelevantExperience;
            Position = position;
            Job_Stream_ID = JobStreamID;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxJobStream_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPreferrence_Load(object sender, EventArgs e)
        {

            if (Flag == "PI")
            {
                btnUpdateAndSubmit.Hide();

            }

            if (Flag == "EditPI")
            {
                btnSaveCandidateDetail.Text = "Cancel";

            }
            else
            {
                btnSaveCandidateDetail.Text = "Next";
            }

            ClsCandidateRegistration objShowCity = new ClsCandidateRegistration();
            DataTable dt1 = new DataTable();
            dt1 = objShowCity.FetchPCity();

            cmbbxPLocation.ValueMember = "City_ID";
            cmbbxPLocation.DisplayMember = "City_Name";
            cmbbxPLocation.DataSource = dt1;

            cmbbxPLocation.Text = "Select City";

            ClsCandidateRegistration objP=new ClsCandidateRegistration(Candidate_ID);
            SqlDataReader dr;
            dr = objP.UpdatePI();
            if (dr.Read())
            { 
            txtComment.Text=dr["Comment"].ToString();
                txtFacebook.Text= dr["Facebook_Profile_URL"].ToString();
                txtGitHub.Text= dr["Github_Profile_URL"].ToString();
                txtLinkedin.Text= dr["LinkedIn_Profile_URL"].ToString();  
                txtRating.Text= dr["Rating"].ToString();
                txtSkills.Text= dr["Skills"].ToString();
                cmbbxReadyForFieldWork.Text =dr["Ready_For_Field_Work"].ToString() ;
                cmbbxReadyToWorkInShift.Text = dr["Ready_To_Work_In_Shifts"].ToString();
                cmbbxRegisterStaff.Text = dr["Staff_Register_ID"].ToString();
                cmbbxWillingToRelocate.Text = dr["Willing_To_Relocate"].ToString();
                cmbbxWorkPreferType.Text= dr["Work_Prefer_Type"].ToString();
                cmbbxPLocation.Text = dr["Preferred_Location"].ToString();
                dateTimeCandidateRegistraionDate.Text = dr["Registration_Date"].ToString();

                Staff_Register_ID = Convert.ToInt32(dr["Staff_Register_ID"]);
                ClsCandidateRegistration objGetStaff = new ClsCandidateRegistration(Staff_Register_ID);
                SqlDataReader dr1;
                dr1 = objGetStaff.GetStaffData();
                while (dr1.Read())
                {
                    cmbbxRegisterStaff.Text = dr1["Full_Name"].ToString();
                    
                }
            }

                
        }

        private void btnSaveCandidateDetail_Click(object sender, EventArgs e)
        {

            if (btnSaveCandidateDetail.Text == "Cancel")
            {
                this.Close();
                FrmCandidateList obj = new FrmCandidateList();
                obj.Show();
            }
            if (btnSaveCandidateDetail.Text == "Next")
            {
                if (cmbbxWillingToRelocate.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Relocate ");
                    cmbbxWillingToRelocate.Focus();
                    return;
                }

                if (cmbbxWorkPreferType.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Work Type ");
                    cmbbxWorkPreferType.Focus();
                    return;
                }

                if (cmbbxReadyForFieldWork.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Ready For Field Work ");
                    cmbbxReadyForFieldWork.Focus();
                    return;
                }


                if (cmbbxReadyToWorkInShift.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Ready For Field Shift ");
                    cmbbxReadyToWorkInShift.Focus();
                    return;
                }
                if (!Regex.Match(txtRating.Text, @"^[1-5]").Success)   //Name Validation
                {
                    //  Name was incorrect  
                    MessageBox.Show("Rating Must be between 1 to 5", "Message");
                    txtRating.Focus();
                    return;
                } // end if

                if (cmbbxRegisterStaff.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Registration Staff Name ");
                    cmbbxRegisterStaff.Focus();
                    return;
                }
                if (txtFacebook.Text == "")
                {
                    MessageBox.Show("Please Fill Facebook Url");
                    txtFacebook.Focus();
                    return;

                }
                if (txtLinkedin.Text == "")
                {
                    MessageBox.Show("Please Fill Linkdin Url");
                    txtLinkedin.Focus();
                    return;

                }
                if (txtGitHub.Text == "")
                {
                    MessageBox.Show("Please Fill GitHub Url");
                    txtGitHub.Focus();
                    return;
                }
                if (txtComment.Text == "")
                {
                    MessageBox.Show("Please give Any Comment..!!");
                    txtComment.Focus();
                    return;
                }
                if (cmbbxWillingToRelocate.Text == "Yes")
                {
                    cmbbxPLocation.Text = "NA";
                }
                if (!Regex.Match(txtFacebook.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Facebook Profile Validation
                {

                    MessageBox.Show("Please Enter valid Facebook URL");
                    txtFacebook.Focus();
                    return;
                }

                if (!Regex.Match(txtLinkedin.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // LinkedIn Profile Validation
                {

                    MessageBox.Show("Please Enter valid LinkedIn URL");
                    txtLinkedin.Focus();
                    return;
                }

                if (!Regex.Match(txtGitHub.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Twitter Profile Validation
                {

                    MessageBox.Show("Please Enter valid Twitter URL");
                    txtGitHub.Focus();
                    return;
                }
                if (DateTime.Today < dateTimeCandidateRegistraionDate.Value)
                {
                    MessageBox.Show("Please Select Valid Date...!!!");
                    dateTimeCandidateRegistraionDate.Value = DateTime.Today;
                    return;

                }
                // string Stat = Convert.ToInt32(cmbbxStatus.Selected.ToString());

                int staff_id = Convert.ToInt32(cmbbxRegisterStaff.SelectedValue.ToString());
                DateTime RegistrationDate = Convert.ToDateTime(dateTimeCandidateRegistraionDate.Text);

                ClsCandidateRegistration objRegisterCandidate = new ClsCandidateRegistration(staff_id, Full_Name, Email_ID, Gender, Contact_No, DOB, City_ID, Address, Qualification_ID, Specialization_ID, Experience, Resume, Photo, Marksheet_10th, Marksheet_12th, Diploma_Marksheet, Graduation_Marksheet, Post_Graduation_Marksheet, Pan_Card, Aadhar, Cheque, Last_Organization, Current_Employee_Status, Current_CTC, Expected_CTC, Currency, Notice_Period, Relevant_Experience, Position, Job_Stream_ID, cmbbxWillingToRelocate.SelectedItem.ToString(), cmbbxPLocation.Text, txtSkills.Text, cmbbxWorkPreferType.SelectedItem.ToString(), cmbbxReadyToWorkInShift.SelectedItem.ToString(), cmbbxReadyForFieldWork.SelectedItem.ToString(), txtFacebook.Text, txtLinkedin.Text, txtGitHub.Text, txtComment.Text, RegistrationDate, Convert.ToInt32(txtRating.Text));
                objRegisterCandidate.SaveCandidateInfo();

                MessageBox.Show("Candidate Registered Done...!");
                this.Hide();
                FrmCandidateList objlist = new FrmCandidateList();
                objlist.Show();
            }
        }
    }
}
