using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;
using System.Text.RegularExpressions;

namespace GayaSoftHRForum
{
    public partial class frmAddCountry : Form
    {
        public frmAddCountry()
        {
            InitializeComponent();
        }

        private void btnSaveCountry_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txtCountryName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)  // Add Country Validation
            {

                MessageBox.Show("Invalid Country", "Message");
                txtCountryName.Focus();
                return;
            }// end if 
            ClsCandidateRegistration objCountry = new ClsCandidateRegistration(txtCountryName.Text);
            objCountry.SaveCountry();
            MessageBox.Show("Country Added Successfully...!");
            txtCountryName.Clear();

        }
    }
}
