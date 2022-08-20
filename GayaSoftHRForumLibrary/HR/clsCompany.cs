using System;
using System.Data;
using System.Data.SqlClient;
using GayaSoftHRForumLibrary.HR;

namespace GayaSoftHRForumLibrary.HR
{
    public class ClsCompany
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P7MPNPH;Initial Catalog=GayaSoftHRForum;Integrated Security=True");

        //  SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS7NF1D;Initial Catalog=GayaSoftHRForum;Integrated Security=True");
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public string Full_Address { get; set; }
        public string Company_Email { get; set; }
        public string Company_Owner { get; set; }
        public string Company_Website { get; set; }
        public string Facebook_Profile_URL { get; set; }
        public string Twitter_Profile_URL { get; set; }
        public string LinkedIn_Profile_URL { get; set; }
        public DateTime Company_Registration_Date { get; set; }
        public DateTime Date { get; set; }
        public int Is_Deleted { get; set; }
        public int StatusID { get; set; }


        // Industry
        public int IndustryID { get; set; }
        public string IndustryName { get; set; }

        /*For country*/
        public string CountryName { get; set; }
        public int CountryID { get; set; }

        /*for state*/
        public int StateID { get; set; }
        public string StateName { get; set; }

        /*For City*/
        public int CityID { get; set; }
        public string City { get; set; }

        /*Company HR contact*/
        public string HRname { get; set; }
        public string HRnumber { get; set; }
        public string HRemail { get; set; }

        /*Job*/
        public int JobID { get; set; }
        public int Job_ID { get; set; }
       public DateTime From_Date { get; set; }
       public DateTime To_Date { get; set; }

    public DataTable ShowAllCompanies()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllCompanyList");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        /*Company Registration*/
        public ClsCompany(string cname, int industry, string address, int city, string email, string owner, string website, string facebook, string twitter, string linkedin, int statusid, DateTime regdate, DateTime date, int isdeleted)
        {
            Company_Name = cname;
            IndustryID = industry;
            Full_Address = address;
            CityID = city;
            Company_Email = email;
            Company_Owner = owner;
            Company_Website = website;
            Facebook_Profile_URL = facebook;
            Twitter_Profile_URL = twitter;
            LinkedIn_Profile_URL = linkedin;
            StatusID = statusid;
            Company_Registration_Date = regdate;
            Date = date;
            Is_Deleted = isdeleted;
        }
        public DataTable ExistCompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ExistCompany");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public void RegisterCompany()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Add_Company");
            cmd.Parameters.AddWithValue("@Company_Name", Company_Name);
            cmd.Parameters.AddWithValue("@Industry_ID", IndustryID);
            cmd.Parameters.AddWithValue("@Full_Address", Full_Address);
            cmd.Parameters.AddWithValue("@City_ID", CityID);
            cmd.Parameters.AddWithValue("@Company_Email", Company_Email);
            cmd.Parameters.AddWithValue("@Company_Owner", Company_Owner);
            cmd.Parameters.AddWithValue("@Company_Website", Company_Website);
            cmd.Parameters.AddWithValue("@Facebook_Profile_URL", Facebook_Profile_URL);
            cmd.Parameters.AddWithValue("@Twitter_Profile_URL", Twitter_Profile_URL);
            cmd.Parameters.AddWithValue("@LinkedIn_Profile_URL", LinkedIn_Profile_URL);
            cmd.Parameters.AddWithValue("@Status_ID", StatusID);
            cmd.Parameters.AddWithValue("@Company_Registration_Date", Company_Registration_Date);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        //To Fetch Industry ID from Industry Name
        public SqlDataReader GetIndustryID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetIndustryID");
            cmd.Parameters.AddWithValue("@Industry_Name", IndustryName);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;


            con.Close();
        }

        //To Fetch City ID from City Name
        public SqlDataReader GetCityID()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCityID");
            cmd.Parameters.AddWithValue("@City_Name", City);
            SqlDataReader dr1;
            dr1 = cmd.ExecuteReader();
            return dr1;
            con.Close();
        }


        public ClsCompany(int companyID, string cname, string email, int industry, string website, string owner, string address, string facebook, string linkedin, string twitter)
        {
            Company_ID = companyID;
            Company_Name = cname;
            Company_Email = email;
            IndustryID = industry;
            Company_Website = website;

            Company_Owner = owner;
            Full_Address = address;

            Facebook_Profile_URL = facebook;
            LinkedIn_Profile_URL = linkedin;

            Twitter_Profile_URL = twitter;
        }

        public void UpdateCompany()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update_Company");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);

            cmd.Parameters.AddWithValue("@Company_Name", Company_Name);
            cmd.Parameters.AddWithValue("@Company_Email", Company_Email);
            cmd.Parameters.AddWithValue("@Industry_ID", IndustryID);
            cmd.Parameters.AddWithValue("@Company_Website", Company_Website);
            cmd.Parameters.AddWithValue("@Company_Owner", Company_Owner);
            cmd.Parameters.AddWithValue("@Full_Address", Full_Address);
            cmd.Parameters.AddWithValue("@Facebook_Profile_URL", Facebook_Profile_URL);
            cmd.Parameters.AddWithValue("@LinkedIn_Profile_URL", LinkedIn_Profile_URL);
            cmd.Parameters.AddWithValue("@Twitter_Profile_URL", Twitter_Profile_URL);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable FetchCountry()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCountry");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;


            con.Close();
        }

        public ClsCompany(int comdetails)
        {
            CountryID = comdetails;   /*Fetch City*/
            StateID = comdetails;   /*Fetch State*/
            Company_ID = comdetails;
            IndustryID = comdetails;
        }
        public DataTable FetchState()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchState");
            cmd.Parameters.AddWithValue("@Country_ID", StateID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }


        public DataTable FetchCity()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCity");
            cmd.Parameters.AddWithValue("@State_ID", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }

        public DataTable FetchIndustry()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchIndustry");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }

        public ClsCompany(string industryname)
        {
            IndustryName = industryname;  /*Add Industry*/
            CountryName = industryname;   /*Add Country*/
            // Company_Name = industryname;
            City = industryname;


        }
        public DataTable AddIndustry()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Save_Industry_Name");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public ClsCompany(int Companyid, string hrName, string hrNumber, string hrEmail)
        {
            Company_ID = Companyid;
            HRname = hrName;
            HRnumber = hrNumber;
            HRemail = hrEmail;
        }

        public void AddHR()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CompanyHRContact");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@HR_Name", HRname);
            cmd.Parameters.AddWithValue("@Phone_Number", HRnumber);
            cmd.Parameters.AddWithValue("@Email", HRemail);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader FetchCompanyID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCompanyID");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();

        }

        // To Delete Company
        public void DeleteCompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Delete_Company");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }


       

        public ClsCompany(string companyname, string ownername, string email)
        {
            Company_Name = companyname;
            Company_Owner = ownername;
            Company_Email = email;
        }

        public DataTable Search()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchCompany");
            cmd.Parameters.AddWithValue("@Company_Name", Company_Name);
            cmd.Parameters.AddWithValue("@Company_Owner", Company_Owner);
            cmd.Parameters.AddWithValue("@Company_Email", Company_Email);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public ClsCompany()
        {

        }
        public DataTable ShowCompanyDashboard()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Company_Dashboard");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        //To Show Individual CompanyWise Job Opeing List
        public DataTable ShowIndividual_Companywise_Job_Opening_List()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowIndividual_Companywise_Job_Opening_List");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        //To Show Individual Comapny Deatils
        public SqlDataReader ShowIndividual_Company_Details()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowIndividual_Company_Details");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        //To Show Open Jobs for Specific Company


        public DataTable ShowOpenJobs()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Open_Jobs");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable ShowClosedJobs()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Closed_Jobs");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public SqlDataReader CompanyGraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CompanyGraph");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();



        }

        //-------------Filter_By_Industry_Name--------------
        public DataTable Filter_By_Industry_Name()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Industry_Name");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        
        //--------------Filter_By_Industry_Name_Fron_Grd-----------------
        public DataTable Filter_By_Industry_Name_Fron_Grd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Filter_By_Industry_Name_Fron_Grd");
            cmd.Parameters.AddWithValue("@Industry_ID", IndustryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);
            return dt2;
            con.Close();


        }
        public ClsCompany(int company_id, DateTime fromdate, DateTime todate)
        {
            Company_ID = company_id;
            From_Date = fromdate;
            To_Date = todate;
        }

        public DataTable Get_GraphCompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Admin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_GraphCompany");
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            cmd.Parameters.AddWithValue("@From_Date", From_Date);
            cmd.Parameters.AddWithValue("@To_Date", To_Date);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }


    }
}
