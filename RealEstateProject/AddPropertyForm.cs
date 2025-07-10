using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RealEstateProject
{
    public partial class AddPropertyForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-V7ECTRG\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True";

        public AddPropertyForm()
        {
            InitializeComponent();
            LoadOwnerNumbers();
        }
        private void LoadOwnerNumbers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT OwnerNo FROM PropertyOwner";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbPropertyOwner.Items.Clear();

                    while (reader.Read())
                    {
                        cbPropertyOwner.Items.Add(reader["OwnerNo"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Owner Numbers: " + ex.Message);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get Gender
            string type = "";
            if (rbApartment.Checked)
            {
                type = "Apartment";
            }
            else if (rbShop.Checked)
            {
                type = "Shop";
            }
            else if (rbHouse.Checked)
            {
                type = "House";
            }
            else
            {
                MessageBox.Show("Please Select Property Type");
                return;
            }

            // Get Province
            string province = "";
            if (rbPunjab.Checked)
                province = "Punjab";
            else if (rbSindh.Checked)
                province = "Sindh";
            else if (rbKPK.Checked)
                province = "Khyber Pakhtunkhwa";
            else if (rbBalochistan.Checked)
                province = "Balochistan";
            else if (rbAJK.Checked)
                province = "Azad Jammu & Kashmir";
            else if (rbGilgitBaltistan.Checked)
                province = "Gilgit Baltistan";
            else
            {
                MessageBox.Show("Please select province.");
                return;
            }
            string status = "";
            if (rbAvailable.Checked)
            {
                status = "Available";
            }
            else if (rbRented.Checked)
            {
                status = "Rented";
            }
            else
            {
                MessageBox.Show("Please Select Property Status");
                return;
            }
            if (cbPropertyOwner.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtPropertyNo.Text)||
                string.IsNullOrWhiteSpace(txtPropertyAddress.Text)||
                string.IsNullOrWhiteSpace(txtPropertyCity.Text)||
                string.IsNullOrWhiteSpace(txtPropertySize.Text)
                )
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Property 
                            (PropertyNo, P_Address, P_Province, P_City, P_Rent, P_Type, P_Size, P_Status, P_Description, OwnerNo)
                            VALUES 
                            (@PropertyNo, @Address, @Province, @City, @Rent, @Type, @Size, @Status, @Description, @OwnerNo)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PropertyNo", int.Parse(txtPropertyNo.Text));
                    cmd.Parameters.AddWithValue("@Address", txtPropertyAddress.Text);
                    cmd.Parameters.AddWithValue("@Province", province);
                    cmd.Parameters.AddWithValue("@City", txtPropertyCity.Text);
                    cmd.Parameters.AddWithValue("@Rent", decimal.Parse(txtPropertyRent.Text));
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Size", int.Parse(txtPropertySize.Text));
                    cmd.Parameters.AddWithValue("@Status", status); // e.g., Available, Rented
                    cmd.Parameters.AddWithValue("@Description", txtPropertyDesc.Text);
                    cmd.Parameters.AddWithValue("@OwnerNo", int.Parse(cbPropertyOwner.SelectedItem.ToString()));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Property added successfully.");
                        ClearFields();
                        LoadOwnerNumbers();  // Optional: reset form
                    }
                    else
                    {
                        MessageBox.Show("Failed to add property.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving property: " + ex.Message);
                }
            }

        }
        private void ClearFields()
        {
            txtPropertyNo.Clear();
            txtPropertyAddress.Clear();
            txtPropertyCity.Clear();
            txtPropertyRent.Clear();
            txtPropertySize.Clear();
            txtPropertyDesc.Clear();

            // Uncheck all radio buttons for Province
            rbPunjab.Checked = false;
            rbSindh.Checked = false;
            rbKPK.Checked = false;
            rbBalochistan.Checked = false;
            rbAJK.Checked = false;
            rbGilgitBaltistan.Checked = false;

            // Uncheck all radio buttons for Status
            rbAvailable.Checked = false;
            rbRented.Checked = false;

            // Uncheck all radio buttons for Type
            rbHouse.Checked = false;
            rbApartment.Checked = false;
            rbShop.Checked = false;

            // Reset only combo box (Owner No)
            cbPropertyOwner.SelectedIndex = -1;
        }
        public void btnClear_Click(Object sender, EventArgs e)
        {
            ClearFields();
            LoadOwnerNumbers();

        }

    }
}
