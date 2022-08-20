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
    public partial class frmAddSpecialization : Form
    {
        public frmAddSpecialization()
        {
            InitializeComponent();
        }

        private void lblQualificationName_Click(object sender, EventArgs e)
        {

        }

        private void frmAddSpecialization_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objGetQualification=new ClsCandidateRegistration();
            DataTable dt = new DataTable();
            dt = objGetQualification.FetchQualification();

            cmbbxQualificationAddSpec.ValueMember = "Qualification_ID";
            cmbbxQualificationAddSpec.DisplayMember = "Qualification";
            cmbbxQualificationAddSpec.DataSource = dt;

        }

        private void btnSaveSpecialization_Click(object sender, EventArgs e)
        {
            if (cmbbxQualificationAddSpec.SelectedIndex == -1)//    Combobox Qualification Validation
            {
                MessageBox.Show("Please select Qualification");
                cmbbxQualificationAddSpec.Focus();
                return;
            }
            if (!Regex.Match(txtSpecializationName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+).$").Success)  // Specialization Validation
            {

                MessageBox.Show("Invalid Specialization", "Message");
                txtSpecializationName.Focus();
                return;
            }// end if  

            ClsCandidateRegistration objSaveSpecialization=new ClsCandidateRegistration(Convert.ToInt32(cmbbxQualificationAddSpec.SelectedValue.ToString()),txtSpecializationName.Text);
            objSaveSpecialization.SaveSpecialization();
            MessageBox.Show("Specialization Added Successfully...!");
            txtSpecializationName.Clear();
            cmbbxQualificationAddSpec.SelectedItem = null;
            //frmEducationInformation objedu=new frmEducationInformation();
            //objedu.Show();
        }
    }
}
