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
    public partial class UnplacedCandidate : Form
    {
        public int Staff_Registration_Id;
        public UnplacedCandidate()
        {
            InitializeComponent();
        }
        public UnplacedCandidate(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i <grdUnplaced.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdUnplaced.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdUnplaced.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdUnplaced.Columns.Count; j++)
                {
                    if (grdUnplaced.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdUnplaced.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }

        }

        private void UnplacedCandidate_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objunplaced =new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objunplaced.ShowUnplacedCandidate();
            grdUnplaced.DataSource = dt;
            this.grdUnplaced.Columns["Candidate_ID"].Visible = false;
            this.grdUnplaced.Columns["Job_ID"].Visible = false;
            this.grdUnplaced.Columns["Company_ID"].Visible = false;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdUnplaced.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
