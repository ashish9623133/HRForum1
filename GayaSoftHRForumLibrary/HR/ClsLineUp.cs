using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using GayaSoftHRForumLibrary.Admin;
using GayaSoftHRForumLibrary.HR;


namespace GayaSoftHRForumLibrary.HR
{
    public class ClsLineUp
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int Placed_Candidate_ID { get; set; }
        public int Company_ID { get; set; }
        public string Profile { get; set; }
        public DateTime Joining_Date { get; set; }
        public string CTC { get; set; }

        public DateTime Placed_Date { get; set; }
        public string Payment_Status { get; set; }  
        public int Is_Deleted { get; set; }
       public int Job_ID { get; set; }
        public int Status_ID { get; set; }
        public int Number_Of_Opening { get; set; }

        public ClsLineUp()
        {

        }
        public ClsLineUp (int jobid, int opening)
        {
            Job_ID = jobid;
            Number_Of_Opening = opening;
        }

        public ClsLineUp(int Cid,int companyId, string profile, DateTime joiningDate, string ctc, DateTime placeddate, string payStatus)
        {
            Placed_Candidate_ID = Cid;
            Company_ID = companyId;
            Profile = profile;
            CTC = ctc;
            Payment_Status = payStatus;
            Joining_Date= joiningDate;  
            Placed_Date= placeddate;
            Is_Deleted = 0;

        }
        public void SavePlacementDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SavePlacedCandidateData");
            cmd.Parameters.AddWithValue("@Candidate_ID", Placed_Candidate_ID);
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@Profile", Profile);
            cmd.Parameters.AddWithValue("@Joining_Date", Joining_Date);
            cmd.Parameters.AddWithValue("@CTC", CTC);
            cmd.Parameters.AddWithValue("@Placed_Date", Placed_Date);
            cmd.Parameters.AddWithValue("@Payment_Status", Payment_Status);
            cmd.Parameters.AddWithValue("@Is_Deleted",Is_Deleted);
            cmd.Parameters.AddWithValue("@Status_ID", 13);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public ClsLineUp(int candidateid,int companyId,string jobTitle,string ctc,string paymStatus)
        {
            Placed_Candidate_ID = candidateid;
            Company_ID = companyId;
            Profile = jobTitle;
            Company_ID= companyId;
            CTC = ctc;
            Payment_Status = paymStatus;
            Is_Deleted = 0;
            
        }
        public void SaveAcceptedOfferDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveOfferAcceptedCandidates");
            cmd.Parameters.AddWithValue("@Candidate_ID", Placed_Candidate_ID);
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@Profile", Profile);
            cmd.Parameters.AddWithValue("@CTC", CTC);
            cmd.Parameters.AddWithValue("@Payment_Status", Payment_Status);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.Parameters.AddWithValue("@Status_ID", 12);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void UpdateNumberOfOpening()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateNumberOfOpening");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Number_Of_Opening", Number_Of_Opening);
            cmd.ExecuteNonQuery();
            con.Close();

        }



    }
}
