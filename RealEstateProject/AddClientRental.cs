using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RealEstateProject
{
    public partial class AddClientRental : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True; TrustServerCertificate=True");

        public AddClientRental()
        {
            InitializeComponent();
            LoadClientNo();
            LoadAvailableProperties();
            UpdateExpiredRentals(); // Check expired rentals and update status
        }

        private void LoadClientNo()
        {
            cbClientNo.Items.Clear(); 
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientNo FROM Client", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbClientNo.Items.Add(reader["ClientNo"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadAvailableProperties()
        {
            cbPropertyNo.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT PropertyNo FROM Property WHERE P_Status = 'Available'", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbPropertyNo.Items.Add(reader["PropertyNo"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading properties: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void UpdateExpiredRentals()
        {
            try
            {
                con.Open();
                // Find expired rentals and update property status
                string query = @"
                    UPDATE Property 
                    SET P_Status = 'Available'
                    WHERE PropertyNo IN (
                        SELECT PropertyNo FROM ClientRental
                        WHERE RentFinish < GETDATE()
                    )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating expired rentals: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pystatus = "";
            if (rbPaid.Checked)
            {
                pystatus = "Paid";
            }
            else if (rbPending.Checked)
            {
                pystatus = "Pending";
            }
            else if (rbOngoing.Checked)
            {
                pystatus = "Ongoing";
            }
            else
            {
                MessageBox.Show("Please Select Payment Status");
                return;
            }
            if (cbClientNo.SelectedItem == null || cbPropertyNo.SelectedItem == null)
            {
                MessageBox.Show("Please select both Client No and Property No.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ClientRental (ClientNo, PropertyNo, RentStart, RentFinish,DepositAmount,MonthlyRent,PaymentStatus,RentDescription) VALUES (@clientno, @propertyno, @startdate, @enddate,@depositamount,@monthlyrent,@paymentstatus,@description)", con);
                cmd.Parameters.AddWithValue("@clientno", int.Parse(cbClientNo.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@propertyno", int.Parse(cbPropertyNo.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@startdate", dtpRentStart.Value.Date);
                cmd.Parameters.AddWithValue("@enddate", dtpRentFinish.Value.Date);
                cmd.Parameters.AddWithValue("@depositamount", decimal.Parse(txtDepositAmount.Text));
                cmd.Parameters.AddWithValue("@monthlyrent", decimal.Parse(txtMonthlyRent.Text));
                cmd.Parameters.AddWithValue("@paymentstatus", pystatus);
                cmd.Parameters.AddWithValue("@description", txtRentalDesc.Text);
                cmd.ExecuteNonQuery();

                // Update property status to Rented
                SqlCommand updateCmd = new SqlCommand("UPDATE Property SET P_Status = 'Rented' WHERE PropertyNo = @propertyno", con);
                updateCmd.Parameters.AddWithValue("@propertyno", int.Parse(cbPropertyNo.SelectedItem.ToString()));
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Rental Saved Successfully!");
                ClearFields();

                // Reload available properties list
                LoadAvailableProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving rental: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            MessageBox.Show("Rental Saved Successfully!");
            ClearFields();

            // Use fresh connections for these
            LoadAvailableProperties();
            LoadClientNo();
            UpdateExpiredRentals();
        }   
        private void ClearFields()
        {
            cbClientNo.SelectedIndex = -1;
            cbPropertyNo.SelectedIndex = -1;
            dtpRentStart.Value = DateTime.Now;
            dtpRentFinish.Value = DateTime.Now;
            txtDepositAmount.Clear();
            txtMonthlyRent.Clear();
            txtRentalDesc.Clear();
            rbPaid.Checked = false;
            rbPending.Checked = false;
            rbOngoing.Checked = false;
        }
        public void btnClear_Click(Object sender, EventArgs e)
        {
            ClearFields();
            LoadClientNo();
            LoadAvailableProperties();
            UpdateExpiredRentals();

        }
    }
}
