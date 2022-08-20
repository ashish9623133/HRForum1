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
using System.Data.SqlClient;

namespace GayaSoftHRForum
{
    public partial class PlacementDetails : Form
    {
        int StatusId, CandidateId,JobId,CompanyId, No_Of_Opening;
        string Company_Name, JobTitle,CTC,PaymentStatus;

        private void dtpPlaced_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpPlaced.Value)
            {
                MessageBox.Show("You are not allowed to select older day than today!");
                dtpPlaced.Value = DateTime.Today;

            }

        }

        private void dtpInterviewDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpInterviewDate.Value)
            {
                MessageBox.Show("You are not allowed to select older day than today!");
                dtpInterviewDate.Value = DateTime.Today;

            }

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtCtc.Text))
            {
                txtCtc.Focus();
                errorProvider1.SetError(txtCtc, "Please Enter CTC");
                MessageBox.Show("Plz Fill CTC....!");
                errorProvider1.Clear();
            }

            else if (string.IsNullOrEmpty(cmbbxPaymentStatus.Text))
            {
               cmbbxPaymentStatus.Focus();
                MessageBox.Show("Plz Select Payment Status....!");
            }

            else
            {
                //Save Placement Details in Tbl_Placed_Candidate
                CTC = txtCtc.Text;
                JoiningDate = Convert.ToDateTime(dtpInterviewDate.Text);
                PlacedDate = Convert.ToDateTime(dtpPlaced.Text);
                PaymentStatus = cmbbxPaymentStatus.Text;

                ClsLineUp objPlacedDetails = new ClsLineUp(CandidateId, CompanyId, JobTitle, JoiningDate, CTC, PlacedDate, PaymentStatus);
                objPlacedDetails.SavePlacementDetails();
                MessageBox.Show("Placement details are saved successfully...");
                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
                No_Of_Opening = No_Of_Opening - 1;
                ClsLineUp objnumberofopening = new ClsLineUp(JobId, No_Of_Opening);
                objnumberofopening.UpdateNumberOfOpening();
            }


        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        DateTime JoiningDate,PlacedDate;
        public PlacementDetails()
        {
            InitializeComponent();
        }
        public PlacementDetails(int statusid,int candidateid,int jobid)
        {
            InitializeComponent();
            StatusId = statusid;
            CandidateId = candidateid;
            JobId = jobid;
        }

        private void PlacementDetails_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objplaced = new ClsInterviewSchedule(JobId,CandidateId);
            SqlDataReader dr;

            dr = objplaced.ShowPlacedDetails();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    Company_Name = txtCompanyName.Text = dr["Company_Name"].ToString();
                    JobTitle = txtProfile.Text = dr["Job_Title"].ToString();
                    CompanyId=Convert.ToInt32(dr["Company_ID"].ToString());
                    No_Of_Opening = Convert.ToInt32(dr["Number_Of_Opening"]);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }
    }
}
