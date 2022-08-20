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
    public partial class Closed_Jobs_Details : Form
    {
        public int Company_ID,Job_ID;
        public Closed_Jobs_Details()
        {
            InitializeComponent();
        }

        public Closed_Jobs_Details(int company_id)
        {
            InitializeComponent();
            Company_ID = company_id;
        }
        private void Closed_Jobs_Details_Load(object sender, EventArgs e)
        {
            ClsCompany objShowOpenJobs = new ClsCompany(Company_ID);
            DataTable dt = new DataTable();
            dt = objShowOpenJobs.ShowClosedJobs();
            grdClosedJobDetails.DataSource = dt;
            grdClosedJobDetails.Show();
           // this.grdClosedJobDetails.Columns["Job_ID"].Visible = true;
        }

        private void grdClosedJobDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdClosedJobDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                Job_ID = Convert.ToInt32(grdClosedJobDetails.CurrentRow.Cells[2].Value);
                Update_Job updjob = new Update_Job(Job_ID);
                updjob.Show();
            }
        }
    }
}
