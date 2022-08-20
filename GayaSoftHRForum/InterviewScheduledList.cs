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

namespace GayaSoftHRForum
{
    public partial class InterviewScheduledList : Form
    {
        ComboBox combo;
        int Staff_Register_ID, StatusId, CandidateId, JobId;
        public InterviewScheduledList()
        {
            InitializeComponent();
        }
        public InterviewScheduledList(int staffid)
        {
            InitializeComponent();
            Staff_Register_ID = staffid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        //To show candidates having status Interview Scheduled.

        private void InterviewScheduledList_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objScheduled = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objScheduled.ShowInterviewScheduledList();
            grdListScheduled.DataSource = dt;
            
            this.grdListScheduled.Columns["Candidate_ID"].Visible = false;
            this.grdListScheduled.Columns["Job_ID"].Visible = false;
            this.grdListScheduled.Columns["Company_ID"].Visible = false;

        }

        private void grdListScheduled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdListScheduled.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdListScheduled.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objScheduled = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objScheduled.ShowInterviewScheduledList();
            grdListScheduled.DataSource = dt;

        }

        private void btnExport_Click(object sender, EventArgs e)
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
            for (int i = 1; i < grdListScheduled.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdListScheduled.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <grdListScheduled.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdListScheduled.Columns.Count; j++)
                {
                    if (grdListScheduled.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdListScheduled.Rows[i].Cells[j].Value.ToString();
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
            (grdListScheduled.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void grdListScheduled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //To create event for combobox property SelectedIndexChanged in DataGridview.

        private void grdListScheduled_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }


        }
        //To update status,add comment,update feedback for selected combobox value.
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = (sender as ComboBox).SelectedItem.ToString();
            if (status == "Interviewed")
            {
                StatusId = 7;
                UpdateFeedback objfeedback = new UpdateFeedback(StatusId, CandidateId,JobId);
                objfeedback.Show();
            }
            
            else if (status == "Not Attended")
            {

                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 5;
                Comment objcomment = new Comment(StatusId, CandidateId, JobId);
                objcomment.Show();
                

            }


        }


    }

    //private void InterviewScheduledListcs_Load(object sender, EventArgs e)
    //    {





    //    }


}
