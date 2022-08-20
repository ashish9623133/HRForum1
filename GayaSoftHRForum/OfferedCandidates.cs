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
    public partial class OfferedCandidates : Form
    {
        ComboBox combo;
        int StatusId, CandidateId, JobId, Staff_Registration_Id;
        public OfferedCandidates()
        {
            InitializeComponent();
            
        }
        public OfferedCandidates(int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id=staffid;
        }
        //To show candidates having status Offered in Datagridview.

        private void OfferedCandidates_Load(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOffered =new ClsInterviewSchedule();
            DataTable dt=new DataTable();
            dt = objOffered.ShowOfferedCandidate();
            grdOffered.DataSource = dt;

            this.grdOffered.Columns["Candidate_ID"].Visible = false;
            this.grdOffered.Columns["Job_ID"].Visible = false;
            this.grdOffered.Columns["Company_ID"].Visible = false;

        }

        private void grdOffered_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidateId = Convert.ToInt32(grdOffered.CurrentRow.Cells[1].Value.ToString());
            JobId = Convert.ToInt32(grdOffered.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJob objjob = new AddJob(JobId);
            objjob.Show();
        }

        private void grdOffered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsInterviewSchedule objOffered = new ClsInterviewSchedule();
            DataTable dt = new DataTable();
            dt = objOffered.ShowOfferedCandidate();
            grdOffered.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (grdOffered.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdOffered.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdOffered.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdOffered.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdOffered.Columns.Count; j++)
                {
                    if (grdOffered.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdOffered.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        //To create event for combobox property SelectedIndexChanged in DataGridview.
        private void grdOffered_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }
        //To update status,add comment,update feedback for selected combobox value.
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = (sender as ComboBox).SelectedItem.ToString();
            if (status == "Offer Rejected")
            {
                StatusId = 20;
                Comment objcomment = new Comment(StatusId, CandidateId, JobId);
                objcomment.Show();
                //ClsInterviewSchedule objupdate = new ClsInterviewSchedule(StatusId, CandidateId,JobId);
                //objupdate.UpdateCandidateStatus();
                //objupdate.UpdateStatusInterviewSchedule();
            }
            else if (status == "Offer Accepted")
            {
                StatusId = 12;
                AcceptedOfferDetails objacceptedoffer = new AcceptedOfferDetails(StatusId, CandidateId, JobId);
                objacceptedoffer.Show();
            }
           



        }



    }
}
