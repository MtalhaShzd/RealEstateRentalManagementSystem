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
    public partial class EditOwnerForm : Form
    {
        private int OwnerId;
        private string connectionString = "Data Source=DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog=RealEstateDB;Integrated Security=True; TrustServerCertificate=True";

        public EditOwnerForm(int id)
        {
            InitializeComponent();
            OwnerId = id;
            LoadOwnerData();
        }

        private void LoadOwnerData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PropertyOwner WHERE OwnerNo = @id", conn);
                cmd.Parameters.AddWithValue("@id", OwnerId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtOwnerNo.Text = reader["OwnerNo"].ToString();
                    txtOwnerName.Text = reader["OwnerName"].ToString();
                    txtOwnerEmail.Text = reader["O_Email"].ToString();
                    txtOwnerCNIC.Text = reader["O_NationalID"].ToString();
                    txtOwnerAddress.Text = reader["O_Address"].ToString();
                    txtOwnerCity.Text = reader["O_City"].ToString();
                    txtOwnerPhnum.Text = reader["O_Phone"].ToString();
                    txtOwnerBankAccount.Text = reader["O_BankAccountNo"].ToString();
                    dtpOwnerDOB.Value = Convert.ToDateTime(reader["O_DOB"]);


                    string gender = reader["O_Gender"].ToString();
                    if (gender == "Male") rbMale.Checked = true;
                    else if (gender == "Female") rbFemale.Checked = true;
                    else rbOther.Checked = true;

                    string province = reader["O_Province"].ToString();
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

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            string name = txtOwnerName.Text;
            string email = txtOwnerEmail.Text;
            string cnic = txtOwnerCNIC.Text;
            string address = txtOwnerAddress.Text;
            string city = txtOwnerCity.Text;
            string phone = txtOwnerPhnum.Text;
            DateTime dob = dtpOwnerDOB.Value;
            string bankacc = txtOwnerBankAccount.Text;


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
                    UPDATE PropertyOwner SET 
                        OwnerName = @name,
                        O_Email = @email,
                        O_NationalID = @cnic,
                        O_Address = @address,
                        O_City = @city,
                        O_Phone = @phone,
                        O_Gender = @gender,
                        O_Province = @province,
                        O_DOB = @dob,
                        O_BankAccountNo = @bankacc
                    WHERE OwnerNo = @id", conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@province", province);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@bankacc", bankacc);
                cmd.Parameters.AddWithValue("@id", OwnerId);



                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Owner Information Updated Successfully.");
            this.Close();
            ClearFields();
        }
        private void ClearFields()
        {
            txtOwnerNo.Clear();
            txtOwnerName.Clear();
            txtOwnerEmail.Clear();
            txtOwnerPhnum.Clear();
            txtOwnerAddress.Clear();
            txtOwnerCity.Clear();
            txtOwnerCNIC.Clear();
            txtOwnerBankAccount.Clear();
            dtpOwnerDOB.Value = DateTime.Now;
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
            LoadOwnerData();

        }
    }
}