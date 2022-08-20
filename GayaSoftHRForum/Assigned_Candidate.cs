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
    public partial class Assigned_Candidate : Form
    {
        public int Job_ID, Status_ID, Candidate_ID, Staff_ID;
        public Assigned_Candidate()
        {
            InitializeComponent();
        }

        private void lblAssignedCandidate_Click(object sender, EventArgs e)
        {

        }

        private void grdAssignedCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Status_ID = 3;
            ClsCandidateAssign objShowAssignedCandidate = new ClsCandidateAssign(Job_ID, Status_ID);
            DataTable dt = new DataTable();
            dt = objShowAssignedCandidate.ShowAssignedCandidate();
            grdAssignedCandidate.DataSource = dt;
            this.grdAssignedCandidate.Columns["CandidateID"].Visible = false;

        }

        public Assigned_Candidate(int job_id,int staff_id)
        {
            InitializeComponent();
            Job_ID = job_id;
            Staff_ID = staff_id;
        }

        private void grdAssignedCandidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Status_ID = 4;
                Candidate_ID = Convert.ToInt32(grdAssignedCandidate.CurrentRow.Cells[1].Value);
                Schedule_Candidate_Interview objScheduleCandidateInterview = new Schedule_Candidate_Interview(Candidate_ID, Job_ID, Staff_ID, Status_ID);
                objScheduleCandidateInterview.Show();
                this.Close();
            }
        }

        private void Assigned_Candidate_Load(object sender, EventArgs e)
        {
            Status_ID = 3;
            ClsCandidateAssign objShowAssignedCandidate=new ClsCandidateAssign(Job_ID, Status_ID);
            DataTable dt=new DataTable();
            dt=objShowAssignedCandidate.ShowAssignedCandidate();
            grdAssignedCandidate.DataSource=dt;

           this.grdAssignedCandidate.Columns["CandidateID"].Visible = false;

        }
    }
}
