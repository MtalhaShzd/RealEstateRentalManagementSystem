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
    public partial class AddClientForm : Form
    {
        string connectionString = "Data Source = DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog = RealEstateDB; Integrated Security = true; TrustServerCertificate = true";
        public AddClientForm()
        {
            InitializeComponent();
        }
        public void btnSave_Click(Object sender , EventArgs e)
        {
            //Get Gender
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbOther.Checked)
            {
                gender = "Other";
            }
            else
            {
                MessageBox.Show("Please Select Gender");
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
            if(string.IsNullOrEmpty(txtClientNo.Text)||
               string.IsNullOrEmpty(txtClientName.Text)||
               string.IsNullOrEmpty(txtClientCNIC.Text)||
               string.IsNullOrEmpty(txtClientPhnum.Text)
               )
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtClientCNIC.Text, @"^\d{5}-\d{7}-\d{1}$"))
            {
                MessageBox.Show("Invalid CNIC format. Example: 12345-1234567-1", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtClientPhnum.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Invalid Phone Number format. Example: 03334331233", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpClientDOB.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Client (ClientNo, ClientName, C_Gender, C_Email, C_Phone, C_Address, C_Province, C_City, C_DOB, C_NationalID) " +
                                   "VALUES (@ClientNo, @ClientName, @Gender, @Email, @Phone, @Address, @Province, @City, @DOB, @CNIC)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ClientNo", int.Parse(txtClientNo.Text));
                        cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Email", txtClientEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtClientPhnum.Text);
                        cmd.Parameters.AddWithValue("@Address", txtClientAddress.Text);
                        cmd.Parameters.AddWithValue("@Province", province);
                        cmd.Parameters.AddWithValue("@City", txtClientCity.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpClientDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@CNIC", txtClientCNIC.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Client added successfully.");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        public void btnClear_Click(Object sender, EventArgs e)
        {
             ClearFields();

        }


    }

}
