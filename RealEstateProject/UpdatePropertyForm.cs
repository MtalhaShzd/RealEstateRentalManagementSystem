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
    public partial class UpdatePropertyForm : Form
    {
        public UpdatePropertyForm()
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
        private void dgvProperty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgvProperty.Rows[e.RowIndex].Cells["PropertyNo"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    try
                    {
                        int selectedPropertyNo = Convert.ToInt32(cellValue);

                        EditPropertyForm editForm = new EditPropertyForm(selectedPropertyNo);
                        editForm.ShowDialog();

                        LoadDataGridView(); // Refresh grid after possible edit
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening Edit form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("PropertyNo is missing or invalid for this row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
