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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void temphome_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            home form8=new home();  
            form8.Show();
        }

        private void tempprofile_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Profile form5 = new Profile();
            form5.Show();
        }

        private void tempquestion_Click(object sender, EventArgs e)
        {

        }

        private void tempimpexp_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Import_export form4 = new Import_export();
            form4.Show();
        }

        private void tempSettings_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Settings form6 = new Settings();
            form6.Show();
        }

        private void tempClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
