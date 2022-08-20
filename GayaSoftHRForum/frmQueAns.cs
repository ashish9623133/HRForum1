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
    public partial class frmQueAns : Form
    {
        public frmQueAns()
        {
            InitializeComponent();
        }

        private void frmQueAns_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration objQueAns = new ClsCandidateRegistration(txtQuestion.Text,txtAnswer.Text,Convert.ToInt32(txtMarks.Text));
            objQueAns.AddQuestionAnswer();
            MessageBox.Show("Question and answer Added Successfully...!");
            txtQuestion.Clear();
            txtAnswer.Clear();
            txtMarks.Clear();
        }
    }
}
