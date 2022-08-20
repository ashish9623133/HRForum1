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
using System.Text.RegularExpressions;

namespace GayaSoftHRForum
{
    public partial class frmAddState : Form
    {
        public frmAddState()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddState_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objGetCountry = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objGetCountry.FetchCountry();

            cmbbxCountryAddState.ValueMember = "Country_ID";
            cmbbxCountryAddState.DisplayMember = "Country_Name";
            cmbbxCountryAddState.DataSource = dt;
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {
            if (cmbbxCountryAddState.SelectedIndex == -1)//    Combobox Country Validation
            {
                MessageBox.Show("Please select Country");
                cmbbxCountryAddState.Focus();
                return;
            }
            if (!Regex.Match(txtAddState.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)  // State Validation
            {

                MessageBox.Show("Invalid State", "Message");
                txtAddState.Focus();
                return;
            }// end if  

            
            ClsCandidateRegistration objSaveState = new ClsCandidateRegistration(Convert.ToInt32(cmbbxCountryAddState.SelectedValue.ToString()),txtAddState.Text);
            objSaveState.SaveState();
            MessageBox.Show("State Added Successfully...!");
            txtAddState.Clear();
        }
    }
}
