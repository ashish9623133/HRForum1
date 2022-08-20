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
    public class ClsCandidateRegistration
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int State_ID { get; set; }
        public string State_Name { get; set; }
        public int Qualification_ID { get; set; }
        public string Qualification { get; set; }

        public int Specialization_ID { get; set; }
        public string Specialization_Name { get; set; }
        public int Staff_Register_ID { get; set; }
        public string Full_Name { get; set; }
        public string Gender { get; set; }
        public string Contact_No { get; set; }
        //  public string DOB { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Total_Experience { get; set; }
        public string Current_CTC { get; set; }
        public string Expected_CTC { get; set; }
        public string Resume { get; set; }
        public string Photo { get; set; }
        public string Marksheet_10th { get; set; }
        public string Marksheet_12th { get; set; }
        public string Diploma_Marksheet { get; set; }
        public string Graduation_Marksheet { get; set; }
        public string Post_Graduation_Marksheet { get; set; }
        public string PAN_Card { get; set; }
        public string Aadhar { get; set; }
        public string Cheque { get; set; }
        public string Skills { get; set; }
        public string Last_Organization { get; set; }
        public string Current_Employee_Status { get; set; }
        public string Currency { get; set; }
        public string Notice_Period { get; set; }
        public string Relevant_Experience { get; set; }
        public string Position { get; set; }
        public string Willing_To_Relocate { get; set; }
        public string Preferred_Location { get; set; }
        public string Ready_To_Work_In_Shifts { get; set; }
        public string Work_Prefer_Type { get; set; }
        public string Ready_For_Field_Work { get; set; }
        public string Facebook_Profile_URL { get; set; }
        public string LinkedIn_Profile_URL { get; set; }
        public string Github_Profile_URL { get; set; }
        public string Comment { get; set; }
        public DateTime Registration_Date { get; set; }
        public int Rating { get; set; }
        public string City_Name { get; set; }
        public int Country_ID { get; set; }

        public string Country_Name { get; set; }
        public int Candidate_Id { get; set; }

        public int Candidate_ID { get; set; }
        public int Candidate_Assign_ID { get; set; }

        public int City_ID { get; set; }

        public int Job_Stream_ID { get; set; }
       
        public string Job_Stream_Name { get; set; }
        public int Job_ID { get; set; }
        public int Status_ID { get; set; }

        public string Email_ID { get; set; }
        public int Is_Deleted { get; set; }


       
        //Status
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        //Qualification & Specialization
       
        public string Status { get; set; }
        public string job_title { get; set; }
       

        // question and answer
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Marks { get; set; }

        public string sname;

        //Constructors
        // Show All Candidate List
        public ClsCandidateRegistration(string candidatedetail)   //Constructor For Save Country
        {
            Email_ID = candidatedetail;
            City_Name = candidatedetail;
            Country_Name = candidatedetail;
            Qualification = candidatedetail;
            Specialization_Name = candidatedetail;
            Job_Stream_Name = candidatedetail;
            Status = candidatedetail;
            job_title = candidatedetail;
        }
        public ClsCandidateRegistration(int candidate_ID, int staff_Register_ID, string full_Name, string gender, string contact_No, DateTime dOB, string address, string total_Experience, string current_CTC, string expected_CTC, string resume, string photo, string marksheet_10th, string marksheet_12th, string diploma_Marksheet, string graduation_Marksheet, string post_Graduation_Marksheet, string pAN_Card, string aadhar, string cheque, string skills, string last_Organization, string current_Employee_Status, string currency, string notice_Period, string relevant_Experience, string position, string willing_To_Relocate, string preferred_Location, string ready_To_Work_In_Shifts, string work_Prefer_Type, string ready_For_Field_Work, string facebook_Profile_URL, string linkedIn_Profile_URL, string github_Profile_URL, string comment, DateTime registration_Date, int rating)

        {
            Staff_Register_ID = staff_Register_ID;
            Candidate_Id = candidate_ID;
            Full_Name = full_Name;
            Gender = gender;
            Contact_No = contact_No;
            DOB = dOB;
            Address = address;
            Total_Experience = total_Experience;
            Expected_CTC = expected_CTC;
            Resume = resume;
            Photo = photo;
            Marksheet_10th = marksheet_10th;
            Marksheet_12th = marksheet_12th;
            Diploma_Marksheet = diploma_Marksheet;
            Graduation_Marksheet = graduation_Marksheet;
            Post_Graduation_Marksheet = post_Graduation_Marksheet;
            PAN_Card = pAN_Card;
            Aadhar = aadhar;
            Cheque = cheque;
            Skills = skills;
            Last_Organization = last_Organization;
            Current_Employee_Status = current_Employee_Status;
            Currency = currency;
            Notice_Period = notice_Period;
            Relevant_Experience = relevant_Experience;
            Position = position;
            Willing_To_Relocate = willing_To_Relocate;
            Preferred_Location = preferred_Location;
            Ready_To_Work_In_Shifts = ready_To_Work_In_Shifts;
            Work_Prefer_Type = work_Prefer_Type;
            Ready_For_Field_Work = ready_For_Field_Work;
            Facebook_Profile_URL = facebook_Profile_URL;
            LinkedIn_Profile_URL = linkedIn_Profile_URL;
            Github_Profile_URL = github_Profile_URL;
            Comment = comment;
            Registration_Date = registration_Date;
            Rating = rating;
        }

        public ClsCandidateRegistration()
        {
        }
        public DataTable ShowAllCandidateList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllCandidateList");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader LineUpDashbord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LineUpDashbord");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public ClsCandidateRegistration(int candidate_Id)
        {
            Candidate_Id = candidate_Id;
            Job_ID = candidate_Id;

            Country_ID = candidate_Id;
            State_ID = candidate_Id;
            Qualification_ID = candidate_Id;
            Candidate_ID = candidate_Id;
            City_ID = candidate_Id;
            Staff_Register_ID = candidate_Id;
            Job_Stream_ID = candidate_Id;
            Specialization_ID = candidate_Id;

        }
       

        public void DeleteCandidat()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Delete_Candidate");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_Id);
            cmd.Parameters.AddWithValue("@Candidate_Assign_ID", Candidate_Assign_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

     

        public DataTable ShowMatchingCandidate()
        {


            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowMatchingCandidate");
            cmd.Parameters.AddWithValue("@Job_ID", Job_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public ClsCandidateRegistration(int candidateid, string comment)
        {
            Candidate_Id = candidateid;
            Comment = comment;
            Country_ID = candidateid;
            State_Name = comment;
            Qualification_ID = candidateid;
            Specialization_Name = comment;

        }
        public void AddComment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateComment");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_Id);
            cmd.Parameters.AddWithValue("@Comment", Comment);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveCountry() //For Save Country
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "country");
         cmd.Parameters.AddWithValue("@country", Country_Name);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable FetchCountry()    //Procedure For Fetching Country For Add new state
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCountry");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

       
        public void SaveState()    //Stored Procedure for Save State
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "state");
            cmd.Parameters.AddWithValue("@country_Id", Country_ID);
            cmd.Parameters.AddWithValue("@state", State_Name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //public ClsCandidateRegistration(int cid)
        //{

        //    Country_ID = cid;
        //    State_ID = cid;
        //    Qualification_ID = cid;
        //    Candidate_ID = cid;
        //    City_ID = cid;
        //    Staff_Register_ID = cid;
        //    Job_Stream_ID = cid;
        //    Specialization_ID = cid;
        //}
        public DataTable FetchState()    //Procedure For Fetching State For Add new City
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchState");
            cmd.Parameters.AddWithValue("@country_Id", Country_ID);
            cmd.Parameters.AddWithValue("@state", State_Name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

        public ClsCandidateRegistration(string cityname, int stateid)    //For Save City Constructor
        {
            City_Name = cityname;
            State_ID = stateid;
            Qualification_ID = stateid;
            Specialization_Name = cityname;

        }
        public DataTable FetchStateAddcity()    //Procedure For Fetching State For Add new City
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStateAddCity");
            cmd.Parameters.AddWithValue("@state", State_Name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

        public void SaveCity()    //Stored Procedure for Save City
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "city");
            cmd.Parameters.AddWithValue("@state_id", State_ID);
            cmd.Parameters.AddWithValue("@city", City_Name);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable FetchCity()    //Procedure For Fetching City 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCity");
            cmd.Parameters.AddWithValue("@state_Id", State_ID);
            //cmd.Parameters.AddWithValue("@City_Name", City_Name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

        public void SaveQualification()  //Procedure for Saving new Qualification
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Qualification");
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable FetchQualification()    // Procedure for Fetch Qualification for add New Specialization
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchQualification");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void SaveSpecialization()  //Procedure for add new specializtion
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Specialization");
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@specialization_name", Specialization_Name);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable FetchSpecialization()    // Procedure for Fetch Specialization
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchSpecialization");
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            // cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void SaveJobStream()  //Procedure for add new specializtion
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddJobStream");
            cmd.Parameters.AddWithValue("@Job_Stream_Name", Job_Stream_Name);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable FetchJobStream()    // Procedure for Fetch job stream
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchJobStream");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public ClsCandidateRegistration(int StaffRegisterID, string FullName, string EmailID, string gender, string ContactNo, DateTime dob,
            int city, string address, int QualificationID, int SpecializationID, string TotalExperience, string resume, string photo,
            string Marksheet10th, string Marksheet12th, string DiplomaMarksheet, string GraduationMarksheet, string PostGraduationMarksheet,
            string PANCard, string aadhar, string cheque, string LastOrganization, string CurrentEmployeeStatus, string CurrentCTC, string ExpectedCTC,
            string currency, string NoticePeriod, string RelevantExperience, string position, int JobStream, string WillingToRelocate,
            string PreferredLocation, string skills, string WorkPreferType, string ReadyToWorkInShifts, string ReadyForFieldWork,
            string FacebookProfileURL, string LinkedInProfileURL, string GithubProfileURL, string comment, DateTime RegistrationDate,
            int rating)      //For Saving Candidate Details
        {
            Staff_Register_ID = StaffRegisterID;
            Full_Name = FullName;
            Email_ID = EmailID;
            Gender = gender;
            Contact_No = ContactNo;
            DOB = dob;
            City_ID = city;
            Address = address;
            Qualification_ID = QualificationID;
            Specialization_ID = SpecializationID;
            Total_Experience = TotalExperience;
            Current_CTC = CurrentCTC;
            Expected_CTC = ExpectedCTC;
            Resume = resume;
            Photo = photo;
            Marksheet_10th = Marksheet10th;
            Marksheet_12th = Marksheet12th;
            Diploma_Marksheet = DiplomaMarksheet;
            Graduation_Marksheet = GraduationMarksheet;
            Post_Graduation_Marksheet = PostGraduationMarksheet;
            PAN_Card = PANCard;
            Aadhar = aadhar;
            Cheque = cheque;
            Skills = skills;
            Last_Organization = LastOrganization;
            Current_Employee_Status = CurrentEmployeeStatus;
            Currency = currency;
            Notice_Period = NoticePeriod;
            Relevant_Experience = RelevantExperience;
            Position = position;
            Willing_To_Relocate = WillingToRelocate;
            Preferred_Location = PreferredLocation;
            Ready_To_Work_In_Shifts = ReadyToWorkInShifts;
            Work_Prefer_Type = WorkPreferType;
            Job_Stream_ID = JobStream;
            Ready_For_Field_Work = ReadyForFieldWork;
            Facebook_Profile_URL = FacebookProfileURL;
            LinkedIn_Profile_URL = LinkedInProfileURL;
            Github_Profile_URL = GithubProfileURL;
            Status_ID = 1;
            Comment = comment;
            Registration_Date = RegistrationDate;
            Rating = rating;
            Is_Deleted = 0;
        }

       
        public void SaveCandidateInfo()  //Procedure for add new specializtion
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;    
            cmd.Parameters.AddWithValue("@Flag", "Register_Candidate");
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Email_ID", Email_ID);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@City_ID", City_ID);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@Total_Experience", Total_Experience);
            cmd.Parameters.AddWithValue("@Current_CTC", Current_CTC);
            cmd.Parameters.AddWithValue("@Expected_CTC", Expected_CTC);
            cmd.Parameters.AddWithValue("@Resume", Resume);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            cmd.Parameters.AddWithValue("@Marksheet_10th", Marksheet_10th);
            cmd.Parameters.AddWithValue("@Marksheet_12th", Marksheet_12th);
            cmd.Parameters.AddWithValue("@Diploma_Marksheet", Diploma_Marksheet);
            cmd.Parameters.AddWithValue("@Graduation_Marksheet", Graduation_Marksheet);
            cmd.Parameters.AddWithValue("@Post_Graduation_Marksheet", Post_Graduation_Marksheet);
            cmd.Parameters.AddWithValue("@PAN_Card", PAN_Card);
            cmd.Parameters.AddWithValue("@Aadhar", Aadhar);
            cmd.Parameters.AddWithValue("@Cheque", Cheque);
            cmd.Parameters.AddWithValue("@Skills", Skills);
            cmd.Parameters.AddWithValue("@Last_Organization", Last_Organization);
            cmd.Parameters.AddWithValue("@Current_Employee_Status", Current_Employee_Status);
            cmd.Parameters.AddWithValue("@Currency", Currency);
            cmd.Parameters.AddWithValue("@Notice_Period", Notice_Period);
            cmd.Parameters.AddWithValue("@Relevant_Experience", Relevant_Experience);
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Willing_To_Relocate", Willing_To_Relocate);
            cmd.Parameters.AddWithValue("@Preferred_Location", Preferred_Location);
            cmd.Parameters.AddWithValue("@Ready_To_Work_In_Shifts", Ready_To_Work_In_Shifts);
            cmd.Parameters.AddWithValue("@Work_Prefer_Type", Work_Prefer_Type);
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.Parameters.AddWithValue("@Ready_For_Field_Work", Ready_For_Field_Work);
            cmd.Parameters.AddWithValue("@Facebook_Profile_URL", Facebook_Profile_URL);
            cmd.Parameters.AddWithValue("@LinkedIn_Profile_URL", LinkedIn_Profile_URL);
            cmd.Parameters.AddWithValue("@Github_Profile_URL", Github_Profile_URL);
            cmd.Parameters.AddWithValue("@Status_ID", Status_ID);
            cmd.Parameters.AddWithValue("@Comment", Comment);
            cmd.Parameters.AddWithValue("@Registration_Date", Registration_Date);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable FetchRegisterStaff()    // Procedure for Fetch job stream
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStaffRegister");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public ClsCandidateRegistration(string question, string answer, int marks)
        {
            Question = question;
            Answer = answer;
            Marks = marks;

        }
        public void AddQuestionAnswer()  //Procedure for add new specializtion
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddQuestions");
            cmd.Parameters.AddWithValue("@Question", Question);
            cmd.Parameters.AddWithValue("@ans", Answer);
            cmd.Parameters.AddWithValue("@marks", Marks);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllCandidateList");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }
        //Line up
        public DataTable LineUp_ShowAllCandidateList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LineUp_ShowAllCandidateList");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }
        //Line up
        public DataTable ShowUnAssignedCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUnAssignedCandidate");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }




        public ClsCandidateRegistration(int cid, string FullName, string EmailID, string gender, string ContactNo, DateTime dob,
            int city, string address)
        {
            Candidate_ID = cid;
            Full_Name = FullName;
            Email_ID = EmailID;
            Gender = gender;
            Contact_No = ContactNo;
            DOB = dob;
            City_ID = city;
            Address = address;

        }
        public void UpdatePerInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePerInfo");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Email_ID", Email_ID);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@City_ID", City_ID);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ClsCandidateRegistration(int cid, int QualificationID, int SpecializationID, string TotalExperience)
        {
            Candidate_ID = cid;
            Qualification_ID = QualificationID;
            Specialization_ID = SpecializationID;
            Total_Experience = TotalExperience;
        }

        public void UpdateEduInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateEduInfo");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@Total_Experience", Total_Experience);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ClsCandidateRegistration(int cid, string resume, string photo,
            string Marksheet10th, string Marksheet12th, string DiplomaMarksheet, string GraduationMarksheet, string PostGraduationMarksheet,
            string PANCard, string aadhar, string cheque)
        {
            Candidate_ID = cid;
            Resume = resume;
            Photo = photo;
            Marksheet_10th = Marksheet10th;
            Marksheet_12th = Marksheet12th;
            Diploma_Marksheet = DiplomaMarksheet;
            Graduation_Marksheet = GraduationMarksheet;
            Post_Graduation_Marksheet = PostGraduationMarksheet;
            PAN_Card = PANCard;
            Aadhar = aadhar;
            Cheque = cheque;
        }

        public void UpdateUpDocInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateUpDocInfo");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Resume", Resume);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            cmd.Parameters.AddWithValue("@Marksheet_10th", Marksheet_10th);
            cmd.Parameters.AddWithValue("@Marksheet_12th", Marksheet_12th);
            cmd.Parameters.AddWithValue("@Diploma_Marksheet", Diploma_Marksheet);
            cmd.Parameters.AddWithValue("@Graduation_Marksheet", Graduation_Marksheet);
            cmd.Parameters.AddWithValue("@Post_Graduation_Marksheet", Post_Graduation_Marksheet);
            cmd.Parameters.AddWithValue("@PAN_Card", PAN_Card);
            cmd.Parameters.AddWithValue("@Aadhar", Aadhar);
            cmd.Parameters.AddWithValue("@Cheque", Cheque);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public ClsCandidateRegistration(int cid, string LastOrganization, string CurrentEmployeeStatus, string CurrentCTC, string ExpectedCTC,
            string currency, string NoticePeriod, string RelevantExperience, string position, int JobStream)
        {
            Candidate_ID = cid;
            Last_Organization = LastOrganization;
            Current_Employee_Status = CurrentEmployeeStatus;
            Current_CTC = CurrentCTC;
            Expected_CTC = ExpectedCTC;
            Currency = currency;
            Notice_Period = NoticePeriod;
            Relevant_Experience = RelevantExperience;
            Position = position;
            Job_Stream_ID = JobStream;
        }

        public void UpdateEmpDetailsInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateEmpDetailsInfo");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Last_Organization", Last_Organization);
            cmd.Parameters.AddWithValue("@Current_Employee_Status", Current_Employee_Status);
            cmd.Parameters.AddWithValue("@Current_CTC", Current_CTC);
            cmd.Parameters.AddWithValue("@Expected_CTC", Expected_CTC);
            cmd.Parameters.AddWithValue("@Currency", Currency);
            cmd.Parameters.AddWithValue("@Notice_Period", Notice_Period);
            cmd.Parameters.AddWithValue("@Relevant_Experience", Relevant_Experience);
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ClsCandidateRegistration(int cid, int staffid, string WillingToRelocate,
            string PreferredLocation, string skills, string WorkPreferType, string ReadyToWorkInShifts, string ReadyForFieldWork,
            string FacebookProfileURL, string LinkedInProfileURL, string GithubProfileURL, string comment, DateTime RegistrationDate,
            int rating)
        {
            Candidate_ID = cid;
            Staff_Register_ID = staffid;
            Willing_To_Relocate = WillingToRelocate;
            Preferred_Location = PreferredLocation;
            Skills = skills;
            Ready_To_Work_In_Shifts = ReadyToWorkInShifts;
            Work_Prefer_Type = WorkPreferType;
            Ready_For_Field_Work = ReadyForFieldWork;
            Facebook_Profile_URL = FacebookProfileURL;
            LinkedIn_Profile_URL = LinkedInProfileURL;
            Github_Profile_URL = GithubProfileURL;
            Comment = comment;
            Registration_Date = RegistrationDate;
            Rating = rating;
        }

        public void UpdatePrefInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePrefInfo");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.Parameters.AddWithValue("@Skills", Skills);
            cmd.Parameters.AddWithValue("@Willing_To_Relocate", Willing_To_Relocate);
            cmd.Parameters.AddWithValue("@Preferred_Location", Preferred_Location);
            cmd.Parameters.AddWithValue("@Ready_To_Work_In_Shifts", Ready_To_Work_In_Shifts);
            cmd.Parameters.AddWithValue("@Work_Prefer_Type", Work_Prefer_Type);
            cmd.Parameters.AddWithValue("@Ready_For_Field_Work", Ready_For_Field_Work);
            cmd.Parameters.AddWithValue("@Facebook_Profile_URL", Facebook_Profile_URL);
            cmd.Parameters.AddWithValue("@LinkedIn_Profile_URL", LinkedIn_Profile_URL);
            cmd.Parameters.AddWithValue("@Github_Profile_URL", Github_Profile_URL);
            cmd.Parameters.AddWithValue("@Comment", Comment);
            cmd.Parameters.AddWithValue("@Registration_Date", Registration_Date);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ShowCandidateDashboard()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Candidate Dashboard");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        ////Nilam Data ////




        public DataTable ShowCandidateList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowCandidateJobList");
            cmd.Parameters.AddWithValue("@Job_Title", job_title);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }





        public SqlDataReader RemainingDataFetch()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "RemainingDataFetch");

            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }


        public ClsCandidateRegistration(string full_name, string contact_no, string email_id, string city_name,
          string qualification, string status, string job_stream_name, string gender, string last_org, string skills, string currency
          , string total_experience, string comment, string position, string current_employees_status)
        {
            Full_Name = full_name;
            Contact_No = contact_no;

            Email_ID = email_id;
            City_Name = city_name;
            Status = status;
            Qualification = qualification;
            Job_Stream_Name = job_stream_name;
            Total_Experience = total_experience;
            Comment = comment;
            Position = position;
            Current_Employee_Status = current_employees_status;
            Gender = gender;
            Last_Organization = last_org;
            Skills = skills;
            Currency = currency;

        }
        public DataTable SearchCandidateList()
        {
            

            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchCandidateList");
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            //...Rohan Edit
            cmd.Parameters.AddWithValue("@Email_ID", Email_ID);
            cmd.Parameters.AddWithValue("@City_Name", City_Name);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.Parameters.AddWithValue("@Job_Stream_Name", Job_Stream_Name);
            cmd.Parameters.AddWithValue("@Total_Experience", Total_Experience);
            cmd.Parameters.AddWithValue("@Comment", Comment);
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Current_Employee_Status", Current_Employee_Status);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Last_Organization", Last_Organization);
            cmd.Parameters.AddWithValue("@Skills", Skills);
            cmd.Parameters.AddWithValue("@Currency", Currency);



            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }



        //public ClsCandidateRegistration(string full_name, string contact_no)
        //{
        //    Full_Name = full_name;
        //    Contact_No = contact_no;

        //}
        //public DataTable SearchCandidateList()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Candidate", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "SearchCandidateList");
        //    cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
        //    cmd.Parameters.AddWithValue("@Contact_No", Contact_No);

        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    con.Close();

        //}
        //................................................................................................................
        //For Import Candidate List

        public SqlDataReader FetchCityID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCityID");
            cmd.Parameters.AddWithValue("@City_Name", City_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader FetchStaffRegID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStaffRegID");
            cmd.Parameters.AddWithValue("@Email_ID", Email_ID);
            SqlDataReader dr1;
            dr1 = cmd.ExecuteReader();
            return dr1;

            con.Close();
        }
        public SqlDataReader FetchQualificationID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchQualificationID");
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();
            return dr2;
            con.Close();
        }

        public SqlDataReader FetchSpecializationID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchSpecializationID");
            cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);
            SqlDataReader dr3;
            dr3 = cmd.ExecuteReader();
            return dr3;
            con.Close();
        }

        public SqlDataReader FetchJobStreamID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchJobStreamID");
            cmd.Parameters.AddWithValue("@Job_Stream_Name", Job_Stream_Name);
            SqlDataReader dr4;
            dr4 = cmd.ExecuteReader();
            return dr4;
            con.Close();
        }
        public SqlDataReader FetchStatusID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchStatusID");
            cmd.Parameters.AddWithValue("@Status", Status);
            SqlDataReader dr5;
            dr5 = cmd.ExecuteReader();
            return dr5;
            con.Close();
        }
        public SqlDataReader UpdatePI()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateCandidateInfoFetch");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }


        public SqlDataReader GetStaffData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStaffData");
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            //cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader GetJobStreamData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetJobStreamData");
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            //cmd.Parameters.AddWithValue("@Job_Stream_Name", Job_Stream_Name);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        //................................................................................................................
        //Sajesh
        public void deleterow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Delete_Candidate");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //..................................................................................................
        //Asmita Methods

        public DataTable GetInterviewDetails()
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InterviewAttended");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        public DataTable GetSelectedDetails()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Selected");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            con.Close();
            return dt;
        }
        public DataTable offerAcepted()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "offeraccepted");
            cmd.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            con.Close();
            return dt;
        }


        // Daily LineUp Graph 

        public DataTable GetLineUpGraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Line_Up_Graph");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        // Daily Candidate Graph
        public DataTable GetCandidateCount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Candidate_Graph");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        // Filter_By_Condidate
        public DataTable Filter_By_Condidate()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Cnadidate");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

            //Candidate_With_Specialization
          public DataTable Candidate_With_Specialization()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Candidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Candidate_With_Specialization");
                cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
                con.Close();

            }

        public DataTable Filter_By_Job_Stream()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Job_Stream_ID");
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        //Candidate_With_Specialization
        
        public DataTable Candidate_With_Job_Stream()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Candidate_With_Job_Stream");
            cmd.Parameters.AddWithValue("@Job_Stream_ID", Job_Stream_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Candidate_With_Qualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Candidate_With_Qualification");
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Filter_By_Qualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Qualification");
            
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable FetchPCity()    //Procedure For Fetching City 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPCity");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable DataDuplication()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DataDuplication");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable FetchExperience()    //Procedure For Fetching Experience
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Candidate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Experience");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            con.Close();

        }

    }
    }
    

