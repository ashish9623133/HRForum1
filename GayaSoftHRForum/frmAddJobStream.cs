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
    public partial class frmAddJobStream : Form
    {
        public frmAddJobStream()
        {
            InitializeComponent();
        }

        private void btnSaveJobStream_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objJobStream = new ClsCandidateRegistration(txtJobStreamName.Text);
            objJobStream.SaveJobStream();
            MessageBox.Show("Job Stream Added Successfully...!");
            txtJobStreamName.Clear();
        }
    }
}
