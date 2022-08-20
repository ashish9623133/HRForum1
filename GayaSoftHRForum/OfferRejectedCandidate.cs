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
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class OfferRejectedCandidate : Form
    {
        int Staff_Registration_Id, StatusId, CandidateId, JobId;

        private void grdOffereRejected_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CandidateId = Convert.ToInt32(grdOffereRejected.CurrentRow.Cells[0].Value.ToString());
            JobId = Convert.ToInt32(grdOffereRejected.CurrentRow.Cells[1].Value.ToString());
        }

        private void OfferRejectedCandidate_Load(object sender, EventArgs e)
        {
            //ClsInterviewSchedule objofferrejected =new ClsInterviewSchedule();
            //DataTable dt =new DataTable();
            //dt = objofferrejected.ShowOfferRejectedData();
            //grdOffereRejected.DataSource = dt;

            //this.grdOffereRejected.Columns["Candidate_ID"].Visible = false;
            //this.grdOffereRejected.Columns["Job_ID"].Visible = false;
            //this.grdOffereRejected.Columns["Company_ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void OfferRejectedCandidate_Load_1(object sender, EventArgs e)
        {
            ClsInterviewSchedule objofferrejected = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objofferrejected.ShowOfferRejectedData();
            grdOffereRejected.DataSource = dt;

            this.grdOffereRejected.Columns["Candidate_ID"].Visible = false;
            this.grdOffereRejected.Columns["Job_ID"].Visible = false;
            this.grdOffereRejected.Columns["Company_ID"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdOffereRejected.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdOffereRejected.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdOffereRejected.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdOffereRejected.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdOffereRejected.Columns.Count; j++)
                {
                    if (grdOffereRejected.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdOffereRejected.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        public OfferRejectedCandidate()
        {
            InitializeComponent();
        }
        public OfferRejectedCandidate(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;


        }

        private void grdOffereAccepted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
