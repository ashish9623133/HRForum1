using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class Individual_Companywise_Job_Opening_List : Form
    {

        public int Company_ID, ComID, Staff_ID;
       
        public Individual_Companywise_Job_Opening_List(int company_id,int staff_id)
        {
            InitializeComponent();
            Company_ID = company_id;
            Staff_ID = staff_id;
        }

        private void grdIndividualCompanywiseOpeningList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHrName_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenJob_Click(object sender, EventArgs e)
        {
            Open_Jobs_Details obj = new Open_Jobs_Details(Company_ID,Staff_ID);
            obj.Show();
        }

        private void btnClosedJob_Click(object sender, EventArgs e)
        {
            Closed_Jobs_Details obj = new Closed_Jobs_Details(Company_ID);
            obj.Show();
        }

        private void grdIndividualCompanywiseOpeningList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Individual_Companywise_Job_Opening_List_Load(object sender, EventArgs e)
        {
            ClsCompany obj = new ClsCompany(Company_ID);
            SqlDataReader dr;
            dr = obj.ShowIndividual_Company_Details();
            if (dr.Read())
            {
                lblCompanyName.Text = dr["Company_Name"].ToString();
                lblIndustryName.Text = dr["Industry_Name"].ToString();
                lblEmailID.Text = dr["Company_Email"].ToString();
                lblWebsiteName.Text = dr["Company_Website"].ToString();
                lblCompanyAddress.Text = dr["Full_Address"].ToString();
                lblTwitterURL.Text = dr["Twitter_Profile_URL"].ToString();
                lblLinkedInURL.Text = dr["LinkedIn_Profile_URL"].ToString();
                DateTime cregdate =Convert.ToDateTime (dr["Company_Registration_Date"]);
                lblCompanyRegDate.Text= cregdate.ToShortDateString();
                lblHrName.Text = dr["HR_Name"].ToString();
            }


            ClsCompany objIndividual_Companywise_Job_Opening_List = new ClsCompany(Company_ID);
            DataTable dt = new DataTable();
            dt = objIndividual_Companywise_Job_Opening_List.ShowIndividual_Companywise_Job_Opening_List();
            grdIndividualCompanywiseOpeningList.DataSource = dt;
            grdIndividualCompanywiseOpeningList.Show();

        }
    }
}
