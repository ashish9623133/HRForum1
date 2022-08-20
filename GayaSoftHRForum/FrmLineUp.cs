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
using System.Data.SqlClient;

namespace GayaSoftHRForum
{
    public partial class FrmLineUp : Form
    {
        int Staff_Registration_Id;
        public FrmLineUp()
        {
            InitializeComponent();
        }
        public FrmLineUp( int staffid)
        {
            InitializeComponent();
            Staff_Registration_Id = staffid;
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {

        }

        private void clsLineUp_Load(object sender, EventArgs e)
        {
            ClsCandidateRegistration obj = new ClsCandidateRegistration();
            SqlDataReader dr;
            dr=obj.LineUpDashbord();
            if(dr.Read())
            {
                lblAssignCount.Text = dr["Assigned"].ToString();
               lblinterviewSCount.Text = dr["Interview_Scheduled"].ToString();
                lblNACount.Text=dr["Not_Attended"].ToString();
                lblCount.Text=dr["Interviewed"].ToString() ;
                lblOHCount.Text=dr["On_Hold"].ToString();
                lblRCount.Text = dr["Rejected"].ToString();
                lblSelectCount.Text = dr["Selected"].ToString();
                lblOCount.Text = dr["Offered"].ToString();
                lblOACount.Text = dr["Offered_Accepted"].ToString();
                //lblPCount.Text = dr["Placed"].ToString();
               // lblRCount.Text = dr["Interview_Rescheduled"].ToString();
               lblPCount.Text=dr["Placed"].ToString();    
               lblInterviewRCount.Text=dr["Interview_Rescheduled"].ToString(); 
               lblUACount.Text = dr["UnAssigned"].ToString();
               lblUnPlacedCount.Text = dr["UnPlaced"].ToString();
               lblORCount.Text = dr["Offer_Rejected"].ToString();
               lblBCount.Text = dr["Black_List"].ToString();



            }


        }

        private void btnShowAllCandidateList_Click(object sender, EventArgs e)
        {
            LineUpCandidateList objcan = new LineUpCandidateList();
            objcan.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNotAttended_Click(object sender, EventArgs e)
        {

        }

        private void lnkAssignedShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            AssignedCandidate objAssignedCandidate =new AssignedCandidate(Staff_Registration_Id);
            objAssignedCandidate.Show();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOHCount_Click(object sender, EventArgs e)
        {

        }

        private void lnkISShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterviewScheduledList objScheduled =new InterviewScheduledList(Staff_Registration_Id);
            objScheduled.Show();
        }

        private void LnkNAShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterviewNotAttended objnotAttended =new InterviewNotAttended(Staff_Registration_Id);
            objnotAttended.Show();
        }

        private void LnkIShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interviewed objInterviewed =new Interviewed(Staff_Registration_Id);  
            objInterviewed.Show();
        }

        private void lnkRShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rejected objrejected =new Rejected(Staff_Registration_Id);
            objrejected.Show();
        }

        private void lnkSelectedShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedCandidates objselected =new SelectedCandidates(Staff_Registration_Id);
            objselected.Show();
        }

        private void lnkOShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OfferedCandidates objOffered =new OfferedCandidates(Staff_Registration_Id);
            objOffered.Show();
        }

        private void lnkONShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnHoldCandidates objonHoldCandidates =new OnHoldCandidates(Staff_Registration_Id);
            objonHoldCandidates.Show();
        }

        private void lnkOFShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OfferAcceptedCandidates objacceptedoffer =new OfferAcceptedCandidates(Staff_Registration_Id);
            objacceptedoffer.Show();
        }

        private void lnkPShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlacedCandidates objplacedCandidates =new PlacedCandidates(Staff_Registration_Id);
            objplacedCandidates.Show();
        }

        private void lnkLRShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterviewRescheduled objInterviewrescheduled =new InterviewRescheduled(Staff_Registration_Id);
            objInterviewrescheduled.Show();
        }

        private void lblOCount_Click(object sender, EventArgs e)
        {

        }

        private void lblDailyLineUpDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblNACount_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClsCandidateRegistration obj = new ClsCandidateRegistration();
            SqlDataReader dr;
            dr = obj.LineUpDashbord();
            if (dr.Read())
            {
                lblAssignCount.Text = dr["Assigned"].ToString();
                lblinterviewSCount.Text = dr["Interview_Scheduled"].ToString();
                lblNACount.Text = dr["Not_Attended"].ToString();
                lblCount.Text = dr["Interviewed"].ToString();
                lblOHCount.Text = dr["On_Hold"].ToString();
                lblRCount.Text = dr["Rejected"].ToString();
                lblSelectCount.Text = dr["Selected"].ToString();
                lblOCount.Text = dr["Offered"].ToString();
                lblOACount.Text = dr["Offered_Accepted"].ToString();
                //lblPCount.Text = dr["Placed"].ToString();
                // lblRCount.Text = dr["Interview_Rescheduled"].ToString();
                lblPCount.Text = dr["Placed"].ToString();
                lblInterviewRCount.Text = dr["Interview_Rescheduled"].ToString();

            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lnkORShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OfferRejectedCandidate objrejected = new OfferRejectedCandidate(Staff_Registration_Id);
            objrejected.Show();
        }

        private void lnkUPShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnplacedCandidate objunplaced = new UnplacedCandidate(Staff_Registration_Id);
            objunplaced.Show();
        }

        private void lnkUnAssingShowList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnAssignedCandidates objunassign = new UnAssignedCandidates(Staff_Registration_Id);
                objunassign.Show();
        }

        private void lblUnPlacedCount_Click(object sender, EventArgs e)
        {

        }
    }
}
