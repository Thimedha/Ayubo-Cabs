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
    public partial class Day_Tour_Hire : Form
    {
        static string connectionstr = "Data Source=WHITE-DEVIL\\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionstr);
        public Day_Tour_Hire()
        {
            InitializeComponent();
            fillcomboboxPackage();
            fillcomboboxVehicleNo();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Hide();
        }
        private void fillcomboboxPackage()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Package from Package_Table", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPackage.DataSource = dt;
            cmbPackage.DisplayMember = "Package";
            cmbPackage.ValueMember = "Package";
        }

        private void fillcomboboxVehicleNo()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select VehicleNo from Register_Table", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbVehicleNo.DataSource = dt;
            cmbVehicleNo.DisplayMember = "VehicleNo";
            cmbVehicleNo.ValueMember = "VehicleNo";
        }
        private void FormClear()
        {
            txtDayTourID.Text = "";
            cmbPackage.ResetText();
            cmbVehicleNo.ResetText();
            txtClient.Text = "";
            txtContactNo.Text = "";
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
            txtStartKmReading.Text = "";
            txtEndKmReading.Text = "";
            txtTotalHire.Text = "";
            txtSearch.Text = "";
            txtDriverCharge.Text = "";
            txtBasicKmCharge.Text = "";
            txtMaxKmLimit.Text = "";
            txtExtraKmCharge.Text = "";
            txtMaxHours.Text = "";
            txtWaitingCharge.Text = "";

        }

        private void btnDClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }
        private void InsertDayTour()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Day_Tour_Table VALUES (@DayTourID, @Package, @VehicleNo, @Client, @ContactNo, @StartTime, @EndTime, @StartKmReading, @EndKmReading, @TotalHire)", cnn);
                cmd.Parameters.AddWithValue("@DayTourID", txtDayTourID.Text);
                cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value);
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value);
                cmd.Parameters.AddWithValue("@StartKmReading", txtStartKmReading.Text);
                cmd.Parameters.AddWithValue("@EndKmReading", txtEndKmReading.Text);
                cmd.Parameters.AddWithValue("@TotalHire", txtTotalHire.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Hire Day Tour Record Added", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormClear();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnDInsert_Click(object sender, EventArgs e)
        {
            InsertDayTour();
        }
        private void UpdateDayTour()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Update Day_Tour_Table Set Package=@Package, VehicleNo=@VehicleNo, Client=@Client, ContactNo=@ContactNo, StartTime=@StartTime, EndTime=@EndTime, StartKmReading=@StartKmReading, EndKmReading=@EndKmReading, TotalHire=@TotalHire where DayTourID=@DayTourID", cnn);
                cmd.Parameters.AddWithValue("@DayTourID", txtDayTourID.Text);
                cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
                cmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value);
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value);
                cmd.Parameters.AddWithValue("@StartKmReading", txtStartKmReading.Text);
                cmd.Parameters.AddWithValue("@EndKmReading", txtEndKmReading.Text);
                cmd.Parameters.AddWithValue("@TotalHire", txtTotalHire.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Day Tour Record Updated", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            UpdateDayTour();
        }
        private void DeleteDayTour()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Day_Tour_Table Where DayTourID=@DayTourID", cnn);
                cmd.Parameters.AddWithValue("@DayTourID", txtDayTourID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Day Tour Record Deleted", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            DeleteDayTour();
        }

        private void ViewDayTour()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Day_Tour_Table Where DayTourID=@DayTourID", cnn);
                cmd.Parameters.AddWithValue("@DayTourID", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtDayTourID.Text = dr[0].ToString();
                    cmbPackage.Text = dr[1].ToString();
                    cmbVehicleNo.Text = dr[2].ToString();
                    txtClient.Text = dr[3].ToString();
                    txtContactNo.Text = dr[4].ToString();
                    dtpStartTime.Text = dr[5].ToString();
                    dtpEndTime.Text = dr[6].ToString();
                    txtStartKmReading.Text = dr[7].ToString();
                    txtEndKmReading.Text = dr[8].ToString();
                    txtTotalHire.Text = dr[9].ToString();
                }
                else
                {
                    MessageBox.Show("Day Tour Not Found", "Database load", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            ViewDayTour();
        }

        private void btnDView_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Day_Tour_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLongTour.DataSource = dt;
            cnn.Close();
        }

        private void btnDCalculate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Package_Table where Package=@Package", cnn);
            cmd.Parameters.AddWithValue("@Package", cmbPackage.Text);
            cnn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txtBasicKmCharge.Text = dr1.GetValue(5).ToString();
                txtMaxKmLimit.Text = dr1.GetValue(2).ToString();
                txtExtraKmCharge.Text = dr1.GetValue(4).ToString();
                txtMaxHours.Text = dr1.GetValue(3).ToString();
                txtWaitingCharge.Text = dr1.GetValue(6).ToString();
                txtDriverCharge.Text = dr1.GetValue(7).ToString();
            }
            cnn.Close();

            
            float Waiting_Charge = 0;
            float Extra_Km_Charge = 0;
            DateTime time1 = dtpStartTime.Value;
            DateTime time2 = dtpEndTime.Value;
            int Total_Hours = (int)time2.Subtract(time1).TotalHours;

            float Start_Km = float.Parse(txtStartKmReading.Text);
            float EndKm = float.Parse(txtEndKmReading.Text);
            float TotalKm = EndKm - Start_Km;

            float Basic_Km_Rate = float.Parse(txtBasicKmCharge.Text);
            float Max_Km_Limit = float.Parse(txtMaxKmLimit.Text);
            float Extra_Km_Rate = float.Parse(txtExtraKmCharge.Text);
            float Max_Hours = float.Parse(txtMaxHours.Text);
            float Extra_Hour_Rate = float.Parse(txtWaitingCharge.Text);
            float Driver_Charge = float.Parse(txtDriverCharge.Text);

            if (Total_Hours > Max_Hours)
            {
                Waiting_Charge = (Total_Hours - Max_Hours) * Extra_Hour_Rate;//(extra hours) * extra hour rate
            }

            if (TotalKm > Max_Km_Limit)
            {
                Extra_Km_Charge = (TotalKm - Max_Km_Limit) * Extra_Km_Rate;// (Extra Distance ) * extra KM Rate
            }
            
            double Total_Hire_Charge = Basic_Km_Rate + Waiting_Charge + Extra_Km_Charge + Driver_Charge;
            
            txtTotalHire.Text = Total_Hire_Charge.ToString();

        }

       
    }
}
