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
    public partial class Interview_Scheduled_Candidate : Form
    {
        public int Job_ID, Status_ID;
        public string Title;
        public Interview_Scheduled_Candidate()
        {
            InitializeComponent();
        }
        public Interview_Scheduled_Candidate(int job_id, int status_id, string title)
        {
            InitializeComponent();
            Job_ID=job_id;
            Status_ID=status_id;
            Title=title;

        }

        private void Interview_Scheduled_Candidate_Load(object sender, EventArgs e)
        {
            lblInterview_Scheduled_Candidate.Text = Title;
            grdInterviewScheduledCandidate.ClearSelection();
            ClsInterviewSchedule objShowIntScheduledCand = new ClsInterviewSchedule(Status_ID,Job_ID);
            DataTable dt = new DataTable();
            dt =objShowIntScheduledCand.ShowInterviewScheduledCand();
            grdInterviewScheduledCandidate.DataSource=dt;
            //this.grdInterviewScheduledCandidate.Columns["Candidate_ID"].Visible = false;
        }
    }
}
