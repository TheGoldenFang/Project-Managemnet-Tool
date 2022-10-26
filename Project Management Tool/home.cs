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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void btHomeImpExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import_export form4 = new Import_export();
            form4.Show();
        }

        private void btHomeAccDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile form5 = new Profile();
            form5.Show();
        }

        private void btHomeToPremium_Click(object sender, EventArgs e)
        {
            Premium form7 = new Premium();
            form7.ShowDialog();
        }

        private void btHomeSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings form6 = new Settings();
            form6.Show();
        }

        private void btHomeFile_Click(object sender, EventArgs e)
        {

        }

        private void btHomeGetStarted_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template form3 = new Template();
            form3.Show();
        }

        private void homeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
