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


namespace GayaSoftHRForum
{
    public partial class Comment : Form
    {
        int StatusId, CandidateId,JobId;
        string AddComment;
        public Comment()
        {
            InitializeComponent();
        }

        //To add comment in Tbl_Candidate_Registration.

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtComment.Text))
            {
                txtComment.Focus();
                erpComment.SetError(txtComment, "Please Enter Comment");
                MessageBox.Show("Please Enter Comment....!");
                erpComment.Clear();
            }
            else
            {
                AddComment = txtComment.Text;
                ClsCandidateRegistration objaddComment = new ClsCandidateRegistration(CandidateId, AddComment);
                objaddComment.AddComment();
                this.Close();
                

                //To update Status of Candidate in Tbl_Candidate_Assign
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                //To update Status of Candidate in Tbl_Interview_Schedule
                objupdate.UpdateStatusInterviewSchedule();
            }


        }

        private void Comment_Load(object sender, EventArgs e)
        {

        }

        public Comment(int statusid,int candidateid,int jobId)
        {
            InitializeComponent();
            StatusId=statusid;
            CandidateId=candidateid;
            JobId = jobId;
            
        }
    }
}
