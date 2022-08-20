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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace GayaSoftHRForum
{

    public partial class frmEducationInformation : Form
    {
        public int Qualification_ID, Candidate_ID, Specialization_ID, City_ID;
        string Flag, Full_Name, Email_ID, Gender, Contact_No, Address, Experience,Specialization,Qualification;
        DateTime DOB;
        
       

        private void btnUpdatePI_Click(object sender, EventArgs e)
        {
            
            frmUploadDocument objDoc=new frmUploadDocument(Flag,Candidate_ID);
            objDoc.Show();

            if (rdbbtnFresher.Checked == true)
            {
                Experience = "Fresher";
                lblTotalExperience.Hide();
                
            }
            if (rdbbtnExperienced.Checked == true)
            {
                if (cmbbxTotAlExperience.SelectedIndex == -1)//    Combobox Qualification Validation
                {
                    MessageBox.Show("Please select Experience");
                    cmbbxTotAlExperience.Focus();
                    return;
                }

                Experience = cmbbxTotAlExperience.Text;
            }
            int Qualification_ID = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
            int Specialization_ID = Convert.ToInt32(cmbbxSpecialization.SelectedValue.ToString());

            ClsCandidateRegistration objUpdateEduInfo=new ClsCandidateRegistration(Candidate_ID, Qualification_ID, Specialization_ID, Experience);
            objUpdateEduInfo.UpdateEduInfo();
            this.Hide();
        }

        //int City;
        DateTime Registration_Date;
        public frmEducationInformation()
        {
            InitializeComponent();
        }

        private void lblSpecialization_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbbxQualification_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbxQualification.Refresh();
            
            ClsCandidateRegistration objShowQualification = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt = objShowQualification.FetchQualification();

            cmbbxQualification.ValueMember = "Qualification_ID";
            cmbbxQualification.DisplayMember = "Qualification";
            cmbbxQualification.DataSource = dt;
            cmbbxQualification.Update();
        }

        private void cmbbxSpecialization_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbxSpecialization.Refresh();
            int Qualification_ID = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
            ClsCandidateRegistration objShowSpecialization = new ClsCandidateRegistration(Qualification_ID);
            DataTable dt = new DataTable();
            dt = objShowSpecialization.FetchSpecialization();

            cmbbxSpecialization.ValueMember = "Specialization_ID";
            cmbbxSpecialization.DisplayMember = "Specialization_Name";
            cmbbxSpecialization.DataSource = dt;
            cmbbxSpecialization.Update();
        }

        public frmEducationInformation(string flag,int cid)
        {
            InitializeComponent();
            Candidate_ID = cid;
            Flag = flag;
        }

        

        public frmEducationInformation(string flag1,string FullName, string EmailID, string gender, string ContactNo, DateTime dateTimeDob, int city, string address)
        {
            InitializeComponent();
            Full_Name = FullName;
            Email_ID = EmailID;
            Gender = gender;
            Contact_No = ContactNo;
            DOB = dateTimeDob;
            City_ID = city;
            Address = address;
            Flag = flag1;
        }

        private void cmbbxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbbxExperienceMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbleducation_Click(object sender, EventArgs e)
        {

        }

        private void lblAddQualification_Click(object sender, EventArgs e)
        {
            frmAddQualification objQualification = new frmAddQualification();
            objQualification.Show();
             
        }

        private void frmEducationInformation_Load(object sender, EventArgs e)
        {
            if (Flag == "PI")
            {
                btnUpdatePI.Hide();

            }

            if (Flag == "EditPI")
            {
                btnSaveEducation.Text = "Cancel";

            }
            else
            {
                btnSaveEducation.Text = "Next";
            }

            ClsCandidateRegistration objShowQualification = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt = objShowQualification.FetchQualification();

            cmbbxQualification.ValueMember = "Qualification_ID";
            cmbbxQualification.DisplayMember = "Qualification";
            cmbbxQualification.DataSource = dt;
            
            ClsCandidateRegistration objShow = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt3 = objShow.FetchExperience();

            cmbbxTotAlExperience.ValueMember = "Exp_ID";
            cmbbxTotAlExperience.DisplayMember = "Experience";
            cmbbxTotAlExperience.DataSource = dt3;
            cmbbxTotAlExperience.Text = "Select Experience";



            ClsCandidateRegistration objEI = new ClsCandidateRegistration(Candidate_ID);
            SqlDataReader dr;
            dr = objEI.UpdatePI();
            if (dr.Read())
            {
                string TotalExperience = dr["Total_Experience"].ToString();
                cmbbxTotAlExperience.Text = TotalExperience;
                if (dr["Total_Experience"].ToString() == "Fresher")
                {
                    rdbbtnFresher.Checked = true;
                    
                }
                else
                { 
                rdbbtnExperienced.Checked = true;
                   
                }
                
                Specialization =dr["Specialization_Name"].ToString();
                Qualification = dr["Qualification"].ToString();
                
                cmbbxQualification.Text = Qualification;
                cmbbxSpecialization.Text = Specialization;


            }
           
            


        }

        private void lblAddSpecialization_Click(object sender, EventArgs e)
            {
                frmAddSpecialization objAddSpecialization = new frmAddSpecialization();
                objAddSpecialization.Show();
                   
            }

            private void cmbbxQualification_SelectedIndexChanged(object sender, EventArgs e)
            {

                

            
                int Qualification_ID = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
                ClsCandidateRegistration objShowSpecialization = new ClsCandidateRegistration(Qualification_ID);
                DataTable dt = new DataTable();
                dt = objShowSpecialization.FetchSpecialization();

                cmbbxSpecialization.ValueMember = "Specialization_ID";
                cmbbxSpecialization.DisplayMember = "Specialization_Name";
                cmbbxSpecialization.DataSource = dt;
           


            }

        private void btnSaveEducation_Click(object sender, EventArgs e)
        {
            if (btnSaveEducation.Text == "Cancel")
            {
                this.Close();
                FrmCandidateList obj = new FrmCandidateList();
                obj.Show();
            }
            if (btnSaveEducation.Text == "Next")
            {
                if (cmbbxQualification.SelectedIndex == -1)//    Combobox Qualification Validation
                {
                    MessageBox.Show("Please select Qualification");
                    cmbbxQualification.Focus();
                    return;
                }
                if (cmbbxSpecialization.SelectedIndex == -1)//    Combobox Qualification Validation
                {
                    MessageBox.Show("Please select Specialization");
                    cmbbxSpecialization.Focus();
                    return;
                }
                if (!(this.rdbbtnExperienced.Checked || this.rdbbtnFresher.Checked)) // Gender Validation

                {
                    MessageBox.Show("Please Select Experiencce");

                    return;

                }

               
                if (rdbbtnExperienced.Checked == true)
                {
                    if (cmbbxTotAlExperience.SelectedIndex == -1)//    Combobox Qualification Validation
                    {
                        MessageBox.Show("Please select Experience");
                        cmbbxTotAlExperience.Focus();
                        return;
                    }

                    Experience = cmbbxTotAlExperience.Text;
                }


                if (rdbbtnFresher.Checked == true)
                {
                    Experience = "Fresher";
                    lblTotalExperience.Hide();
                    cmbbxTotAlExperience.Hide();
                }
                int Qualification_ID = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
                int Specialization_ID = Convert.ToInt32(cmbbxSpecialization.SelectedValue.ToString());
                frmUploadDocument objEmploymentDetails = new frmUploadDocument(Flag,Full_Name, Email_ID, Gender, Contact_No, DOB, City_ID, Address, Qualification_ID, Specialization_ID, Experience);
                objEmploymentDetails.Show();
                this.Hide();

            }

        }
    }
}
    

