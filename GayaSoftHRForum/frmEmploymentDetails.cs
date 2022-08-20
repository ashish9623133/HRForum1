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
    public partial class frmEmploymentDetails : Form
    {

        string Flag, Full_Name, Email_ID, Gender, Contact_No, Address, Experience, Photo, Resume, Marksheet_10th, Marksheet_12th, Diploma_Marksheet, Graduation_Marksheet, Post_Graduation_Marksheet, Pan_Card, Aadhar, Cheque;

        private void cmbbxJobStream_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbxJobStream.Refresh();
            ClsCandidateRegistration objShowJobStream = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objShowJobStream.FetchJobStream();

            cmbbxJobStream.ValueMember = "Job_Stream_ID";
            cmbbxJobStream.DisplayMember = "Job_Stream_Name";
            cmbbxJobStream.DataSource = dt;
            cmbbxJobStream.Update();
        }

        private void txtRelevantExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdatePI_Click(object sender, EventArgs e)
        {
            frmPreferrence objP=new frmPreferrence(Flag,Candidate_ID);
            objP.Show();

            int JobStreamID = Convert.ToInt32(cmbbxJobStream.SelectedValue.ToString());
            ClsCandidateRegistration objUpdateEmpDetails=new ClsCandidateRegistration(Candidate_ID,txtLastOrganization.Text, txtCurrentEmployeeStatus.Text, txtCurrentCTC.Text, txtExpectedCtc.Text, txtCurrency.Text, txtNoticePeriod.Text, txtRelevantExperience.Text, txtPosition.Text, JobStreamID);
            objUpdateEmpDetails.UpdateEmpDetailsInfo();
            this.Hide();
        }

        int Qualification_ID, Specialization_ID, City_ID,Candidate_ID, Job_Stream_ID;
        DateTime DOB;
        public frmEmploymentDetails()
        {
            InitializeComponent();
        }
        public frmEmploymentDetails(string flag1,int cid)
        {
            InitializeComponent();
            Candidate_ID= cid;
            Flag = flag1;
        }
        public frmEmploymentDetails(string flag,string FullName, string EmailID, string gender, string ContactNo, DateTime dateTimeDob, int city, string address, int qualification, int specialization, string experience, string resume, string photo, string SSCMarksheet, string HSCMarksheet, string DiplomaMarksheet, string GraduationMarksheet, string PGMarksheet, string PanCard, string AadharCard, string cheque)
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
            Resume = resume;
            Photo = photo;
            Marksheet_10th = SSCMarksheet;
            Marksheet_12th = HSCMarksheet;
            Diploma_Marksheet = DiplomaMarksheet;
            Graduation_Marksheet = GraduationMarksheet;
            Post_Graduation_Marksheet = PGMarksheet;
            Pan_Card=PanCard;
            Aadhar=AadharCard;
            Cheque=cheque;
        }
       
        private void frmEmploymentDetails_Load(object sender, EventArgs e)
        {

            if (Flag == "PI")
            {
                btnUpdatePI.Hide();

            }

            if (Flag == "EditPI")
            {
                btnSaveEmployeeDetails.Text = "Cancel";

            }
            else
            {
                btnSaveEmployeeDetails.Text = "Next";
            }
            ClsCandidateRegistration objShowJobStream = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objShowJobStream.FetchJobStream();

            cmbbxJobStream.ValueMember = "Job_Stream_ID";
            cmbbxJobStream.DisplayMember = "Job_Stream_Name";
            cmbbxJobStream.DataSource = dt;

            ClsCandidateRegistration objED =new ClsCandidateRegistration(Candidate_ID);
            SqlDataReader dr;
            dr = objED.UpdatePI();
            if (dr.Read())
            { 
                txtCurrency.Text=dr["Currency"].ToString();
                txtCurrentCTC.Text= dr["Current_CTC"].ToString();
                txtCurrentEmployeeStatus.Text= dr["Current_Employee_Status"].ToString();
                txtExpectedCtc.Text= dr["Expected_CTC"].ToString();
                txtLastOrganization.Text= dr["Last_Organization"].ToString();
                txtNoticePeriod.Text= dr["Notice_Period"].ToString();
                txtPosition.Text= dr["Position"].ToString();
                txtRelevantExperience.Text= dr["Relevant_Experience"].ToString();
                cmbbxJobStream.Text = dr["Job_Stream_ID"].ToString();

                Job_Stream_ID = Convert.ToInt32(dr["Job_Stream_ID"]);
                ClsCandidateRegistration objGetJS = new ClsCandidateRegistration(Job_Stream_ID);
                SqlDataReader dr1;
                dr1 = objGetJS.GetJobStreamData();
                while (dr1.Read())
                {
                    cmbbxJobStream.Text = dr1["Job_Stream_Name"].ToString();

                }

            }
        }

        private void lblWillingToRelocate_Click(object sender, EventArgs e)
        {

        }

        private void txtWillingToRelocate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblAddJobStream_Click(object sender, EventArgs e)
        {
         frmAddJobStream objJobStream = new frmAddJobStream();
            objJobStream.Show();
            
        }

        private void btnSaveEmployeeDetails_Click(object sender, EventArgs e)
        {
            if (btnSaveEmployeeDetails.Text == "Cancel")
            {
                this.Close();
                FrmCandidateList obj = new FrmCandidateList();
                obj.Show();
            }
            if (btnSaveEmployeeDetails.Text == "Next")
            {
                if (cmbbxJobStream.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Type");
                    cmbbxJobStream.Focus();
                    return;
                }
                if (Experience == "Fresher")
                {
                    txtLastOrganization.Text = "NA";
                    txtCurrentEmployeeStatus.Text = "Unemployee";
                    txtCurrentCTC.Text = "NA";
                    txtNoticePeriod.Text = "NA";
                    txtRelevantExperience.Text = "NA";
                    txtPosition.Text = "NA";
                    cmbbxJobStream.Text = "NA";

                }
                if (txtLastOrganization.Text == "")   //Name Validation
                {
                    //  Name was incorrect  
                    MessageBox.Show("Please Provide Last Organization");
                    txtLastOrganization.Focus();
                    return;
                }
                if (txtExpectedCtc.Text == "")
                {
                    MessageBox.Show("Please Enter Expected CTC...!!!");
                    txtExpectedCtc.Focus();
                    return;
                }
                int JobStreamID = Convert.ToInt32(cmbbxJobStream.SelectedValue.ToString());
                frmPreferrence objPreferrance = new frmPreferrence(Flag,Full_Name, Email_ID, Gender, Contact_No, DOB, City_ID, Address, Qualification_ID, Specialization_ID, Experience, Resume, Photo, Marksheet_10th, Marksheet_12th, Diploma_Marksheet, Graduation_Marksheet, Post_Graduation_Marksheet, Pan_Card, Aadhar, Cheque, txtLastOrganization.Text, txtCurrentEmployeeStatus.Text, txtCurrentCTC.Text, txtExpectedCtc.Text, txtCurrency.Text, txtNoticePeriod.Text, txtRelevantExperience.Text, txtPosition.Text, JobStreamID);
                objPreferrance.Show();
                this.Hide();
            }
        }
    }
}

