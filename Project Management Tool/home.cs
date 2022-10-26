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

        private void button4_Click(object sender, EventArgs e)
        {
            Profile form5 = new Profile();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Template form3 = new Template();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Import_export form4 = new Import_export();
            form4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings form6 = new Settings();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Premium form7 = new Premium();
            form7.ShowDialog();
        }
    }
}
