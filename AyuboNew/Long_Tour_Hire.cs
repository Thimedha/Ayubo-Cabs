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
    public partial class Long_Tour_Hire : Form
    {
        static string connectionstr = "Data Source=WHITE-DEVIL\\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionstr);
        public Long_Tour_Hire()
        {
            InitializeComponent();
            FillcmbPackage();
            FillcmbVehicleNo();
            
        }

       
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Hide();
        }
        private void FormClear()
        {
            txtLongTourID.Text = "";
            cmbPackage.ResetText();
            cmbVehicleNo.ResetText();
            txtClient.Text = "";
            txtContactNo.Text = "";
            dtpStartDate.ResetText();
            dtpEndDate.ResetText();
            txtStartKmReading.Text = "";
            txtEndKmReading.Text = "";
            txtTotalHire.Text = "";
            txtSearch.Text = "";
            txtBasicHireCharge.Text = "";
            txtDriverCharge.Text = "";
            txtDriverOvernightRate.Text = "";
            txtWaitOvernightRate.Text = "";
            txtExtraKmCharge.Text = "";
            txtMaximumKmLimit.Text = "";
        }

        private void btnLClear_Click(object sender, EventArgs e)
        {
            FormClear();

        }
        private void FillcmbPackage()
        {

        
            SqlDataAdapter da = new SqlDataAdapter("Select Package from Package_Table", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPackage.DataSource = dt;
            cmbPackage.DisplayMember = "Package";
            cmbPackage.ValueMember = "Package";
        }

        private void FillcmbVehicleNo() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select VehicleNo from Register_Table", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbVehicleNo.DataSource = dt;
            cmbVehicleNo.DisplayMember = "VehicleNo";
            cmbVehicleNo.ValueMember = "VehicleNo";
        }

        private void InsertLongTour()  
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Long_Tour_Table VALUES (@LongTourID, @Package, @VehicleNo, @Client, @ContactNo, @StartDate, @EndDate, @StartKmReading, @EndKmReading, @TotalHire)", cnn);
                cmd.Parameters.AddWithValue("@LongTourID", txtLongTourID.Text);
                cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@StartKmReading", txtStartKmReading.Text);
                cmd.Parameters.AddWithValue("@EndKmReading", txtEndKmReading.Text);
                cmd.Parameters.AddWithValue("@TotalHire", txtTotalHire.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Long Tour Data Record Added", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnLInsert_Click(object sender, EventArgs e)
        {
            InsertLongTour();
        }
        private void UpdateLongTour() 
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Update Long_Tour_Table Set Package=@Package, VehicleNo=@VehicleNo, Client=@Client, ContactNo=@ContactNo, StartDate=@StartDate, EndDate=@EndDate, StartKmReading=@StartKmReading, EndKmReading=@EndKmReading, TotalHire=@TotalHire where LongTourID=@LongTourID", cnn);
                cmd.Parameters.AddWithValue("@LongTourID", txtLongTourID.Text);
                cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@StartKmReading", txtStartKmReading.Text);
                cmd.Parameters.AddWithValue("@EndKmReading", txtEndKmReading.Text);
                cmd.Parameters.AddWithValue("@TotalHire", txtTotalHire.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Long Tour Data Record Updated", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnLUpdate_Click(object sender, EventArgs e)
        {
            UpdateLongTour();
        }
        private void DeleteLongTour()  
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Long_Tour_Table Where LongTourID=@LongTourID", cnn);
                cmd.Parameters.AddWithValue("@LongTourID", txtLongTourID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Long Tour Data Record Deleted", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnLDelete_Click(object sender, EventArgs e)
        {
            DeleteLongTour();
        }
        private void ViewLongTour()  
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Long_Tour_Table Where LongTourID=@LongTourID", cnn);
                cmd.Parameters.AddWithValue("@LongTourID", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtLongTourID.Text = dr[0].ToString();
                    cmbPackage.Text = dr[1].ToString();
                    cmbVehicleNo.Text = dr[2].ToString();
                    txtClient.Text = dr[3].ToString();
                    txtContactNo.Text = dr[4].ToString();
                    dtpStartDate.Text = dr[5].ToString();
                    dtpEndDate.Text = dr[6].ToString();
                    txtStartKmReading.Text = dr[7].ToString();
                    txtEndKmReading.Text = dr[8].ToString();
                    txtTotalHire.Text = dr[9].ToString();
                }
                else
                {
                    MessageBox.Show("Long Tour Data Not Found", "Database load", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

       

        private void btnLView_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Long_Tour_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLongTour.DataSource = dt;
            cnn.Close();
        }

        private void btnLCalculate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Package_Table where Package=@Package", cnn);
            cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
            cnn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txtMaximumKmLimit.Text = dr1.GetValue(2).ToString();
                txtBasicHireCharge.Text = dr1.GetValue(5).ToString();
                txtExtraKmCharge.Text = dr1.GetValue(4).ToString();
                txtDriverCharge.Text = dr1.GetValue(7).ToString();
                txtDriverOvernightRate.Text = dr1.GetValue(8).ToString();
                txtWaitOvernightRate.Text = dr1.GetValue(9).ToString();
            }
            cnn.Close();

            float extra_km_Charge = 0;
            float total_driver_overnight_Charge = 0;
            float total_wait_overnight_Charge = 0;
            float total_overnight_Charge = 0;
            DateTime Start_Date = dtpStartDate.Value;
            DateTime End_Date = dtpEndDate.Value;
            int Number_Of_Days = (int)End_Date.Subtract(Start_Date).TotalDays + 1;
            //.....

            float start_Km = float.Parse(txtStartKmReading.Text);
            float end_Km = float.Parse(txtEndKmReading.Text);
            float total_Km = end_Km - start_Km;

            float max_km_Limit = float.Parse(txtMaximumKmLimit.Text);
            float extra_1km_Charge = float.Parse(txtExtraKmCharge.Text);
            float basic_1Km_Charge = float.Parse(txtBasicHireCharge.Text);
            float perday_driver_overnight_Charge = float.Parse(txtDriverOvernightRate.Text);
            float perday_overnight_park_Charge = float.Parse(txtWaitOvernightRate.Text);
            float driver_Charge = float.Parse(txtDriverCharge.Text);

            if (total_Km > max_km_Limit)
            {
                extra_km_Charge = (total_Km - max_km_Limit) * extra_1km_Charge;
            }

            if (Number_Of_Days >= 2)
            {
                total_driver_overnight_Charge = (Number_Of_Days - 1) * perday_driver_overnight_Charge;

                total_wait_overnight_Charge = (Number_Of_Days - 1) * perday_overnight_park_Charge;

                total_overnight_Charge = total_driver_overnight_Charge + total_wait_overnight_Charge;
            }

            double total_hire_Charge = basic_1Km_Charge + extra_km_Charge + total_overnight_Charge + driver_Charge;
            txtTotalHire.Text = total_hire_Charge.ToString();




        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            ViewLongTour();
        }
    }
    
}
