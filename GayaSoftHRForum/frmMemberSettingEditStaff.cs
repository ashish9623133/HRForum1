using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class frmMemberSettingEditStaff : Form
    {
        int Staff_Register_ID;
        string Gender;
        public frmMemberSettingEditStaff()
        {
            InitializeComponent();

        }
        public frmMemberSettingEditStaff(int sid)
        {
            InitializeComponent();
             Staff_Register_ID = sid;
        }

        private void lblmobileno_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberSettingEditStaff_Load(object sender, EventArgs e)
        {
            ClsStaffRegistration objclsStaffRegistration = new ClsStaffRegistration();
            DataTable dt = new DataTable();
            dt = objclsStaffRegistration.countrybind();
            cmbbxcountry.DisplayMember = "Country_Name";
            cmbbxcountry.ValueMember = "Country_ID";
            cmbbxcountry.DataSource = dt;
            cmbbxcountry.Text = "Select Country";

            ClsStaffRegistration objobjclsStaffRegistration = new ClsStaffRegistration();
            DataTable dt1 = new DataTable();
            dt = objobjclsStaffRegistration.Positionbind();
            cmbbxposition.DisplayMember = "Position_Name";
            cmbbxposition.ValueMember = "Position_ID";
            cmbbxposition.DataSource = dt;
            cmbbxposition.Text = "Select Position";


            ClsStaffRegistration objFetchStaffDetails = new ClsStaffRegistration(Staff_Register_ID);
            SqlDataReader dr;
            dr = objFetchStaffDetails.FetchEditStaff();
            if (dr.Read())
            {
                txtfullname.Text = dr["Full_Name"].ToString();
                txtemailid.Text = dr["Email_ID"].ToString();
                txtmobileno.Text = dr["Mobile_No"].ToString();
                txtpincode.Text = dr["Pincode"].ToString();
                txtaddress.Text = dr["Address"].ToString();
                if (dr["Gender"].ToString() == "Male")
                {
                    rdbtnmale.Checked = true;
                }
                if (dr["Gender"].ToString() == "Female")
                {
                    rdbtnfemale.Checked = true;
                }

               string Country_Name = dr["Country_Name"].ToString();
               string State_Name = dr["State_Name"].ToString();
                string City_Name = dr["City_Name"].ToString();
                string Position = dr["Position_Name"].ToString();

                cmbbxcountry.Text = Country_Name;
                cmbbxstate.Text = State_Name;
                cmbbxcity.Text = City_Name;
                cmbbxposition.Text = Position;

                DTPdob.Text = dr["DOB"].ToString();
            }

        }

        private void lblmobileno_Click_1(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (rdbtnmale.Checked == true)
            {
                Gender = "Male";
            }
            if (rdbtnfemale.Checked == true)
            {
                Gender = "Female";
            }
            ClsStaffRegistration objUpdateStaff = new ClsStaffRegistration(Staff_Register_ID,txtfullname.Text,txtemailid.Text,txtmobileno.Text,Convert.ToDateTime(DTPdob.Text),Gender,txtaddress.Text,Convert.ToInt32(cmbbxcity.SelectedValue.ToString()),Convert.ToInt32(txtpincode.Text),Convert.ToInt32(cmbbxposition.SelectedValue.ToString()));
            objUpdateStaff.UpdateStaff();
            MessageBox.Show("Staff Details Updated Successfully...!!!");
            Add_member objMember = new Add_member();
            objMember.Show();
                
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
            ClsStaffRegistration objclsStaffRegistration = new ClsStaffRegistration(State_ID);
            DataTable dt = new DataTable();
            dt = objclsStaffRegistration.Citybind();

            cmbbxcity.DisplayMember = "City_Name";
            cmbbxcity.ValueMember = "City_ID";
            cmbbxcity.DataSource = dt;
            cmbbxcity.Text = "select City";
        }
    }
}
