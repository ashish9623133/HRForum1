using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForum
{
    public partial class FrmCompanyList : Form
    {
        int companyID, Staff_ID;
        public FrmCompanyList(int staff_id)
        {
            InitializeComponent();
            Staff_ID=staff_id;
        }

        public FrmCompanyList()
        {
            InitializeComponent();
        }


        System.Data.DataTable dt = new System.Data.DataTable();
        System.Data.DataTable dt1 = new System.Data.DataTable();

        private void FrmCompanyList_Load(object sender, EventArgs e)
        {
            ClsCompany objCompany = new ClsCompany();
            dt = objCompany.ShowAllCompanies();
            grdviewCompanyList.DataSource = dt;
            grdviewCompanyList.Show();

            this.grdviewCompanyList.Columns["Company_ID"].Visible = false;
        }
        

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            FrmCompanyRegistration objCompanyReg = new FrmCompanyRegistration();
            objCompanyReg.Show();
            //objCompanyReg.MdiParent = this;
        }

        private void grdviewCompanyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void btnImport_Click(object sender, EventArgs e)
        {
            FrmImportCompany objImport = new FrmImportCompany();
            objImport.Show();

            //Microsoft.Office.Interop.Excel.Application xlApp;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            //Microsoft.Office.Interop.Excel.Range xlRange;

            //int xlRow;
            //string strfilename;


            //openFileDialog1.Filter = "Excel Office (*.xlx)|*.xlx|All Files(*.*)|*.*";
            //openFileDialog1.ShowDialog();
            //strfilename = openFileDialog1.FileName;

            //if(strfilename != string.Empty)
            //{
            //    xlApp = new Microsoft.Office.Interop.Excel.Application();
            //    xlWorkbook = xlApp.Workbooks.Open(strfilename);
            //    xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
            //    xlRange = xlWorksheet.UsedRange;

            //    int i = 0;
            //    for(xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
            //    {
            //        i++;
            //        grdviewCompanyList.Rows.Add(i, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text);
            //        xlWorkbook.Close();
            //        xlApp.Quit();
            //    }
            //}




        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtSearch.Text == "")
            {
                ClsCompany objCompany = new ClsCompany();
                dt = objCompany.ShowAllCompanies();
                grdviewCompanyList.DataSource = dt;

                grdviewCompanyList.Show();

            }
            else
            {
                ClsCompany objcompany = new ClsCompany(txtSearch.Text, txtSearch.Text, txtSearch.Text);
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = objcompany.Search();
                grdviewCompanyList.DataSource = dt;
                grdviewCompanyList.Show();
                
            }

            


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          

        }

        
        private void CmbbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Industry_ID = Convert.ToInt32(CmbbxFilter.SelectedValue);

            ClsCompany objcan = new ClsCompany(Industry_ID);

            System.Data.DataTable dt2 = new System.Data.DataTable();
            dt2 = objcan.Filter_By_Industry_Name_Fron_Grd();
            grdviewCompanyList.DataSource = dt2;
            grdviewCompanyList.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            //--------------Filter_By_Industry_Name----------------
            ClsCompany objFilter = new ClsCompany();

            dt1 = objFilter.Filter_By_Industry_Name();

            CmbbxFilter.ValueMember = "Industry_ID";
            CmbbxFilter.DisplayMember = "Industry_Name";
            CmbbxFilter.DataSource = dt1;
            CmbbxFilter.Text = "Filter_By_Industry_Name";
            CmbbxFilter.Show();

            ClsCompany objCompany = new ClsCompany();
            dt = objCompany.ShowAllCompanies();
            grdviewCompanyList.DataSource = dt;
            grdviewCompanyList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCompany objCompany = new ClsCompany();
            dt = objCompany.ShowAllCompanies();
            grdviewCompanyList.DataSource = dt;
            grdviewCompanyList.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 4; i < grdviewCompanyList.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdviewCompanyList.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdviewCompanyList.Rows.Count - 1; i++)
            {
                for (int j = 3; j < grdviewCompanyList.Columns.Count; j++)
                {
                    if (grdviewCompanyList.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdviewCompanyList.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void grdviewCompanyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                companyID = Convert.ToInt32(grdviewCompanyList.CurrentRow.Cells[3].Value.ToString());
                //Individual_Company_Details objCompanyDetails = new Individual_Company_Details(companyID, Staff_ID);
                Individual_Companywise_Job_Opening_List objCompanyDetails = new Individual_Companywise_Job_Opening_List(companyID, Staff_ID);
                objCompanyDetails.Show();
            }
            if (e.ColumnIndex == 1)
            {
                FrmEditCompany.Companyid = Convert.ToInt32(grdviewCompanyList.CurrentRow.Cells[3].Value.ToString());
                FrmEditCompany.name = grdviewCompanyList.CurrentRow.Cells[4].Value.ToString();
                FrmEditCompany.email = grdviewCompanyList.CurrentRow.Cells[5].Value.ToString();

                FrmEditCompany.industryname = grdviewCompanyList.CurrentRow.Cells[6].Value.ToString();

                FrmEditCompany.CompanyWebsite = grdviewCompanyList.CurrentRow.Cells[7].Value.ToString();

                FrmEditCompany.CompanyOwner = grdviewCompanyList.CurrentRow.Cells[8].Value.ToString();

                FrmEditCompany.Address = grdviewCompanyList.CurrentRow.Cells[9].Value.ToString();

                FrmEditCompany.FacebookProfile = grdviewCompanyList.CurrentRow.Cells[10].Value.ToString();

                FrmEditCompany.LinkedInProfile = grdviewCompanyList.CurrentRow.Cells[11].Value.ToString();

                FrmEditCompany.TwitterProfile = grdviewCompanyList.CurrentRow.Cells[12].Value.ToString();

                FrmEditCompany objcompany = new FrmEditCompany();

                objcompany.Show();
            }

            if (e.ColumnIndex == 2)
            {
                int companyID = Convert.ToInt32(grdviewCompanyList.CurrentRow.Cells[3].Value.ToString());
                grdviewCompanyList.Rows.Remove(grdviewCompanyList.Rows[e.RowIndex]);
                ClsCompany objCompany = new ClsCompany(companyID);
                objCompany.DeleteCompany();
                MessageBox.Show("Delete Data Successfully..!");

            }
        }
    }
}

