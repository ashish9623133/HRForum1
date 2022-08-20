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
    public partial class SelectedCandidates : Form
    {
        ComboBox combo;
        int StatusId, CandidateId, JobId, Staff_Registration_Id;
        public SelectedCandidates()
        {
            InitializeComponent();
            
        }
        public SelectedCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id=staffid;
        }

        private void SelectedCandidates_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objSelected =new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objSelected.ShowSelectedCandidates();
            grdSelected.DataSource = dt;

            this.grdSelected.Columns["Candidate_ID"].Visible = false;
            this.grdSelected.Columns["Job_ID"].Visible = false;
            this.grdSelected.Columns["Company_ID"].Visible = false;
        }

        private void grdSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdSelected.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdSelected.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void grdSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objSelected = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objSelected.ShowSelectedCandidates();
            grdSelected.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            (grdSelected.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);

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
            for (int i = 1; i < grdSelected.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdSelected.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdSelected.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdSelected.Columns.Count; j++)
                {
                    if (grdSelected.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdSelected.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void grdSelected_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            
             if (status == "Offered")
            {
                //To update Status of Candidate in Tbl_Candidate_Assign and Tbl_Interview_Schedule
                StatusId = 11;
                ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                objupdate.UpdateCandidateStatus();
                objupdate.UpdateStatusInterviewSchedule();
            }
           






        }



    }
}
