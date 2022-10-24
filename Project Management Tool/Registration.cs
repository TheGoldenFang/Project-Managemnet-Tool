using Project_Management_Tool.Project_Management_Tool_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        Name user=new Name();
        private void button1_Click(object sender, EventArgs e)
        {
            //Get values from the input fields
            user.EmailId = textBox1.Text;
            user.Username=textBox3.Text;
            user.Password=textBox2.Text;
            user.ConfirmPassword=textBox4.Text;
            user.Organization=textBox6.Text;
            user.OrganizationId=textBox7.Text;
            user.FirstName=textBox10.Text;
            user.LastName=textBox8.Text;
            user.PhoneNumber = textBox9.Text;

            //Inserting data into database
            bool success=user.Register(user);
            if (success)
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
        }
    }
}
