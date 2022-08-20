using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;


namespace GayaSoftHRForum
{
    public partial class Company_Dashboard : Form
    {
        public int Company_ID, numRows, Staff_Reg_ID;
        public Panel dynamicPanel;
        public Company_Dashboard()
        {
            InitializeComponent();
           
        }
        public Company_Dashboard(int staff_id)
        {         
            InitializeComponent();
            Staff_Reg_ID = staff_id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsCompany objCompanydashboard = new ClsCompany();
            DataTable dt = new DataTable();
            dt = objCompanydashboard.ShowCompanyDashboard();
            numRows = dt.Rows.Count;

            if (dt != null)
            {
                for (int i = 0; i < numRows; i++)
                {
                    dynamicPanel = newPanel(i);
                    Label label = newLabel();
                    Label label2 = newLabel2();
                    Label label3 = newLabel3();

                    LinkLabel linklabel = newLinkLabel();
                    dynamicPanel.Controls.Add(label);
                    dynamicPanel.Controls.Add(label2);
                    dynamicPanel.Controls.Add(label3);
                    label3.Hide();
                    dynamicPanel.Controls.Add(linklabel);
                    flowLayoutPanel1.Controls.Add(dynamicPanel);


                    Panel newPanel(int x)
                    {
                        Panel dpanel = new Panel();
                        dpanel.Location = new System.Drawing.Point(26, 12);
                        dpanel.Name = "Panel" + x.ToString();
                        dpanel.Size = new System.Drawing.Size(287, 221);
                        dpanel.BackColor = Color.DodgerBlue;
                        dpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        return dpanel;
                    }
                    Label newLabel3()
                    {
                        Label l3 = new Label();
                        l3.AutoSize = true;
                        l3.Location = new System.Drawing.Point(55, 12);
                        l3.Name = "lblCompanyID" + dynamicPanel.Controls.Count;
                        l3.Size = new System.Drawing.Size(81, 16);
                        l3.TabIndex = 5;
                        l3.Text = dt.Rows[i][0].ToString();
                        l3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l3.ForeColor = Color.White;
                        return l3;
                    }

                    Label newLabel()
                    {
                        Label l = new Label();
                        l.AutoSize = true;
                        l.Location = new System.Drawing.Point(47, 50);
                        l.Name = "lblCompany" + dynamicPanel.Controls.Count;
                        l.Size = new System.Drawing.Size(105, 16);
                        l.Text = dt.Rows[i][1].ToString();
                        l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l.TabIndex = 2;
                        return l;
                    }
                    Label newLabel2()
                    {
                        Label l2 = new Label();
                        l2.AutoSize = true;
                        l2.Location = new System.Drawing.Point(58, 86);
                        l2.Name = "lblNoOpenings" + dynamicPanel.Controls.Count;
                        l2.Size = new System.Drawing.Size(65, 16);
                        l2.Text = dt.Rows[i][2].ToString();
                        l2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l2.TabIndex = 3;
                        return l2;
                    }
                    LinkLabel newLinkLabel()
                    {
                        LinkLabel lk = new LinkLabel();
                        lk.AutoSize = true;
                        lk.Location = new System.Drawing.Point(47, 138);
                        lk.Name = "linkLabel" + dynamicPanel.Controls.Count;
                        lk.Size = new System.Drawing.Size(89, 16);
                        lk.TabIndex = 4;
                        lk.TabStop = true;
                        lk.Tag = dt.Rows[i][0];
                        lk.Text = "Show Job List with No of Openings";
                        lk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                        return lk;
                    }
                }

            }
        }
        public void CampanyDashboard()
        {

           
        }
        

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Company_ID = (int)(sender as LinkLabel).Tag;
            Individual_Companywise_Job_Opening_List obj = new Individual_Companywise_Job_Opening_List(Company_ID,Staff_Reg_ID);
            obj.Show();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {}

        private void btnShowJob_Click(object sender, EventArgs e)
        { }

        private void btnShowAllCompanyList_Click(object sender, EventArgs e)
        {
            FrmCompanyList obj = new FrmCompanyList(Staff_Reg_ID);
            obj.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Company_Dashboard obj=new Company_Dashboard(Staff_Reg_ID);
            obj.Show();
        }

        private void grdCompanywithOpenings_CellClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void grdCompanywithOpenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
    }
}
