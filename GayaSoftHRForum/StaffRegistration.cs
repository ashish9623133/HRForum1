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
using System.Text.RegularExpressions;


namespace GayaSoftHRForum
{
    public partial class StaffRegistration : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIIO9S3\\MSSQLSERVER01;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        string gen = null;
        public StaffRegistration()
        {
            InitializeComponent();
           // IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsStaffRegistration objclsStaffRegistration = new ClsStaffRegistration();
            DataTable dt = new DataTable();
            dt=objclsStaffRegistration.countrybind();
            cmbbxcountry.DisplayMember = "Country_Name";
            cmbbxcountry.ValueMember = "Country_ID";
            cmbbxcountry.DataSource = dt;
            cmbbxcountry.Text = "Select Country";

            ClsStaffRegistration objobjclsStaffRegistration =new ClsStaffRegistration();
            DataTable dt1 = new DataTable();
            dt = objobjclsStaffRegistration.Positionbind();
            cmbbxposition.DisplayMember = "Position_Name";
            cmbbxposition.ValueMember = "Position_ID";
            cmbbxposition.DataSource = dt;
            cmbbxposition.Text = "Select Position";
        }

        private void lblRegisterAcccount_Click(object sender, EventArgs e) { }
        
        private void btnregister_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txtfullname.Text, @"[A-Z][a-zA-Z]*$").Success)   //Name Validation
            {
                //  Name was incorrect  
                MessageBox.Show("Please Name character");
                txtfullname.Focus();
                return;
            } // end if

            if (!Regex.Match(txtemailid.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)   //Email Validation
            {
                MessageBox.Show("Please Enter Valid Email", "Message");
                txtemailid.Focus();
                return;
            }
            if (!Regex.Match(txtconfirmemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)   //Email Validation
            {
                MessageBox.Show("Please Enter Valid Confirm Email", "Message");
                txtconfirmemail.Focus();
                return;
            }

            if (!Regex.Match(txtpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$").Success)  // Password Validation
            {
                MessageBox.Show("Please Valid Password...At least one lower case letter,At least one upper case letter,At least special character,At least one number, At least 8 characters length");
                txtpassword.Focus();
                return;
            }

            if (!Regex.Match(txtconfirmpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$").Success)  // Password Validation
            {
                MessageBox.Show(" Please Confirm Valid Password...At least one lower case letter,At least one upper case letter,At least special character,At least one number, At least 8 characters length");
                txtconfirmpassword.Focus();
                return;
            }

            // if (!Regex.Match(txtmobileno.Text, @"^(0|91)?[7-9][0-9]{9}").Success)  // Mobile Validation
            //if (!Regex.Match(txtmobileno.Text, "(0|91)?[7-9][0-9]{9}").Success)  // Mobile Validation
            if (!Regex.Match(txtmobileno.Text, "^[7-9][0-9]{9}$").Success)  // Mobile Validation
            {
                MessageBox.Show("Enter Valid Mobile Number", "Message");
                txtmobileno.Focus();
                return;
            }

            if (!Regex.Match(txtpincode.Text, "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$").Success)  // Pincode Validation
            {
                MessageBox.Show("Enter 6 Digit Pincode", "Message");
                txtpincode.Focus();
                return;
            }

            if (rdbtnfemale.Checked == true)
            {

                gen = "Female";
            }
            if (rdbtnmale.Checked == true)
            {
              gen = "Male";
            }

         

            ClsStaffRegistration objstaffregistration = new ClsStaffRegistration(txtfullname.Text, txtemailid.Text, txtpassword.Text,
                txtmobileno.Text, Convert.ToDateTime(DTPdob.Text), gen, txtaddress.Text, 
                Convert.ToInt32(cmbbxcity.SelectedValue), Convert.ToInt32(txtpincode.Text), Convert.ToInt32(cmbbxposition.SelectedValue));

                    objstaffregistration.Staffregisterdata();
            MessageBox.Show("Staff Register Successfully");

            FrmLogin objfrmLogin = new FrmLogin();
            objfrmLogin.Show();
           // objfrmLogin.MdiParent = this;

        }

        private void cmbbxcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Country_ID = Convert.ToInt32(cmbbxcountry.SelectedValue.ToString());
            ClsStaffRegistration objclsStaffRegistration = new ClsStaffRegistration(Country_ID);
            DataTable dt = new DataTable();
            dt = objclsStaffRegistration.Statebind();

            cmbbxstate.DisplayMember = "State_Name";
            cmbbxstate.ValueMember = "State_ID";
            cmbbxstate.DataSource = dt;
            cmbbxstate.Text = "Select State";
        }

        private void cmbbxstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int State_ID = Convert.ToInt32(cmbbxstate.SelectedValue.ToString());
            ClsStaffRegistration objclsStaffRegistration =new ClsStaffRegistration(State_ID);
            DataTable dt = new DataTable();
            dt = objclsStaffRegistration.Citybind();

            cmbbxcity.DisplayMember = "City_Name";
            cmbbxcity.ValueMember = "City_ID";
            cmbbxcity.DataSource = dt;
            cmbbxcity.Text = "select City";

        }
        private void DTPdob_ValueChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}

