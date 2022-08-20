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
using GayaSoftHRForum;
using GayaSoftHRForumLibrary.HR;



namespace GayaSoftHRForum
{
    public partial class frmCandidatelifecyclereport : Form
    {
        DataTable dt = new DataTable();
        public object Excelapp;
        public int Candidate_ID, Status_ID;
        public DateTime Assign_Date,from_Date,to_Date;
        int flag = 0;
        public frmCandidatelifecyclereport()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app.Visible = true;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //for (int i = 1; i < grdview.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = grdview.Columns[i - 1].HeaderText;
            //}
            //for (int i = 0; i < grdview.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < grdview.Columns.Count; j++)
            //    {
            //        if (grdview.Rows[i].Cells[j].Value != null)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = grdview.Rows[i].Cells[j].Value.ToString();
            //        }
            //        else
            //        {
            //            worksheet.Cells[i + 2, j + 1] = "";
            //        }
            //    }
            //}
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           ClsCandidateAssign objAdmin = new ClsCandidateAssign();
            dt = objAdmin.checklist();


            for (int i = 0; i < dt.Rows.Count; i++)
            {


                checklist.Items.Add(dt.Rows[i]["Status"].ToString());


            }
           ClsCandidateAssign objCandidateGraph = new ClsCandidateAssign();

            DataTable dt2 = new DataTable();
            dt2 = objCandidateGraph.GetCandidateCount();

            DataRow graph = dt2.Rows[0];
            var Candi = graph["placed"];

            DataRow graph1 = dt2.Rows[0];
            var Candi1 = graph["Assigned"];

            DataRow graph2 = dt2.Rows[0];
            var Candi2 = graph["Interview_Scheduled"];

            DataRow graph3 = dt2.Rows[0];
            var Candi3 = graph["Interview_Not_Attended"];

            DataRow graph4 = dt2.Rows[0];
            var Candi4 = graph["Rejected"];

            DataRow graph5 = dt2.Rows[0];
            var Candi5 = graph["Interview_Resecheduled"];

            DataRow graph6 = dt2.Rows[0];
            var Candi6 = graph["Offered"];

            DataRow graph7 = dt2.Rows[0];
            var Candi7 = graph["On_Hold"];

            DataRow graph8 = dt2.Rows[0];
            var Candi8 = graph["Selected"];


            this.chart1.Series["Candidate_Count"].Points.AddXY("placed", Candi);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Assigned", Candi1);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Interview_Scheduled", Candi2);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Interview_Not_Attended", Candi3);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Rejected", Candi4);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Interview_Resecheduled", Candi5);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Offered", Candi6);
            this.chart1.Series["Candidate_Count"].Points.AddXY("On_Hold", Candi7);
            this.chart1.Series["Candidate_Count"].Points.AddXY("Selected", Candi8);


        }

        private void btngeneratechart_Click(object sender, EventArgs e)
        {
            string checkboxselect = "";
            foreach (string s in checklist.CheckedItems)
            {

                string a = s;
                if (a == "Assigned")
                {
                    checkboxselect += "'" + 3 + "'";
                    flag = 1;
                }
                if (a == "Placed")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 13 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 13 + "'";
                        flag = 1;
                    }
                }
                if (a == "Interview Scheduled")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 4 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 4 + "'";
                        flag = 1;
                    }
                }
                if (a == "Not Attended")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 5 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 5 + "'";
                        flag = 1;
                    }
                }
                if (a == "Rejected")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 9 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 9 + "'";
                        flag = 1;
                    }
                }
                if (a == "Interview Rescheduled")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 6 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 6 + "'";
                        flag = 1;
                    }
                }
                if (a == "Offered")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 11 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 11 + "'";
                        flag = 1;
                    }
                }
                if (a == "On Hold")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 8 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 8 + "'";
                        flag = 1;
                    }
                }
                if (a == "Selected")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 10 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 10 + "'";
                        flag = 1;
                    }
                }
                if (a == "Interviewed")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 7 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 7 + "'";
                        flag = 1;
                    }
                }

                if (a == "Offer Accepted")
                {
                    if (flag == 1)
                    {
                        checkboxselect += "," + "'" + 12 + "'";
                    }
                    else
                    {
                        checkboxselect += "'" + 12 + "'";
                        flag = 1;
                    }
                }


               

            }

           
            from_Date = Convert.ToDateTime(dtformat1.Text);
            to_Date = Convert.ToDateTime(dtformat2.Text);
           ClsCandidateAssign objAdmin = new ClsCandidateAssign(checkboxselect, from_Date, to_Date);
            dt = objAdmin.graph();

            this.chart1.DataSource = dt;


            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Series["Candidate_Count"].XValueMember = "Status";
            
            chart1.Series["Candidate_Count"].YValueMembers = "dupe_cnt";

           
            this.chart1.DataBind();


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
        }

        private void btnINA_Click(object sender, EventArgs e)
        {
           
        }

        private void btnI_R_Click(object sender, EventArgs e)
        {
            
        }

        private void btnrejected_Click(object sender, EventArgs e)
        {
           
        }

        private void btnO_H_Click(object sender, EventArgs e)
        {
             }

        private void btnselected_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOffered_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.HitTestResult result = chart1.HitTest(e.X, e.Y);
           
            int index = result.PointIndex;
            if (index >= 0)
            {


               
                string x = dt.Rows[index][0].ToString();
                int v = Convert.ToInt32(x);
                DataTable dt3 = new DataTable();
                ClsCandidateAssign objgridview = new ClsCandidateAssign(v);
                dt3 = objgridview.Admingridview();
                grdview.DataSource = dt3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdview.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grdview.Columns.Count; j++)
                {
                    if (grdview.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdview.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btndate1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void btnplaced_Click(object sender, EventArgs e)
        {
           

        }
    }
  }
    

