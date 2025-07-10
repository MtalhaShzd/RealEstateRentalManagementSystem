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
    public partial class SearchClientRentalForm : Form
    {
        public SearchClientRentalForm()
        {
            InitializeComponent();
            LoadDataGridViewClientRental();
            txtSearchClientRental.TextChanged += TxtSearchClientRental_TextChanged;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True");

        private void TxtSearchClientRental_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchClientRental.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ClientRental WHERE ClientNo LIKE @keyword OR PropertyNo LIKE @keyword OR RentStart LIKE @keyword", con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClientRental.DataSource = dt;
        }
        private void LoadDataGridViewClientRental()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ClientRental", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClientRental.DataSource = dt;
        }
    }
}
