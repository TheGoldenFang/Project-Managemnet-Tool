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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void settingshome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form8 = new home();
            form8.Show();
        }

        private void settingsprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile form5 = new Profile();
            form5.Show();
        }

        private void settingstemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template form3 = new Template();
            form3.Show();
        }

        private void settingsquestion_Click(object sender, EventArgs e)
        {

        }

        private void settingsimpexp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import_export form4 = new Import_export();
            form4.Show();
        }

        private void settingsSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings form6 = new Settings();
            form6.Show();
        }

        private void settingsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
