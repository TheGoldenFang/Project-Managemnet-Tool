﻿using Project_Management_Tool.Project_Management_Tool_Classes;
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


   
        private void regClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regLoginRedirect_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void btbregister_Click(object sender, EventArgs e)
        {
            //Get values from the input fields
            user.EmailId = txtEmail.Text;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.ConfirmPassword = txtConfirmPass.Text;
            user.Organization = txtOrg.Text;
            user.OrganizationId = txtOrgID.Text;
            user.FirstName = txtFName.Text;
            user.LastName = txtLName.Text;
            user.PhoneNumber = txtPhno.Text;

            //Inserting data into database
            bool success = user.Register(user);
            if (success)
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

    }
}
