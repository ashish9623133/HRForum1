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

namespace GayaSoftHRForum
{
    
    public partial class frmchangepassword : Form
    {
        string Mail_ID;
        string Currentpwd;

        public frmchangepassword()
        {
            InitializeComponent();
        }
        public frmchangepassword(string mailid)
        {
            InitializeComponent();
            Mail_ID = mailid;
            Currentpwd = mailid;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            ClsStaffRegistration objCheckOldPass = new ClsStaffRegistration(Mail_ID, txtoldpassword.Text);
            SqlDataReader dr;
            dr = objCheckOldPass.CheckOldPassword();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string mail = dr["Email_ID"].ToString();
                    string dbpwd = dr["Password"].ToString();
                    if (txtoldpassword.Text == dbpwd)
                    {
                        if (txtnewpassword.Text == txtconfimpassword.Text)
                        {
                            ClsStaffRegistration objUpdatePassword = new ClsStaffRegistration(mail, txtconfimpassword.Text);
                            objUpdatePassword.ChangePWD();
                            this.Close();
                            MessageBox.Show("Password Changed Successfully..");
                            FrmLogin objloginfrom = new FrmLogin();
                            objloginfrom.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Proper Confirm Password");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Proper Old Password");
            }

        }
        private void txtnewpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmchangepassword_Load(object sender, EventArgs e)
        {

        }

        private void txtoldpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblconfirmpassword_Click(object sender, EventArgs e)
        {

        }
    }
}

