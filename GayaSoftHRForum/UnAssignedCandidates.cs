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
    public partial class UnAssignedCandidates : Form
    {
        public int Staff_Registration_Id;
        public UnAssignedCandidates()
        {
            InitializeComponent();

        }
        public UnAssignedCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;

        }

        private void UnAssignedCandidates_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objunassign =new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objunassign.ShowUnAssignedCandidate();
            grdUnAssigned.DataSource = dt;
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdUnAssigned.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdUnAssigned.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdUnAssigned.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdUnAssigned.Columns.Count; j++)
                {
                    if (grdUnAssigned.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdUnAssigned.Rows[i].Cells[j].Value.ToString();
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
            (grdUnAssigned.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Email_ID like '{0}%' or Contact_No like '{0}%'or Gender like '{0}%'or City_Name like '{0}%' or Address like '{0}%' or Qualification like '{0}%' or Specialization_Name like '{0}%' or Total_Experience like '{0}%' or Current_CTC like '{0}%' or Expected_CTC like '{0}%' or Skills like '{0}%' or Relevant_Experience like '{0}%' or Position like '{0}%' or Preferred_Location like '{0}%' or Job_Stream_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
