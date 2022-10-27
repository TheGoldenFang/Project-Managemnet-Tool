using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class workspace : Form
    {
        public workspace()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblDesign_Click(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblshapes_Click(object sender, EventArgs e)
        {

        }

        private void basicdiagramspannel_Paint(object sender, PaintEventArgs e)
        {

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
        private void workspaceClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workspace_Load(object sender, EventArgs e)
        {
            homepanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            WorkspacePage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, WorkspacePage.Width, WorkspacePage.Height, 30, 30));
        }
    }
}
