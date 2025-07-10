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
    public partial class SearchOwnerForm : Form
    {
        public SearchOwnerForm()
        {
            InitializeComponent();
            LoadDataGridViewOwner();
            txtSearchOwner.TextChanged += TxtSearchOwner_TextChanged;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True");

        private void TxtSearchOwner_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchOwner.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PropertyOwner WHERE OwnerNo LIKE @keyword OR O_NationalID LIKE @keyword OR OwnerName LIKE @keyword", conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOwner.DataSource = dt;
        }
        private void LoadDataGridViewOwner()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PropertyOwner", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOwner.DataSource = dt;
        }
    }
}
