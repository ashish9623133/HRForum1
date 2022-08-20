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
    public partial class frmAddCandidate : Form
    {
        string Full_Name;
        int Candidate_ID;

        

        public frmAddCandidate()
        {
            InitializeComponent();
        }

        public frmAddCandidate(int canid)
        {
            InitializeComponent();
            Candidate_ID = canid;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void educationQualificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUploadDocument objDocument=new frmUploadDocument();
            objDocument.Show();
            objDocument.MdiParent = this;
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Flag = "PI";
            frmPersonalInformation objPersonalInformation = new frmPersonalInformation(Flag);
            objPersonalInformation.Show();
            this.Hide();
          // btnUpdate.Hide();
          
            
        }

        private void educationQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEducationInformation objEducationalInfo=new frmEducationInformation();
            objEducationalInfo.Show();
            objEducationalInfo.MdiParent = this;
        }

        private void employmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmploymentDetails objEmploymentDetails =new frmEmploymentDetails();
            objEmploymentDetails.Show();
            objEmploymentDetails.MdiParent= this;
        }

        private void preferranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmPreferrence objPreferrance=new frmPreferrence();
            objPreferrance.Show();
            objPreferrance.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPersonalInformation objPI = new frmPersonalInformation(Candidate_ID);
            objPI.Show();
           
        }
    }
}
