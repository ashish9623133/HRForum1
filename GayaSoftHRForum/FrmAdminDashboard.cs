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
using System.Data.SqlClient;
using System.Data;
namespace GayaSoftHRForum
{
    public partial class FrmAdminDashboard : Form
    {
        int Staff_Register_Id;
        string Email;

        public FrmAdminDashboard()
        {
            InitializeComponent();
           // IsMdiContainer = true;
        }

        public FrmAdminDashboard(int staff_Register_Id, string email)
        {
            InitializeComponent();
            Staff_Register_Id = staff_Register_Id;
            Email = email;
        }
        private DataTable JobData()
        {
            DataTable dt = new DataTable();
            ClsJob objob = new ClsJob();
            SqlDataReader dr;
            dr = objob.JobGraph();
            dt.Load(dr);
            return dt;
        }

        private DataTable CompanyData()
        {
            DataTable dt = new DataTable();
            ClsCompany objcompany = new ClsCompany();
            SqlDataReader dr;
            dr = objcompany.CompanyGraph();
            dt.Load(dr);
            return dt;
        }


        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {

                this.IsMdiContainer = true;
                ClsJob objNotification = new ClsJob();
                DataTable dt1 = new DataTable();
                dt1 = objNotification.CheckedForClosedJob();

                int count2 = dt1.Rows.Count;
                if (count2 > 0)
                {
                    ClsJob obj = new ClsJob();
                    SqlDataReader dr;
                    dr = obj.NotificationForClosedJob();
                    if (dr.Read())
                    {
                        int count = Convert.ToInt32(dr["OpenHoldJobs"]);
                        FrmNotification_For_Closed_Job objnotificationclosed = new FrmNotification_For_Closed_Job(count);
                        objnotificationclosed.Show();
                    }


                }

                // Daily Line Up Graph

                ClsCandidateRegistration ObjLineupGraph = new ClsCandidateRegistration();
                DataTable dt = new DataTable();
                dt = ObjLineupGraph.GetLineUpGraph();
                DataRow row = dt.Rows[0];
                var test = row["Placed_candiates"];

                DataRow row1 = dt.Rows[0];
                var test1 = row["On_Hold"];

                DataRow row2 = dt.Rows[0];
                var test2 = row["Interviewed"];

                DataRow row3 = dt.Rows[0];
                var test3 = row["Assigned"];

                DataRow row4 = dt.Rows[0];


                this.chart6.Series["Daily LineUp Graph"].Points.AddXY("Placed_candiates", test);
                this.chart6.Series["Daily LineUp Graph"].Points.AddXY("On_Hold", test1);
                this.chart6.Series["Daily LineUp Graph"].Points.AddXY("Interviewed", test2);
                this.chart6.Series["Daily LineUp Graph"].Points.AddXY("Assigned", test3);



                // Candidate Graph


                ClsCandidateRegistration objCandidateGraph = new ClsCandidateRegistration();

                DataTable dt2 = new DataTable();
                dt2 = objCandidateGraph.GetCandidateCount();

                DataRow graph = dt2.Rows[0];
                var Candi = graph["placed"];

                DataRow graph1 = dt2.Rows[0];
                var Candi1 = graph["Assigned"];

                DataRow graph2 = dt2.Rows[0];
                var Candi2 = graph["Interview_Scheduled"];

                DataRow graph3 = dt2.Rows[0];
                var Candi3 = graph["Interview_Not_Attended"];

                DataRow graph4 = dt2.Rows[0];
                var Candi4 = graph["Rejected"];

                DataRow graph5 = dt2.Rows[0];
                var Candi5 = graph["Interview_Resecheduled"];

                DataRow graph6 = dt2.Rows[0];
                var Candi6 = graph["Offered"];

                DataRow graph7 = dt2.Rows[0];
                var Candi7 = graph["On_Hold"];

                DataRow graph8 = dt2.Rows[0];
                var Candi8 = graph["Selected"];


                this.chart5.Series["Candidate_Count"].Points.AddXY("placed", Candi);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Assigned", Candi1);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Interview_Scheduled", Candi2);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Interview_Not_Attended", Candi3);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Rejected", Candi4);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Interview_Resecheduled", Candi5);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Offered", Candi6);
                this.chart5.Series["Candidate_Count"].Points.AddXY("On_Hold", Candi7);
                this.chart5.Series["Candidate_Count"].Points.AddXY("Selected", Candi8);



                //Job Graph

                chart1.DataSource = JobData();
                chart1.Series["Open Job"].XValueMember = "Job_Title";
                chart1.Series["Open Job"].YValueMembers = "Open_Job";

                chart1.Series["Closed Job"].XValueMember = "Job_Title";
                chart1.Series["Closed Job"].YValueMembers = "Closed_Job";

                chart1.Series["Hold Job"].XValueMember = "Job_Title";
                chart1.Series["Hold Job"].YValueMembers = "Hold_Job";

                chart1.Show();

                //Company Graph

                chart4.DataSource = CompanyData();
                chart4.Series["Open Job"].XValueMember = "Company_Name";
                chart4.Series["Open Job"].YValueMembers = "Open_Job";

                chart4.Series["Closed Job"].XValueMember = "Company_Name";
                chart4.Series["Closed Job"].YValueMembers = "Closed_Job";

                chart4.Series["Hold Job"].XValueMember = "Company_Name";
                chart4.Series["Hold Job"].YValueMembers = "Hold_Job";

                chart4.Show();

            
        }

        private void btncandidate_Click(object sender, EventArgs e)
        {
            //DailyLineUp.Hide();
            //CandidateGraph.Hide();
            chart6.Hide();
            chart5.Hide();
            chart1.Hide();
            chart4.Hide();
            //flowLayoutPanel1.Hide();

            FrmCandidateLDashBoard objCandidateDashboard = new FrmCandidateLDashBoard();
            objCandidateDashboard.MdiParent = this;
            objCandidateDashboard.Show();
        }

        private void btncompany_Click(object sender, EventArgs e)
        {
            //DailyLineUp.Hide();
            //CandidateGraph.Hide();
            chart6.Hide();
            chart5.Hide();
            chart1.Hide();
            chart4.Hide();
            //flowLayoutPanel1.Hide();
            Company_Dashboard objcompanydashbaord = new Company_Dashboard(Staff_Register_Id);

            objcompanydashbaord.MdiParent = this;

            objcompanydashbaord.Show();
        }

        private void btnjob_Click(object sender, EventArgs e)
        {
            //DailyLineUp.Hide();
            //CandidateGraph.Hide();
            chart6.Hide();
            chart5.Hide();
            chart1.Hide();
            chart4.Hide();
            //flowLayoutPanel1.Hide();

            Frmjobdash objjobdash = new Frmjobdash(Staff_Register_Id);
            objjobdash.MdiParent = this;
            objjobdash.Show();

        }

        private void btnlineup_Click(object sender, EventArgs e)
        {
            //DailyLineUp.Hide();
            //CandidateGraph.Hide();
            chart6.Hide();
            chart5.Hide();
            chart1.Hide();
            chart4.Hide();
            //flowLayoutPanel1.Hide();

            FrmLineUp objlineup = new FrmLineUp(Staff_Register_Id);

            objlineup.MdiParent = this;

            objlineup.Show();
        }

        private void btnhrdashboard_Click(object sender, EventArgs e)
        {
            FrmAdminDashboard obj = new FrmAdminDashboard(/*Staff_Register_Id*/);
            obj.Show();
        }

        private void btnMemberSetting_Click(object sender, EventArgs e)
        {
            Add_member obj = new Add_member();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmail obj = new FrmEmail(Email);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Edit obj = new Admin_Edit(Staff_Register_Id);
            obj.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AllReports obj = new AllReports();
            obj.Show();
        }

        private void btnMemberSetting_Click_1(object sender, EventArgs e)
        {
            Add_member objadd = new Add_member();
            objadd.Show();
        }

        private void btnlogo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin objlogout = new FrmLogin();
            objlogout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAdminCompany obj = new FrmAdminCompany();
            obj.Show();
            
        }
    }
}
