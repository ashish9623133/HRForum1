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
using Microsoft.Office.Interop.Excel;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class frmCandidateImport : Form
    {
        private object worksheet;
        int i,Cityid,StaffID, Qualificationid, SpecializationID, JobStreamID, StatusID;
        string City_Name, Email_ID, Qualification, Specialization_Name, Job_Stream_Name, Status;

        private void frmCandidateImport_Load(object sender, EventArgs e)
        {

        }

        
        public frmCandidateImport()
        {
            InitializeComponent();
        }

        private void btnBrowseCandidateImport_Click(object sender, EventArgs e)
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


                for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;

                    grdImportCandidate.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text, xlRange.Cells[xlRow, 15].Text, xlRange.Cells[xlRow, 16].Text,
                         xlRange.Cells[xlRow, 17].Text, xlRange.Cells[xlRow, 18].Text, xlRange.Cells[xlRow, 19].Text, xlRange.Cells[xlRow, 20].Text, xlRange.Cells[xlRow, 21].Text, xlRange.Cells[xlRow, 22].Text, xlRange.Cells[xlRow, 23].Text, xlRange.Cells[xlRow, 24].Text, xlRange.Cells[xlRow, 25].Text,
                          xlRange.Cells[xlRow, 26].Text, xlRange.Cells[xlRow, 27].Text, xlRange.Cells[xlRow, 28].Text, xlRange.Cells[xlRow, 29].Text, xlRange.Cells[xlRow, 30].Text, xlRange.Cells[xlRow, 31].Text, xlRange.Cells[xlRow, 32].Text, xlRange.Cells[xlRow, 33].Text, xlRange.Cells[xlRow, 34].Text, xlRange.Cells[xlRow, 35].Text, xlRange.Cells[xlRow, 36].Text, xlRange.Cells[xlRow, 37].Text, xlRange.Cells[xlRow, 38].Text, xlRange.Cells[xlRow, 39].Text, xlRange.Cells[xlRow, 40].Text, xlRange.Cells[xlRow, 41].Text, xlRange.Cells[xlRow, 42].Text, xlRange.Cells[xlRow, 43].Text, xlRange.Cells[xlRow, 44].Text);

                    foreach (DataGridViewRow dr in grdImportCandidate.Rows)
                    {
                        Email_ID = dr.Cells[1].Value.ToString();
                        City_Name = dr.Cells[7].Value.ToString();
                        
                        Qualification = dr.Cells[9].Value.ToString();
                        Specialization_Name = dr.Cells[10].Value.ToString();
                        Job_Stream_Name = dr.Cells[30].Value.ToString();
                       // Status = dr.Cells[40].Value.ToString();

                        ClsCandidateRegistration ObjCandidateImport1 = new ClsCandidateRegistration(Email_ID);
                        SqlDataReader DR1;
                        DR1 = ObjCandidateImport1.FetchStaffRegID();
                        if (DR1.Read())
                        {
                            StaffID = Convert.ToInt32(DR1["Staff_Register_ID"]);
                        }
                        //if(DR1.HasRows)
                        //{
                        //    //while(DR1.Read())
                        //    //{
                        //    //    StaffID = (int)DR1["Staff_Register_ID"];

                        //    //}
                        //}

                        //DR1.Close();

                        ClsCandidateRegistration ObjCandidateImport = new ClsCandidateRegistration(City_Name);
                        SqlDataReader DR;
                        DR = ObjCandidateImport.FetchCityID();
                        if (DR.Read())
                        {
                            Cityid = (int)DR["City_ID"];

                        }
                        DR.Close();

                        ClsCandidateRegistration ObjCandidateImport2 = new ClsCandidateRegistration(Qualification);
                        SqlDataReader DR2;
                        DR2 = ObjCandidateImport2.FetchQualificationID();
                        if (DR2.Read())
                        {
                            Qualificationid = (int)DR2["Qualification_ID"];

                        }
                        DR2.Close();

                        ClsCandidateRegistration ObjCandidateImport3 = new ClsCandidateRegistration(Specialization_Name);
                        SqlDataReader DR3;
                        DR3 = ObjCandidateImport3.FetchSpecializationID();
                        if (DR3.Read())
                        {
                            SpecializationID = (int)DR3["Specialization_ID"];
                        }
                        DR3.Close();






                        ClsCandidateRegistration ObjCandidateImport4 = new ClsCandidateRegistration(Job_Stream_Name);
                        SqlDataReader DR4;
                        DR4 = ObjCandidateImport4.FetchJobStreamID();
                        if (DR4.Read())
                        {
                            JobStreamID = (int)DR4["Job_Stream_ID"];

                        }
                        DR4.Close();


                        //ClsCandidateRegistration ObjCandidateImport5 = new ClsCandidateRegistration(Status);
                        //SqlDataReader DR5;
                        //DR5 = ObjCandidateImport5.FetchStatusID();
                        //if (DR5.Read())
                        //{
                        //    StatusID = (int)DR5["Status_ID"];

                        //}
                        //DR5.Close();


                        ClsCandidateRegistration objCandidate = new ClsCandidateRegistration(StaffID, dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString(), Convert.ToDateTime(dr.Cells[6].Value.ToString()),
                               Convert.ToInt32(Cityid), dr.Cells[8].Value.ToString(), Convert.ToInt32(Qualificationid), Convert.ToInt32(SpecializationID), dr.Cells[11].Value.ToString(), dr.Cells[12].Value.ToString(), dr.Cells[13].Value.ToString(),
                               dr.Cells[14].Value.ToString(), dr.Cells[15].Value.ToString(), dr.Cells[16].Value.ToString(), dr.Cells[17].Value.ToString(), dr.Cells[18].Value.ToString(),
                               dr.Cells[19].Value.ToString(), dr.Cells[20].Value.ToString(), dr.Cells[21].Value.ToString(), dr.Cells[22].Value.ToString(), dr.Cells[23].Value.ToString(), dr.Cells[24].Value.ToString(), dr.Cells[25].Value.ToString(),
                               dr.Cells[26].Value.ToString(), dr.Cells[27].Value.ToString(), dr.Cells[28].Value.ToString(), dr.Cells[29].Value.ToString(), Convert.ToInt32(JobStreamID), dr.Cells[31].Value.ToString(),
                               dr.Cells[32].Value.ToString(), dr.Cells[33].Value.ToString(), dr.Cells[34].Value.ToString(), dr.Cells[35].Value.ToString(), dr.Cells[36].Value.ToString(),
                               dr.Cells[37].Value.ToString(), dr.Cells[38].Value.ToString(), dr.Cells[39].Value.ToString(), dr.Cells[41].Value.ToString(), Convert.ToDateTime(dr.Cells[42].Value.ToString()),
                               Convert.ToInt32(dr.Cells[43].Value.ToString()));
                        objCandidate.SaveCandidateInfo();
                        MessageBox.Show("Data Saved Successfully..!");
                        break;
                    }

                }

                xlWorkbook.Close();
                xlApp.Quit();

                FrmCandidateList objCanList=new FrmCandidateList();
                objCanList.Show();
            }
        }
    }
}
