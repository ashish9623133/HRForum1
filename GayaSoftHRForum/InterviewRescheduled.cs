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

namespace GayaSoftHRForum
{
    public partial class InterviewRescheduled : Form
    {
        ComboBox combo;
        int Staff_Registration_Id,StatusId, CandidateId, JobId;
        public InterviewRescheduled()
        {
            InitializeComponent();
        }
        public InterviewRescheduled(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id=staffid;
        }

        private void grdInterviewRescheduled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdInterviewRescheduled.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdInterviewRescheduled.CurrentRow.Cells[2].Value.ToString());
        }

        private void grdInterviewRescheduled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objRescheduled = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objRescheduled.ShowInterviewRescheduled();
            grdInterviewRescheduled.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdInterviewRescheduled.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdInterviewRescheduled.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdInterviewRescheduled.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdInterviewRescheduled.Columns.Count; j++)
                {
                    if (grdInterviewRescheduled.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdInterviewRescheduled.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdInterviewRescheduled.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        //To show candidates having status Interview Rescheduled
        private void InterviewRescheduled_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objRescheduled =new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objRescheduled.ShowInterviewRescheduled();
            grdInterviewRescheduled.DataSource = dt;

            this.grdInterviewRescheduled.Columns["Candidate_ID"].Visible = false;
            this.grdInterviewRescheduled.Columns["Job_ID"].Visible = false;
            this.grdInterviewRescheduled.Columns["Company_ID"].Visible = false;
        }

        private void grdInterviewRescheduled_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                UpdateFeedback objfeedback = new UpdateFeedback(StatusId, CandidateId, JobId);
                objfeedback.Show();
            }
            
            else if (status == "Not Attended")
            {

                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 5;
                Comment objComment = new Comment(StatusId, CandidateId, JobId);
                objComment.Show();
            }
            



        }
    }
}
