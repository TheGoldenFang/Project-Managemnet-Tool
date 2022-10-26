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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void profilehome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form8 = new home();
            form8.Show();
        }

        private void profiletemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template form3 = new Template();
            form3.Show();
        }

        private void profilequestion_Click(object sender, EventArgs e)
        {

        }

        private void profileimpexp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import_export form4 = new Import_export();
            form4.Show();
        }

        private void profileSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings form6 = new Settings();
            form6.Show();
        }

        private void profileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
