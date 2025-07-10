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
    public partial class DeleteOwnerForm : Form
    {
        public DeleteOwnerForm()
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
        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedOwnerNo = Convert.ToInt32(dgvOwner.Rows[e.RowIndex].Cells["OwnerNo"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Owner No: {selectedOwnerNo}?",
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
                            SqlCommand cmd = new SqlCommand("DELETE FROM PropertyOwner WHERE OwnerNo = @OwnerNo", con);
                            cmd.Parameters.AddWithValue("@OwnerNo", selectedOwnerNo);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            $"Owner No: {selectedOwnerNo} deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadDataGridViewOwner(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting Owner: " + ex.Message);
                    }
                }
            }
        }
    }
}
