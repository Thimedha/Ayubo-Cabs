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
    public partial class Rent : Form
    {
        // SQL Connection String connecting
        SqlConnection cnn = new SqlConnection(connectionstr);
        static string connectionstr = "Data Source=WHITE-DEVIL\\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True"; 
        public Rent()
        {
            InitializeComponent();
            fillComboBox();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Hide();
        }
        private void fillComboBox() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select VehicleNo from Register_Table", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbVehicleNo.DataSource = dt;
            cmbVehicleNo.DisplayMember = "VehicleNo";
            cmbVehicleNo.ValueMember = "VehicleNo";
        }
        private void FormClear()
            /*
             * This is form clearing code
             * It is usinge all form cleaning function for ceaning button
             */
        {
            txtRentID.Text = "";
            txtClient.Text = "";
            txtContactNo.Text = "";
            cmbVehicleNo.ResetText();
            dtpRentDate.ResetText();
            dtpReturnDate.ResetText();
            rdbWithDriver.Checked = false;
            rdbWithoutDriver.Checked = false;
            txtTotalRent.Text = "";
            txtSearch.Text = "";
            txtDriverCharge.Text = "";
            txtDailyRent.Text = "";
            txtWeeklyRent.Text = "";
            txtMonthlyRent.Text = "";
        }

        private void btnRClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }
        private void InsertRent()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rent_Table VALUES (@RentID, @Client, @ContactNo, @VehicleNo, @RentedDate, @ReturnDate, @Driver, @TotalRent)", cnn);
                cmd.Parameters.AddWithValue("@RentID", txtRentID.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@RentedDate", dtpRentDate.Value);
                cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value);
                string Driver;
                if (rdbWithDriver.Checked) Driver = "With Driver";
                else Driver = "Without Driver";
                cmd.Parameters.AddWithValue("@Driver", Driver);
                cmd.Parameters.AddWithValue("@TotalRent", txtTotalRent.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Record Added", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormClear();
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

        private void btnRInsert_Click(object sender, EventArgs e)
        {
            InsertRent();
        }
        private void UpdateRent()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Update Rent_Table Set Client=@Client, ContactNo=@ContactNo, VehicleNo=@VehicleNo, RentDate=@RentDate, ReturnDate=@ReturnDate, Driver=@Driver, TotalRent=@TotalRent Where RentID=@RentID", cnn);
                cmd.Parameters.AddWithValue("@RentID", txtRentID.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@RentDate", dtpRentDate.Value);
                cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value);
                string Driver;
                if (rdbWithDriver.Checked) Driver = "With Driver";
                else Driver = "Without Driver";
                cmd.Parameters.AddWithValue("@Driver", Driver);
                cmd.Parameters.AddWithValue("@TotalRent", txtTotalRent.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Record Updated", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormClear();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            UpdateRent();
        }
        private void DeleteRent()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Rent_Table Where RentID=@RentID", cnn);
                cmd.Parameters.AddWithValue("@RentID", txtRentID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormClear();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnRDelete_Click(object sender, EventArgs e)
        {
            DeleteRent();
        }
        private void ViewRent()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Rent_Table Where RentID=@RentID", cnn);
                cmd.Parameters.AddWithValue("@RentID", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtRentID.Text = dr[0].ToString();
                    txtClient.Text = dr[1].ToString();
                    txtContactNo.Text = dr[2].ToString();
                    cmbVehicleNo.Text = dr[3].ToString();
                    dtpRentDate.Text = dr[4].ToString();
                    dtpReturnDate.Text = dr[5].ToString();
                    if (dr[6].Equals("With Driver"))
                        rdbWithDriver.Checked = true;
                    else
                        rdbWithoutDriver.Checked = true;
                    txtTotalRent.Text = dr[7].ToString();
                }
                else
                {
                    MessageBox.Show("Rent Vehicle Not Found", "Database load", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            finally
            {
                cnn.Close();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            ViewRent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Rent_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            dgvRent.DataSource = dt;
            cnn.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Register_Table where VehicleNo=@VehicleNo", cnn);
            cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
            cnn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txtDailyRent.Text = dr1.GetValue(2).ToString();
                txtWeeklyRent.Text = dr1.GetValue(3).ToString();
                txtMonthlyRent.Text = dr1.GetValue(4).ToString(); 
                txtDriverCharge.Text = dr1.GetValue(5).ToString();
            }
            cnn.Close();


            string client;
            double check = 0;
            float charges = 0;
            DateTime Rent_Date = dtpRentDate.Value;
            DateTime End_Date = dtpReturnDate.Value;
            int remaining_Days = (int)End_Date.Subtract(Rent_Date).TotalDays + 1;


            float no_of_months = remaining_Days / 30;
            float no_of_weeks = remaining_Days / 7;
           
            float no_of_days = remaining_Days - no_of_weeks * 7;
            float monthly_Rent = float.Parse(txtMonthlyRent.Text);
            float weekly_Rent = float.Parse(txtWeeklyRent.Text);
            float daily_Rent = float.Parse(txtDailyRent.Text);
            float driver_Charge = float.Parse(txtDriverCharge.Text);


            if (remaining_Days < 7)
            {
                client = txtClient.Text;
                charges = no_of_days * daily_Rent;
            }

            if (remaining_Days >= 7 | remaining_Days < 30)
            {
                charges = (no_of_months * monthly_Rent) + (no_of_weeks * weekly_Rent) + (no_of_days * daily_Rent)+(no_of_days * driver_Charge);
            }
            else if (remaining_Days >= 7 | remaining_Days < 30)
            {
                charges = (no_of_months * monthly_Rent) + (no_of_weeks * weekly_Rent) + (no_of_days * daily_Rent) ;
            }
            

            if (rdbWithDriver.Checked)
            {
                charges = (no_of_months * monthly_Rent) + (no_of_weeks * weekly_Rent) + (no_of_days * daily_Rent) + (remaining_Days * driver_Charge);
            }
            else 
            {
                charges = (no_of_months * monthly_Rent) + (no_of_weeks * weekly_Rent) + (no_of_days * daily_Rent);
            }
          

            double totalCost = charges + check;
            txtTotalRent.Text = totalCost.ToString();


        }
    }
}
