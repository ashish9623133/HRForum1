using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class Schedule_Candidate_Interview : Form
    {
        int Candidate_ID, Job_ID, Candidate_Assign_ID, Staff_Register_ID, Status_ID;
        public string CandidateName, Company_Name, JobTitle, Interview_Mode, StartTime, EndTime, Address,Interviwer_Name, Note;

        private void dtpInterviewDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpInterviewDate.Value)
            {
                MessageBox.Show("You are not allowed to select older day than today!");
                dtpInterviewDate.Value = DateTime.Today;

            }

        }

        DateTime Interview_Date;

        private void btnScheduleInterview_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtInterviewMode.Text))
            {
                txtInterviewMode.Focus();
                erpInterviewMode.SetError(txtInterviewMode, "Please Enter InterviewMode ");
                MessageBox.Show("Please Enter InterviewMode....!");
                erpInterviewMode.Clear();
            }
            else if (string.IsNullOrEmpty(txtStartTime.Text))
            {
                txtStartTime.Focus();
                erpStartTime.SetError(txtStartTime, "Please Enter Start Time");
                MessageBox.Show("Please Enter Start Time....!");
                erpInterviewMode.Clear();
            }
            else if (string.IsNullOrEmpty(txtEndTime.Text))
            {
                txtEndTime.Focus();
                erpEndTime.SetError(txtEndTime, "Please Enter End Time");
                MessageBox.Show("Please Enter End Time....!");
                erpEndTime.Clear();
            }
            else if (string.IsNullOrEmpty(txtNotes.Text))
            {
                txtNotes.Focus();
                erpNotes.SetError(txtNotes, "Please Enter Note");
                MessageBox.Show("Please Enter Note ....!");
                erpNotes.Clear();
            }
            else
            {

                Interview_Mode = txtInterviewMode.Text;
                StartTime = txtStartTime.Text;
                EndTime = txtEndTime.Text;
                Address = txtAddress.Text;
                Interview_Date = Convert.ToDateTime(dtpInterviewDate.Text);
                Interviwer_Name = txtInterviewerName.Text;
                Note = txtNotes.Text;
                Interview_Assign_Date = DateTime.Now;

                ClsInterviewSchedule objschedule = new ClsInterviewSchedule(Candidate_ID, Job_ID, Interview_Mode,
                Interview_Date, StartTime, EndTime, Address, Interviwer_Name, Note, Staff_Register_ID, Status_ID, Interview_Assign_Date, Candidate_Assign_ID);
                objschedule.SaveInterviewScheduled();
                objschedule.UpdateCandidateStatus();
                MessageBox.Show("Interview Scheduled Successfully...!!!");

                
                // FrmJobList obj = new FrmJobList(Staff_Register_ID);
                this.Close();
                Jobs obj = new Jobs();
                obj.Show();
            }
        }

        DateTime Interview_Assign_Date;
        public Schedule_Candidate_Interview()
        {
            InitializeComponent();
        }

        public Schedule_Candidate_Interview(int candidate_id, int job_id, int staff_id)
        {
            InitializeComponent();
            Candidate_ID = candidate_id;
            Job_ID = job_id;
            Staff_Register_ID = staff_id;

        }

        public Schedule_Candidate_Interview(int candidate_id, int job_id, int staff_id, int statusid)
        {
            InitializeComponent();
            Candidate_ID = candidate_id;
            Job_ID = job_id;
            Staff_Register_ID = staff_id;
            Status_ID = statusid;

        }
        private void Schedule_Candidate_Interview_Load(object sender, EventArgs e)
        {
            
            ClsCandidateAssign objLoadInterviewScheduleData = new ClsCandidateAssign(Job_ID, Candidate_ID);
            SqlDataReader dr;
            dr = objLoadInterviewScheduleData.LoadDataOnInterviewSchedule();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCandidateName.Text = dr["Full_Name"].ToString();
                    txtCompanyName.Text = dr["Company_Name"].ToString();
                    txtJobTitle.Text = dr["Job_Title"].ToString();
                    txtAddress.Text = dr["Full_Address"].ToString();
                    txtInterviewerName.Text = dr["HR_Name"].ToString();
                    Candidate_Assign_ID = Convert.ToInt32(dr["Candidate_Assign_ID"].ToString());
                    //Interview_Assign_Date = Convert.ToDateTime(dr["Assign_Date"].ToString());
                }
            }
             
           

        }
    }
}
