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
    public partial class Candidate_Pipeline : Form
    {
        int Job_ID, Status_ID, Staff_ID;
        string Title;
        public Candidate_Pipeline()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        public Candidate_Pipeline(int job_id, int staff_id)
        {
            InitializeComponent();
            Job_ID = job_id;
            Staff_ID=staff_id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assignedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assigned_Candidate obj = new Assigned_Candidate(Job_ID, Staff_ID);
            obj.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Candidate_Pipeline_Load(object sender, EventArgs e)
        {
            ClsJob objShowJobDetailsforCandidatePipeline = new ClsJob(Job_ID);
            SqlDataReader dr;
            dr = objShowJobDetailsforCandidatePipeline.ShowJobDetailsforCandidatePipeline();
            if (dr.Read())
            {
                lblJobTitleName.Text=dr["Job_Title"].ToString();
                lblJobStatusName.Text= dr["Status"].ToString();
                lblCompanyName.Text= dr["Company_Name"].ToString();
                lblJDDetails.Text= dr["Job_Description"].ToString();
                lblAddressDetails.Text= dr["Full_Address"].ToString();
                lblCityName.Text= dr["City_Name"].ToString();
                lblOpeningsNo.Text= dr["Number_Of_Opening"].ToString();
                lblMinExpr.Text= dr["Min_Years_Experience"].ToString();
                lblMaxExpr.Text= dr["Max_Years_Experience"].ToString();
                lblMinSalary.Text= dr["Min_Salary"].ToString();
                lblMaxSalary.Text= dr["Max_Salary"].ToString();
                lblHRName.Text= dr["HR_Name"].ToString();
                lblHREmailID.Text= dr["Email"].ToString();
                lblHRPhoneNo.Text= dr["Phone_Number"].ToString();


                

            }

        }

        private void matchingCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatchingCandidate obj = new MatchingCandidate(Job_ID, Staff_ID);
            obj.Show();
           
        }

        private void interviewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if(interviewScheduleToolStripMenuItem.Text == "Interview Schedule")
            {
                Status_ID = 4;
                Title = "Interview Scheduled Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();
               
            }
            
            

        }

        private void interviewNotAttentedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (interviewNotAttentedToolStripMenuItem.Text == "Interview Not Attended")
            {
                Status_ID = 5;
                Title = "Interview Not Attended Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();
            }
            
            //Interview_Not_Attended_Candidate obj = new Interview_Not_Attended_Candidate(Job_ID);
            //obj.Show();

        }

        private void interviewdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (interviewdToolStripMenuItem.Text == "Interviewed")
            {
                Status_ID = 7;
                Title = "Interviewed Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();
            }
            
            //Interviewed_Candidate obj = new Interviewed_Candidate();
            //obj.Show();
            

        }

        private void interviewRescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(interviewRescheduleToolStripMenuItem .Text== "Interview Reschedule")
            {
                Status_ID = 6;
                Title = "Interview Rescheduled Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }
            //Interview_Rescheduled_Candidate obj = new Interview_Rescheduled_Candidate();
            //obj.Show();
           
        }

        private void rejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rejectedToolStripMenuItem.Text == "Rejected")
            {
                Status_ID = 9;
                Title = "Rejected Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }
            //RejectedCandidate obj= new RejectedCandidate();
            //obj.Show();

        }

        private void onHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onHoldToolStripMenuItem.Text == "On Hold")
            {
                Status_ID = 8;
                Title = "On Hold Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }
            //On_Hold_Candidate obj = new On_Hold_Candidate();
            //obj.Show();
            
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedToolStripMenuItem.Text == "Selected")
            {
                Status_ID = 10;
                Title = "Selected Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }
            
            //Selected_Candidates obj = new Selected_Candidates();
            //obj.Show();
            
        }

        private void offeredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (offeredToolStripMenuItem.Text == "Offered")
            {
                Status_ID = 11;
                Title = "Offered Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }
            
            //Offered_Candidate obj = new Offered_Candidate();
            //obj.Show();
            
        }

        private void placedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (placedToolStripMenuItem.Text == "Placed")
            {
                Status_ID = 13;
                Title = "Placed Candidates";
                Interview_Scheduled_Candidate obj = new Interview_Scheduled_Candidate(Job_ID, Status_ID, Title);
                obj.Show();

            }

            ////Placed_Candidate obj = new Placed_Candidate();
            ////obj.Show();

        }

        private void lblOpenings_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblJobStatusName_Click(object sender, EventArgs e)
        {

        }

        private void lblJD_Click(object sender, EventArgs e)
        {

        }
    }
}
