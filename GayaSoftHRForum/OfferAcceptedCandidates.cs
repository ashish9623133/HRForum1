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
    public partial class OfferAcceptedCandidates : Form
    {
        ComboBox combo;
        int StatusId, CandidateId, JobId, Staff_Registration_Id;
        public OfferAcceptedCandidates()
        {
            InitializeComponent();
        }
        public OfferAcceptedCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }


        //To show offerAccepted Candidate.

        private void OfferAcceptedCandidates_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOfferaccepted = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objOfferaccepted.ShowOfferAcceptedCandidate();
            grdOffereAccepted.DataSource = dt;

            this.grdOffereAccepted.Columns["Candidate_ID"].Visible = false;
            this.grdOffereAccepted.Columns["Job_ID"].Visible = false;
            this.grdOffereAccepted.Columns["Company_ID"].Visible = false;
        }
        //To create event for combobox property SelectedIndexChanged in DataGridview.
        private void grdOffereAccepted_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }

        private void grdOffereAccepted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdOffereAccepted.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdOffereAccepted.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void grdOffereAccepted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOfferaccepted = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objOfferaccepted.ShowOfferAcceptedCandidate();
            grdOffereAccepted.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdOffereAccepted.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
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
            for (int i = 1; i < grdOffereAccepted.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdOffereAccepted.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdOffereAccepted.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdOffereAccepted.Columns.Count; j++)
                {
                    if (grdOffereAccepted.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdOffereAccepted.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        //To update status,add comment,update feedback for selected combobox value.
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = (sender as ComboBox).SelectedItem.ToString();
            if (status == "Placed")
            {
                StatusId = 13;
                PlacementDetails objShowPlacementDeatils = new PlacementDetails(StatusId, CandidateId, JobId);
                objShowPlacementDeatils.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
