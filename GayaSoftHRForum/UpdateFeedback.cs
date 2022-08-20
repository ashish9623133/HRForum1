using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using GayaSoftHRForumLibrary.Admin;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class UpdateFeedback : Form
    {
        int StatusId, JobId, CandidateId;
        string Feedback;
        public UpdateFeedback()
        {
            InitializeComponent();
        }

        public UpdateFeedback(int statusid , int candidateid)
        {
            InitializeComponent();
            StatusId = statusid;
            CandidateId = candidateid;
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtFeedback.Text))
            {
                txtFeedback.Focus();
                erpFeedback.SetError(txtFeedback, "Please Enter Feedback");
                MessageBox.Show("Please Enter Feedback....!");
                erpFeedback.Clear();
            }
            else
            {
                Feedback = txtFeedback.Text;
                ClsInterviewSchedule objUpdateFeedback = new ClsInterviewSchedule(CandidateId, Feedback,JobId);
                objUpdateFeedback.UpdateFeedback();
                MessageBox.Show("Feedback Updated Successfully...");
                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId, JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();

            }

        }

        public UpdateFeedback(int statusid,int candidateid,int job_id)
        {
            InitializeComponent();
            StatusId = statusid;
            CandidateId = candidateid;
            JobId=job_id;
        }

        private void UpdateFeedback_Load(object sender, EventArgs e)
        {


        }
    }
}
