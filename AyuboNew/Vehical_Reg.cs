using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboNew
{
    /// <summary>
    /// This is a wvhicle registration form program.
    /// </summary>
    public partial class Vehical_Reg : Form
    {
        static string connectionstr = "Data Source=WHITE-DEVIL\\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public Vehical_Reg()
        {
            InitializeComponent();
        }

        private void btnRMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want close this ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Menu obj1 = new Menu();
                obj1.Show();
                this.Hide();

            }
            else if (result == DialogResult.No)
            {
                //.
            }
          

        }
        private void formClear() 
        {
            txtVehicleNo.Text = "";
            txtVehicleType.Text = "";
            txtDailyRent.Text = "";
            txtWeeklyRent.Text = "";
            txtMonthlyRent.Text = "";
            txtDriverCharge.Text = "";
            txtSearch.Text = "";
        }

        private void btnRClear_Click(object sender, EventArgs e)
        {
            formClear();
        }
        private void registerVehicle()  
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Register_Table VALUES (@VehicleNo, @VehicleType, @DailyRent, @WeeklyRent, @MonthlyRent, @DriverCharge)", cnn);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@VehicleType", txtVehicleType.Text);
                cmd.Parameters.AddWithValue("@DailyRent", txtDailyRent.Text);
                cmd.Parameters.AddWithValue("@WeeklyRent", txtWeeklyRent.Text);
                cmd.Parameters.AddWithValue("@MonthlyRent", txtMonthlyRent.Text);
                cmd.Parameters.AddWithValue("@DriverCharge", txtDriverCharge.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Vehicle Registerd", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                formClear();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        private void updateVehicle()   // Coding for update function 
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Update Register_Table Set VehicleType=@VehicleType, DailyRent=@DailyRent, WeeklyRent=@WeeklyRent, MonthlyRent=@MonthlyRent, DriverCharge=@DriverCharge where VehicleNo=@VehicleNo", cnn);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@VehicleType", txtVehicleType.Text);
                cmd.Parameters.AddWithValue("@DailyRent", txtDailyRent.Text);
                cmd.Parameters.AddWithValue("@WeeklyRent", txtWeeklyRent.Text);
                cmd.Parameters.AddWithValue("@MonthlyRent", txtMonthlyRent.Text);
                cmd.Parameters.AddWithValue("@DriverCharge", txtDriverCharge.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Details Updated", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                formClear();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            updateVehicle();
        }
        private void deleteVehicle()  // Coding for delete function
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Register_Table Where VehicleNo = @VehicleNo", cnn);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Record Deleted", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                formClear();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnRDelete_Click(object sender, EventArgs e)
        {
            deleteVehicle();
        }
        private void loadRegistration()  
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Register_Table Where VehicleNo=@VehicleNo", cnn);
                cmd.Parameters.AddWithValue("@VehicleNo", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtVehicleNo.Text = dr[0].ToString();
                    txtVehicleType.Text = dr[1].ToString();
                    txtDailyRent.Text = dr[2].ToString();
                    txtWeeklyRent.Text = dr[3].ToString();
                    txtMonthlyRent.Text = dr[4].ToString();
                    txtDriverCharge.Text = dr[5].ToString();
                }
                else
                {
                    MessageBox.Show("Vehicle Not Found", "Database load", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                cnn.Close();
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            loadRegistration();
        }

        private void btnRView_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Register_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvReg.DataSource = dt;
            cnn.Close();
        }

        private void btnRRegister_Click(object sender, EventArgs e)
        {
            registerVehicle();
        }
    }
}
