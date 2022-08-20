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
    public partial class Open_Jobs_Details : Form
    {

        int Company_ID, Staff_ID;
        public Open_Jobs_Details()
        {
            InitializeComponent();
        }

        public Open_Jobs_Details(int company_id, int staff_id)
        {
            InitializeComponent();
            Company_ID = company_id;
            Staff_ID = staff_id;
        }

        private void grdOpenJobsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Job_ID=Convert.ToInt32(grdOpenJobsDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
            Candidate_Pipeline obj = new Candidate_Pipeline(Job_ID, Staff_ID);
            obj.Show();
            this.Close();
        }

        private void grdOpenJobsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCompany objShowOpenJobs = new ClsCompany(Company_ID);
            DataTable dt = new DataTable();
            dt = objShowOpenJobs.ShowOpenJobs();
            grdOpenJobsDetails.DataSource = dt;
            grdOpenJobsDetails.Show();
            this.grdOpenJobsDetails.Columns["Job_ID"].Visible = false;
        }

        private void Open_Jobs_Details_Load(object sender, EventArgs e)
        {
            ClsCompany objShowOpenJobs = new ClsCompany(Company_ID);
            DataTable dt = new DataTable();
            dt=objShowOpenJobs.ShowOpenJobs();
            grdOpenJobsDetails.DataSource=dt;
            grdOpenJobsDetails.Show();
            this.grdOpenJobsDetails.Columns["Job_ID"].Visible = false;
        }
    }
}
