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
using GayaSoftHRForum;

namespace GayaSoftHRForum
{
    public partial class frmDetails : Form
    {
        public int Canid ;
        string FullName,Position, Email, Contact, Gender,CityName,totalEXP,currentCTC,expCTC;

        private void lblValueOfID_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Date_Value_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_No_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Experience_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_CTC_Click(object sender, EventArgs e)
        {

        }

        private void lblExpected_CTC_Click(object sender, EventArgs e)
        {

        }

        private void lblExpectedCtc_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentctc_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalexp_Click(object sender, EventArgs e)
        {

        }

        private void lblGender2_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOB_Click(object sender, EventArgs e)
        {

        }

        private void Email_ID2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegistration_Date_Click(object sender, EventArgs e)
        {

        }

        private void lblCandidateID_Click(object sender, EventArgs e)
        {

        }

        private void lblContacTNo_Click(object sender, EventArgs e)
        {

        }

        DateTime dob, can_reg_date;



        public frmDetails()
        {

         InitializeComponent();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RCTU4JK;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
              
           
        }


        public frmDetails(int ID, string Full_name,string position, string email, string contact, string gender,DateTime DOB,string cityname,string totalEX,string CurrentCT,string ExpCT)
        {
            InitializeComponent();
            Canid = ID;
            FullName = Full_name;
           Position = position; 
            Email = email;
            Contact = contact;
            Gender = gender;
           dob = DOB;
            CityName = cityname;
            totalEXP= totalEX;
            currentCTC = CurrentCT;
           expCTC = ExpCT; 


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration obj = new ClsCandidateRegistration(Canid);
            SqlDataReader dr;
            dr = obj.RemainingDataFetch();
                 if (dr.Read())
                        {
                        can_reg_date =Convert.ToDateTime(dr["Registration_Date"].ToString()); 

                        totalEXP=(dr["Total_Experience"]).ToString();
                        currentCTC = (dr["Current_CTC"]).ToString();
                        expCTC = (dr["Expected_CTC"]).ToString();
                Position = (dr["Position"]).ToString();
                         }
                        lblValueOfID.Text = Canid.ToString();
                        lblFullName.Text = FullName;
                        lblPosition.Text = Position;    
                        lblContacTNo.Text = Contact;
                        Email_ID2.Text = Email;
                        lblGender2.Text = Gender;
                        lblDateOB.Text = Convert.ToString(dob);
                        Registration_Date_Value.Text = can_reg_date.ToString();
                        lblTotalexp.Text = totalEXP.ToString();
                        lblCurrentctc.Text = currentCTC;
                        lblExpectedCtc.Text = expCTC;

        }

       
    }
    }


