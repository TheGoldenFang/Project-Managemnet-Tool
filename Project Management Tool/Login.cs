using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private void btblogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form8 = new home();
            form8.Show();
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form2 = new Registration();
            form2.Show();
        }
        private void loginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.FromArgb(50,0,0,0);
            welcomepanel.BackColor = Color.FromArgb(50,0,0,0);
            LoginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginPanel.Width,LoginPanel.Height, 30, 30));
            welcomepanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomepanel.Width, welcomepanel.Height, 30, 30));
        }

       
    }
}
