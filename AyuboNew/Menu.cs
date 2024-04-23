using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboNew
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void applicationExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this system?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this system?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 obj2 = new Form1();
            obj2.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Vehical_Reg obj3 = new Vehical_Reg();
            obj3.Show();
            this.Hide();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            Package obj4 = new Package();
            obj4.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Rent obj5 = new Rent();
            obj5.Show();
            this.Hide();
        }

        private void btnDayTour_Click(object sender, EventArgs e)
        {
            Day_Tour_Hire obj6 = new Day_Tour_Hire();
            obj6.Show();
            this.Hide();
        }

        private void btnLongTour_Click(object sender, EventArgs e)
        {
            Long_Tour_Hire obj7 = new Long_Tour_Hire();
            obj7.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj8 = new Form1();
            obj8.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vehical_Reg obj9 = new Vehical_Reg();
            obj9.Show();
            this.Hide();
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package obj10 = new Package();
            obj10.Show();
            this.Hide();
        }

        private void rentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rent obj11 = new Rent();
            obj11.Show();
            this.Hide();
        }

        private void dayTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Day_Tour_Hire obj12 = new Day_Tour_Hire();
            obj12.Show();
            this.Hide();
        }

        private void longTourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Long_Tour_Hire obj13 = new Long_Tour_Hire();
            obj13.Show();
            this.Hide();
        }
    }
}
