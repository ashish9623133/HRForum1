using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GayaSoftHRForumLibrary.HR;
using System.Windows.Forms;

namespace GayaSoftHRForum
{
    public partial class SelectedDetails : Form
    {
        int Canidate_ID = 0;
        public SelectedDetails(int C_Id)
        {

            InitializeComponent();
            Canidate_ID = C_Id;
        }
        public SelectedDetails()
        {
            InitializeComponent();
        }

        private void SelectedDetails_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(Canidate_ID);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.GetSelectedDetails();
            dataGridViewSelected.DataSource = dt;


        }
    }
}
