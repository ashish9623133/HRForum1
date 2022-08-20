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



namespace GayaSoftHRForum
{
    public partial class Frm_Team_Performance_Report : Form
    {
      public  string[] Value;

        int Staff_ID;
        DateTime Fromassigndate;
        DateTime Toassigndate;
        public Frm_Team_Performance_Report()
        {
            InitializeComponent();
        }
       
        private void Frm_Team_Performance_Report_Load(object sender, EventArgs e)
        {
            ClsStaffRegistration objobjclsStaffRegistration = new ClsStaffRegistration();
            DataTable dt = new DataTable();
            dt = objobjclsStaffRegistration.BindTeamMember();
            cbbxteammember.DisplayMember = "Full_Name";
            cbbxteammember.ValueMember = "Staff_Register_ID";
            cbbxteammember.DataSource = dt;
            cbbxteammember.Text = "Select Team Member";

        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Show Graph Data

            if (chbxstatus.CheckedItems.Count == 0)
            { 
                Staff_ID = Convert.ToInt32(cbbxteammember.SelectedValue.ToString());
                Fromassigndate = Convert.ToDateTime(dtpstartdate.Text);
                Toassigndate = Convert.ToDateTime(dtpenddate.Text);

                Fromassigndate.ToShortDateString();
                Toassigndate.ToShortDateString();

                ClsStaffRegistration objTPR = new ClsStaffRegistration(Staff_ID, Fromassigndate, Toassigndate);

                DataTable dt2 = new DataTable();
                dt2 = objTPR.Team_Performance_Report();

                DGVStatusTotal.DataSource = dt2;
                DGVStatusTotal.Show();

              

                foreach (var series in Team_Performance_Report.Series)
                {
                    series.Points.Clear();
                }
                Team_Performance_Report.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                DataRow graph = dt2.Rows[0];
                var TPR = graph["placed"];

                DataRow graph1 = dt2.Rows[0];
                var TPR1 = graph1["Assigned"];

                DataRow graph2 = dt2.Rows[0];
                var TPR2 = graph2["Interview_Scheduled"];

                DataRow graph3 = dt2.Rows[0];
                var TPR3 = graph3["Interview_Not_Attended"];

                DataRow graph4 = dt2.Rows[0];
                var TPR4 = graph4["Rejected"];

                DataRow graph5 = dt2.Rows[0];
                var TPR5 = graph5["Interview_Rescheduled"];

                DataRow graph6 = dt2.Rows[0];
                var TPR6 = graph6["Offered"];

                DataRow graph7 = dt2.Rows[0];
                var TPR7 = graph7["On_Hold"];

                DataRow graph8 = dt2.Rows[0];
                var TPR8 = graph8["Selected"];

                DataRow graph9 = dt2.Rows[0];
                var TPR9 = graph9["Offer_Accepted"];

                DataRow graph10 = dt2.Rows[0];
                var TPR10 = graph10["Interviewed"];

                //  DataRow graph9 = dt2.Rows[0];
                // var TPR9 = graph["Candidate_Added"];



                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("placed", TPR);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Assigned", TPR1);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Scheduled", TPR2);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Not_Attended", TPR3);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Rejected", TPR4);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Resecheduled", TPR5);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offered", TPR6);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("On_Hold", TPR7);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Selected", TPR8);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offer_Accepted", TPR9);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interviewed", TPR10);
                // this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Candidate_Added", TPR9);
            }
           
        }
          

        private void chbxstatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void chbxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            int f = 0;
            string qry = "";
            for (int N = 0; N < chbxstatus.Items.Count; N++)
            {
                if (chbxstatus.GetItemChecked(N))
                {
                    if (f == 1)
                    {
                        qry = chbxstatus.Items[N].ToString();
                        this.DGVStatusTotal.Columns[qry].Visible = true;
                    }
                    if (f == 0)
                    {
                        qry = chbxstatus.Items[N].ToString();
                        f = 1;
                        this.DGVStatusTotal.Columns[qry].Visible = true;
                    }
                }
                else
                {
                    qry = chbxstatus.Items[N].ToString();
                    this.DGVStatusTotal.Columns[qry].Visible = false;
                }
            }



            // Checklistbox Code

            String[] Itemarr = new String[chbxstatus.CheckedItems.Count];
            int counter = 0;
            foreach (object item in this.chbxstatus.CheckedItems)
            {
                String temp = Convert.ToString(item);
                Itemarr[counter] = temp;
                counter++;

            }

            if (chbxstatus.CheckedItems.Count > 0)
            {
                Staff_ID = Convert.ToInt32(cbbxteammember.SelectedValue.ToString());
                Fromassigndate = Convert.ToDateTime(dtpstartdate.Text);
                Toassigndate = Convert.ToDateTime(dtpenddate.Text);

                Fromassigndate.ToShortDateString();
                Toassigndate.ToShortDateString();

                ClsStaffRegistration objTPR = new ClsStaffRegistration(Staff_ID, Fromassigndate, Toassigndate);

                DataTable dt3 = new DataTable();
                dt3 = objTPR.Team_Performance_Report();


                foreach (var series in Team_Performance_Report.Series)
                {
                    series.Points.Clear();
                }

                Team_Performance_Report.ChartAreas["ChartArea1"].AxisX.Interval = 1;



                DataRow graph = dt3.Rows[0];
                var Candi = graph["placed"];

                DataRow graph1 = dt3.Rows[0];
                var Candi1 = graph1["Assigned"];

                DataRow graph2 = dt3.Rows[0];
                var Candi2 = graph2["Interview_Scheduled"];

                DataRow graph3 = dt3.Rows[0];
                var Candi3 = graph3["Interview_Not_Attended"];

                DataRow graph4 = dt3.Rows[0];
                var Candi4 = graph4["Rejected"];

                DataRow graph5 = dt3.Rows[0];
                var Candi5 = graph5["Interview_Rescheduled"];

                DataRow graph6 = dt3.Rows[0];
                var Candi6 = graph6["Offered"];

                DataRow graph7 = dt3.Rows[0];
                var Candi7 = graph7["On_Hold"];

                DataRow graph8 = dt3.Rows[0];
                var Candi8 = graph8["Selected"];

                DataRow graph9 = dt3.Rows[0];
                var Candi9 = graph9["Interviewed"];

                DataRow graph10 = dt3.Rows[0];
                var Candi10 = graph10["Offer_Accepted"];

                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("placed", Candi);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Assigned", Candi1);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Scheduled", Candi2);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Not_Attended", Candi3);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Rejected", Candi4);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Rescheduled", Candi5);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offered", Candi6);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("On_Hold", Candi7);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Selected", Candi8);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interviewed", Candi9);
                this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offer_Accepted", Candi10);

                foreach (var series in Team_Performance_Report.Series)
                {
                    series.Points.Clear();
                }


                for (int i = 0; i < Itemarr.Length; i++)
                {
                    string status = Itemarr[i];

                    if (status == "placed")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("placed", Candi);
                    }
                    if (status == "Assigned")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Assigned", Candi1);
                    }

                    if (status == "Interview_Scheduled")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Scheduled", Candi2);
                    }
                    if (status == "Interview_Not_Attended")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Not_Attended", Candi3);
                    }

                    if (status == "Rejected")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Rejected", Candi4);
                    }
                    if (status == "Interview_Rescheduled")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interview_Resecheduled", Candi5);
                    }

                    if (status == "Offered")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offered", Candi6);
                    }
                    if (status == "On_Hold")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("On_Hold", Candi7);
                    }

                    if (status == "Selected")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Selected", Candi8);
                    }
                    if (status == "Offer_Accepted")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Offer_Accepted", Candi9);
                    }

                    if (status == "Interviewed")
                    {
                        this.Team_Performance_Report.Series["Team_Performance_Report"].Points.AddXY("Interviewed", Candi10);
                    }

                }



            }


        }
        private void DGVStatusTotal_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnExport_Click(object sender, EventArgs e)
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
            for (int i = 1; i < DGVStatusTotal.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DGVStatusTotal.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DGVStatusTotal.Rows.Count - 0; i++)
            {
                for (int j = 0; j < DGVStatusTotal.Columns.Count; j++)
                {
                    if (DGVStatusTotal.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGVStatusTotal.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
