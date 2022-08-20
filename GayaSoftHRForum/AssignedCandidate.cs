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
//using GayaSoftHRForumLibrary.Admin;

namespace GayaSoftHRForum
{
    public partial class AssignedCandidate : Form
    {
        int CandidateId, JobId,Staff_Registration_Id,StatusId;
     
        public AssignedCandidate()
        {
            InitializeComponent();
        }
        public AssignedCandidate(int Staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = Staffid;
        }

        //private void btnAddJob_Click(object sender, EventArgs e)
        //{
        //    AddJob objjob = new AddJob(JobId);
        //    objjob.Show();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCandidateAssign objShow = new ClsCandidateAssign();
            DataTable dt = new DataTable();
            dt = objShow.ShowAssignedCandidateList();
            grdAssigned.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
            for (int i = 1; i < grdAssigned.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdAssigned.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdAssigned.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdAssigned.Columns.Count; j++)
                {
                    if (grdAssigned.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdAssigned.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void lblExport_Click(object sender, EventArgs e)
        {

        }

        //To Schedule Interview of particular candidate
        private void grdAssigned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdAssigned.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdAssigned.CurrentRow.Cells[2].Value.ToString());

            if (e.ColumnIndex == 0)
            {
                StatusId = 4;
                Schedule_Candidate_Interview objScheduleCandidateInterview = new Schedule_Candidate_Interview(CandidateId, JobId, Staff_Registration_Id, StatusId);
                objScheduleCandidateInterview.Show();
            }
            

        }
        //To show list of assigned candidate list

        private void AssignedCandidate_Load(object sender, EventArgs e)
        {
            ClsCandidateAssign objShow = new ClsCandidateAssign(); 
            DataTable dt = new DataTable();
            dt = objShow.ShowAssignedCandidateList();
            grdAssigned.DataSource = dt;

            this.grdAssigned.Columns["Candidate_ID"].Visible = false;
            this.grdAssigned.Columns["Job_ID"].Visible = false;
            this.grdAssigned.Columns["Company_ID"].Visible = false;
        }

        private void grdAssigned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
    }
}
