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

namespace GayaSoftHRForum
{
    public partial class FrmCandidateLDashBoard : Form
    {
        public int Candidate_ID, numRows;
        public Panel dynamicPanel;
        public FrmCandidateLDashBoard()
        {
            InitializeComponent();

        }

        private void FrmCandidateLDashBoard_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objCandidatedashboard = new ClsCandidateRegistration();
            DataTable dt = new DataTable();
             dt = objCandidatedashboard.ShowCandidateDashboard();
          //  dt = objCandidatedashboard.ShowCandidateList();
            numRows = dt.Rows.Count;

            if (dt != null)
            {
                for (int i = 0; i < numRows; i++)
                {
                    dynamicPanel = newPanel(i);
                    Label label = newLabel();
                    Label label2 = newLabel2();
                    LinkLabel linklabel = newLinkLabel();
                    dynamicPanel.Controls.Add(label);
                    dynamicPanel.Controls.Add(label2);
                    dynamicPanel.Controls.Add(linklabel);
                    flowLayoutPanel1.Controls.Add(dynamicPanel);

                    //Label label3 = newLabel3();

                    //Company_ID = Convert.ToInt32(dt.Rows[i][0].ToString());

                    //dynamicPanel.Controls.Add(label3);




                    Panel newPanel(int x)
                    {
                        Panel dpanel = new Panel();
                        dpanel.Location = new System.Drawing.Point(26, 12);
                        dpanel.Size = new System.Drawing.Size(287, 221);
                        dpanel.BackColor = Color.DodgerBlue;
                        dpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        dpanel.TabIndex = 4;
                        return dpanel;
                    }


                    Label newLabel()
                    {
                        Label l = new Label();
                        l.AutoSize = true;
                        l.Location = new System.Drawing.Point(47, 50);
                        l.Name = "lblJobTitle" + dynamicPanel.Controls.Count;
                        l.Size = new System.Drawing.Size(105, 16);
                        l.Text = dt.Rows[i][0].ToString();
                        l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l.ForeColor = Color.White;
                        l.TabIndex = 2;
                        return l;
                    }
                    Label newLabel2()
                    {
                        Label l2 = new Label();
                        l2.AutoSize = true;
                        l2.Location = new System.Drawing.Point(58, 86);
                        l2.Name = "lblNoofCandidates" + dynamicPanel.Controls.Count;
                        l2.Size = new System.Drawing.Size(65, 16);
                        l2.Text = dt.Rows[i][1].ToString();
                        l2.TabIndex = 2;
                        l2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        l2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        l2.ForeColor = Color.White;
                        l2.Location = new System.Drawing.Point(99, 98);
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
                        lk.Text = "Show Candidate List";
                        lk.Location = new System.Drawing.Point(45, 137);
                        lk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
                        return lk;
                    }
                    //Label newLabel3()
                    //{
                    //    Label l3 = new Label();
                    //    l3.AutoSize = true;
                    //    l3.Location = new System.Drawing.Point(55, 12);
                    //    l3.Name = "lblCompany" + dynamicPanel.Controls.Count;
                    //    l3.Size = new System.Drawing.Size(81, 16);
                    //    l3.TabIndex = 5;
                    //    l3.Text = dt.Rows[i][0].ToString();
                    //    return l3;
                    //}

                    
                }
            }



        }

        private void btnShowAllCandidateList_Click(object sender, EventArgs e)
        {

            FrmCandidateList objcan = new FrmCandidateList();
            objcan.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string JobTitle = (string)(sender as LinkLabel).Tag;
            FrmShowCandidateList objcandidatelist = new FrmShowCandidateList(JobTitle);
            objcandidatelist.Show();
            //frmCandidateListForSpecJobTitle obj = new frmCandidateListForSpecJobTitle(JobTitle);
            //obj.Show();

        }
    }
}
