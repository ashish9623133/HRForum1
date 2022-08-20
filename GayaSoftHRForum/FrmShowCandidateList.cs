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
using GayaSoftHRForum;

namespace GayaSoftHRForum
{
    public partial class FrmShowCandidateList : Form
    {
        public int cid;
        public int cityid;
        public string Position;
        public int totalEXP;
        public string currCTC;
        public string expCTC, JobTitle;


        public FrmShowCandidateList()
        {
            InitializeComponent();
        }

       public FrmShowCandidateList(string jobtitle)
        {
            InitializeComponent();
            JobTitle = jobtitle;

        }



        private void frm_Candidate_List_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration obj = new ClsCandidateRegistration(JobTitle);
            DataTable dt = new DataTable();
            dt = obj.ShowCandidateList();
            grdViewCandidateShowL.DataSource = dt;
            grdViewCandidateShowL.Show();

            this.grdViewCandidateShowL.Columns["City_ID"].Visible = false;
            this.grdViewCandidateShowL.Columns["Candidate_ID"].Visible = false;
            this.grdViewCandidateShowL.Columns["Job_ID"].Visible = false;


        }

        private void grdViewCandidateShowL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

                int CID = Convert.ToInt32(grdViewCandidateShowL.CurrentRow.Cells[9].Value.ToString());
                string Full_name = grdViewCandidateShowL.CurrentRow.Cells[2].Value.ToString();
                string email = grdViewCandidateShowL.CurrentRow.Cells[3].Value.ToString();
                string contact = grdViewCandidateShowL.CurrentRow.Cells[4].Value.ToString();
                string gender = grdViewCandidateShowL.CurrentRow.Cells[5].Value.ToString();
                DateTime DOB = Convert.ToDateTime(grdViewCandidateShowL.CurrentRow.Cells[6].Value.ToString());
               string cityname =grdViewCandidateShowL.CurrentRow.Cells[7].Value.ToString();
                frmDetails obj = new frmDetails(CID,Full_name,Position,email,contact,gender,DOB,cityname,Convert.ToString(totalEXP), currCTC, expCTC);
                obj.Show();
              
        }
    }
}
