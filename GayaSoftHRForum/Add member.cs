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
    public partial class Add_member : Form
    {
        int Staff_Register_ID;
        public Add_member()
        {
            InitializeComponent();
        }

        private void Add_member_Load(object sender, EventArgs e)
        {
            ClsStaffRegistration objcan = new ClsStaffRegistration();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = objcan.Addmember();
            grdDataview.DataSource = dt;
            grdDataview.Show();

            this.grdDataview.Columns["Staff_Register_ID"].Visible = false;
        }

        private void grdDataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
              
        }

        private void grdDataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                if (MessageBox.Show("Do You Want To Remove This Row", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Staff_Register_ID = Convert.ToInt32(grdDataview.CurrentRow.Cells[2].Value.ToString());
                    grdDataview.Rows.Remove(grdDataview.Rows[e.RowIndex]);
                   ClsStaffRegistration objdelete = new ClsStaffRegistration(Staff_Register_ID);
                    objdelete.deleterow();
                    MessageBox.Show("Deleted SuccessFully");
                }
            if (e.ColumnIndex == 1)
            {
                int Staff_Register_ID = Convert.ToInt32(grdDataview.CurrentRow.Cells[2].Value);
                frmMemberSettingEditStaff objstaff = new frmMemberSettingEditStaff(Staff_Register_ID);
                objstaff.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffRegistration objadd = new StaffRegistration();          
            objadd.Show();
           
        }
    }
}
