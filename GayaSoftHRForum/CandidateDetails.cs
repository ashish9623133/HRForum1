using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForum;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class CandidateDetails : Form
    {
    
        int Can_ID;
        int Candidate_ID,Staff_Register_ID;

        public CandidateDetails()
        {
            InitializeComponent();
        }
        public CandidateDetails(int id1)
        {
            InitializeComponent();
            Can_ID = id1;
            Staff_Register_ID = id1;
        }

        private void CandidateDetails_Load(object sender, EventArgs e)
        {
           
            int Status_ID = 3;
            //Can_ID = 1;


        }
       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnassigned_Click(object sender, EventArgs e)
        {
            Can_ID = Convert.ToInt32(canid.Text);

           
            AssignedJobsDetails objassignedjob = new AssignedJobsDetails(Can_ID, Staff_Register_ID);

            objassignedjob.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void phno_Click(object sender, EventArgs e)
        {

        }

        private void BtnCandidateHistory_Click(object sender, EventArgs e)
        {
            Candidate_ID = Convert.ToInt32(canid.Text);
            CandidateHistory objCanHistory=new CandidateHistory(Candidate_ID);
            objCanHistory.Show();
        }

        private void expectedctc_Click(object sender, EventArgs e)
        {

        }

        private void skill_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void lblJobStream_Click(object sender, EventArgs e)
        {

        }

        private void canid_Click(object sender, EventArgs e)
        {

        }
    }
}
