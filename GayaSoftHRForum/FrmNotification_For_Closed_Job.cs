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
    public partial class FrmNotification_For_Closed_Job : Form
    {
        int Count;
        public FrmNotification_For_Closed_Job()
        {
            InitializeComponent();
        }
        public FrmNotification_For_Closed_Job(int count)
        {
            InitializeComponent();
            Count = count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUpdateOpenHoldJob obj = new FrmUpdateOpenHoldJob();
            obj.Show();


            //ClsJob objNotificationClosedJob = new ClsJob(Count);
            //DataTable dt = new DataTable();
            //dt = objNotificationClosedJob.NotificationForClosedJob();
            //lblmsg.Text = "";
        }

        private void FrmNotification_For_Closed_Job_Load(object sender, EventArgs e)
        {
            lblmsg.Text=Count.ToString();
        }
    }
}
