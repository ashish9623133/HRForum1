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
    public partial class Interviewed : Form
    {
        ComboBox combo;
        int StatusId,JobId, CandidateId, Staff_Registration_Id;
        public Interviewed()
        {
            InitializeComponent();
        }
        public Interviewed(int Staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = Staffid;
        }

        //To show candidates with status Interviewed
        private void AllCandidate_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objinterviewed = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objinterviewed.ShowInterviewedCandidate();
            grdInterviewed.DataSource = dt;


            this.grdInterviewed.Columns["Candidate_ID"].Visible = false;
            this.grdInterviewed.Columns["Job_ID"].Visible = false;
            this.grdInterviewed.Columns["Company_ID"].Visible = false;
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

        }

        private void grdInterviewed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdInterviewed.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdInterviewed.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click_1(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void grdInterviewed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objinterviewed = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objinterviewed.ShowInterviewedCandidate();
            grdInterviewed.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdInterviewed.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdInterviewed.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdInterviewed.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdInterviewed.Columns.Count; j++)
                {
                    if (grdInterviewed.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdInterviewed.Rows[i].Cells[j].Value.ToString();
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
            (grdInterviewed.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //To create event SelecetedIndexChanged of Combobox in Datagridview.
        private void grdInterviewed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }
        //To Update status and add comment on selection of combobox Value.
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = (sender as ComboBox).SelectedItem.ToString();
            
            if(status== "Selected")
            {
                StatusId = 10;
                Comment objcomment = new Comment(StatusId,CandidateId,JobId);
                objcomment.Show();
            }
            else if(status== "Rejected")
            {
                StatusId = 9;
                Comment objcomment = new Comment(StatusId,CandidateId,JobId);
                objcomment.Show();

            }
            else if(status== "On Hold")
            {
                StatusId = 8;
                Comment objcomment = new Comment(StatusId,CandidateId,JobId);
                objcomment.Show();

            }
        }
    }
}
