using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;
using GayaSoftHRForumLibrary.HR;



namespace GayaSoftHRForumLibrary.HR
{
    public class ClsStaffRegistration
    {
        
       // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6EEOFMV\\SQLEXPRESS01;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int Position_ID { get; set; }
        public string Position_Name { get; set; }

        //Staff Register
        public int Staff_Register_ID { get; set; }
        public string Full_Name { get; set; }
        public string Email_ID { get; set; }
        public string Password { get; set; }
        public string Mobile_No { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int City_ID { get; set; }
        public int Pincode { get; set; }
        public int Country_ID { get; set; }
        public int State_ID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public string Company_Size { get; set; }
        public int Time_Zone_ID { get; set; }
        public string Time_Zone { get; set; }
        public int Currency_ID { get; set; }
        public string Currency { get; set; }
        public DateTime Assign_Date { get; set; }

        public DateTime FromAssign_Date { get; set; }

        public DateTime ToAssign_Date { get; set; }

     

        public ClsStaffRegistration(string fullname, string emailid,
                                    string password, string mobileno, DateTime dob, string gender, string address,
                                    int cityid, int pincode, int positionid)
        {
            Full_Name = fullname;
            Email_ID = emailid;
            Password = password;
            Mobile_No = mobileno;
            DOB = dob;
            Gender = gender;
            Address = address;
            City_ID = cityid;
            Pincode = pincode;
            Position_ID = positionid;
        }

        //Register Staff Data
        public ClsStaffRegistration()
        {

        }
        public void Staffregisterdata()     //Register Staff Data
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn); //Stored Procdeure Name
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "RegisterStaff");
            command.Parameters.AddWithValue("@Full_Name ", Full_Name);
            command.Parameters.AddWithValue("@Email_ID ", Email_ID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Mobile_No ", Mobile_No);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@City_ID", City_ID);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@Position_ID", Position_ID);
            command.Parameters.AddWithValue("@Is_Deleted", 0);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable countrybind()  //Country Bind in ComboBox
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "Get_Country");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }
        public ClsStaffRegistration(int id)
        {
            Time_Zone_ID = id;
            Currency_ID = id;
            ID = id;
            Staff_Register_ID = id;
        }
        public DataTable Statebind()        //State Bind in ComboBox
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "Get_State");
            command.Parameters.AddWithValue("@Country_ID", ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }
        public DataTable Citybind()  //City Bind in ComboBox
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "Get_City");
            command.Parameters.AddWithValue("@State_ID", ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }

        public DataTable Positionbind() //Position Bind in ComboBox
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "Get_Position");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }

        // Login User
        public ClsStaffRegistration(string emailid, string password)
        {
            Email_ID = emailid;
            Password = password;
        }

        public SqlDataReader Checklogin()         // Login     
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "CheckLogin");
            command.Parameters.AddWithValue("@Email_ID", Email_ID);
            command.Parameters.AddWithValue("@Password", Password);
            SqlDataReader dr;
            dr = command.ExecuteReader();
            return dr;
            conn.Close();
        }

        // Forgot Password
        public ClsStaffRegistration(string name)
        {
            Email_ID = name;

        }
        public SqlDataReader ForgotPwd()     // forgot password
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "ForgetPassword");
            command.Parameters.AddWithValue("@Email_ID", Email_ID);
            SqlDataReader dr;
            dr = command.ExecuteReader();
            return dr;
            conn.Close();
        }
        public void ChangePWD()   // change Password
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "UpdatePassword");
            command.Parameters.AddWithValue("@Email_ID", Email_ID);
            command.Parameters.AddWithValue("@Password", Password);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public SqlDataReader CheckOldPassword()    //Change Password - Check Old Password
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "CheckPassword");
            command.Parameters.AddWithValue("@Email_ID", Email_ID);
            command.Parameters.AddWithValue("@Password", Password);
            SqlDataReader dr;
            dr = command.ExecuteReader();
            return dr;
            conn.Close();
        }
        //public SqlDataReader DashCheckOldPassword()    //Change Password - Check Old Password
        //{
        //    conn.Open();
        //    SqlCommand command = new SqlCommand("Admin", conn);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@Flag", "CheckPassword");
        //    command.Parameters.AddWithValue("@Email_ID", Email_ID);
        //    command.Parameters.AddWithValue("@Password", Password);
        //    SqlDataReader dr;
        //    dr = command.ExecuteReader();
        //    return dr;
        //    conn.Close();
        //}

        public SqlDataReader getposition()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "GetPosition");
            command.Parameters.AddWithValue("@Position_ID", ID);

            SqlDataReader dr;
            dr = command.ExecuteReader();
            return dr;
            conn.Close();
        }
        public SqlDataReader FetchEditStaff()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "FetchStaffEdit");
            command.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);

            SqlDataReader dr;
            dr = command.ExecuteReader();
            return dr;
            conn.Close();
        }
        public DataTable Addmember()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddMember");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            conn.Close();

        }
        public void deleterow()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteRow");
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public ClsStaffRegistration(int srid, string fname, string email, string mono, DateTime dob, string gen, string add, int cid, int pinco, int poid)
        {
            Staff_Register_ID = srid;
            Full_Name = fname;
            Email_ID = email;
            Mobile_No = mono;
            DOB = dob;
            Gender = gen;
            Address = add;
            City_ID = cid;
            Pincode = pinco;
            Position_ID = poid;
        }
        public void UpdateStaff()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "UpdateStaff");
            command.Parameters.AddWithValue("@Staff_Register_ID ", Staff_Register_ID);
            command.Parameters.AddWithValue("@Full_Name ", Full_Name);
            command.Parameters.AddWithValue("@Email_ID ", Email_ID);
            command.Parameters.AddWithValue("@Mobile_No ", Mobile_No);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@City_ID", City_ID);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@Position_ID", Position_ID);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public ClsStaffRegistration(int id, string full_Name, string email_ID, string mobile_No, string password)
        {
            Staff_Register_ID = id;
            Full_Name = full_Name;
            Email_ID = email_ID;
            Mobile_No = mobile_No;
            Password = password;
        }

        public void UpdateAdmin()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update_Admin_Profile");
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Email_ID", Email_ID);
            cmd.Parameters.AddWithValue("@Mobile_No", Mobile_No);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public SqlDataReader GetData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getdata");
            cmd.Parameters.AddWithValue("@Staff_Register_ID", Staff_Register_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            conn.Close();
        }
        //*********************************************************************Tejal

        public ClsStaffRegistration(string companyName, string companySize, int timeZoneId, int currencyId)
        {
            Company_Name = companyName;
            Company_Size = companySize;
            Time_Zone_ID = timeZoneId;
            Currency_ID = currencyId;
        }
        public void SaveCompanyDetails()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Save_Company");
            cmd.Parameters.AddWithValue("@Company_Name", Company_Name);
            cmd.Parameters.AddWithValue("@Company_Size", Company_Size);
            cmd.Parameters.AddWithValue("@Time_Zone_ID", Time_Zone_ID);
            cmd.Parameters.AddWithValue("@Currency_ID", Currency_ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       

        public DataTable getTime_Zone()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchTime_Zone");
            cmd.Parameters.AddWithValue("@Time_Zone_ID", Time_Zone_ID);
            cmd.Parameters.AddWithValue("@Time_Zone", Time_Zone);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }
        public DataTable getCurrency()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCurrency");
            cmd.Parameters.AddWithValue("@Currency_ID", Currency_ID);
            cmd.Parameters.AddWithValue("@Currency", Currency);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt1 = new DataTable();
            adpt.Fill(dt1);
            return dt1;
            conn.Close();
        }

        // Staff_Registration Team Member Bind

        public DataTable BindTeamMember() //Position Bind in ComboBox
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Admin", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Flag", "BindTeamMember");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = command;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }

        // Team Performance Report 

        public ClsStaffRegistration(int staffreg, DateTime assigndate, DateTime AssignDate)
        {
            Staff_Register_ID = staffreg;
            FromAssign_Date = assigndate;
            ToAssign_Date = AssignDate;

        }

        public DataTable Team_Performance_Report()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Admin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Team_Performance_Report");
            cmd.Parameters.AddWithValue("@Staff_Register_ID ", Staff_Register_ID);
            cmd.Parameters.AddWithValue("@FromAssign_Date ", FromAssign_Date);
            cmd.Parameters.AddWithValue("@ToAssign_Date ", ToAssign_Date);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }
        public DataTable BindJobTitle()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Job", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "BindJobTitle");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            conn.Close();
        }
    }
}


