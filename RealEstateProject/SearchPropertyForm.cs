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
    public partial class SearchPropertyForm : Form
    {
        public SearchPropertyForm()
        {
            InitializeComponent();
            LoadDataGridView();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True");

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Property WHERE PropertyNo LIKE @keyword OR P_City LIKE @keyword", con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProperty.DataSource = dt;
        }
        private void LoadDataGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Property", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProperty.DataSource = dt;
        }
    }
}
