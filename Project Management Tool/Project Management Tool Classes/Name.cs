using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Tool.Project_Management_Tool_Classes
{
    class Name
    {
        public string EmailId { get; set;  }
        public string Username  { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Organization { get; set; }
        public string OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[" "].ConnectionString;

        //Inserting data into database
        public bool Register(Name n)
        {
            //Creating a default retun type and setting value to false
            bool isSuccess = false;
            //Connect database
            SqlConnection conn=new SqlConnection(myconnstrng);
            try
            {
                //Create sql query to insert into data
                string sql = "INSERT INTO ";
                //Creating sql command using sq and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue();  //Adding first name
                cmd.Parameters.AddWithValue(); //Adding last name
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                cmd.Parameters.AddWithValue();
                //Connection open here
                conn.Open();
                int rows=cmd.ExecuteNonQuery();
                //If the query runs successfully then value of rows will be greater than zero else less than zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
