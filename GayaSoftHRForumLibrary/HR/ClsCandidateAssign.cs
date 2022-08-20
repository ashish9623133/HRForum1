using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GayaSoftHRForumLibrary.HR;


namespace GayaSoftHRForumLibrary.HR
{
    public class ClsCandidateAssign
    {
        //Nisha
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int Candidate_Assign_ID { get; set; }
        public int Candidate_ID { get; set; }
        public int Job_ID { get; set; }

        public int Status_ID { get; set; }

        public int Staff_Register_ID { get; set; }

        public DateTime Assign_Date { get; set; }

       public  int Is_Deleted { get; set; }

        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public int Status_id { get; set; }

        public int Interview_Schedule_ID { get; set; }
        public string Interview_Mode { get; set; }
        public DateTime Interview_Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public string Address { get; set; }
        public string Interviewer_Name { get; set; }
        public string Note { get; set; }
        public DateTime Interview_Assign_Date { get; set; }
        public string Feedback { get; set; }

        public int ID2 { get; set; }
        string Status_Id { get; set; }
      
        public object Excelapp { get; set; }
        
        public int Company_ID { get; set; }
        public string Full_Name { get; set; }
        public string Job_Title { get; set; }
        public string Company_Name { get; set; }
        public string Email_ID { get; set; }
        public string Contact_No { get; set; }
        public string Status { get; set; }
       
       
        
        public DateTime From_Date { get; set; }
        public DateTime To_Date { get; set; }

        public ClsCandidateAssign()
        {


        }
        public ClsCandidateAssign(int status_ID)
        {
            Status_ID = status_ID;

        }

        public ClsCandidateAssign(string status_Id, DateTime from_Date, DateTime to_Date)
        {
            Status_Id = status_Id;
            From_Date = from_Date;
            To_Date = to_Date;
        }
        public ClsCandidateAssign(int ID1, int ID2)
        {
            Status_id = ID1;
            Job_ID = ID1;
            Candidate_ID = ID2;
        }

        //To check whether candidate is assigned or not

        public SqlDataReader CheckAssignedOrNot()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckAssignedOrNot");
            cmd.Parameters.AddWithValue("@Job_Id", Job_ID);
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public ClsCandidateAssign(int can_id, int job_id, int status_id, int staff_id, DateTime can_ass_date)
        {
            Candidate_ID = can_id;
            Job_ID = job_id;
            Status_ID = status_id;
            Staff_Register_ID = staff_id;
            Assign_Date = can_ass_date;
            Is_Deleted = 0;
        }

        //To show assigned candidate for Specific Job
        public DataTable ShowAssignedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Flag", "ShowAssignedCandidate");
            cmd.Parameters.AddWithValue("@Status_ID", 3);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //To Load data on Interview Schedule form
        public SqlDataReader LoadDataOnInterviewSchedule()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LoadDataOnInterviewSchedule");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Candidate_Id", Candidate_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            
            return dr;
            con.Close();
        }
        //To Save Assigned Candidate

        public void SaveAssignedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveAssignedCandidate");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@Assign_Date", Assign_Date);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ShowAssignedCandidateList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAssignedCandidateList");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
      
        public SqlDataReader ShowAssignedDetails() //Show Assigned Candidate for Specfic Status Daily LineUP
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAssignedCandidateDetails");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }

        public DataTable ShowAssignedJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Assigned_Job_Details");
            cmd.Parameters.AddWithValue("@Status_ID", Status_id);
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();

            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public ClsCandidateAssign(int candidate_id, int job_id, string interview_mode, DateTime interview_date, string starttime, string endtime, string address, string interviwer_name, string note,
                                  int staff_register_id, int status_id, DateTime interview_assign_date, int candidate_assign_id)
        {

            Candidate_ID = candidate_id;
            Job_ID = job_id;
            Interview_Mode = interview_mode;
            Interview_Date = interview_date;
            Start_Time = starttime;
            End_Time = endtime;
            Address = address;
            Interviewer_Name = interviwer_name;
            Note = note;
            Staff_Register_ID = staff_register_id;
            Status_ID = status_id;
            Interview_Assign_Date = interview_assign_date;
            Candidate_Assign_ID = candidate_assign_id;
            Is_Deleted = 0;
        }
        public void SaveInterviewScheduled()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveInterviewScheduled");
            cmd.Parameters.AddWithValue("@Candidate_Id", Candidate_ID);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Interview_Mode", Interview_Mode);
            cmd.Parameters.AddWithValue("@Interview_Date", Interview_Date);
            cmd.Parameters.AddWithValue("@Start_Time", Start_Time);
            cmd.Parameters.AddWithValue("@End_Time", End_Time);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Interviewer_Name", Interviewer_Name);
            cmd.Parameters.AddWithValue("@Note", Note);
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@Status_ID", 4);
            cmd.Parameters.AddWithValue("@Interview_Assign_Date", Interview_Assign_Date);
            cmd.Parameters.AddWithValue("@Candidate_Assign_ID", Candidate_Assign_ID);
            cmd.Parameters.AddWithValue("@Is_Deleted", 0);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateCandidateStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateCandidateStatus");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetCandidateCount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Candidate_Graph");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable CandidateAdmin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AdminCandidate");
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@From_Date", From_Date);
            cmd.Parameters.AddWithValue("@To_Date", To_Date);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable graph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "checklist");
            cmd.Parameters.AddWithValue("@TestVariable", Status_Id);
            cmd.Parameters.AddWithValue("@From_Date", From_Date);
            cmd.Parameters.AddWithValue("@To_Date", To_Date);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable checklist()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AdminStatus");

            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Admingridview()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AdminGridview");
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
       }
    }
