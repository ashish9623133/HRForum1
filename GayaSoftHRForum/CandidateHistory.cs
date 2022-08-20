using GayaSoftHRForumLibrary.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class CandidateHistory : Form
    {
        int candidate_id;
        public CandidateHistory(int Candidate_idd)
        {
            InitializeComponent();
             candidate_id = Candidate_idd;
        }
        public CandidateHistory()
        {
            InitializeComponent();
        }

        private void CandidateHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void interviewAttentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InterviewDetails objInterviewDetails = new InterviewDetails(candidate_id);
            //objInterviewDetails.Show();
            ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(candidate_id);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.GetInterviewDetails();
            dataGridViewCandidateHistory.DataSource = dt;

        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectedDetails objSelectedDetails = new SelectedDetails(candidate_id);
            //objSelectedDetails.Show();
            GayaSoftHRForumLibrary.HR.ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(candidate_id);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.GetSelectedDetails();
            dataGridViewCandidateHistory.DataSource = dt;

        }

        private void offerAcceptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(candidate_id);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.offerAcepted();
            dataGridViewCandidateHistory.DataSource = dt;
            dataGridViewCandidateHistory.Show();

        }

        private void lblCandidateHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
