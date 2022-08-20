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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
//using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class AddJob : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        int Is_Deleted = 0;
        int Job_ID;

        public AddJob()
        {
            InitializeComponent();
        }
        public AddJob(int jobid)
        {
            InitializeComponent();
            Job_ID=jobid;
        }
        private void AddJob_Load(object sender, EventArgs e)
        {
            ClsJob getcomp = new ClsJob();
            DataTable dt = new DataTable();
            dt = getcomp.Getcompany();
            cmbbxcompany.ValueMember = "Company_ID";
            cmbbxcompany.DisplayMember = "Company_Name";
            cmbbxcompany.DataSource = dt;

        }

        private void cmbbxcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob getqualify = new ClsJob();
            DataTable dt = new DataTable();
            dt = getqualify.Getqualification();
            cmbbxeducationqualy.ValueMember = "Qualification_ID";
            cmbbxeducationqualy.DisplayMember = "Qualification";
            cmbbxeducationqualy.DataSource = dt;

            int SI = Convert.ToInt32(cmbbxcompany.SelectedValue.ToString());
            ClsJob getHR = new ClsJob(SI,cmbbxcompantHR.Text);
            DataTable dt1 = new DataTable();
            dt1 = getHR.GetHRname();
            cmbbxcompantHR.ValueMember = "Company_HR_Contact_ID";
            cmbbxcompantHR.DisplayMember = "HR_Name";
            cmbbxcompantHR.DataSource = dt1;
        }

        private void cmbbxeducationqualy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SI = Convert.ToInt32(cmbbxeducationqualy.SelectedValue.ToString());
            ClsJob getspeclize = new ClsJob(SI, cmbbxeducatioSpez.Text);
            DataTable dt = new DataTable();
            dt = getspeclize.getspecelization();
            cmbbxeducatioSpez.ValueMember = "Qualification_ID";
            cmbbxeducatioSpez.DisplayMember = "Specialization_Name";
            cmbbxeducatioSpez.DataSource = dt;
        }

        private void cmbbxeducatioSpez_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob getjobstream = new ClsJob();
            DataTable dt = new DataTable();
            dt = getjobstream.getstream();
            cmbbxjobstream.ValueMember = "Job_Stream_ID";
            cmbbxjobstream.DisplayMember = "Job_Stream_Name";
            cmbbxjobstream.DataSource = dt;


            ClsJob get = new ClsJob();
            DataTable dt1 = new DataTable();
            dt1 = get.GetExperience();
            cmbbxminexp.ValueMember = "Exp_ID";
            cmbbxminexp.DisplayMember = "Experience";
            cmbbxminexp.DataSource = dt1;
        }

        private void cmbbxjobstream_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob getcity = new ClsJob();
            DataTable dt = new DataTable();
            dt = getcity.Getcity();
            cmbbxcity.ValueMember = "City_ID";
            cmbbxcity.DisplayMember = "City_Name";           
            cmbbxcity.DataSource = dt;

        }

        private void cmbbxcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob getstatus = new ClsJob();
            DataTable dt = new DataTable();
            dt =getstatus.Getstatus();
            cmbbxstatus.ValueMember = "Status_ID";
            cmbbxstatus.DisplayMember = "Status";
            cmbbxstatus.DataSource = dt;
        }

        private void txtjobtital_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJobTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSavejob_Click(object sender, EventArgs e)
        {
           // if (string.IsNullOrEmpty(txtjobtital.Text))
           // {
           //     txtjobtital.Focus();
           //     MessageBox.Show("Plz Fill Tital...........!!");
           // }
            if (string.IsNullOrEmpty(txtnumbropening.Text))
            {
                txtnumbropening.Focus();
                MessageBox.Show("Plz Fill Number Of Opening........!!");
            }
            else if (string.IsNullOrEmpty(txtrichfulladdress.Text))
            {
                txtrichfulladdress.Focus();
                MessageBox.Show("Plz Fill Full Address........!!");

            }



            DateTime date = DateTime.Today;
                DateTime OpenDate = Convert.ToDateTime(openingdatepicker.Text);
                DateTime CloseDate = Convert.ToDateTime(closingdateTimePicker.Text);
                DateTime Jobpostingdate = Convert.ToDateTime(datetimejobposting.Text);


                ClsJob addjob = new ClsJob(txtjobtital.Text, Convert.ToInt32(txtnumbropening.Text),
                Convert.ToInt32(cmbbxcompany.SelectedValue.ToString()), OpenDate, CloseDate,
                txtrichjobdescription.Text, txtUploadfile.Text, cmbbxmaxExp.Text, cmbbxminexp.Text, cmbbxcurrency.Text,
                Convert.ToInt32(cmbbxjobstream.SelectedValue.ToString()),
                txtminsalary.Text, txtmaxsalary.Text, Convert.ToInt32(cmbbxeducationqualy.SelectedValue.ToString()),
                Convert.ToInt32(cmbbxeducatioSpez.SelectedValue.ToString()), Jobpostingdate, txtskills.Text,
                Convert.ToInt32(cmbbxcity.SelectedValue.ToString()), txtrichfulladdress.Text, date,
                Convert.ToInt32(cmbbxstatus.SelectedValue.ToString()), Convert.ToInt32(Is_Deleted), Convert.ToInt32(cmbbxcompantHR.SelectedValue.ToString()));
                addjob.Addjob();
                MessageBox.Show("Save Successfully.....");

            Jobs objlist = new Jobs();
            objlist.Show();

        }

        private void cmbbxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClsJob getHR = new ClsJob();
            //DataTable dt = new DataTable();
            //dt = getHR.GetHRname();
            //cmbbxcompantHR.ValueMember = "Company_HR_Contact_ID";
            //cmbbxcompantHR.DisplayMember = "HR_Name";
            //cmbbxcompantHR.DataSource = dt;
        }

        private void cmbbxcurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxcompantHR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtjobtital_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtjobtital_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtjobtital.Text))
            {
                txtjobtital.Focus();
                MessageBox.Show("Plz Fill The Title...........!!");
            }
            
        }

        private void txtnumbropening_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtnumbropening.Text))
            //{
            //    txtnumbropening.Focus();
            //    MessageBox.Show("Plz Fill Number Of Opening........!!");
            //}
           
        }

        private void txtmaxsalary_TextChanged(object sender, EventArgs e)
         {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmaxsalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtmaxsalary.Text = txtmaxsalary.Text.Remove(txtmaxsalary.Text.Length - 1);
            }
        }

        private void openingdatepicker_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtrichfulladdress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtrichfulladdress.Text))
            {
                txtrichfulladdress.Focus();
                MessageBox.Show("Plz Fill Full Address........!!");
            }
        }

        private void txtnumbropening_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtnumbropening.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtnumbropening.Text = txtnumbropening.Text.Remove(txtnumbropening.Text.Length - 1);
            }
        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File Do You Want To Uplaod";

            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                      //  label1.Text = path;
                        txtUploadfile.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblFulladdress_Click(object sender, EventArgs e)
        {

        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtjobtital.Text = String.Empty;
            txtnumbropening.Text = String.Empty;
            cmbbxcompany.Text = String.Empty;
            txtUploadfile.Text = String.Empty;
            txtrichjobdescription.Text = String.Empty;
            cmbbxmaxExp.Text = String.Empty;
            cmbbxminexp.Text = String.Empty;
            txtmaxsalary.Text = String.Empty;
            txtminsalary.Text = String.Empty;
            cmbbxcurrency.Text = String.Empty;
            cmbbxeducationqualy.Text = String.Empty;
            cmbbxeducatioSpez.Text = String.Empty;
            cmbbxjobstream.Text = String.Empty;
            cmbbxcity.Text = String.Empty;
            txtskills.Text = String.Empty;
            txtrichfulladdress.Text = String.Empty;
            cmbbxcompantHR.Text = String.Empty;
            cmbbxstatus.Text = String.Empty;

        }

        private void txtUploadfile_TextChanged(object sender, EventArgs e)
        {
            //ClsJob getstatus = new ClsJob();
            //DataTable dt = new DataTable();
            //dt = getstatus.GetExperience();
            //cmbbxmaxExp.ValueMember = "Exp_ID";
            //cmbbxmaxExp.DisplayMember = "Experience";
            //cmbbxmaxExp.DataSource = dt;
        }

        private void txtminsalary_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtminsalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtminsalary.Text = txtminsalary.Text.Remove(txtminsalary.Text.Length - 1);
            }

            //if (string.IsNullOrEmpty(txtminsalary.Text))
            //{
            //    txtminsalary.Focus();
            //    MessageBox.Show("Plz Fill Number Of Opening........!!");
            //}
        }

        private void txtminexp_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtminexp.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtminexp.Text = txtminexp.Text.Remove(txtminexp.Text.Length - 1);
            //}
        }

        private void txtmaxsalary_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtmaxsalary.Text))
            //{
            //    txtmaxsalary.Focus();
            //    MessageBox.Show("Plz Fill Maximum Salary........!!");
            //}

            //if (System.Text.RegularExpressions.Regex.IsMatch(txtmaxsalary.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtmaxsalary.Text = txtmaxsalary.Text.Remove(txtmaxsalary.Text.Length - 1);
            //}
        }

        private void txtminsalary_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtminexp.Text))
            //{
            //    txtminexp.Focus();
            //    MessageBox.Show("Plz Fill Minimum Salary........!!");
            //}
        }

        private void txtmaxExp_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtmaxExp.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtmaxExp.Text = txtmaxExp.Text.Remove(txtmaxExp.Text.Length - 1);
            //}
        }

        private void cmbbxminexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob get = new ClsJob();
            DataTable dt1 = new DataTable();
            dt1 = get.GetExperience();
            cmbbxmaxExp.ValueMember = "Exp_ID";
            cmbbxmaxExp.DisplayMember = "Experience";
            cmbbxmaxExp.DataSource = dt1;
        }
    }
}
