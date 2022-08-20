using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using GayaSoftHRForumLibrary.HR;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class FrmImportJob : Form
    {
        string companyname, jobstream, qualification, specialization, city, status, Hrname;
        int i, companyid, jobstreamid, qualificationid, specializationid, cityid, statusid, Hrid, isdeleted = 0;
        public FrmImportJob()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;


            openFileDialog1.Filter = "Excel Office (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFileDialog1.ShowDialog();
            strfilename = openFileDialog1.FileName;

            if (strfilename != string.Empty)
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strfilename);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;


                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {

                    i++;

                    grdJob.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text,
                        xlRange.Cells[xlRow, 15].Text, xlRange.Cells[xlRow, 16].Text, xlRange.Cells[xlRow, 17].Text, xlRange.Cells[xlRow, 18].Text, xlRange.Cells[xlRow, 19].Text, xlRange.Cells[xlRow, 20].Text, xlRange.Cells[xlRow, 21].Text, xlRange.Cells[xlRow, 22].Text, xlRange.Cells[xlRow, 23].Text);

                    foreach (DataGridViewRow dr in grdJob.Rows)
                    {
                        companyname = dr.Cells[3].Value.ToString();
                        jobstream = dr.Cells[11].Value.ToString();
                        qualification = dr.Cells[14].Value.ToString();
                        specialization = dr.Cells[15].Value.ToString();
                        city = dr.Cells[18].Value.ToString();
                        status = dr.Cells[21].Value.ToString();
                        Hrname = dr.Cells[23].Value.ToString();


                       ClsJob objcompany = new ClsJob(companyname);
                        SqlDataReader DR;
                        DR = objcompany.GetcompnyID();
                        if (DR.Read())
                        {
                            companyid = (int)DR["Company_ID"];
                        }

                        ClsJob objjobstream = new ClsJob(jobstream);
                        SqlDataReader DR1;
                        DR1 = objjobstream.GetjobStreamID();
                        if (DR1.Read())
                        {
                            jobstreamid = (int)DR1["Job_Stream_ID"];
                        }


                        ClsJob objqual = new ClsJob(qualification);
                        SqlDataReader DR2;
                        DR2 = objqual.GetqualificationID();
                        if (DR2.Read())
                        {
                            qualificationid = (int)DR2["Qualification_ID"];
                        }


                        ClsJob objspec = new ClsJob(specialization);
                        SqlDataReader DR3;
                        DR3 = objspec.GetspecializationID();
                        if (DR3.Read())
                        {
                            specializationid = (int)DR3["Specialization_ID"];
                        }



                        ClsJob objcity = new ClsJob(city);
                        SqlDataReader DR4;
                        DR4 = objcity.GetcityID();
                        if (DR4.Read())
                        {
                            cityid = (int)DR4["City_ID"];
                        }


                        ClsJob objstatus = new ClsJob(status);
                        SqlDataReader DR5;
                        DR5 = objstatus.GetstatusID();
                        if (DR5.Read())
                        {
                            statusid = (int)DR5["Status_ID"];
                        }


                        ClsJob objhr = new ClsJob(Hrname);
                        SqlDataReader DR6;
                        DR6 = objhr.GethrID();
                        if (DR6.Read())
                        {
                            Hrid = (int)DR6["Company_HR_Contact_ID"];
                        }


                        ClsJob objinsert = new ClsJob(dr.Cells[1].Value.ToString(), Convert.ToInt32(dr.Cells[2].Value.ToString()), Convert.ToInt32(companyid.ToString()), Convert.ToDateTime(dr.Cells[4].Value.ToString()), Convert.ToDateTime(dr.Cells[5].Value.ToString()),
                            dr.Cells[6].Value.ToString(), dr.Cells[7].Value.ToString(), dr.Cells[8].Value.ToString(), dr.Cells[9].Value.ToString(), dr.Cells[10].Value.ToString(), Convert.ToInt32(jobstreamid.ToString()), dr.Cells[12].Value.ToString(), dr.Cells[13].Value.ToString(),
                            Convert.ToInt32(qualificationid.ToString()), Convert.ToInt32(specializationid.ToString()), Convert.ToDateTime(dr.Cells[16].Value.ToString()), dr.Cells[17].Value.ToString(), Convert.ToInt32(cityid.ToString()), dr.Cells[19].Value.ToString(),
                            DateTime.Today, Convert.ToInt32(statusid.ToString()), isdeleted, Convert.ToInt32(Hrid.ToString()));

                        objinsert.Addjob();
                        MessageBox.Show("Data saved successfully..!");
                        
                        Jobs obj = new Jobs();
                        obj.Show();
                        break;
                    }
                    
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
        }
    }
}
