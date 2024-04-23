using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AyuboNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Conecting to SQL data base
            SqlConnection cnn = new SqlConnection(@"Data Source=WHITE-DEVIL\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True");
            // SQL user name Password collecting  for login_table 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login_table WHERE username = '" + txtUser.Text + "' AND password ='" + txtPassword.Text + "' ", cnn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Success", "Login Allow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu obj1 = new Menu();
                obj1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your user name and password !", "Login Allow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtUser.Clear();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this system?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
