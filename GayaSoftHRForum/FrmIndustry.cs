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
    public partial class FrmIndustry : Form
    {
        public FrmIndustry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveIndustry_Click(object sender, EventArgs e)
        {
            ClsCompany objcompany = new ClsCompany(txtAddIndustry.Text);
            DataTable dt = new DataTable();
            dt = objcompany.AddIndustry();
            MessageBox.Show("Industry Added Successfully..!");
        }
    }
}
