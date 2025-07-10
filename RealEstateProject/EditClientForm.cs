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
    public partial class EditClientForm : Form
    {
        private int clientId;
        private string connectionString = "Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True; TrustServerCertificate=True";

        public EditClientForm(int id)
        {
            InitializeComponent();
            clientId = id;
            LoadClientData();
        }

        private void LoadClientData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE ClientNo = @id", conn);
                cmd.Parameters.AddWithValue("@id", clientId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtClientNo.Text = reader["ClientNo"].ToString();
                    txtClientName.Text = reader["ClientName"].ToString();
                    txtClientEmail.Text = reader["C_Email"].ToString();
                    txtClientCNIC.Text = reader["C_NationalID"].ToString();
                    txtClientAddress.Text = reader["C_Address"].ToString();
                    txtClientCity.Text = reader["C_City"].ToString();
                    txtClientPhnum.Text = reader["C_Phone"].ToString();
                    dtpClientDOB.Value = Convert.ToDateTime(reader["C_DOB"]);


                    string gender = reader["C_Gender"].ToString();
                    if (gender == "Male") rbMale.Checked = true;
                    else if (gender == "Female") rbFemale.Checked = true;
                    else rbOther.Checked = true;

                    string province = reader["C_Province"].ToString();
                    switch (province)
                    {
                        case "Punjab": rbPunjab.Checked = true; break;
                        case "Sindh": rbSindh.Checked = true; break;
                        case "KPK": rbKPK.Checked = true; break;
                        case "Balochistan": rbBalochistan.Checked = true; break;
                        case "AJK": rbAJK.Checked = true; break;
                        case "Gilgit Baltistan": rbGilgitBaltistan.Checked = true; break;
                    }
                }
                reader.Close();
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text;
            string email = txtClientEmail.Text;
            string cnic = txtClientCNIC.Text;
            string address = txtClientAddress.Text;
            string city = txtClientCity.Text;
            string phone = txtClientPhnum.Text;
            DateTime dob = dtpClientDOB.Value;


            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "Other";
            string province = rbPunjab.Checked ? "Punjab" :
                              rbSindh.Checked ? "Sindh" :
                              rbKPK.Checked ? "KPK" :
                              rbBalochistan.Checked ? "Balochistan" :
                              rbAJK.Checked ? "AJK" : "Gilgit Baltistan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Client SET 
                        ClientName = @name,
                        C_Email = @email,
                        C_NationalID = @cnic,
                        C_Address = @address,
                        C_City = @city,
                        C_Phone = @phone,
                        C_Gender = @gender,
                        C_Province = @province,
                        C_DOB = @dob
                    WHERE ClientNo = @id", conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@province", province);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@id", clientId);



                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Client Information Updated Successfully.");
            this.Close();
            ClearFields();
        }
        private void ClearFields()
        {
            txtClientNo.Clear();
            txtClientName.Clear();
            txtClientEmail.Clear();
            txtClientPhnum.Clear();
            txtClientAddress.Clear();
            txtClientCity.Clear();
            txtClientCNIC.Clear();
            dtpClientDOB.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbPunjab.Checked = false;
            rbSindh.Checked = false;
            rbKPK.Checked = false;
            rbBalochistan.Checked = false;
            rbAJK.Checked = false;
            rbGilgitBaltistan.Checked = false;
            rbOther.Checked = false;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadClientData();

        }
    }
}