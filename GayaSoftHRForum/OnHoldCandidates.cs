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
    public partial class OnHoldCandidates : Form
    {
        ComboBox combo;
        int StatusId, CandidateId, JobId, Staff_Registration_Id;
        public OnHoldCandidates()
        {
            InitializeComponent();
            
        }
        public OnHoldCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id=staffid;
        }
        //To show Candidates having Status On Hold in Datagridview.

        private void OnHoldCandidates_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOnHold =new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objOnHold.ShowOnHoldCandidate();
            grdOnHold.DataSource = dt;


            this.grdOnHold.Columns["Candidate_ID"].Visible = false;
            this.grdOnHold.Columns["Job_ID"].Visible = false;
            this.grdOnHold.Columns["Company_ID"].Visible = false;
        }

        private void grdOnHold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdOnHold.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdOnHold.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void grdOnHold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOnHold = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objOnHold.ShowOnHoldCandidate();
            grdOnHold.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdOnHold.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdOnHold.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i <grdOnHold.Rows.Count - 0; i++)
            {
                for (int j = 0; j <grdOnHold.Columns.Count; j++)
                {
                    if (grdOnHold.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdOnHold.Rows[i].Cells[j].Value.ToString();
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
            (grdOnHold.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grdOnHold_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            
            if (status == "Selected")
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
           

        }



    }
}
