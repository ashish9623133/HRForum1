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
    public partial class MatchingCandidate : Form
    {
        public int Job_ID, Candidate_ID, Staff_ID;
        public int Status_ID = 3;
        public DateTime Assign_Date;
        public MatchingCandidate(int job_id,int staff_id)
        {
            InitializeComponent();
            Job_ID = job_id;
            Staff_ID = staff_id;
        }

        private void MatchingCandidate_Load(object sender, EventArgs e)
        {

            ClsCandidateRegistration objGetmatchingCandidate=new ClsCandidateRegistration(Job_ID);
            DataTable dt = new DataTable();
            dt=objGetmatchingCandidate.ShowMatchingCandidate();
            grdMatchingCandidate.DataSource=dt;

            this.grdMatchingCandidate.Columns["CandidateID"].Visible = false;
            

        }

        private void grdMatchingCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objGetmatchingCandidate = new ClsCandidateRegistration(Job_ID);
            DataTable dt = new DataTable();
            dt = objGetmatchingCandidate.ShowMatchingCandidate();
            grdMatchingCandidate.DataSource = dt;
        }

        private void btnAssign_Candidate_Click(object sender, EventArgs e)
        {
            List<int> selecteditem = new List<int>();
            DataGridViewRow objgrd = new DataGridViewRow();
            for (int i = 0; i <= grdMatchingCandidate.Rows.Count - 1; i++)
            {
                objgrd = grdMatchingCandidate.Rows[i];

                if (Convert.ToBoolean(objgrd.Cells[0].Value) == true)
                {
                    int candidate_id = Convert.ToInt32(objgrd.Cells[1].Value.ToString());
                    selecteditem.Add(candidate_id);
                    foreach (int Can_ID in selecteditem)
                    {
                        ClsCandidateAssign objCheckAssignedOrNot = new ClsCandidateAssign(Job_ID,Can_ID);
                        SqlDataReader dr;
                        dr = objCheckAssignedOrNot.CheckAssignedOrNot();
                        if(dr.Read())
                        {
                            MessageBox.Show("Please select another candiddate. This candidate is already assigned.");
                        }
                        else
                        {
                            ClsCandidateAssign objAssignCandidate = new ClsCandidateAssign(Can_ID, Job_ID, Status_ID, Staff_ID, DateTime.Now);
                            objAssignCandidate.SaveAssignedCandidate();
                            MessageBox.Show("Candidate Assigned Successfully........");
                            this.Close();
                        }

                       
                    }
                }
                
            }

        }

        private void grdMatchingCandidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
