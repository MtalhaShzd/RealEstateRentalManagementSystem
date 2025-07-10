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
    public partial class DeletePropertyForm : Form
    {
        public DeletePropertyForm()
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
        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedPropertyNo = Convert.ToInt32(dgvProperty.Rows[e.RowIndex].Cells["PropertyNo"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Property No: {selectedPropertyNo}?",
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
                            SqlCommand cmd = new SqlCommand("DELETE FROM Property WHERE PropertyNo = @PropertyNo", con);
                            cmd.Parameters.AddWithValue("@PropertyNo", selectedPropertyNo);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            $"Property No: {selectedPropertyNo} deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadDataGridView(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting property: " + ex.Message);
                    }
                }
            }
        }

    }
}
