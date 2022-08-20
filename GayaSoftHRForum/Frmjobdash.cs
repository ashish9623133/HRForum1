using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;
using GayaSoftHRForum;



namespace GayaSoftHRForum
{
    public partial class Frmjobdash : Form
    {

        public int Job_Id, numRows, Staff_Register_Id;
        public Panel dynamicPanel;
        public Frmjobdash(int staff_id)
        {
            InitializeComponent();
            Staff_Register_Id=staff_id;
        }

        private void Frmjobdash_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Frmjobdash_Load_1(object sender, EventArgs e)
        {
            

            ClsJob objJobydashboard = new ClsJob();
            DataTable dt = new DataTable();
            dt = objJobydashboard.ShowJobDashboard();
            numRows = dt.Rows.Count;

            if (dt != null)
            {
                for (int i = 0; i < numRows; i++)
                {

                    dynamicPanel = newPanel(i);
                    Label label = newLabel();
                  
                    Label label3 = newLabel3();
                    LinkLabel linklabel = newLinkLabel();
                    
                    dynamicPanel.Controls.Add(label);
                    
                    dynamicPanel.Controls.Add(label3);
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
                        dpanel.TabIndex = 4;
                        return dpanel;

                    }
                    Label newLabel3()
                    {
                        Label l3 = new Label();
                        l3.AutoSize = true;
                        l3.Location = new System.Drawing.Point(45, 25);
                        l3.Name = "lblJobTitle" + dynamicPanel.Controls.Count;
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
                        l.Name = "lblCompanyCount" + dynamicPanel.Controls.Count;
                        l.Size = new System.Drawing.Size(105, 16);
                        l.Text = dt.Rows[i][1].ToString();
                        l.TabIndex = 2;
                        l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l.ForeColor = Color.White;
                        l.Location = new System.Drawing.Point(99, 98);
                        return l;
                    }
                    
                    LinkLabel newLinkLabel()
                    {
                        LinkLabel lk = new LinkLabel(); 
                        lk.AutoSize = true;
                        lk.Location = new System.Drawing.Point(30, 110);
                        lk.Name = "linkLabel" + dynamicPanel.Controls.Count;
                        lk.Size = new System.Drawing.Size(89, 16);
                        lk.TabIndex = 4;
                        lk.TabStop = true;
                        lk.Tag = dt.Rows[i][0];
                        lk.Text = "Show Company List";
                        lk.Location = new System.Drawing.Point(95, 167);

                        lk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                        return lk;
                    }


                }

            }
           

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Jobs objjob = new Jobs(Staff_Register_Id);
             objjob.Show();
           

          
        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Job_Title = (string)(sender as LinkLabel).Tag;
            FrmJobList obj = new FrmJobList(Job_Title, Staff_Register_Id);
            obj.Show();


        }
   
    }

       
    
}
