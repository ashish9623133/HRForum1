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
    public partial class frmPersonalInformation : Form
    {
       
        string Gender,Country_Name, State_Name,City_Name, Em_ID, CoNO, Flag;
        public  int City,State_ID, Country_ID,Candidate_ID,City_ID;
        DateTime DOB, Registration_Date;
        public frmPersonalInformation()
        {
            InitializeComponent();
        }
        public frmPersonalInformation(int canid)
        {
            InitializeComponent();
            Candidate_ID = canid;


        }
        public frmPersonalInformation(int canid, string flag1)
        {
            InitializeComponent();
            Candidate_ID = canid;
            Flag = flag1;


        }
        public frmPersonalInformation(string flag)
        {
            InitializeComponent();
            Flag = flag;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmAddCountry objCountry = new frmAddCountry();
            objCountry.Show();
            
        }

        private void frmPersonalInformation_Load(object sender, EventArgs e)
        {
            if (Flag == "PI")
            {
                btnUpdatePI.Hide();

            }

            if (Flag == "EditPI")
            {
                btnSavePersonalInfo.Text = "Cancel";

            }
            else
            {
                btnSavePersonalInfo.Text = "Next";
            }




            ClsCandidateRegistration objShowCountry = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt = objShowCountry.FetchCountry();

            cmbbxCountry.ValueMember = "Country_ID";
            cmbbxCountry.DisplayMember = "Country_Name";
            cmbbxCountry.DataSource = dt;




            ClsCandidateRegistration objLoadPI = new ClsCandidateRegistration(Candidate_ID);
            SqlDataReader dr;
            dr = objLoadPI.UpdatePI();
            if (dr.Read())
            {
                txtFullName.Text = dr["Full_Name"].ToString();
                txtEmailID.Text = dr["Email_ID"].ToString();
                txtContactNo.Text = dr["Contact_NO"].ToString();
                txtAddress.Text = dr["Address"].ToString();

                if (dr["Gender"].ToString() == "Male")
                {
                    rdbbtnMale.Checked = true;
                }
                if (dr["Gender"].ToString() == "Female")
                {
                    rdbbtnFemale.Checked = true;
                }
                if (dr["Gender"].ToString() == "Other")
                {
                    rdbbtnOther.Checked = true;
                }

                Country_Name = dr["Country_Name"].ToString();
                State_Name = dr["State_Name"].ToString();
                City_Name = dr["City_Name"].ToString();

                cmbbxCountry.Text = Country_Name;
                cmbbxState.Text = State_Name;
                cmmbxCity.Text = City_Name;




                dateTimeDob.Text = dr["DOB"].ToString();

            }




        }

        private void lblAddState_Click(object sender, EventArgs e)
        {
            frmAddState objAddState=new frmAddState();
            objAddState.Show();
            
        }

        private void lblAddCity_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country_ID=Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            ClsCandidateRegistration objShowState = new ClsCandidateRegistration(Country_ID);
            DataTable dt = new DataTable();
            dt = objShowState.FetchState();

            cmbbxState.ValueMember = "State_ID";
            cmbbxState.DisplayMember = "State_Name";
            cmbbxState.DataSource = dt;

            cmbbxState.Text = "Select State";
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            State_ID = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            
            ClsCandidateRegistration objShowCity = new ClsCandidateRegistration(State_ID);
            DataTable dt1 = new DataTable();
            dt1 = objShowCity.FetchCity();
            
            cmmbxCity.ValueMember = "City_ID";
            cmmbxCity.DisplayMember = "City_Name";
            cmmbxCity.DataSource = dt1;

            cmmbxCity.Text = "Select City";
        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "PI")
            {
                ClsCandidateRegistration objDataDup = new ClsCandidateRegistration();
                DataTable dt1 = new DataTable();
                dt1 = objDataDup.DataDuplication();

                foreach (DataRow row in dt1.Rows)
                {
                    Em_ID = row["Email_ID"].ToString();

                    if (Em_ID == txtEmailID.Text)
                    {
                        MessageBox.Show("Email_ID is Already Exist...!!!");
                        txtEmailID.Clear();
                        txtEmailID.Focus();
                        this.Refresh();
                        return;
                    }

                }
            }

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "PI")
            {
                ClsCandidateRegistration objDataDup = new ClsCandidateRegistration();
                DataTable dt1 = new DataTable();
                dt1 = objDataDup.DataDuplication();

                foreach (DataRow row in dt1.Rows)
                {

                    CoNO = row["Contact_No"].ToString();

                    if (CoNO == txtContactNo.Text)
                    {
                        MessageBox.Show("Contact No is Already exixt...!!!");
                        txtContactNo.Clear();
                        txtContactNo.Focus();
                        this.Refresh();
                        return;

                    }
                }

            }

        }

    private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbbxCountry_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbxCountry.Refresh();
            ClsCandidateRegistration objShowCountry = new ClsCandidateRegistration();
            _ = new DataTable();
            DataTable dt = objShowCountry.FetchCountry();

            cmbbxCountry.ValueMember = "Country_ID";
            cmbbxCountry.DisplayMember = "Country_Name";
            cmbbxCountry.DataSource = dt;
            cmbbxCountry.Update();
        }

        private void txtEmailID_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtEmailID_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbbxState_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbxState.Refresh();
            Country_ID = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            ClsCandidateRegistration objShowState = new ClsCandidateRegistration(Country_ID);
            DataTable dt = new DataTable();
            dt = objShowState.FetchState();

            cmbbxState.ValueMember = "State_ID";
            cmbbxState.DisplayMember = "State_Name";
            cmbbxState.DataSource = dt;

            cmbbxState.Update();
        }

        private void cmmbxCity_MouseClick(object sender, MouseEventArgs e)
        {
            cmmbxCity.Refresh();
            State_ID = Convert.ToInt32(cmbbxState.SelectedValue.ToString());

            ClsCandidateRegistration objShowCity = new ClsCandidateRegistration(State_ID);
            DataTable dt1 = new DataTable();
            dt1 = objShowCity.FetchCity();

            cmmbxCity.ValueMember = "City_ID";
            cmmbxCity.DisplayMember = "City_Name";
            cmmbxCity.DataSource = dt1;

            cmmbxCity.Update();
        }

        private void btnUpdatePI_Click(object sender, EventArgs e)
        {
            frmEducationInformation objFetchEI=new frmEducationInformation(Flag,Candidate_ID);
            objFetchEI.Show();

            if (rdbbtnMale.Checked == true)
            {
                Gender = "Male";
            }
            if (rdbbtnFemale.Checked == true)
            {
                Gender = "Female";
            }
            if (rdbbtnOther.Checked == true)
            {
                Gender = "Other";
            }
            DateTime DOB = Convert.ToDateTime(dateTimeDob.Text);
            int City_ID = Convert.ToInt32(cmmbxCity.SelectedValue.ToString());
            ClsCandidateRegistration objUpdatePerInfo=new ClsCandidateRegistration(Candidate_ID,txtFullName.Text,  txtEmailID.Text, Gender,  txtContactNo.Text, DOB, City_ID, txtAddress.Text);
            objUpdatePerInfo.UpdatePerInfo();
            this.Hide();

        }

        private void btnSavePersonalInfo_Click(object sender, EventArgs e)
        {
            if (btnSavePersonalInfo.Text == "Cancel")
            {
                this.Close();
                FrmCandidateList obj = new FrmCandidateList();
                obj.Show();
            }
            if (btnSavePersonalInfo.Text == "Next")
            {
                ClsCandidateRegistration objDataDup = new ClsCandidateRegistration();
                DataTable dt1 = new DataTable();
                dt1 = objDataDup.DataDuplication();

                foreach (DataRow row in dt1.Rows)
                {
                    Em_ID = row["Email_ID"].ToString();
                    CoNO = row["Contact_No"].ToString();
                    if (Em_ID == txtEmailID.Text)
                    {
                        MessageBox.Show("Email_ID is Already Exist...!!!");
                        txtEmailID.Clear();
                        return;
                    }
                    if (CoNO == txtContactNo.Text)
                    {
                        MessageBox.Show("Contact No is Already exixt...!!!");
                        txtContactNo.Clear();
                        return;

                    }
                }



                if (!Regex.Match(txtFullName.Text, @"[A-Z][a-zA-Z]*$").Success)   //Name Validation
                {
                    //  Name was incorrect  
                    MessageBox.Show("Please Enter Valid Name...!!!");
                    txtFullName.Focus();
                    return;
                } // end if
                if (!Regex.Match(txtEmailID.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)   //Email Validation
                {
                    MessageBox.Show("Please Enter Valid Email", "Message");
                    txtEmailID.Focus();
                    return;
                }
                if (!(this.rdbbtnMale.Checked || this.rdbbtnFemale.Checked || rdbbtnOther.Checked)) // Gender Validation

                {
                    MessageBox.Show("Please Select Gender");

                    return;

                }
                if (!Regex.Match(txtContactNo.Text, "(0|91)?[7-9][0-9]{9}").Success)  // Mobile Validation
                {
                    MessageBox.Show("Enter Valid Mobile Number", "Message");
                    txtContactNo.Focus();
                    return;
                }
                if (cmbbxCountry.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select Country");
                    cmbbxCountry.Focus();
                    return;
                }
                if (cmbbxState.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select State");
                    cmbbxState.Focus();
                    return;
                }
                if (cmmbxCity.SelectedIndex == -1)//    Combobox Type Validation
                {
                    MessageBox.Show("Please select City");
                    cmmbxCity.Focus();
                    return;
                }


                DateTime bday = DateTime.Parse(dateTimeDob.Text);
                DateTime today = DateTime.Today;
                int age = today.Year - bday.Year;
                if (age < 18)
                {
                    MessageBox.Show("Invalid Birth Day");
                    return;
                }





                if (rdbbtnMale.Checked == true)
                {
                    Gender = "Male";
                }
                if (rdbbtnFemale.Checked == true)
                {
                    Gender = "Female";
                }
                if (rdbbtnOther.Checked == true)
                {
                    Gender = "Other";
                }
                DateTime DOB = Convert.ToDateTime(dateTimeDob.Text);
                int City_ID = Convert.ToInt32(cmmbxCity.SelectedValue.ToString());
                frmEducationInformation objEducationalInfo = new frmEducationInformation(Flag,txtFullName.Text, txtEmailID.Text, Gender, txtContactNo.Text, DOB, City_ID, txtAddress.Text);
                objEducationalInfo.Show();
                this.Hide();
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dateTimeDob_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            frmAddCity objAddCity = new frmAddCity();
            objAddCity.Show();
            //objAddCity.MdiParent = this;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }
    }
}
