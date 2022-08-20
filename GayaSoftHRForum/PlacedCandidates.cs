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
    public partial class PlacedCandidates : Form
    {
        ComboBox combo;
        //public string selected;
        public string status;
        public int Staff_Registration_Id;
        public PlacedCandidates()
        {
            InitializeComponent();
        }
        public PlacedCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }

        private void PlacedCandidates_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objPlaced = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objPlaced.ShowPlacedCandidates();
            grdPlaced.DataSource = dt;

            this.grdPlaced.Columns["Candidate_ID"].Visible = false;
            this.grdPlaced.Columns["Job_ID"].Visible = false;
            this.grdPlaced.Columns["Company_ID"].Visible = false;


        }

        private void grdPlaced_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdPlaced_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void grdPlaced_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //combo = e.Control as ComboBox;
            //if (combo != null)
            //{
            //    combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
            //    combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            //}

        }
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string status = (sender as ComboBox).SelectedItem.ToString();
            //if (status == "Interviewed")
            //{
            //    UpdateFeedback objfeedback = new UpdateFeedback();
            //    objfeedback.Show();
            //}
            //else if (status == "Selected")
            //{
            //    Comment objcomment = new Comment();
            //    objcomment.Show();
            //}
            //else if (status == "Rejected")
            //{
            //    Comment objcomment = new Comment();
            //    objcomment.Show();

            //}
            //else if (status == "On Hold")
            //{
            //    Comment objcomment = new Comment();
            //    objcomment.Show();

            //}
            //else if (status == "Placed")
            //{
            //    PlacementDetails objShowPlacementDeatils = new PlacementDetails();
            //    objShowPlacementDeatils.Show();
            //}


        }

        private void grdPlaced_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
            for (int i = 1; i < grdPlaced.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdPlaced.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdPlaced.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdPlaced.Columns.Count; j++)
                {
                    if (grdPlaced.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdPlaced.Rows[i].Cells[j].Value.ToString();
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
            (grdPlaced.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
