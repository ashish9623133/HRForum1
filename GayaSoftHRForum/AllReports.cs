using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class AllReports : Form
    {
        public AllReports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void AllReports_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void clientPerformanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientPerformanceReport objreport = new ClientPerformanceReport();
            objreport.Show();
            objreport.MdiParent = this;
        }

        private void teamPerformanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Team_Performance_Report obj = new Frm_Team_Performance_Report();
            obj.Show();
            obj.MdiParent = this;
        }

        private void jabStatisticsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Job_Statistics_Report obj = new Job_Statistics_Report();
            obj.Show();
            obj.MdiParent = this;
        }

        private void candidateLifecycleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidatelifecyclereport obj = new frmCandidatelifecyclereport();
            obj.Show();
            obj.MdiParent= this;
        }
    }
}
