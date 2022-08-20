using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GayaSoftHRForumLibrary.HR;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class InterviewDetails : Form
    {
        int Candidate_ID;
        public InterviewDetails(int C_Id)
        {
            
            InitializeComponent();
             Candidate_ID = C_Id;
        }
        public InterviewDetails()
        {
            InitializeComponent();
        }

        private void InterviewDetails_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(Candidate_ID);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.GetInterviewDetails();
            dataGridViewInterviewDetails.DataSource = dt;

        }

        private void dataGridViewInterviewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
