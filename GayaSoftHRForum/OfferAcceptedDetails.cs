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
    public partial class OfferAcceptedDetails : Form
    {
        int Canidate_ID = 0;
        public OfferAcceptedDetails()
        {
            InitializeComponent();
        }
        public OfferAcceptedDetails(int C_Id)
        {
            InitializeComponent();
            Canidate_ID = C_Id;
        }

        private void OfferAcceptedDetails_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration objCandidateRegistration = new ClsCandidateRegistration(Canidate_ID);
            DataTable dt = new DataTable();
            dt = objCandidateRegistration.offerAcepted();
            dataGridViewPlacedCandidate.DataSource = dt;
        }

        private void dataGridViewPlacedCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           // (D.DataSource as DataTable).DefaultView.RowFilter = String.Format("Full_Name like '{0}%' or Job_Title like '{0}%'or Email_ID like '{0}%' or Contact_No like '{0}%'or Company_Name like '{0}%'", txtSearch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
