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
    public partial class frmAddQualification : Form
    {
        public frmAddQualification()
        {
            InitializeComponent();
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txtQualificationName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+).$").Success)  // Qualification Validation
            {

                MessageBox.Show("Invalid Qualification", "Message");
                txtQualificationName.Focus();
                return;
            }// end if  
            ClsCandidateRegistration objQualification = new ClsCandidateRegistration(txtQualificationName.Text);
            objQualification.SaveQualification();
            MessageBox.Show("Qualification Added Successfully...!");
            txtQualificationName.Clear();
        }

        private void frmAddQualification_Load(object sender, EventArgs e)
        {
            
        }
    }
}
