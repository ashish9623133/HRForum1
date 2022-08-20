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
    public class ClsJob
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        public int Job_ID { get; set; }
        public string Job_Title { get; set; }
        public int Number_Of_Opening { get; set; }
        public DateTime Opening_Date { get; set; }
        public DateTime Closing_Date { get; set; }
        public string Job_Description { get; set; }
        public string Job_Description_File { get; set; }
        public string Min_Years_Experience { get; set; }
        public string Max_Years_Experience { get; set; }
        public string Currency { get; set; }
        public string Min_Salary { get; set; }
        public string Max_Salary { get; set; }
        public DateTime Job_Posting_Date { get; set; }
        public string Skills { get; set; }
        public int City_ID { get; set; }
        public string City { get; set; }

        public string Full_Address { get; set; }
        public DateTime Date { get; set; }
        public int Is_Deleted { get; set; }

     
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }

        public int Job_Stream_ID { get; set; }
      
        public int Qualification_ID { get; set; }
        public string Qualification_Name { get; set; }

        public int Specialization_ID { get; set; }
        public string Specialization_Name { get; set; }

        public DateTime job_Posting_Date { get; set; }
      
      
        public int Status_ID { get; set; }
        public string StatusName { get; set; }

        public int Company_HR_Contact_ID { get; set; }
        // Job Stream
      
        public string Job_Stream_Name { get; set; }
        public string HRname { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }


        public ClsJob(int job_id)
        {
            Job_ID = job_id;
            Job_Stream_ID = job_id;
            

        }
        public ClsJob(int job_id, int status_id)
        {
            Job_ID = job_id;
            Status_ID = status_id;

        }

        //To Show Single Job Details for Candidate Pipeline
        public SqlDataReader ShowJobDetailsforCandidatePipeline()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Job_Details_For_Candidate_Pipeline");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

       
       
        public ClsJob()
        {

        }
        public ClsJob(string job_Title, int number_Of_Opening, int company_ID, DateTime opening_Date,
           DateTime closing_Date, string job_Description, string job_Description_File, string min_Years_Experience,
          string max_Years_Experience, string currency, int job_Stream, string min_Salary,
           string max_Salary, int qualification_ID, int specialization_ID, DateTime Job_Posting_Date, string skills, int city_ID,
          string full_Address, DateTime date, int status_ID, int is_deleted, int company_HR_Contact_ID)

        {
            Job_Title = job_Title;
            Number_Of_Opening = number_Of_Opening;
            Company_ID = company_ID;
            Opening_Date = opening_Date;
            Closing_Date = closing_Date;
            Job_Description = job_Description;
            Job_Description_File = job_Description_File;
            Min_Years_Experience = min_Years_Experience;
            Max_Years_Experience = max_Years_Experience;
            Currency = currency;
            Job_Stream_ID = job_Stream;
            Min_Salary = min_Salary;
            Max_Salary = max_Salary;
            Qualification_ID = qualification_ID;
            Specialization_ID = specialization_ID;
            job_Posting_Date = Job_Posting_Date;
            Skills = skills;
            City_ID = city_ID;
            Full_Address = full_Address;
            Date = date;
            Status_ID = status_ID;
            Is_Deleted = is_deleted;
            Company_HR_Contact_ID = company_HR_Contact_ID;

        }

        public void Addjob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddJob");
            cmd.Parameters.AddWithValue("@Job_Title", Job_Title);
            cmd.Parameters.AddWithValue("@Number_Of_Opening", Number_Of_Opening);
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@Opening_Date", Opening_Date);
            cmd.Parameters.AddWithValue("@Closing_Date", Closing_Date);
            cmd.Parameters.AddWithValue("@Job_Description", Job_Description);
            cmd.Parameters.AddWithValue("@Job_Description_File", Job_Description_File);
            cmd.Parameters.AddWithValue("@Min_Years_Experience", Min_Years_Experience);
            cmd.Parameters.AddWithValue("@Max_Years_Experience", Max_Years_Experience);
            cmd.Parameters.AddWithValue("@Currency", Currency);
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.Parameters.AddWithValue("@Min_Salary", Min_Salary);
            cmd.Parameters.AddWithValue("@Max_Salary", Max_Salary);
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@Job_Posting_Date", job_Posting_Date);
            cmd.Parameters.AddWithValue("@Skills", Skills);
            cmd.Parameters.AddWithValue("@City_ID", City_ID);
            cmd.Parameters.AddWithValue("@Full_Address", Full_Address);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.Parameters.AddWithValue("@Company_HR_Contact_ID", Company_HR_Contact_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getaddjob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getaddjob");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

            //Delete Job//

      

        public void deleteJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteJob");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }



        public DataTable Getcompany()              //Get Company//
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getcompany");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Getqualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getqualification");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public ClsJob(int specialization_ID, string specialization_Name)
        {
            Specialization_ID = specialization_ID;
            Specialization_Name = specialization_Name;
            Company_ID = specialization_ID;
            HRname=specialization_Name;
        }
        public DataTable getspecelization()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSpecalization");
            cmd.Parameters.AddWithValue("@Qualification_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable getstream()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetJobstream");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Getcity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Getstatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getstatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetHRname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetHRname");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@HR_Name", HRname);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public ClsJob(int job_id, string job_Title, int number_Of_Opening, int company_ID, DateTime opening_Date,
            DateTime closing_Date, string job_Description, string job_Description_File, string min_Years_Experience,
           string max_Years_Experience, string currency, int job_Stream, string min_Salary,
            string max_Salary, int qualification_ID, int specialization_ID, DateTime Job_Posting_Date, string skills, int city_ID,
           string full_Address, DateTime date, int status_ID, int is_deleted, int company_HR_Contact_ID)

        {
            Job_ID = job_id;
            Job_Title = job_Title;
            Number_Of_Opening = number_Of_Opening;
            Company_ID = company_ID;
            Opening_Date = opening_Date;
            Closing_Date = closing_Date;
            Job_Description = job_Description;
            Job_Description_File = job_Description_File;
            Min_Years_Experience = min_Years_Experience;
            Max_Years_Experience = max_Years_Experience;
            Currency = currency;
            Job_Stream_ID = job_Stream;
            Min_Salary = min_Salary;
            Max_Salary = max_Salary;
            Qualification_ID = qualification_ID;
            Specialization_ID = specialization_ID;
            job_Posting_Date = Job_Posting_Date;
            Skills = skills;
            City_ID = city_ID;
            Full_Address = full_Address;
            Date = date;
            Status_ID = status_ID;
            Is_Deleted = is_deleted;
            Company_HR_Contact_ID = company_HR_Contact_ID;


        }


        public SqlDataReader LoadJobData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LoadJobData");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public void UpdateJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update_Job");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Job_Title", Job_Title);
            cmd.Parameters.AddWithValue("@Number_Of_Opening", Number_Of_Opening);
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@Opening_Date", Opening_Date);
            cmd.Parameters.AddWithValue("@Closing_Date", Closing_Date);
            cmd.Parameters.AddWithValue("@Job_Description", Job_Description);
            cmd.Parameters.AddWithValue("@Job_Description_File", Job_Description_File);
            cmd.Parameters.AddWithValue("@Min_Years_Experience", Min_Years_Experience);
            cmd.Parameters.AddWithValue("@Max_Years_Experience", Max_Years_Experience);
            cmd.Parameters.AddWithValue("@Currency", Currency);
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.Parameters.AddWithValue("@Min_Salary", Min_Salary);
            cmd.Parameters.AddWithValue("@Max_Salary", Max_Salary);
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@Job_Posting_Date", job_Posting_Date);
            cmd.Parameters.AddWithValue("@Skills", Skills);
            cmd.Parameters.AddWithValue("@City_ID", City_ID);
            cmd.Parameters.AddWithValue("@Full_Address", Full_Address);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.Parameters.AddWithValue("@Company_HR_Contact_ID", Company_HR_Contact_ID);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        
        public DataTable SerachJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchJob");
            cmd.Parameters.AddWithValue("@Job_Title", Job_Title);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ShowJobDashboard()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "job_dashboard");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //To Show Individual Job Deatils
        public DataTable joblist()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Selected_Job");
            cmd.Parameters.AddWithValue("@Job_Title", Job_Title);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable ShowOpenHoldDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Close_Job");
            cmd.Parameters.AddWithValue("@Closing_Date", DateTime.Now);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public void UpdateJobStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update_Job_Status");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable CheckedForClosedJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Checked_For_Closed_Job");
            cmd.Parameters.AddWithValue("@Closing_Date", DateTime.Now);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public SqlDataReader NotificationForClosedJob()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Notification_For_Closed_Job");
            cmd.Parameters.AddWithValue("@Closing_Date", DateTime.Now);
            SqlDataReader dr;
            dr= cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public ClsJob(String job_title)
        {
            Job_Title = job_title;
            Company_Name = job_title;
            Job_Stream_Name = job_title;
            Qualification_Name = job_title;
            Specialization_Name = job_title;
            City = job_title;
            StatusName = job_title;
            HRname = job_title;
        }
        public SqlDataReader GetcompnyID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "companyID");
            cmd.Parameters.AddWithValue("@Company_Name", Company_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GetjobStreamID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "jobStreamID");
            cmd.Parameters.AddWithValue("@Job_Stream_Name", Job_Stream_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GetqualificationID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "qualificationID");
            cmd.Parameters.AddWithValue("@Qualification_Name", Qualification_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GetspecializationID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "specializationID");
            cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GetcityID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "cityID");
            cmd.Parameters.AddWithValue("@City_Name", City);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GetstatusID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "statusID");
            cmd.Parameters.AddWithValue("@Status_Name", StatusName);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        public SqlDataReader GethrID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "hrID");
            cmd.Parameters.AddWithValue("@HR_Name", HRname);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        

        public SqlDataReader JobGraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "JobGraph");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        

       // ---------------cls_Job-------------------------
        public ClsJob(int job_id, string job_title, int job_Stream_ID, string job_Stream_Name)
        {
            Job_ID = job_id;
            Job_Title = job_title;
            Job_Stream_ID = job_Stream_ID;
            Job_Stream_Name = job_Stream_Name;
        }

        //------------------Filter_By_Job_Title---------------------
        public DataTable Filter_By_Job_Title()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Job_Title");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt1 = new DataTable();
            adpt.Fill(dt1);
            return dt1;
            con.Close();

        }
        //------------Filter_By_Job_Stream_Name---------------
        public DataTable Filter_By_Job_Stream_Name()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","Filter_By_Job_Stream_Name");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);
            return dt2;
            con.Close();

        }
        //--------------Job_Stream_Filter_Job_title_Filter--------------------
        public DataTable Job_Stream_Filter_Job_title_Filter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Job_Stream_Filter_Job_title_Filter");
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt3 = new DataTable();
            adpt.Fill(dt3);
            return dt3;
            con.Close();

        }


        //-----------Job_title_Filter--------------

        public DataTable Job_title_Filter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Job_title_Filter");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }


        //-----------Job_Stream_Filter--------------

        public DataTable Job_Stream_Filter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Job_Stream_Filter");
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExperience()              //Get Company//
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExperience");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //Job Statastic Report

        public ClsJob(string job_Title, DateTime fromDate, DateTime toDate)
        {
            Job_Title = job_Title;
            FromDate = fromDate;
            ToDate = toDate;

        }
        public DataTable GetJobStatasticsReport()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Admin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Job_Statastics_Report");
            cmd.Parameters.AddWithValue("@Job_Title", Job_Title);
            cmd.Parameters.AddWithValue("@From_Date", FromDate);
            cmd.Parameters.AddWithValue("@To_Date", ToDate);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

    }
}
