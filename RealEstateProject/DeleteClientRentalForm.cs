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
    public partial class DeleteClientRentalForm : Form
    {
        public DeleteClientRentalForm()
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
        private void dgvClientRental_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedClientNo = Convert.ToInt32(dgvClientRental.Rows[e.RowIndex].Cells["ClientNo"].Value);
                int selectedPropertyNo = Convert.ToInt32(dgvClientRental.Rows[e.RowIndex].Cells["PropertyNo"].Value);
                DateTime selectedDate = Convert.ToDateTime(dgvClientRental.Rows[e.RowIndex].Cells["RentStart"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete ClientRental for:\nClientNo: {selectedClientNo}, PropertyNo: {selectedPropertyNo}, RentStart: {selectedDate.ToShortDateString()}?",
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
                            SqlCommand cmd = new SqlCommand(
                                "DELETE FROM ClientRental WHERE ClientNo = @ClientNo AND PropertyNo = @PropertyNo AND RentStart = @RentStart", con);
                            cmd.Parameters.AddWithValue("@ClientNo", selectedClientNo);
                            cmd.Parameters.AddWithValue("@PropertyNo", selectedPropertyNo);
                            cmd.Parameters.AddWithValue("@RentStart", selectedDate);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            $"ClientRental deleted successfully for:\nClientNo: {selectedClientNo}, PropertyNo: {selectedPropertyNo}, RentStart: {selectedDate.ToShortDateString()}",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadDataGridViewClientRental(); // Refresh DataGridView after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting ClientRental: " + ex.Message);
                    }
                }
            }
        }

    }
}
