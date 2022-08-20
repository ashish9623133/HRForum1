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
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;


namespace GayaSoftHRForum
{
    public partial class frmforgotpassword : Form
    {
        public static string to;
        public string from;
        string Email_ID, Password;
        public frmforgotpassword()
        {
            InitializeComponent();
        }
        public frmforgotpassword(string pwd)
        {
            InitializeComponent();
            Password = pwd;
        }

        private void btnverify_Click(object sender, EventArgs e)
        {

            //string email = txtenteremailid.Text;
            //ClsStaffRegistration objclsStaffRegistration1 = new ClsStaffRegistration(email);
            //SqlDataReader dr;
            //dr = objclsStaffRegistration1.ForgotPwd();

            //if (dr.HasRows)
            //{
            //    while (dr.Read() == true)
            //    {
            //        string EmailID = dr["Email_id"].ToString();
            //        Password = dr["Password"].ToString();

            //        if (EmailID == email)
            //        {
            //            string from = "crnproject001@gmail.com";
            //            string to = EmailID;
            //            MailMessage msg = new MailMessage(from, to);
            //            string mailbody = "Hello, Your Email ID Is =   " + EmailID + "</br> Your Password Is =   " + Password;
            //            msg.Subject = "GayasoftHRForum";
            //            msg.Body = mailbody;
            //            msg.BodyEncoding = Encoding.UTF8;
            //            msg.IsBodyHtml = true;
            //            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //            System.Net.NetworkCredential a = new System.Net.NetworkCredential("crnproject001@gmail.com", "project001");
            //            client.EnableSsl = true;
            //            client.UseDefaultCredentials = false;
            //            client.Credentials = a;
            //            try
            //            {
            //                client.Send(msg);
            //                //MessageBox.Show("Password send on your email..");
            //                lblmessagesend.Text = "Your Password has Been Sent To " + EmailID;
            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Check Internet Connection");
            //            }
            //        }
            //        else
            //        {
            //            lblmessagesend.Text = EmailID + "    This Email ID Is Not Exists In Our Database";
            //        }
            //    }

            //}

        }
        private void btnverifypwd_Click(object sender, EventArgs e)
        {
            if (Password == txtverifypwd.Text)
            {
                FrmLogin obj=new FrmLogin();
                obj.Show();
                //FrmHRForumDashboard objhrforumdash = new FrmHRForumDashboard();
                //objhrforumdash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.....");
            }
        }
        private void txtverifypwd_TextChanged(object sender, EventArgs e) { }

        private void lblmessagesend_Click(object sender, EventArgs e)
        {
           // lblmessagesend.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmforgotpassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
