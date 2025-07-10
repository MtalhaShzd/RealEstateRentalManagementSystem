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
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
            LoadDataGridViewClient();
            txtSearchClient.TextChanged += TxtSearchClient_TextChanged;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True");

        private void TxtSearchClient_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchClient.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE ClientNo LIKE @keyword OR C_NationalID LIKE @keyword OR ClientName LIKE @keyword", conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClient.DataSource = dt;
        }
        private void LoadDataGridViewClient()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClient.DataSource = dt;
        }
        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedClientNo = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells["ClientNo"].Value);

                EditClientForm editForm = new EditClientForm(selectedClientNo);
                editForm.ShowDialog();

                LoadDataGridViewClient(); // Refresh grid after update
            }
        }
    }
}
