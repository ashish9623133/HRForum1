using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class Job_Statistics_Report : Form
    {
        string Job_Title;
        DateTime FromDate, ToDate;
        DataRow row0, row1, row2, row3, row4, row5, row6, row7, row8, row9, row10;

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdJobStatastics.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdJobStatastics.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdJobStatastics.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdJobStatastics.Columns.Count; j++)
                {
                    if (grdJobStatastics.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdJobStatastics.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        DataTable dt;
        private void chklistStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            String[] ItemArr = new String[chklistStatus.CheckedItems.Count];
            int counter = 0;
            foreach (object item in this.chklistStatus.CheckedItems)
            {
                ItemArr[counter] = Convert.ToString(item);
                counter++;
            }

            Job_Title = cmbbxJobTitle.Text;
            FromDate = Convert.ToDateTime(dtFromdate.Text);
            ToDate = Convert.ToDateTime(dtTodate.Text);
            ClsJob obj1 = new ClsJob(Job_Title, FromDate, ToDate);
            DataTable dt2 = new DataTable();

            dt2 = obj1.GetJobStatasticsReport();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            row0 = dt.Rows[0];
            var graph1 = row0["Assigned"];

            row1 = dt.Rows[0];
            var graph2 = row1["InterviewScheduled"];

            row2 = dt.Rows[0];
            var graph3 = row2["NotAttended"];

            row3 = dt.Rows[0];
            var graph4 = row3["InterviewRescheduled"];

            row4 = dt.Rows[0];
            var graph5 = row4["Interviewed"];

            row5 = dt.Rows[0];
            var graph6 = row5["OnHold"];

            row6 = dt.Rows[0];
            var graph7 = row6["Rejected"];

            row7 = dt.Rows[0];
            var graph8 = row7["Selected"];

            row8 = dt.Rows[0];
            var graph9 = row8["Offered"];

            row9 = dt.Rows[0];
            var graph10 = row9["OfferAccepted"];

            row10 = dt.Rows[0];
            var graph11 = row10["Placed"];


            for (int i = 0; i < ItemArr.Length; i++)
            {

                grdJobStatastics[0, 0].Value = dt2.Rows[0][0].ToString();
                string Status = ItemArr[i];
                if (Status == "Assigned")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Assigned", dt2.Rows[0][1]);
                }
                if (Status == "Interview Scheduled")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("InterviewScheduled", dt2.Rows[0][2]);
                }
                if (Status == "Not Attended")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("NotAttended", dt2.Rows[0][3]);

                }
                if (Status == "Interview Rescheduled")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("InterviewRescheduled", dt2.Rows[0][4]);

                }
                if (Status == "Interviewed")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Interviewed", dt2.Rows[0][5]);

                }
                if (Status == "On Hold")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("OnHold", dt2.Rows[0][6]);

                }
                if (Status == "Rejected")
                {
                    //grdJobStatastics[7, 0].Value = dt2.Rows[0][7].ToString();
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Rejected", dt2.Rows[0][7]);

                }
                if (Status == "Selected")
                {
                    //grdJobStatastics[8, 0].Value = dt2.Rows[0][8].ToString();
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Selected", dt2.Rows[0][8]);

                }
                if (Status == "Offered")
                {
                    //grdJobStatastics[9, 0].Value = dt2.Rows[0][9].ToString();
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Offered", dt2.Rows[0][9]);

                }
                if (Status == "Offer Accepted")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("OfferAccepted", dt2.Rows[0][10]);

                }
                if (Status == "Placed")
                {
                    this.chart1.Series["Candidate_Count"].Points.AddXY("Placed", dt2.Rows[0][11]);
                }


            }

        }

        
        

        private void chklistStatus_Click(object sender, EventArgs e)
        {
           
        }

        public Job_Statistics_Report()
        {
            InitializeComponent();
        }

        private void Job_Statistics_Report_Load(object sender, EventArgs e)
        {
            
            //Bind Job Title
            ClsStaffRegistration objBindJobTitle=new ClsStaffRegistration();
            DataTable dt = new DataTable();
            dt=objBindJobTitle.BindJobTitle();
            cmbbxJobTitle.DisplayMember = "Job_Title";
            cmbbxJobTitle.DataSource=dt;
          

            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chklistStatus_ItemCheck(object sender, ItemCheckEventArgs e)
         {
            
         }
        public void RoWAdd()
        {
            grdJobStatastics.ReadOnly = false;
            grdJobStatastics.Rows.Add();
        }
        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //grdJobStatastics.Rows.Clear();

            //To fetch data for specific Job Title for all Status
            if (chklistStatus.CheckedItems.Count == 0)
            {
                Job_Title = cmbbxJobTitle.Text;
                FromDate = Convert.ToDateTime(dtFromdate.Text);
                ToDate = Convert.ToDateTime(dtTodate.Text);
                ClsJob obj = new ClsJob(Job_Title, FromDate, ToDate);
                dt = new DataTable();
                dt = obj.GetJobStatasticsReport();

                grdJobStatastics.DataSource = dt;
               

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                row0 = dt.Rows[0];
                var graph1 = row0["Assigned"];

                row1 = dt.Rows[0];
                var graph2 = row1["InterviewScheduled"];

                row2 = dt.Rows[0];
                var graph3 = row2["NotAttended"];

                row3 = dt.Rows[0];
                var graph4 = row3["InterviewRescheduled"];

                row4 = dt.Rows[0];
                var graph5 = row4["Interviewed"];

                row5 = dt.Rows[0];
                var graph6 = row5["OnHold"];

                row6 = dt.Rows[0];
                var graph7 = row6["Rejected"];

                row7 = dt.Rows[0];
                var graph8 = row7["Selected"];

                row8 = dt.Rows[0];
                var graph9 = row8["Offered"];

                row9 = dt.Rows[0];
                var graph10 = row9["OfferAccepted"];

                row10 = dt.Rows[0];
                var graph11 = row10["Placed"];


                this.chart1.Series["Candidate_Count"].Points.AddXY("Assigned", graph1);
                this.chart1.Series["Candidate_Count"].Points.AddXY("InterviewScheduled", graph2);
                this.chart1.Series["Candidate_Count"].Points.AddXY("NotAttended", graph3);
                this.chart1.Series["Candidate_Count"].Points.AddXY("InterviewRescheduled", graph4);
                this.chart1.Series["Candidate_Count"].Points.AddXY("Interviewed", graph5);
                this.chart1.Series["Candidate_Count"].Points.AddXY("OnHold", graph6);
                this.chart1.Series["Candidate_Count"].Points.AddXY("Rejected", graph7);
                this.chart1.Series["Candidate_Count"].Points.AddXY("Selected", graph8);
                this.chart1.Series["Candidate_Count"].Points.AddXY("Offered", graph9);
                this.chart1.Series["Candidate_Count"].Points.AddXY("OfferAccepted", graph10);
                this.chart1.Series["Candidate_Count"].Points.AddXY("Placed", graph11);
            }
            
           

        }

        
    }
}
