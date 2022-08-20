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
    public partial class FrmJobList : Form
    {
        //public int Job_ID, JID;
        public string Job_title;
        public int Staff_Register_Id;

        public FrmJobList()
        {
            InitializeComponent();
        }
        public FrmJobList(int staff_id)
        {
            InitializeComponent();
            Staff_Register_Id = staff_id;
        }
        public FrmJobList(string job_title, int staff_id)
        {
            InitializeComponent();
            Job_title = job_title;
            Staff_Register_Id = staff_id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void JobList_Load(object sender, EventArgs e)
        {
            ClsJob obj =new ClsJob (Job_title);
            DataTable dt = new DataTable();
            dt = obj.joblist();
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Job_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                Candidate_Pipeline obj = new Candidate_Pipeline(Job_ID, Staff_Register_Id);
                obj.Show();

          //      job_title obj.label6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          //     CompanyName name obj.label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          //    address  obj.label8.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          //   city   obj.label9.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          //min exp   obj.label10.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
          //  max exp    obj.label18.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          //    min salry  obj.label19.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
          //     max salary  obj.label20.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
          //   openings   obj.label21.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
          //     hrname obj.label22.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
          //    hr email  obj.label23.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
          //    hr phone  obj.label24.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            }

            if (e.ColumnIndex == 2)
            {
                int Job_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                ClsJob objjob = new ClsJob(Job_ID);
                objjob.deleteJob();
                MessageBox.Show("Delete Data Successfully..!");
            }

            if (e.ColumnIndex == 1)
            {

                int Job_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                Update_Job updjob = new Update_Job(Job_ID);
                updjob.Show();

                updjob.txtjobtital.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updjob.cmbbxcompany.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updjob.txtrichfulladdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updjob.cmbbxminexp.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                updjob.cmbbxmaxExp.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                updjob.txtminsalary.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                updjob.txtmaxsalary.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                updjob.txtnumbropening.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
               
               
                
              //  updjob.txtskills.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                

            }
        }
    }
}
