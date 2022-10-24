using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Create sql query to check for the validity of data 
                string checkuser = "SELECT * FROM user_profile WHERE Username=       ";
                //Creating sql command using sq and conn
                SqlCommand cmd = new SqlCommand(checkuser, conn);
                //Connection open here
                conn.Open();
                //Excecutethe query 
                cmd.ExecuteNonQuery();
                //If the query runs successfully then it should open home page 
                if ()
                {
                    home form3 = new home();
                    form3.Show();
                }
                //else it should display invalid credentials
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Registration form2 = new Registration();
            form2.Show();
        }
    }
}
