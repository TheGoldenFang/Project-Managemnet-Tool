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
    public partial class Import_export : Form
    {
        public Import_export()
        {
            InitializeComponent();
        }

        private void Import_export_Load(object sender, EventArgs e)
        {

        }

        private void imphome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form8 = new home();
            form8.Show();
        }

        private void impprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile form5 = new Profile();
            form5.Show();
        }

        private void imptemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template form3 = new Template();
            form3.Show();
        }

        private void impquestion_Click(object sender, EventArgs e)
        {

        }

        private void impSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings form6 = new Settings();
            form6.Show();
        }

        private void impexpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
