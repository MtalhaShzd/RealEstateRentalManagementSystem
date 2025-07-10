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
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
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
        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedClientNo = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells["ClientNo"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Client No: {selectedClientNo}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True"))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE ClientNo = @ClientNo", con);
                            cmd.Parameters.AddWithValue("@ClientNo", selectedClientNo);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            $"Client No: {selectedClientNo} deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadDataGridViewClient(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting Client: " + ex.Message);
                    }
                }
            }
        }
    }
}
