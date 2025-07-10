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
    public partial class AddOwnerForm : Form
    {
        string connectionString = "Data Source = DESKTOP-V7ECTRG\\MSSQLSERVER01;Initial Catalog = RealEstateDB; Integrated Security = true; TrustServerCertificate = true";
        public AddOwnerForm()
        {
            InitializeComponent();
        }
        public void btnSave_Click(Object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtOwnerNo.Text) ||
               string.IsNullOrEmpty(txtOwnerName.Text) ||
               string.IsNullOrEmpty(txtOwnerCNIC.Text) ||
               string.IsNullOrEmpty(txtOwnerPhnum.Text)
               )
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOwnerCNIC.Text, @"^\d{5}-\d{7}-\d{1}$"))
            {
                MessageBox.Show("Invalid CNIC format. Example: 12345-1234567-1", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOwnerPhnum.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Invalid Phone Number format. Example: 03334331233", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpOwnerDOB.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO PropertyOwner (OwnerNo, OwnerName, O_Gender, O_Email, O_Phone, O_Address, O_Province, O_City, O_DOB, O_NationalID, O_BankAccountNo) " +
                                   "VALUES (@OwnerNo, @OwnerName, @Gender, @Email, @Phone, @Address, @Province, @City, @DOB, @CNIC, @BankAccount)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OwnerNo", int.Parse(txtOwnerNo.Text));
                        cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Email", txtOwnerEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtOwnerPhnum.Text);
                        cmd.Parameters.AddWithValue("@Address", txtOwnerAddress.Text);
                        cmd.Parameters.AddWithValue("@Province", province);
                        cmd.Parameters.AddWithValue("@City", txtOwnerCity.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpOwnerDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@CNIC", txtOwnerCNIC.Text);
                        cmd.Parameters.AddWithValue("@BankAccount", txtOwnerBankAccount.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Owner added successfully.");
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
        public void btnClear_Click(Object sender, EventArgs e)
        {
            ClearFields();

        }


    }

}
