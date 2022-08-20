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
using GayaSoftHRForum;

namespace GayaSoftHRForum
{
   
    public partial class AssignedJobsDetails : Form
    {
        
       public int Candidate_ID, Job_ID, Status_ID, Staff_ID, Can_ID;
       
        public AssignedJobsDetails()
        {
            InitializeComponent();
        }
        public AssignedJobsDetails(int canid )
        {
            InitializeComponent();
            Candidate_ID = canid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Status_ID = 3;
            ClsCandidateAssign ShowAssignedJobDetails = new ClsCandidateAssign(Status_ID, Candidate_ID);
            DataTable dt = new DataTable();
            dt = ShowAssignedJobDetails.ShowAssignedJob();
            Assijob.DataSource = dt;
            Assijob.Show();
            this.Assijob.Columns["Job_ID"].Visible = false;
        }

        public AssignedJobsDetails(int can_id, int staff_register_id)
        {
            InitializeComponent();
            Candidate_ID =can_id;
            Staff_ID=staff_register_id;
        }

        private void Assijob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Status_ID = 4;
            Job_ID = Convert.ToInt32(Assijob.CurrentRow.Cells[2].Value);
            Schedule_Candidate_Interview objinterview = new Schedule_Candidate_Interview(Candidate_ID, Job_ID, Staff_ID, Status_ID);
            objinterview.Show();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void AssignedJobsDetails_Load(object sender, EventArgs e)
        {
            int Status_ID = 3;
            ClsCandidateAssign ShowAssignedJobDetails = new ClsCandidateAssign(Status_ID, Candidate_ID);
            DataTable dt = new DataTable();
            dt = ShowAssignedJobDetails.ShowAssignedJob();
            Assijob.DataSource = dt;
            Assijob.Show();
            this.Assijob.Columns["Job_ID"].Visible = false;


        }
    }
}
