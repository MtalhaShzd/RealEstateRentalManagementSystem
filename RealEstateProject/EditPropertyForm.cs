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
    public partial class EditPropertyForm : Form
    {
        string connectionString = "Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True; TrustServerCertificate=True";
        public int PropertyNo { get; set; }

        public EditPropertyForm(int  id)
        {
            this.PropertyNo = id;
            InitializeComponent();
            LoadOwnerCombo();
            LoadPropertyDetails();
        }

        private void EditPropertyForm_Load(object sender, EventArgs e)
        {
            LoadOwnerCombo();
            LoadPropertyDetails();
        }

        private void LoadOwnerCombo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT OwnerNo FROM PropertyOwner", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cbPropertyOwner.DataSource = dt;
                cbPropertyOwner.ValueMember = "OwnerNo";
            }
        }

        private void LoadPropertyDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Property WHERE PropertyNo = @PropertyNo", conn);
                cmd.Parameters.AddWithValue("@PropertyNo", PropertyNo);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtPropertyNo.Text = reader["PropertyNo"].ToString();
                    txtPropertyAddress.Text = reader["P_Address"].ToString();
                    txtPropertyCity.Text = reader["P_City"].ToString();
                    txtPropertyRent.Text = reader["P_Rent"].ToString();
                    txtPropertySize.Text = reader["P_Size"].ToString();
                    txtPropertyDesc.Text = reader["P_Description"].ToString();

                    // Province
                    string province = reader["P_Province"].ToString();
                    if (province == "Punjab") rbPunjab.Checked = true;
                    else if (province == "Sindh") rbSindh.Checked = true;
                    else if (province == "KPK") rbKPK.Checked = true;
                    else if (province == "Balochistan") rbBalochistan.Checked = true;
                    else if (province == "Azad Jammu & Kashmir") rbAJK.Checked = true;
                    else if (province == "Gilgit Baltistan") rbGilgitBaltistan.Checked = true;



                    // Status
                    string status = reader["P_Status"].ToString();
                    if (status == "Available") rbAvailable.Checked = true;
                    else if (status == "Rented") rbRented.Checked = true;

                    // Type
                    string type = reader["P_Type"].ToString();
                    if (type == "House") rbHouse.Checked = true;
                    else if (type == "Shop") rbShop.Checked = true;
                    else if (type == "Apartment") rbApartment.Checked = true;

                    cbPropertyOwner.SelectedValue = Convert.ToInt32(reader["OwnerNo"]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string province = rbPunjab.Checked ? "Punjab" :
                              rbSindh.Checked ? "Sindh" :
                              rbKPK.Checked ? "KPK" :
                              rbBalochistan.Checked ? "Balochistan" :
                              rbAJK.Checked ? "AJK" : "Gilgit Baltistan";

            string status = rbAvailable.Checked ? "Available" :
                            rbRented.Checked ? "Rented" : "";

            string type = rbHouse.Checked ? "House" :
                          rbShop.Checked ? "Shop" :
                          rbApartment.Checked ? "Apartment" : "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                UPDATE Property SET
                    P_Address = @Address,
                    P_City = @City,
                    P_Province = @Province,
                    P_Rent = @Rent,
                    P_Type = @Type,
                    P_Size = @Size,
                    P_Status = @Status,
                    P_Description = @Description,
                    OwnerNo = @OwnerNo
                WHERE PropertyNo = @PropertyNo", conn);

                cmd.Parameters.AddWithValue("@Address", txtPropertyAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtPropertyCity.Text);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Rent", Convert.ToDecimal(txtPropertyRent.Text));
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Size", Convert.ToInt32(txtPropertySize.Text));
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Description", txtPropertyDesc.Text);
                cmd.Parameters.AddWithValue("@OwnerNo", cbPropertyOwner.SelectedValue);
                cmd.Parameters.AddWithValue("@PropertyNo", PropertyNo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Property updated successfully!");
                ClearFields();
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
            LoadOwnerCombo();
            LoadPropertyDetails();

        }
    }
}