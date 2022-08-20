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
using System.Data;
using GayaSoftHRForum;
using GayaSoftHRForumLibrary.HR;


namespace GayaSoftHRForum
{
    public partial class FrmAdminCompany : Form
    {
        public FrmAdminCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
           
            ClsStaffRegistration obj = new ClsStaffRegistration(txtCompanyName.Text,txtCompanySize.Text,Convert.ToInt32(cmbTimeZone.SelectedValue.ToString()),Convert.ToInt32(cmbCurrency.SelectedValue.ToString()));
            obj.SaveCompanyDetails();

            string message = "Saved Successfully!";
            string title = "Message";
            MessageBox.Show(message, title, MessageBoxButtons.OK);
            this.Hide();
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCompanySize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void frmAcc_Load(object sender, EventArgs e)
        {

            ClsStaffRegistration obj=new ClsStaffRegistration();
            DataTable dt = new DataTable();
            dt=obj.getTime_Zone();
            cmbTimeZone.ValueMember = "Time_Zone_ID";
            cmbTimeZone.DisplayMember = "Time_Zone";
            cmbTimeZone.DataSource = dt;

            ClsStaffRegistration obj1 = new ClsStaffRegistration();
            DataTable dt1 = new DataTable();
            dt1=obj1.getCurrency();
            cmbCurrency.ValueMember = "Currency_ID";
            cmbCurrency.DisplayMember = "Currency";
            cmbCurrency.DataSource = dt1;

        }
    }
}
