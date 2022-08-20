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
    public partial class InterviewNotAttended : Form
    {
        ComboBox combo;
        int Staff_Registration_Id, CandidateId, JobId,StatusId;
        public InterviewNotAttended()
        {
            InitializeComponent();
        }
        public InterviewNotAttended(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }

        private void InterviewNotAttendedcs_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objNotAttended =new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objNotAttended.ShowInterviewNotAttended();
            grdInterviewNotAttended.DataSource = dt;

            this.grdInterviewNotAttended.Columns["Candidate_ID"].Visible = false;
            this.grdInterviewNotAttended.Columns["Job_ID"].Visible = false;
            this.grdInterviewNotAttended.Columns["Company_ID"].Visible = false;
        }

        private void grdInterviewNotAttended_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objNotAttended = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objNotAttended.ShowInterviewNotAttended();
            grdInterviewNotAttended.DataSource = dt;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdInterviewNotAttended.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdInterviewNotAttended.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdInterviewNotAttended.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdInterviewNotAttended.Columns.Count; j++)
                {
                    if (grdInterviewNotAttended.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] =grdInterviewNotAttended.Rows[i].Cells[j].Value.ToString();
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
            (grdInterviewNotAttended.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grdInterviewNotAttended_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            
        }
        //To schedule interview for candidate having status Interview Not Attended

        private void grdInterviewNotAttended_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //StatusId = 5;
            CandidateId = Convert.ToInt32(grdInterviewNotAttended.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdInterviewNotAttended.CurrentRow.Cells[2].Value.ToString());

            if (e.ColumnIndex == 0)
            {
                StatusId = 6;
                Schedule_Candidate_Interview objSchedule = new Schedule_Candidate_Interview(CandidateId, JobId, Staff_Registration_Id, StatusId);
                objSchedule.Show();
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();

            }
            
        }
    }
}
