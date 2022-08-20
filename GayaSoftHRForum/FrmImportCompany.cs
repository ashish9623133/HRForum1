using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Configuration;
using GayaSoftHRForumLibrary.HR;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class FrmImportCompany : Form
    {
        string industryName, CityName;
            int i,industryid, cityid, Isdeleted=0, Status=1;

        private void FrmImportCompany_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        public FrmImportCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;


            openFileDialog1.Filter = "Excel Office (*.xlx)|*.xlx|All Files(*.*)|*.*";
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

                    grdImportCompany.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text);

                    foreach (DataGridViewRow dr in grdImportCompany.Rows)
                    {
                        industryName = dr.Cells[2].Value.ToString();
                        CityName = dr.Cells[4].Value.ToString();


                        ClsCompany Objcompany = new ClsCompany(industryName);
                        SqlDataReader DR;
                        DR = Objcompany.GetIndustryID();
                        if (DR.Read())
                        {
                            industryid = (int)DR["Industry_ID"];       //dr.Cells[2].Value.ToString();

                        }
                        DR.Close();


                        ClsCompany ObjCompany = new ClsCompany(CityName);
                        SqlDataReader DR1;
                        DR1 = ObjCompany.GetCityID();
                        if (DR1.Read())
                        {
                            cityid = (int)DR1["City_ID"];

                        }
                        DR1.Close();



                        ClsCompany objCompany = new ClsCompany(dr.Cells[1].Value.ToString(), Convert.ToInt32(industryid.ToString()), dr.Cells[3].Value.ToString(), Convert.ToInt32(cityid.ToString()),
                                                        dr.Cells[5].Value.ToString(), dr.Cells[6].Value.ToString(), dr.Cells[7].Value.ToString(), dr.Cells[8].Value.ToString(),
                                                        dr.Cells[9].Value.ToString(), dr.Cells[10].Value.ToString(), Status, Convert.ToDateTime(dr.Cells[12].Value.ToString()),
                                                        DateTime.Today, Isdeleted);
                        objCompany.RegisterCompany();
                        MessageBox.Show("Data Saved Successfully..!");
                        this.Close();
                    }

                }
                xlWorkbook.Close();
                xlApp.Quit();
                
                FrmCompanyList objcompanyList = new FrmCompanyList();
                objcompanyList.Show();



            }
        }
    }
}
