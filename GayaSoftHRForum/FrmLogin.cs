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
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;


namespace GayaSoftHRForum
{
    public partial class FrmLogin : Form
    {
        string positionname, Password;
        int Staff_Register_Id;
        public string username { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblsignin_Click(object sender, EventArgs e) { }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            ClsStaffRegistration objclsStaffregistration = new ClsStaffRegistration(txtemailid.Text, txtpassword.Text);
            SqlDataReader dr;
            dr = objclsStaffregistration.Checklogin();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    string dbpwd = dr["Password"].ToString();
                    username = txtemailid.Text;
                    string password = txtpassword.Text;

                    if (password == dbpwd)
                    {
                        Staff_Register_Id = Convert.ToInt32(dr["Staff_Register_ID"].ToString());
                        int Positionid = Convert.ToInt32(dr["Position_ID"].ToString());     // Validate Position Name

                        ClsStaffRegistration objclsStaff = new ClsStaffRegistration(Positionid);
                        SqlDataReader dr1;
                        dr1 = objclsStaff.getposition();

                        if (dr1.Read())                         // Validate Position Name
                        {
                            positionname = dr1["Position_Name"].ToString();
                            if (positionname == "Admin")
                            {
                                FrmAdminDashboard objadmindashboard = new FrmAdminDashboard(Staff_Register_Id, username);
                                objadmindashboard.Show();
                                this.Hide();
                            }
                            else if (positionname == "HR")
                            {
                                if (password == dbpwd)
                                {
                                    FrmHRForumDashboard objHRForumDashboard = new FrmHRForumDashboard(Staff_Register_Id, username);
                                    objHRForumDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invaild Password");
                                }
                            }
                            else
                            {
                                FrmHRForumDashboard objfrmHRForumDashboard = new FrmHRForumDashboard(Staff_Register_Id, username);
                                objfrmHRForumDashboard.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invaild Email ID and Password");
            }

        }

        private void linklblregisteranewaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsStaffRegistration objclsStaffregistration = new ClsStaffRegistration(txtemailid.Text, txtpassword.Text);
            SqlDataReader dr;
            dr = objclsStaffregistration.Checklogin();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    string dbpwd = dr["Password"].ToString();
                    string username = txtemailid.Text;
                    string password = txtpassword.Text;

                    int Positionid = Convert.ToInt32(dr["Position_ID"].ToString());

                    ClsStaffRegistration objclsStaff = new ClsStaffRegistration(Positionid);
                    SqlDataReader dr1;
                    dr1 = objclsStaff.getposition();
                    if (dr1.Read())                         // Validate Position Name
                    {
                        positionname = dr1["Position_Name"].ToString();

                        if (positionname == "Admin")
                        {
                            StaffRegistration objstaffregistration = new StaffRegistration();
                            objstaffregistration.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Only Admin can be Register New Staff.....");
                        }
                    }
                }

            }
        }

        private void linklblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //To Send Password on Your Mail ID
            string email = txtemailid.Text;
            ClsStaffRegistration objclsStaffRegistration1 = new ClsStaffRegistration(email);
            SqlDataReader dr;
            dr = objclsStaffRegistration1.ForgotPwd();

            if (dr.HasRows)
            {
                while (dr.Read() == true)
                {
                    string EmailID = dr["Email_id"].ToString();
                    Password = dr["Password"].ToString();

                    if (EmailID == email)
                    {
                        string from = "crnproject001@gmail.com";
                        string to = EmailID;
                        MailMessage msg = new MailMessage(from, to);
                        string mailbody = "Hello, Your Email ID Is =   " + EmailID + "</br> Your Password Is =   " + Password;
                        msg.Subject = "GayasoftHRForum";
                        msg.Body = mailbody;
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = true;
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        System.Net.NetworkCredential a = new System.Net.NetworkCredential("crnproject001@gmail.com", "project001");
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = a;
                        try
                        {
                            client.Send(msg);
                            MessageBox.Show("Your password is sent to your email..");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Check Internet Connection");
                        }
                    }
                    else
                    {
                        MessageBox.Show(EmailID + "    This Email ID Is Not Exists In Our Database");
                    }
                }

            }

            frmforgotpassword objforgotpassword = new frmforgotpassword(Password);
            objforgotpassword.Show();

        }



        private void linklblChangepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            //ClsStaffRegistration objCheckOldPassword = new ClsStaffRegistration(txtemailid.Text,txtpassword.Text);
            //SqlDataReader dr;
            //dr=objCheckOldPassword.CheckOldPassword();

            //if(dr.HasRows)
            //{
            //    if(dr.Read())
            //    { 
            //        string mail = dr["Email_ID"].ToString();
            //        frmchangepassword objfrmchangepassword = new frmchangepassword(mail); 
            //        objfrmchangepassword.Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Email and Password is incorrect!!!!!");
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtemailid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemailid_MouseHover(object sender, EventArgs e)
        {
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btnhidepass_Click(object sender, EventArgs e)
        {
           

            if (txtpassword.PasswordChar == '\0')
            {
                btnhidepass.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btnhidepass.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e) { }
    }
}
