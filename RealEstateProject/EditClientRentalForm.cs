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
    public partial class EditClientRentalForm : Form
    {
        private int ClientId;
        private int PropertyId;
        private DateTime date;




        public EditClientRentalForm(int Cid,int Pid,DateTime dt)
        {
            InitializeComponent();
            this.ClientId = Cid;
            this.PropertyId = Pid;
            this.date = dt;
            LoadRentalData();
        }
        private void LoadRentalData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ClientRental WHERE ClientNo = @ClientId AND PropertyNo = @PropertyId AND RentStart = @date", conn);
                cmd.Parameters.AddWithValue("@ClientId", ClientId);
                cmd.Parameters.AddWithValue("@PropertyId", PropertyId);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cbClientNo.Text = reader["ClientNo"].ToString();
                    cbPropertyNo.Text = reader["PropertyNo"].ToString();
                    dtpRentStart.Value = Convert.ToDateTime(reader["RentStart"]);
                    dtpRentFinish.Value = Convert.ToDateTime(reader["RentFinish"]);
                    txtDepositAmount.Text = reader["DepositAmount"].ToString();
                    txtMonthlyRent.Text = reader["MonthlyRent"].ToString();
                    txtRentalDesc.Text = reader["RentDescription"].ToString();

                    string status = reader["PaymentStatus"].ToString();
                    if (status == "Paid") rbPaid.Checked = true;
                    else if (status == "Pending") rbPending.Checked = true;
                    else rbOngoing.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE ClientRental SET 
                    ClientNo = @ClientID,
                    PropertyNo = @PropertyID,
                    RentStart = @date,
                    RentFinish = @EndDate,
                    DepositAmount = @Deposit,
                    MonthlyRent = @MonthlyRent,
                    PaymentStatus = @PaymentStatus,
                    RentDescription = @Desc
                    WHERE ClientNo = @ClientId AND PropertyNo = @PropertyId  And RentStart = @date ", conn);

                cmd.Parameters.AddWithValue("@ClientID", cbClientNo.Text);
                cmd.Parameters.AddWithValue("@PropertyID", cbPropertyNo.Text);
                cmd.Parameters.AddWithValue("@date", dtpRentStart.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpRentFinish.Value);
                cmd.Parameters.AddWithValue("@Deposit", txtDepositAmount.Text);
                cmd.Parameters.AddWithValue("@MonthlyRent", txtMonthlyRent.Text);
                cmd.Parameters.AddWithValue("@PaymentStatus", GetPaymentStatus());
                cmd.Parameters.AddWithValue("@Desc", txtRentalDesc.Text);
              

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rental record updated successfully!");
                ClearFields();

            }
        }

        private string GetPaymentStatus()
        {
            if (rbPaid.Checked) return "Paid";
            if (rbPending.Checked) return "Pending";
            return "Ongoing";
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
            LoadRentalData();

        }
    }
}