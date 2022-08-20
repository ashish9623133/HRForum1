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
//using GayaSoftHRForumLibrary.Admin;
using GayaSoftHRForumLibrary.HR;


namespace GayaSoftHRForum
{
    public partial class Rejected : Form
    {
        ComboBox combo;
        int StatusId, CandidateId, JobId, Staff_Registration_Id;
        public Rejected()
        {
            InitializeComponent();
        }
        public Rejected(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }

        private void Rejected_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objRejected =new ClsInterviewSchedule();
            DataTable dt=new DataTable();
            dt = objRejected.ShowRejectedCandidate();
            grdRejected.DataSource = dt;

            this.grdRejected.Columns["Candidate_ID"].Visible = false;
            this.grdRejected.Columns["Job_ID"].Visible = false;
            this.grdRejected.Columns["Company_ID"].Visible = false;

        }

        private void grdRejected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdRejected.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdRejected.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdRejected.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdRejected.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdRejected.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdRejected.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdRejected.Columns.Count; j++)
                {
                    if (grdRejected.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdRejected.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void grdRejected_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = (sender as ComboBox).SelectedItem.ToString();
            if (status == "Interviewed")
            {
                StatusId = 7;
                UpdateFeedback objfeedback = new UpdateFeedback(StatusId, CandidateId,JobId);
                objfeedback.Show();
            }
            else if (status == "Selected")
            {
                StatusId = 10;
                Comment objcomment = new Comment(StatusId, CandidateId,JobId);
                objcomment.Show();
            }
            else if (status == "Rejected")
            {
                StatusId = 9;
                Comment objcomment = new Comment(StatusId, CandidateId,JobId);
                objcomment.Show();

            }
            else if (status == "On Hold")
            {
                StatusId = 8;
                Comment objcomment = new Comment(StatusId, CandidateId,JobId);
                objcomment.Show();

            }
            else if (status == "Placed")
            {
                StatusId = 13;
                PlacementDetails objShowPlacementDeatils = new PlacementDetails(StatusId, CandidateId, JobId);
                objShowPlacementDeatils.Show();
            }
            else if (status == "Offer Accepted")
            {
                StatusId = 12;
                AcceptedOfferDetails objacceptedoffer = new AcceptedOfferDetails(StatusId, CandidateId, JobId);
                objacceptedoffer.Show();
            }
            else if (status == "Offered")
            {
                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 11;
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
                

            }
            else if (status == "Not Attended")
            {

                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 5;
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
                

            }
            else if (status == "Interview Rescheduled")
            {

                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 6;
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
                

            }



        }



    }
}
