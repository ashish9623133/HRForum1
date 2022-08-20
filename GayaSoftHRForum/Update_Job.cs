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

namespace GayaSoftHRForum
{
    public partial class Update_Job : Form
    {
        int Is_Deleted = 0;
        int Job_ID;
        


        public Update_Job()
        {
            InitializeComponent();

        }

        public Update_Job(int job_id)
        {
            InitializeComponent();
            Job_ID = job_id;

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            DateTime OpenDate = Convert.ToDateTime(openingdatepicker.Text);
            DateTime CloseDate = Convert.ToDateTime(closingdateTimePicker.Text);
            DateTime Jobpostingdate = Convert.ToDateTime(datetimejobposting.Text);
            ClsJob updatejob = new ClsJob(Convert.ToInt32(Job_ID), txtjobtital.Text, Convert.ToInt32(txtnumbropening.Text),
            Convert.ToInt32(cmbbxcompany.SelectedValue.ToString()), OpenDate, CloseDate,
            txtrichjobdescription.Text, txtUploadfile.Text, cmbbxminexp.Text, cmbbxmaxExp.Text, cmbbxcurrency.Text,
            Convert.ToInt32(cmbbxjobstream.SelectedValue.ToString()),
            txtminsalary.Text, txtmaxsalary.Text, Convert.ToInt32(cmbbxeducationqualy.SelectedValue.ToString()),
            Convert.ToInt32(cmbbxeducatioSpez.SelectedValue.ToString()), Jobpostingdate, txtskills.Text,
            Convert.ToInt32(cmbbxcity.SelectedValue.ToString()), txtrichfulladdress.Text, date,
            Convert.ToInt32(cmbbxstatus.SelectedValue.ToString()), Convert.ToInt32(Is_Deleted), Convert.ToInt32(cmbbxcompantHR.SelectedValue.ToString()));
            updatejob.UpdateJob();
            MessageBox.Show("Update Successfully.....");

            Jobs objlist = new Jobs();
            objlist.Show();
        }

        

        private void Update_Job_Load(object sender, EventArgs e)
        {
            ClsJob loadJob = new ClsJob(Job_ID);
            SqlDataReader dr;
            dr = loadJob.LoadJobData();
       
            if (dr.Read())
            {
                txtjobtital.Text = dr["Job_Title"].ToString();
                txtnumbropening.Text = dr["Number_Of_Opening"].ToString();
                cmbbxcompany.Text = dr["Company_Name"].ToString();
                openingdatepicker.Text = dr["Opening_Date"].ToString();
                closingdateTimePicker.Text = dr["Closing_Date"].ToString();
                txtrichjobdescription.Text = dr["Job_Description"].ToString();
                txtUploadfile.Text = dr["Job_Description_File"].ToString();
                cmbbxminexp.Text = dr["Min_Years_Experience"].ToString();
                cmbbxmaxExp.Text = dr["Max_Years_Experience"].ToString();
                cmbbxcurrency.Text = dr["Currency"].ToString();
                txtminsalary.Text = dr["Min_Salary"].ToString();
                txtmaxsalary.Text = dr["Max_Salary"].ToString();
                cmbbxeducationqualy.Text = dr["Qualification"].ToString();
                cmbbxeducatioSpez.Text = dr["Specialization_Name"].ToString();
                cmbbxjobstream.Text = dr["Job_Stream_Name"].ToString();
                cmbbxcity.Text = dr["City_Name"].ToString();
                txtskills.Text = dr["Skills"].ToString();
                cmbbxstatus.Text = dr["Status"].ToString();
                txtrichfulladdress.Text = dr["Full_Address"].ToString();
                cmbbxcompantHR.Text = dr["HR_Name"].ToString();
                datetimejobposting.Text = dr["Job_Posting_Date"].ToString();
                }
            
            dr.Close();

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
            ClsJob getHR = new ClsJob(SI, cmbbxcompantHR.Text);
            DataTable dt1 = new DataTable();
            dt1 = getHR.GetHRname();
            cmbbxcompantHR.ValueMember = "Company_HR_Contact_ID";
            cmbbxcompantHR.DisplayMember = "HR_Name";
            cmbbxcompantHR.DataSource = dt1;
        }

        private void cmbbxcurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            dt = getstatus.Getstatus();
            cmbbxstatus.ValueMember = "Status_ID";
            cmbbxstatus.DisplayMember = "Status";
            cmbbxstatus.DataSource = dt;
        }

        private void cmbbxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsJob getHR = new ClsJob();
            DataTable dt = new DataTable();
            dt = getHR.GetHRname();
            cmbbxcompantHR.ValueMember = "Company_HR_Contact_ID";
            cmbbxcompantHR.DisplayMember = "HR_Name";
            cmbbxcompantHR.DataSource = dt;
        }

        private void cmbbxcompantHR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUploadfile_TextChanged(object sender, EventArgs e)
        {

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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
