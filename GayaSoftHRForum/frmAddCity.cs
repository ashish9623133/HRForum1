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
    public partial class frmAddCity : Form
    {
        public frmAddCity()
        {
            InitializeComponent();
        }

        private void frmAddCity_Load(object sender, EventArgs e)
        {
          
            ClsCandidateRegistration objGetState = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objGetState.FetchStateAddcity();

            cmbbxStateAddCity.ValueMember = "State_ID";
            cmbbxStateAddCity.DisplayMember = "State_Name";
            cmbbxStateAddCity.DataSource = dt;
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void cmmbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCity_Click(object sender, EventArgs e)
        {
            if (cmbbxStateAddCity.SelectedIndex == -1)//    Combobox State Validation
            {
                MessageBox.Show("Please select State");
                cmbbxStateAddCity.Focus();
                return;
            }
            if (!Regex.Match(txtCityName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)  // City Validation
            {

                MessageBox.Show("Invalid City", "Message");
                txtCityName.Focus();
                return;
            }// end if  
            ClsCandidateRegistration objAddCity = new ClsCandidateRegistration(txtCityName.Text,Convert.ToInt32(cmbbxStateAddCity.SelectedValue.ToString()));
            objAddCity.SaveCity();
            MessageBox.Show("City Added Successfully...!");
            txtCityName.Clear();
        }
    }
}
