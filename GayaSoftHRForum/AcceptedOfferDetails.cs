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
    public partial class AcceptedOfferDetails : Form
    {
        int StatusId, CandidateId, JobId, CompanyId;
        string Company_Name, JobTitle, CTC, PaymentStatus;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtCtc.Text))
            {
                txtCtc.Focus();
                errorProvider1.SetError(txtCtc, "Please Enter CTC");
                MessageBox.Show("Plz Fill CTC....!");
                errorProvider1.Clear();
            }

            else if (string.IsNullOrEmpty(cmbbxPayment.Text))
            {
                cmbbxPayment.Focus();
                MessageBox.Show("Plz Select Payment Status....!");
            }
            else
            {
                //Save AcceptedOfferDetails data into Tbl_Placed_candidate
                CTC = txtCtc.Text;
                PaymentStatus = cmbbxPayment.Text;

                ClsLineUp objAcceptedDetails = new ClsLineUp(CandidateId, CompanyId, JobTitle, CTC, PaymentStatus);
                objAcceptedDetails.SaveAcceptedOfferDetails();
              

                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
                MessageBox.Show("Status updated Successfully...!");
            }


        }
        
        //To show CompanyName,JobTitle on load of form
        private void AcceptedOfferDetails_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objaccepted =new ClsInterviewSchedule(JobId,CandidateId);
            SqlDataReader dr;
            dr=objaccepted.ShowAcceptedOfferDetails();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    Company_Name = txtCompanyName.Text = dr["Company_Name"].ToString();
                    JobTitle = txtProfile.Text = dr["Job_Title"].ToString();
                    CompanyId = Convert.ToInt32(dr["Company_ID"].ToString());

                }
            }
        }

        
        public AcceptedOfferDetails()
        {
            InitializeComponent();
        }
        public AcceptedOfferDetails(int statusId,int  candidateId,int jobId)
        {
            InitializeComponent();
            StatusId = statusId;
            CandidateId = candidateId;
            JobId = jobId;
        }

    }
}
