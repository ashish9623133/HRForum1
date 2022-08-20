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
using System.Text.RegularExpressions;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class FrmCompanyRegistration : Form
    {
        int Status = 1;
        int Isdeleted = 0;
        string companyName, CompanyEmail, companyWebsite, CompanyAddress, HRnumber;
        public string CompanyID { get; set; }
        public FrmCompanyRegistration()
        {
            InitializeComponent();
        }

        private void FrmCompanyRegistration_Load(object sender, EventArgs e)
        {
            ClsCompany objCompany = new ClsCompany();
            DataTable dt = new DataTable();
            dt = objCompany.FetchCountry();
           
            cmbbxCountry.DisplayMember = "Country_Name";
            cmbbxCountry.ValueMember = "Country_ID";
            cmbbxCountry.DataSource = dt;
            cmbbxCountry.Text = "Select Country";


            ClsCompany objcompany = new ClsCompany();
            DataTable dt1 = new DataTable();
            dt1 = objcompany.FetchIndustry();

            cmbbxIndustry.DisplayMember = "Industry_Name";
            cmbbxIndustry.ValueMember = "Industry_ID";
            cmbbxIndustry.DataSource = dt1;
            //cmbbxIndustry.Text = "Select Industry";


        }

        private void btnAddMoreHR_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddIndustry_Click(object sender, EventArgs e)
        {
            FrmIndustry objIndustry = new FrmIndustry();
            objIndustry.Show();  
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please Enter Valid Company Email");
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

            if (DateTime.Today < dateTimePicker1.Value)
            {
                MessageBox.Show("Please Select Valid Date...!!!");
                dateTimePicker1.Value = DateTime.Today;
                return;


            }

            if (!Regex.Match(txtTwitter.Text, "^http(s{0,1})://[a-zA-Z0-9_/\\-\\.]+\\.([A-Za-z/]{2,5})[a-zA-Z0-9_/\\&\\?\\=\\-\\.\\~\\%]*").Success)   // Twitter Profile Validation
            {

                MessageBox.Show("Please Enter valid Twitter URL");
                txtTwitter.Focus();
                return;
            }


            if (cmbbxCountry.SelectedIndex == -1)//    Combobox Country Validation
            {
                MessageBox.Show("Please select Country");
                cmbbxCountry.Focus();
                return;
            }

            if (cmbbxState.SelectedIndex == -1)//    Combobox State Validation
            {
                MessageBox.Show("Please select State");
                cmbbxState.Focus();
                return;
            }

            if (cmbbxCity.SelectedIndex == -1)//    Combobox City Validation
            {
                MessageBox.Show("Please select City");
                cmbbxCity.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rchtxtAddress.Text))
            {
                rchtxtAddress.Focus();
                MessageBox.Show("Please fill Full Address");
            }

            if (!Regex.Match(txtHRname.Text, @"[A-Z][a-zA-Z]*$").Success)   //HRName Validation
            {

                MessageBox.Show("Please Entar Valid HR Name..!");
                txtHRname.Focus();
                return;
            }

            if (!Regex.Match(txtHRemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)   //HREmail Validation
            {
                MessageBox.Show("Please Enter Valid HR Email");
                txtHRemail.Focus();
                return;
            }

            if (!Regex.Match(txtPhoneNo.Text, "(0|91)?[7-9][0-9]{9}").Success)  // Mobile no. Validation
            {
                MessageBox.Show("Please Enter Valid Mobile Number");
                txtPhoneNo.Focus();
                return;
            }

            ClsCompany objCompn = new ClsCompany();
            DataTable dt1 = new DataTable();
            dt1 = objCompn.ExistCompany();
            foreach (DataRow row in dt1.Rows)
            {
                CompanyEmail = row["Company_Email"].ToString();

                companyWebsite = row["Company_Website"].ToString();
                CompanyAddress = row["Full_Address"].ToString();
                HRnumber = row["Phone_Number"].ToString();

                if (txtEmail.Text == CompanyEmail && txtWebsite.Text == companyWebsite && rchtxtAddress.Text == CompanyAddress && txtPhoneNo.Text == HRnumber)
                {
                    MessageBox.Show("Company Already Exist..!");
                    txtEmail.Focus();
                    txtWebsite.Focus();
                    rchtxtAddress.Focus();
                    txtPhoneNo.Focus();
                    return;
                }
            }



            int Industry_ID = Convert.ToInt32(cmbbxIndustry.SelectedValue.ToString());
            int City_ID = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());

            ClsCompany objCompany = new ClsCompany(txtName.Text, Industry_ID, rchtxtAddress.Text, City_ID, txtEmail.Text, txtOwner.Text, txtWebsite.Text, txtFacebook.Text, txtTwitter.Text, txtLinkedIn.Text, Status, Convert.ToDateTime(dateTimePicker1.Text), DateTime.Today, Isdeleted);

            objCompany.RegisterCompany();


            ClsCompany Objcompany = new ClsCompany();
            SqlDataReader dr;
            dr = Objcompany.FetchCompanyID();
            if (dr.Read())
            {
                CompanyID = dr["get"].ToString();

            }
            dr.Close();





            ClsCompany objcompany = new ClsCompany(Convert.ToInt32(CompanyID.ToString()), txtHRname.Text, txtHRemail.Text, txtPhoneNo.Text);
            objcompany.AddHR();
            MessageBox.Show("Registered Successfully..!");
            this.Close();

            FrmCompanyList objlist = new FrmCompanyList();
            objlist.Show();


        }


        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int State_ID = Convert.ToInt32(cmbbxState.SelectedValue.ToString());

            ClsCompany objcompany = new ClsCompany(State_ID);
            DataTable dt = new DataTable();
            dt = objcompany.FetchCity();

            cmbbxCity.DisplayMember = "City_Name";
            cmbbxCity.ValueMember = "City_ID";
            cmbbxCity.DataSource = dt;
            cmbbxCity.Text = "Select City";
        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryID  = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());

            ClsCompany objcompany = new ClsCompany(CountryID);
            DataTable dt = new DataTable();
            dt = objcompany.FetchState();

            cmbbxState.DisplayMember = "State_Name";
            cmbbxState.ValueMember = "State_ID";
            cmbbxState.DataSource = dt;
            cmbbxState.Text = "Select State";
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
            dateTimePicker1.Text = String.Empty;
            cmbbxIndustry.Text = String.Empty;
            cmbbxCountry.Text  = String.Empty;
            cmbbxState.Text= String.Empty;
            cmbbxCity.Text= String.Empty;
            txtHRname.Text= String.Empty;
            txtHRemail.Text= String.Empty;
            txtPhoneNo.Text= String.Empty;
            rchtxtAddress.Text = String.Empty;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validateName();

            //ClsCompany objcomp = new ClsCompany();
            //DataTable dt = new DataTable();
            //dt = objcomp.DuplicateCompany();

            //foreach (DataRow row in dt.Rows)
            //{
            //    companyName = row["Company_Name"].ToString();


            //    if (txtName.Text == companyName)   //Name Validation
            //    {

            //        MessageBox.Show("Company Name Already Exist..!");
            //        txtName.Focus();
            //        return;
            //    }

            //}
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validateEmail();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dateTimePicker1.Value)
            {
                MessageBox.Show("Please Select Valid Date...!!!");
                dateTimePicker1.Value = DateTime.Today;
                return;


            }
           
        }
        private bool validateOwnerName()
        {
            bool chk = false;
            Regex r = new Regex("[A-Z][a-zA-Z]*$");
            if (!(r.IsMatch(txtOwner.Text)) || txtOwner.Text == "")
            {
                errorProvider1.SetError(txtOwner, "Please Enter valid Owner Name");
                chk = true;
            }
            else
                errorProvider1.SetError(txtOwner, "");
            return chk;
        }

        private void txtOwner_TextChanged(object sender, EventArgs e)
        {
            validateOwnerName();
        }
    }
}
