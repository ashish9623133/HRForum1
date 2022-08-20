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

namespace GayaSoftHRForum
{
    public partial class ClientPerformanceReport : Form
    {
        
        

        public ClientPerformanceReport()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           

            String[] Itemarr = new String[checkedListBox1.CheckedItems.Count];
            int counter = 0;
            foreach (object item in this.checkedListBox1.CheckedItems)
            {
                String temp = Convert.ToString(item);
                Itemarr[counter] = temp;
                counter++;

            }

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                DateTime fromdate = Convert.ToDateTime(dtpStartDate.Text);
                DateTime enddate = Convert.ToDateTime(dtpEndDate.Text);
                ClsCompany objCompanyGraph = new ClsCompany(Convert.ToInt32(cmbbxCompanygraph.SelectedValue.ToString()), fromdate, enddate);

                DataTable dt = new DataTable();
                dt = objCompanyGraph.Get_GraphCompany();

                
               

                foreach (var series in chartReport.Series)
                {
                    series.Points.Clear();
                }

                chartReport.ChartAreas["ChartArea1"].AxisX.Interval = 1;



                DataRow graph = dt.Rows[0];
                var Candi = graph["Placed"];

                DataRow graph1 = dt.Rows[0];
                var Candi1 = graph1["Assigned"];

                DataRow graph2 = dt.Rows[0];
                var Candi2 = graph2["Interview_Scheduled"];

                DataRow graph3 = dt.Rows[0];
                var Candi3 = graph3["Interview_Not_Attended"];

                DataRow graph4 = dt.Rows[0];
                var Candi4 = graph4["Rejected"];

                DataRow graph5 = dt.Rows[0];
                var Candi5 = graph5["Interview_Resecheduled"];

                DataRow graph6 = dt.Rows[0];
                var Candi6 = graph6["Offered"];

                DataRow graph7 = dt.Rows[0];
                var Candi7 = graph7["On_Hold"];

                DataRow graph8 = dt.Rows[0];
                var Candi8 = graph8["Selected"];

                DataRow graph9 = dt.Rows[0];
                var Candi9 = graph9["Interviewed"];

                DataRow graph10 = dt.Rows[0];
                var Candi10 = graph10["Offer_Accepted"];

                this.chartReport.Series["Company_Count"].Points.AddXY("Placed", Candi);
                this.chartReport.Series["Company_Count"].Points.AddXY("Assigned", Candi1);
                this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Scheduled", Candi2);
                this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Not_Attended", Candi3);
                this.chartReport.Series["Company_Count"].Points.AddXY("Rejected", Candi4);
                this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Resecheduled", Candi5);
                this.chartReport.Series["Company_Count"].Points.AddXY("Offered", Candi6);
                this.chartReport.Series["Company_Count"].Points.AddXY("On_Hold", Candi7);
                this.chartReport.Series["Company_Count"].Points.AddXY("Selected", Candi8);
                this.chartReport.Series["Company_Count"].Points.AddXY("Interviewed", Candi9);
                this.chartReport.Series["Company_Count"].Points.AddXY("Offer_Accepted", Candi10);




                foreach (var series in chartReport.Series)
                {
                    series.Points.Clear();
                    


                }

                



                for (int i = 0; i < Itemarr.Length; i++)
                {
                    string status = Itemarr[i];

                    if (status == "Placed")
                    {


                        this.chartReport.Series["Company_Count"].Points.AddXY("Placed", Candi);

                        


                    }
                    if (status == "Assigned")
                    {

                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Assigned", Candi1);
                    }

                    if (status == "Interview_Scheduled")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Scheduled", Candi2);
                    }
                    if (status == "Interview_Not_Attended")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Not_Attended", Candi3);
                    }

                    if (status == "Rejected")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Rejected", Candi4);
                    }
                    if (status == "Interview_Resecheduled")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Resecheduled", Candi5);
                    }

                    if (status == "Offered")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Offered", Candi6);
                    }
                    if (status == "On_Hold")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("On_Hold", Candi7);
                    }

                    if (status == "Selected")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Selected", Candi8);
                    }
                    if (status == "Offer_Accepted")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Offer_Accepted", Candi9);
                    }

                    if (status == "Interviewed")
                    {
                        

                        this.chartReport.Series["Company_Count"].Points.AddXY("Interviewed", Candi10);
                    }

                    
                }

            }
        }
        private void ClientPerformanceReport_Load(object sender, EventArgs e)
        {
            ClsJob getcomp = new ClsJob();
            DataTable dt = new DataTable();
            dt = getcomp.Getcompany();
            cmbbxCompanygraph.ValueMember = "Company_ID";
            cmbbxCompanygraph.DisplayMember = "Company_Name";
            cmbbxCompanygraph.DataSource = dt;

            


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            

            DateTime fromdate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime enddate = Convert.ToDateTime(dtpEndDate.Text);
            ClsCompany objCompanyGraph = new ClsCompany(Convert.ToInt32(cmbbxCompanygraph.SelectedValue.ToString()), fromdate, enddate);

            DataTable dt = new DataTable();
            dt = objCompanyGraph.Get_GraphCompany();

            foreach (var series in chartReport.Series)
            {
                series.Points.Clear();
            }

            chartReport.ChartAreas["ChartArea1"].AxisX.Interval = 1;



            DataRow graph = dt.Rows[0];
            var Candi = graph["Placed"];

            DataRow graph1 = dt.Rows[0];
            var Candi1 = graph1["Assigned"];

            DataRow graph2 = dt.Rows[0];
            var Candi2 = graph2["Interview_Scheduled"];

            DataRow graph3 = dt.Rows[0];
            var Candi3 = graph3["Interview_Not_Attended"];

            DataRow graph4 = dt.Rows[0];
            var Candi4 = graph4["Rejected"];

            DataRow graph5 = dt.Rows[0];
            var Candi5 = graph5["Interview_Resecheduled"];

            DataRow graph6 = dt.Rows[0];
            var Candi6 = graph6["Offered"];

            DataRow graph7 = dt.Rows[0];
            var Candi7 = graph7["On_Hold"];

            DataRow graph8 = dt.Rows[0];
            var Candi8 = graph8["Selected"];

            DataRow graph9 = dt.Rows[0];
            var Candi9 = graph9["Interviewed"];

            DataRow graph10 = dt.Rows[0];
            var Candi10 = graph10["Offer_Accepted"];

            this.chartReport.Series["Company_Count"].Points.AddXY("Placed", Candi);
            this.chartReport.Series["Company_Count"].Points.AddXY("Assigned", Candi1);
            this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Scheduled", Candi2);
            this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Not_Attended", Candi3);
            this.chartReport.Series["Company_Count"].Points.AddXY("Rejected", Candi4);
            this.chartReport.Series["Company_Count"].Points.AddXY("Interview_Resecheduled", Candi5);
            this.chartReport.Series["Company_Count"].Points.AddXY("Offered", Candi6);
            this.chartReport.Series["Company_Count"].Points.AddXY("On_Hold", Candi7);
            this.chartReport.Series["Company_Count"].Points.AddXY("Selected", Candi8);
            this.chartReport.Series["Company_Count"].Points.AddXY("Interviewed", Candi9);
            this.chartReport.Series["Company_Count"].Points.AddXY("Offer_Accepted", Candi10);

            DataTable dt1 = new DataTable();
            dt1 = objCompanyGraph.Get_GraphCompany();

            grdClientPerformance.DataSource = dt1;
            grdClientPerformance.Show();

            
        }

        private void btnGenerate_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void chartReport_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdClientPerformance.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdClientPerformance.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdClientPerformance.Rows.Count - 0; i++)
            {
                for (int j = 0; j < grdClientPerformance.Columns.Count; j++)
                {
                    if (grdClientPerformance.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdClientPerformance.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }
    }
    
}
