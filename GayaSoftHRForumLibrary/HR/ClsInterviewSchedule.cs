using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//using GayaSoftHRForumLibrary.Admin;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForumLibrary.HR
{
    public class ClsInterviewSchedule
    {
        //Nisha
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int Candidate_ID { get; set; }
        public int Job_ID { get; set; }
        public int Interview_Schedule_ID { get; set; }
        public string Interview_Mode { get; set; }
        public DateTime Interview_Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public string Address { get; set; }
        public string Interviewer_Name { get; set; }
        public string Note { get; set; }
        public DateTime Interview_Assign_Date { get; set; }
        public DateTime Assign_Date { get; set; }
        public string Feedback { get; set; }
        public int Is_Deleted { get; set; }
        public int Status_ID { get; set; }  
        public int Staff_Register_ID { get; set; }
        public int Candidate_Assign_ID { get; set; }
        public int ID1 { get; set; }
        public int ID2 { get; set; }

       public int Staff_Reg_ID { get; set; }
       

        public ClsInterviewSchedule()
        {

        }
        
        public ClsInterviewSchedule(int candidateid, int jobid, string mode, DateTime date, string startTime, string endtime, string address, string iname, string note, int staffid, int statusid, DateTime interviewassigndate, int assignid)
        {
            Candidate_ID = candidateid;
            Job_ID = jobid;
            Interview_Mode = mode;
            Interview_Date = date;
            Start_Time = startTime;
            End_Time = endtime;
            Address = address;
            Interviewer_Name = iname;
            Note = note;
            Staff_Register_ID = staffid;
            Status_ID = statusid;
            Interview_Assign_Date = interviewassigndate;
            Candidate_Assign_ID = assignid;
            Is_Deleted = 0;
        }

        public DataTable ShowInterviewScheduledCand()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowInterviewScheduledCandidate");
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void SaveInterviewScheduled() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveInterviewScheduled");
            cmd.Parameters.AddWithValue("@Candidate_Id",Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_ID",Job_ID);
            cmd.Parameters.AddWithValue("@Interview_Mode",Interview_Mode);
            cmd.Parameters.AddWithValue("@Interview_Date",Interview_Date );
            cmd.Parameters.AddWithValue("@Start_Time",Start_Time );
            cmd.Parameters.AddWithValue("@End_Time",End_Time);
            cmd.Parameters.AddWithValue("@Address",Address);
            cmd.Parameters.AddWithValue("@Interviewer_Name",Interviewer_Name);
            cmd.Parameters.AddWithValue("@Note", Note);
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Interview_Assign_Date", Interview_Assign_Date);
            cmd.Parameters.AddWithValue("@Candidate_Assign_ID", Candidate_Assign_ID);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.ExecuteNonQuery();
        
            con.Close();
        }
        public ClsInterviewSchedule(int id1, int id2)
        {
            ID1 = id1;
            ID2 = id2;
            Status_ID = id1;
            Candidate_ID = id2;
            Job_ID = id2;

        }
        // To Update  Candidate Status in Candidate Assign Table 
        public void UpdateCandidateStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateCandidateStatus");
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_Id", Job_ID);
            cmd.Parameters.AddWithValue("@Assign_Date", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        // To Update  Candidate Status in Interview Schedule Table 

        public void UpdateStatusInterviewSchedule()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateStatusTblInterviewSchedule");
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_Id", Job_ID);
            cmd.Parameters.AddWithValue("@Interview_Assign_Date", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public ClsInterviewSchedule( int cid,string feedback,int jobid)
        {
            Candidate_ID = cid;
            Feedback = feedback;
            Job_ID=jobid;

        }
        public void UpdateFeedback()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateFeedback");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Feedback", Feedback);
            cmd.Parameters.AddWithValue("@Job_Id",Job_ID);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public ClsInterviewSchedule(int statusid,int candidate_id,int job_id)
        {
            Status_ID = statusid;
            Candidate_ID = candidate_id;
            Job_ID = job_id; 

        }
        public SqlDataReader ShowPlacedDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowPlacedCandidateDetails");
            cmd.Parameters.AddWithValue("@Job_ID", ID1);
            cmd.Parameters.AddWithValue("@Candidate_ID", ID2);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public SqlDataReader ShowAcceptedOfferDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AcceptedOfferDetails");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public DataTable ShowInterviewScheduledList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowInterviewScheduledData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable ShowInterviewNotAttended()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowInterviewNotAttendedData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ShowInterviewRescheduled()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowInterviewRescheduledData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ShowRejectedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowRejectedCandidate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable ShowOnHoldCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOnHoldCandidate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ShowSelectedCandidates()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowSelectedCandidate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        //To show Placed candidates in line up
        public DataTable ShowPlacedCandidates()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowPlacedCandidateData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        //To show Unplaced Candidates in line up
        public DataTable ShowUnplacedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUnplacedCandidate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable ShowOfferedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOfferedCandidateData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        public DataTable ShowOfferAcceptedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOfferAcceptedData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ShowOfferRejectedData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOfferRejectedData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ShowInterviewedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowInterviewedCandidateData");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
    }
}
