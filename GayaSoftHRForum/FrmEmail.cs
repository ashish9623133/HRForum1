using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GayaSoftHRForum
{
    public partial class FrmEmail : Form
    {
        string FileLocation = "";
        string Email;
        public FrmEmail()
        {
            InitializeComponent();
        }
        public FrmEmail(string email)
        {
            InitializeComponent();
            Email = email;
        }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEmail_Load(object sender, EventArgs e)
        {
            txtSender.Text = Email;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to, from, pass, message;
            to = (txtReciever.Text).ToString();
            from = (txtSender.Text).ToString();
           // pass = (txtPass.Text).ToString();
            message = (txtMail.Text).ToString();

            MailMessage msg = new MailMessage();
            msg.Attachments.Add(new Attachment(txtAttachedFile.Text.ToString()));
            msg.To.Add(to);
            msg.From = new MailAddress("gayasoft2@gmail.com");
            msg.Body = message;
            msg.Subject = "Testing Mail";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Credentials = new NetworkCredential("gayasoft2@gmail.com", "9702276185");
            try
            {
                smtp.Send(msg);
                
                MessageBox.Show("Email Sent Successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            FrmAdminDashboard obj = new FrmAdminDashboard();
            obj.Show();
            
        }

        private void btnAttached_Click(object sender, EventArgs e)
        {
            OpenFileDialog objResume = new OpenFileDialog();
            objResume.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*jpeg|pdf files(*.pdf)|*.pdf";
            if (objResume.ShowDialog() == DialogResult.OK)
            {
                FileLocation = objResume.FileName.ToString();
                txtAttachedFile.Text = FileLocation;
            }

        }
    }
}
