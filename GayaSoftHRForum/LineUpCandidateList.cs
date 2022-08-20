using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class LineUpCandidateList : Form
    {
        public object ExcelApp;

        int candidateID;
        public LineUpCandidateList()
        {
            InitializeComponent();
        }
        public LineUpCandidateList(string job_title)
        {
            job_title = job_title;

        }
        private void LineUpCandidateList_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objcan = new ClsCandidateRegistration();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = objcan.LineUp_ShowAllCandidateList();
            grdviewLineUp.DataSource = dt;
            grdviewLineUp.Show();

            this.grdviewLineUp.Columns["Candidate_ID"].Visible = false;
            this.grdviewLineUp.Columns["Staff_Register_ID"].Visible = false;
        }




        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            frmAddCandidate objFrm1 = new frmAddCandidate();
            objFrm1.Show();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmCandidateImport objImport = new frmCandidateImport();
            objImport.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 4; i < grdviewLineUp.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdviewLineUp.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdviewLineUp.Rows.Count - 1; i++)
            {
                for (int j = 3; j < grdviewLineUp.Columns.Count; j++)
                {
                    if (grdviewLineUp.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdviewLineUp.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ClsCandidateRegistration objCandidateList = new ClsCandidateRegistration();
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = objCandidateList.GetType();
                grdviewLineUp.DataSource = dt;
                grdviewLineUp.Show();
            }
            else
            {
                // ClsCandidateRegistration objCandidateList = new ClsCandidateRegistration(txtSearch.Text, txtSearch.Text
                //, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text
                //, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
                // System.Data.DataTable dt = new System.Data.DataTable();
                // dt = objCandidateList.SearchCandidateList();
                // grdviewLineUp.DataSource = dt;
                // grdviewLineUp.Show();
                (grdviewLineUp.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Email_ID like '{0}%' or Contact_No like '{0}%'or Gender like '{0}%'or City_Name like '{0}%' or Address like '{0}%' or Qualification like '{0}%' or Specialization_Name like '{0}%' or Total_Experience like '{0}%' or Current_CTC like '{0}%' or Expected_CTC like '{0}%' or Skills like '{0}%' or Relevant_Experience like '{0}%' or Position like '{0}%' or Preferred_Location like '{0}%' or Job_Stream_Name like '{0}%'", txtSearch.Text);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClsCandidateRegistration objcan = new ClsCandidateRegistration();
            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt = objcan.GetType();
            //grdviewLineUp.DataSource = dt;
            //grdviewLineUp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objcan = new ClsCandidateRegistration();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = objcan.GetType();
            grdviewLineUp.DataSource = dt;
            grdviewLineUp.Show();

        }

        private void cmbxFilter_by_jobstream_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Job_Stream_ID = Convert.ToInt32(cmbxFilter_by_jobstream.SelectedValue.ToString());

            ClsCandidateRegistration objcan = new ClsCandidateRegistration(Job_Stream_ID);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = objcan.Candidate_With_Job_Stream();
            grdviewLineUp.DataSource = dt;
            grdviewLineUp.Show();

        }

        private void cmbbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Specialization_ID = Convert.ToInt32(cmbbxFilter.SelectedValue.ToString());

            ClsCandidateRegistration objcan = new ClsCandidateRegistration(Specialization_ID);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = objcan.Candidate_With_Specialization();
            grdviewLineUp.DataSource = dt;
            grdviewLineUp.Show();
        }

        private void cmbxFilter_by_Qualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Qualification_ID = Convert.ToInt32(cmbxFilter_by_Qualification.SelectedValue);

            ClsCandidateRegistration objcan = new ClsCandidateRegistration(Qualification_ID);
            _ = new System.Data.DataTable();
            DataTable dt1 = objcan.Candidate_With_Qualification();
            grdviewLineUp.DataSource = dt1;
            grdviewLineUp.Show();
        }

        private void grdDataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                candidateID = Convert.ToInt32(grdviewLineUp.CurrentRow.Cells[3].Value);
                frmPersonalInformation objPI = new frmPersonalInformation(candidateID);
                objPI.Show();
            }
            if (e.ColumnIndex == 0)
            {
                candidateID = Convert.ToInt32(grdviewLineUp.CurrentRow.Cells[3].Value);
                int Staff_Register_ID = 2;

                CandidateDetails objDetails = new CandidateDetails(Staff_Register_ID);
                objDetails.Show();

                objDetails.name.Text = grdviewLineUp.CurrentRow.Cells[5].Value.ToString();
                objDetails.canid.Text = grdviewLineUp.CurrentRow.Cells[3].Value.ToString();
                objDetails.dateofregi.Text = grdviewLineUp.CurrentRow.Cells[45].Value.ToString();
                objDetails.phno.Text = grdviewLineUp.CurrentRow.Cells[7].Value.ToString();
                objDetails.email.Text = grdviewLineUp.CurrentRow.Cells[6].Value.ToString();
                objDetails.skill.Text = grdviewLineUp.CurrentRow.Cells[27].Value.ToString();
                objDetails.bday.Text = grdviewLineUp.CurrentRow.Cells[9].Value.ToString();
                objDetails.gender.Text = grdviewLineUp.CurrentRow.Cells[8].Value.ToString();
                objDetails.experience.Text = grdviewLineUp.CurrentRow.Cells[14].Value.ToString();
                objDetails.currentctc.Text = grdviewLineUp.CurrentRow.Cells[15].Value.ToString();
                objDetails.expectedctc.Text = grdviewLineUp.CurrentRow.Cells[16].Value.ToString();
                objDetails.picbxPP.Image = Image.FromFile(grdviewLineUp.CurrentRow.Cells[18].Value.ToString());
                objDetails.lblQualification.Text = grdviewLineUp.CurrentRow.Cells[12].Value.ToString();
                objDetails.lblSpecialization.Text = grdviewLineUp.CurrentRow.Cells[13].Value.ToString();
                objDetails.lblResume.Text = grdviewLineUp.CurrentRow.Cells[17].Value.ToString();
                objDetails.lblJobStr.Text = grdviewLineUp.CurrentRow.Cells[38].Value.ToString();
            }
            if (e.ColumnIndex == 2)
            {
                int Candidate_ID = Convert.ToInt32(grdviewLineUp.CurrentRow.Cells[3].Value.ToString());
                grdviewLineUp.Rows.Remove(grdviewLineUp.Rows[e.RowIndex]);
                ClsCandidateRegistration objdelete = new ClsCandidateRegistration(Candidate_ID);
                objdelete.deleterow();
                MessageBox.Show("Delete SuccessFully");
            }

        }

        private void grdviewLineUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LineUpCandidateList_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objFilter = new ClsCandidateRegistration();
            DataTable dt1 = new DataTable();
            dt1 = objFilter.Filter_By_Condidate();
            cmbbxFilter.ValueMember = "Specialization_ID";
            cmbbxFilter.DisplayMember = "specialization_Name";

            cmbbxFilter.DataSource = dt1;
            cmbbxFilter.Text = "Filter_By_specialization";
            cmbbxFilter.Show();

            //....Fiter by stream
            ClsCandidateRegistration objFilterstream = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt2 = objFilterstream.Filter_By_Job_Stream();
            cmbxFilter_by_jobstream.ValueMember = "Job_Stream_ID";
            cmbxFilter_by_jobstream.DisplayMember = "Job_Stream_Name";

            cmbxFilter_by_jobstream.DataSource = dt2;
            cmbxFilter_by_jobstream.Text = "Filter_By_Job_Stream";
            cmbxFilter_by_jobstream.Show();

            ///......Filter by Qualification
            ClsCandidateRegistration objFilterQualification = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt3 = objFilterQualification.Filter_By_Qualification();

            cmbxFilter_by_Qualification.ValueMember = "Qualification_ID";
            cmbxFilter_by_Qualification.DisplayMember = "Qualification";
            cmbxFilter_by_Qualification.DataSource = dt3;

            cmbxFilter_by_Qualification.Text = "Filter_By_Qualification";
            cmbxFilter_by_Qualification.Show();
        }

    }
}
    

