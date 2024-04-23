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
    public partial class Package : Form
    {
        static string connectionstr = "Data Source=WHITE-DEVIL\\SQLEXPRESS;Initial Catalog=ayubocabs_database;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionstr);
        public Package()
        {
            InitializeComponent();
        }

        private void btnPMainMenu_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Hide();
        }
        private void formClear()
        {
            txtPackageID.Text = "";
            txtPackage.Text = "";
            txtMaxKmLimit.Text = "";
            txtMaxHours.Text = "";
            txtExtraKmCharge.Text = "";
            txtBasicKmCharge.Text = "";
            txtWaitingCharge.Text = "";
            txtDriverCharge.Text = "";
            txtDriverOvernightRate.Text = "";
            txtWaitOvernightRate.Text = "";
            txtSearch.Text = "";
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            formClear();
        }
        private void InsertPackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Package_Table VALUES (@PackageID, @Package, @MaxKmLimit, @MaxHours, @ExtraKmCharge, @BasicKmCharge, @WaitingCharge, @DriverCharge, @DriverOvernightRate, @WaitOvernightRate)", cnn);
                cmd.Parameters.AddWithValue("@PackageID", txtPackageID.Text);
                cmd.Parameters.AddWithValue("@Package", txtPackage.Text);
                cmd.Parameters.AddWithValue("@MaxKmLimit", txtMaxKmLimit.Text);
                cmd.Parameters.AddWithValue("@MaxHours", txtMaxHours.Text);
                cmd.Parameters.AddWithValue("@ExtraKmCharge", txtExtraKmCharge.Text);
                cmd.Parameters.AddWithValue("@BasicKmCharge", txtBasicKmCharge.Text);
                cmd.Parameters.AddWithValue("@WaitingCharge", txtWaitingCharge.Text);
                cmd.Parameters.AddWithValue("@DriverCharge", txtDriverCharge.Text);
                cmd.Parameters.AddWithValue("@DriverOvernightRate", txtDriverOvernightRate.Text);
                cmd.Parameters.AddWithValue("@WaitOvernightRate", txtWaitOvernightRate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Package Added", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnPInsert_Click(object sender, EventArgs e)
        {
            InsertPackage();
        
        }
        private void UpdatePackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Update Package_Table Set Package=@Package, MaxKmLimit=@MaxKmLimit, MaxHours=@MaxHours, ExtraKmCharge=@ExtraKmCharge, BasicKmCharge=@BasicKmCharge, WaitingCharge=@WaitingCharge, DriverCharge=@DriverCharge, DriverOvernightRate=@DriverOvernightRate, WaitOvernightRate=@WaitOvernightRate Where PackageID=@PackageID", cnn);
                cmd.Parameters.AddWithValue("@PackageID", txtPackageID.Text);
                cmd.Parameters.AddWithValue("@Package", txtPackage.Text);
                cmd.Parameters.AddWithValue("@MaxKmLimit", txtMaxKmLimit.Text);
                cmd.Parameters.AddWithValue("@MaxHours", txtMaxHours.Text);
                cmd.Parameters.AddWithValue("@ExtraKmCharge", txtExtraKmCharge.Text);
                cmd.Parameters.AddWithValue("@BasicKmCharge", txtBasicKmCharge.Text);
                cmd.Parameters.AddWithValue("@WaitingCharge", txtWaitingCharge.Text);
                cmd.Parameters.AddWithValue("@DriverCharge", txtDriverCharge.Text);
                cmd.Parameters.AddWithValue("@DriverOvernightRate", txtDriverOvernightRate.Text);
                cmd.Parameters.AddWithValue("@WaitOvernightRate", txtWaitOvernightRate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package Updated", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            UpdatePackage();
        }
        private void DeletePackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Package_Table Where PackageID=@PackageID", cnn);
                cmd.Parameters.AddWithValue("@PackageID", txtPackageID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package Deleted", "Database Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            DeletePackage();

        }
        private void ViewPackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Package_Table Where PackageID=@PackageID", cnn);
                cmd.Parameters.AddWithValue("@PackageID", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtPackageID.Text = dr[0].ToString();
                    txtPackage.Text = dr[1].ToString();
                    txtMaxKmLimit.Text = dr[2].ToString();
                    txtMaxHours.Text = dr[3].ToString();
                    txtExtraKmCharge.Text = dr[4].ToString();
                    txtBasicKmCharge.Text = dr[5].ToString();
                    txtWaitingCharge.Text = dr[6].ToString();
                    txtDriverCharge.Text = dr[7].ToString();
                    txtDriverOvernightRate.Text = dr[8].ToString();
                    txtWaitOvernightRate.Text = dr[9].ToString();
                }
                else
                {
                    MessageBox.Show("Package will Not Found", "Database load", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnPView_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Package_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPackage.DataSource = dt;
            cnn.Close();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            ViewPackage();
        }

        
    }
}
