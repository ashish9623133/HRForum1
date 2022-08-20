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
    public partial class FrmUpdateOpenHoldJob : Form
    {
        public FrmUpdateOpenHoldJob()
        {
            InitializeComponent();
        }

        private void FrmOpenHoldJob_Load(object sender, EventArgs e)
        {
            ClsJob objopenhold = new ClsJob();
            DataTable dt = new DataTable();
            dt = objopenhold.ShowOpenHoldDetails();
            DgvOpenHoldJob.DataSource = dt;
            DgvOpenHoldJob.Show();
            this.DgvOpenHoldJob.Columns["Job_ID"].Visible = false;
            
        }

        private void DgvOpenHoldJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            List<int> selecteditem = new List<int>();
            DataGridViewRow objdgvr = new DataGridViewRow();

            for (int i = 0; i <= DgvOpenHoldJob.Rows.Count - 1; i++)
            {
                objdgvr = DgvOpenHoldJob.Rows[i];

                if (Convert.ToBoolean(objdgvr.Cells[0].Value) == true)
                {
                    int jobid = Convert.ToInt32(objdgvr.Cells[1].Value.ToString());
                    selecteditem.Add(jobid);
                    
                }
                
            }
            foreach (int s in selecteditem)
            {
                int Status_ID = 15;
                ClsJob objobUpdatestatus = new ClsJob(s, Status_ID);
                objobUpdatestatus.UpdateJobStatus();
            }
            MessageBox.Show("Job Status Updated Successfully....");
            this.Close();
            
        }

        private void btnhold_Click(object sender, EventArgs e)
        {
            List<int> selecteditem = new List<int>();
            DataGridViewRow objdgvr = new DataGridViewRow();

            for (int i = 0; i <= DgvOpenHoldJob.Rows.Count - 1; i++)
            {
                objdgvr = DgvOpenHoldJob.Rows[i];

                if (Convert.ToBoolean(objdgvr.Cells[0].Value) == true)
                {
                    int jobid = Convert.ToInt32(objdgvr.Cells[1].Value.ToString());
                    selecteditem.Add(jobid);
                }
            }
            foreach (int s in selecteditem)
            {
                int Status_ID = 16;
                ClsJob objobUpdatestatus = new ClsJob(s, Status_ID);
                objobUpdatestatus.UpdateJobStatus();
            }
            MessageBox.Show("Job Status Updated Successfully....");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
