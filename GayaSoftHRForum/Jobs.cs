using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GayaSoftHRForum;
using GayaSoftHRForumLibrary.HR;
using System.Data.SqlClient;


namespace GayaSoftHRForum
{
    public partial class Jobs : Form
    {
        //private object worksheet;
        public int Staff_Register_Id;

        public Jobs()
        {
            InitializeComponent();
        }
        public Jobs(int staff_id)
        {
            InitializeComponent();
            Staff_Register_Id = staff_id;
        }


        private void lbladdjob_Click(object sender, EventArgs e)
        {

        }
        private void btnaddjob_Click(object sender, EventArgs e)
        {
            AddJob addjob = new AddJob();
            addjob.Show();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            

            ClsJob getjob = new ClsJob();
            DataTable dt = new DataTable();
            dt = getjob.getaddjob();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();

            this.gridviewJobAdd.Columns["Job_ID"].Visible = false;

           // this.gridviewJobAdd.Columns["Candidate_ID"].Visible = false;
            //this.grdAssigned.Columns["Job_ID"].Visible = false;
            //this.gridviewJobAdd.Columns["Company_ID"].Visible = false;



        }

        private void gridviewJobAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) 
               
                if(MessageBox.Show("Do you Want Remove This Row","Remove Row ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)

            {

                int Job_ID = Convert.ToInt32(gridviewJobAdd.CurrentRow.Cells[3].Value.ToString());
                gridviewJobAdd.Rows.Remove(gridviewJobAdd.Rows[e.RowIndex]);
                ClsJob delt = new ClsJob(Job_ID);
                delt.deleteJob();
                MessageBox.Show("Delete SuccessFully.....!!!!");

            }
            if (e.ColumnIndex == 0)
            {

                int Job_ID = Convert.ToInt32(gridviewJobAdd.CurrentRow.Cells[3].Value.ToString());
                Candidate_Pipeline obj = new Candidate_Pipeline(Job_ID, Staff_Register_Id);
                obj.Show();
            }


            if (e.ColumnIndex == 1)
            {

                int Job_ID = Convert.ToInt32(gridviewJobAdd.CurrentRow.Cells[3].Value.ToString());
                Update_Job updjob = new Update_Job(Job_ID);
                updjob.Show();

                updjob.txtjobtital.Text = gridviewJobAdd.CurrentRow.Cells[4].Value.ToString();

                updjob.cmbbxminexp.Text = gridviewJobAdd.CurrentRow.Cells[10].Value.ToString();
                updjob.cmbbxmaxExp.Text = gridviewJobAdd.CurrentRow.Cells[11].Value.ToString();
                updjob.txtrichfulladdress.Text = gridviewJobAdd.CurrentRow.Cells[8].Value.ToString();
                updjob.txtminsalary.Text = gridviewJobAdd.CurrentRow.Cells[13].Value.ToString();
                updjob.txtnumbropening.Text = gridviewJobAdd.CurrentRow.Cells[12].Value.ToString();
                updjob.cmbbxcompany.Text = gridviewJobAdd.CurrentRow.Cells[6].Value.ToString();
                updjob.txtmaxsalary.Text = gridviewJobAdd.CurrentRow.Cells[14].Value.ToString();

            }

            //for (int i = 0; i < gridviewJobAdd.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < gridviewJobAdd.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = gridviewJobAdd.Rows[i].Cells[j].Value.ToString();

            //    }
            //}
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ClsJob serchjob = new ClsJob(txtserchjob.Text);
            DataTable dt = new DataTable();
            dt = serchjob.SerachJob();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();

        }

        private void txtserchjob_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnimport_Click(object sender, EventArgs e)
        {

            FrmImportJob objimportJob = new FrmImportJob();
            objimportJob.Show();

            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "select file";
            //fdlg.InitialDirectory = @"D:\";
            //fdlg.FileName = btnimport.Text;
            //fdlg.Filter = "excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            //fdlg.FilterIndex = 1;
            //fdlg.RestoreDirectory = true;
            //if(fdlg.ShowDialog()==DialogResult.OK)
            //{
            //    btnimport.Text = fdlg.FileName;
                
            //    Application.DoEvents();
            //}
        }

        private void btnexport_Click(object sender, EventArgs e)
        {

            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 4; i < gridviewJobAdd.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = gridviewJobAdd.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < gridviewJobAdd.Rows.Count - 1; i++)
            //{
            //    for (int j = 3; j < gridviewJobAdd.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = gridviewJobAdd.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("D:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();




            ////DataObject dataObject = gridviewJobAdd.GetClipboardContent();
            ////gridviewJobAdd.SelectAll();

            ////if (dataObject != null) Clipboard.SetDataObject(dataObject);
            ////Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            ////xlapp.Visible = true;

            ////Microsoft.Office.Interop.Excel.Workbook xlwbook;
            ////Microsoft.Office.Interop.Excel.Worksheet xlwsheet;

            ////object miseddata = System.Reflection.Missing.Value;
            ////xlwbook = xlapp.Workbooks.Add(miseddata);

            ////xlwsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            ////Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlwsheet.Cells[1, 1];
            ////xlr.Select();

            ////xlwsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void CmbbxFilter_job_Stream_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Job_Stream_ID = Convert.ToInt32(CmbbxFilter_job_Stream.SelectedValue);

            ClsJob objcan = new ClsJob(Job_Stream_ID);
            DataTable dt = new DataTable();
            dt = objcan.Job_Stream_Filter();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();
        }

        private void cmbbxFilterJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Job_ID = Convert.ToInt32(cmbbxFilterJob.SelectedValue);

            ClsJob objcan = new ClsJob(Job_ID);
            DataTable dt = new DataTable();
            dt = objcan.Job_title_Filter();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            //---------------------Filter_By_Job_title-----------------



            ClsJob objFilter = new ClsJob();
            DataTable dt1 = new DataTable();
            dt1 = objFilter.Filter_By_Job_Title();

            cmbbxFilterJob.ValueMember = "Job_ID";
            cmbbxFilterJob.DisplayMember = "Job_Title";
            cmbbxFilterJob.DataSource = dt1;
            cmbbxFilterJob.Text = "Filter_By_Job_title";
            cmbbxFilterJob.Show();




            //  -----------------------Job_Stream_Name--------------------------------

            ClsJob objFilter1 = new ClsJob();
            DataTable dt2 = new DataTable();
            dt2 = objFilter1.Filter_By_Job_Stream_Name();

            CmbbxFilter_job_Stream.ValueMember = "Job_Stream_ID";
            CmbbxFilter_job_Stream.DisplayMember = "Job_Stream_Name";
            CmbbxFilter_job_Stream.DataSource = dt2;
            CmbbxFilter_job_Stream.Text = "Job_Stream_Name";
            CmbbxFilter_job_Stream.Show();

           // ----------------Job_Stream_Filter_Job_title_Filter-------------------- -

            int Job_ID = Convert.ToInt32(cmbbxFilterJob.SelectedValue);
            int Job_Stream_ID = Convert.ToInt32(CmbbxFilter_job_Stream.SelectedValue);

            ClsJob objcan = new ClsJob(Job_ID, Job_Stream_ID);
            DataTable dt3 = new DataTable();
            dt3 = objcan.Job_Stream_Filter_Job_title_Filter();
            gridviewJobAdd.DataSource = dt3;
            gridviewJobAdd.Show();


            ClsJob getjob = new ClsJob();
            DataTable dt = new DataTable();
            dt = getjob.getaddjob();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsJob getjob = new ClsJob();
            DataTable dt = new DataTable();
            dt = getjob.getaddjob();
            gridviewJobAdd.DataSource = dt;
            gridviewJobAdd.Show();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 4; i < gridviewJobAdd.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = gridviewJobAdd.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < gridviewJobAdd.Rows.Count - 1; i++)
            {
                for (int j = 3; j < gridviewJobAdd.Columns.Count; j++)
                {
                    if (gridviewJobAdd.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = gridviewJobAdd.Rows[i].Cells[j].Value.ToString();
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
    

