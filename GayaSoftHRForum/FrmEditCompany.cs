using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class FrmEditCompany : Form
    {
        public static int Companyid { get; set; }

        public static string name { get; set; }
        public static string email { get; set; }

        public static string industryname { get; set; }
        public static string CompanyWebsite { get; set; }
        public static string CompanyOwner { get; set; }
        public static string Address { get; set; }
        public static string FacebookProfile { get; set; }
        public static string LinkedInProfile { get; set; }
        public static string TwitterProfile { get; set; }
        public FrmEditCompany()
        {
            InitializeComponent();
        }

        private void txtECName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmEditCompany_Load(object sender, EventArgs e)
        {

            ClsCompany objCompany = new ClsCompany();
            DataTable dt = new DataTable();
            dt = objCompany.FetchCountry();



            ClsCompany objcompany = new ClsCompany();
            DataTable dt1 = new DataTable();
            dt1 = objcompany.FetchIndustry();

            cmbbxIndustry.DisplayMember = "Industry_Name";
            cmbbxIndustry.ValueMember = "Industry_ID";
            cmbbxIndustry.DataSource = dt1;
            ////cmbbxIndustry.Text = "Select Industry";


            txtName.Text = FrmEditCompany.name;
            txtEmail.Text = FrmEditCompany.email;
            cmbbxIndustry.Text = FrmEditCompany.industryname;
            txtWebsite.Text = FrmEditCompany.CompanyWebsite;
            txtOwner.Text = FrmEditCompany.CompanyOwner;
            rchtxtAddress.Text = FrmEditCompany.Address;
            txtFacebook.Text = FrmEditCompany.FacebookProfile;
            txtLinkedIn.Text = FrmEditCompany.LinkedInProfile;
            txtTwitter.Text = FrmEditCompany.TwitterProfile;



           
        }

        private void btnAddIndustry_Click(object sender, EventArgs e)
        {
            FrmIndustry objIndustry = new FrmIndustry();
            objIndustry.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")   //Name Validation
            {

                MessageBox.Show("Please Enter Company Name");
                txtName.Focus();
                return;
            }
            if (!Regex.Match(txtName.Text, @"[A-Z][a-zA-Z]*$").Success)   //Name Validation
            {
                //  Name was incorrect  
                MessageBox.Show("Please Enter Valid Company Name...!!!");
                txtName.Focus();
                return;
            }

            if (!Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)   //Email Validation
            {
                MessageBox.Show("Please Enter Valid Email");
                txtEmail.Focus();
                return;
            }

            if (txtOwner.Text == "")   //Owner Name Validation
            {

                MessageBox.Show("Please Enter Company Owner Name");
                txtOwner.Focus();
                return;
            }
            if (!Regex.Match(txtOwner.Text, @"[A-Z][a-zA-Z]*$").Success)   //Name Validation
            {
                //  Name was incorrect  
                MessageBox.Show("Please Enter Valid Company Name...!!!");
                txtOwner.Focus();
                return;
            }
            if (cmbbxIndustry.SelectedIndex == -1)//    Combobox Industry Validation
            {
                MessageBox.Show("Please select Industry");
                cmbbxIndustry.Focus();
                return;
            }



            if (!Regex.Match(txtWebsite.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Website Validation
            {

                MessageBox.Show("Please Enter valid Website URL");
                txtWebsite.Focus();
                return;
            }

            if (!Regex.Match(txtFacebook.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Facebook Profile Validation
            {

                MessageBox.Show("Please Enter valid Facebook URL");
                txtFacebook.Focus();
                return;
            }

            if (!Regex.Match(txtLinkedIn.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // LinkedIn Profile Validation
            {

                MessageBox.Show("Please Enter valid LinkedIn URL");
                txtLinkedIn.Focus();
                return;
            }

            if (!Regex.Match(txtTwitter.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Twitter Profile Validation
            {

                MessageBox.Show("Please Enter valid Twitter URL");
                txtTwitter.Focus();
                return;
            }


            if (string.IsNullOrEmpty(rchtxtAddress.Text))
            {
                rchtxtAddress.Focus();
                MessageBox.Show("Please fill Full Address");
            }


            int Industry_ID = Convert.ToInt32(cmbbxIndustry.SelectedValue.ToString());
            ClsCompany objCompany = new ClsCompany(FrmEditCompany.Companyid, txtName.Text, txtEmail.Text, Industry_ID, txtWebsite.Text, txtOwner.Text, rchtxtAddress.Text, txtFacebook.Text, txtLinkedIn.Text, txtTwitter.Text);
            objCompany.UpdateCompany();
            MessageBox.Show("Updated Successfully..!");


            FrmCompanyList objlist = new FrmCompanyList();
            objlist.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty; 
            txtEmail.Text = String.Empty;
            txtOwner.Text = String.Empty;
            txtWebsite.Text = String.Empty;
            txtFacebook.Text = String.Empty;
            txtLinkedIn.Text = String.Empty;
            txtTwitter.Text = String.Empty;
            cmbbxIndustry.Text = String.Empty;
            rchtxtAddress.Text = String.Empty;
        }

        private void rchtxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCompany objcompany = new ClsCompany();
            DataTable dt1 = new DataTable();
            dt1 = objcompany.FetchIndustry();

            cmbbxIndustry.DisplayMember = "Industry_Name";
            cmbbxIndustry.ValueMember = "Industry_ID";
            cmbbxIndustry.DataSource = dt1;
        }
        private bool validateName()
        {

            bool chk = false;
            Regex r = new Regex(@"[A-Z][a-zA-Z]*$");

            if (!(r.IsMatch(txtName.Text)) || txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please Enter Valid Company Name");
                chk = true;
            }
            else
                errorProvider1.SetError(txtName, "");
            return chk;


        }
        private bool validateEmail()
        {
            bool chk = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!(r.IsMatch(txtEmail.Text)) || txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Please Enter valid Company Email");
                chk = true;
            }
            else
                errorProvider1.SetError(txtEmail, "");
            return chk;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validateEmail();
        }
    }
}
