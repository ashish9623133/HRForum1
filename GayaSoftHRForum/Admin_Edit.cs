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


namespace GayaSoftHRForum
{
    public partial class Admin_Edit : Form
    {
        int ID = 2;
        string photo_Location;
        int Staff_Register_Id;
        public Admin_Edit()
        {
            InitializeComponent();
        }
        public Admin_Edit( int staffid)
        {
            InitializeComponent();
            Staff_Register_Id = staffid;
        }

        private void Admin_Edit_Load(object sender, EventArgs e)
        {
            
            
            ClsStaffRegistration objGetdata = new ClsStaffRegistration(Staff_Register_Id);
            SqlDataReader dr;
            dr = objGetdata.GetData();
            if (dr.Read())
            {
                
                txtAdmin_Name.Text = dr["Full_Name"].ToString();
                txtEmail_Id.Text = dr["Email_ID"].ToString();
                txtMobile_No.Text = dr["Mobile_No"].ToString();
                txtOld_Password.Text = dr["Password"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClsStaffRegistration objAdmin = new ClsStaffRegistration(Staff_Register_Id,txtAdmin_Name.Text, txtEmail_Id.Text, txtMobile_No.Text, txtCurrent_Password.Text);
            objAdmin.UpdateAdmin();
            MessageBox.Show("Update Successful....!");
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "jpg File(*.jpg)|*.jpg|jpeg Files(*.jpeg)|*.jpeg|png Files(*.png)|*.png";
            if(obj.ShowDialog()==DialogResult.OK)
            {
                photo_Location = obj.FileName.ToString();
                Admin_Pic.ImageLocation = photo_Location;

            }
        }
    }
}
