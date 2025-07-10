using System.Drawing;
using System.Windows.Forms;
namespace RealEstateProject
{
    partial class EditOwnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOwnerName = new TextBox();
            txtOwnerNo = new TextBox();
            txtOwnerEmail = new TextBox();
            txtOwnerCNIC = new TextBox();
            txtOwnerAddress = new TextBox();
            txtOwnerCity = new TextBox();
            dtpOwnerDOB = new DateTimePicker();
            txtOwnerPhnum = new TextBox();
            lblOwnerNo = new Label();
            lblOwnerName = new Label();
            lblOwnerGender = new Label();
            lblOwnerCNIC = new Label();
            lblOwnerEmail = new Label();
            lblOwnerDOB = new Label();
            lblOwnerAddress = new Label();
            lblOwnerProvince = new Label();
            lblOwnerCity = new Label();
            lblOwnerPhnum = new Label();
            btnClear = new Button();
            btnAddOwner = new Button();
            gbProvince = new GroupBox();
            rbGilgitBaltistan = new RadioButton();
            rbAJK = new RadioButton();
            rbBalochistan = new RadioButton();
            rbKPK = new RadioButton();
            rbSindh = new RadioButton();
            rbPunjab = new RadioButton();
            gbGender = new GroupBox();
            rbOther = new RadioButton();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            txtOwnerBankAccount = new TextBox();
            lblOwnerBankAccount = new Label();
            gbProvince.SuspendLayout();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(382, 54);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(406, 23);
            txtOwnerName.TabIndex = 0;
            // 
            // txtOwnerNo
            // 
            txtOwnerNo.Location = new Point(125, 54);
            txtOwnerNo.Name = "txtOwnerNo";
            txtOwnerNo.ReadOnly = true;
            txtOwnerNo.Size = new Size(100, 23);
            txtOwnerNo.TabIndex = 1;
            // 
            // txtOwnerEmail
            // 
            txtOwnerEmail.Location = new Point(125, 166);
            txtOwnerEmail.Name = "txtOwnerEmail";
            txtOwnerEmail.Size = new Size(364, 23);
            txtOwnerEmail.TabIndex = 5;
            // 
            // txtOwnerCNIC
            // 
            txtOwnerCNIC.Location = new Point(562, 112);
            txtOwnerCNIC.Name = "txtOwnerCNIC";
            txtOwnerCNIC.Size = new Size(236, 23);
            txtOwnerCNIC.TabIndex = 6;
            // 
            // txtOwnerAddress
            // 
            txtOwnerAddress.Location = new Point(125, 222);
            txtOwnerAddress.Name = "txtOwnerAddress";
            txtOwnerAddress.Size = new Size(663, 23);
            txtOwnerAddress.TabIndex = 7;
            // 
            // txtOwnerCity
            // 
            txtOwnerCity.Location = new Point(125, 345);
            txtOwnerCity.Name = "txtOwnerCity";
            txtOwnerCity.Size = new Size(262, 23);
            txtOwnerCity.TabIndex = 14;
            // 
            // dtpOwnerDOB
            // 
            dtpOwnerDOB.Location = new Point(552, 166);
            dtpOwnerDOB.Name = "dtpOwnerDOB";
            dtpOwnerDOB.Size = new Size(200, 23);
            dtpOwnerDOB.TabIndex = 15;
            // 
            // txtOwnerPhnum
            // 
            txtOwnerPhnum.Location = new Point(508, 345);
            txtOwnerPhnum.Name = "txtOwnerPhnum";
            txtOwnerPhnum.Size = new Size(280, 23);
            txtOwnerPhnum.TabIndex = 16;
            // 
            // lblOwnerNo
            // 
            lblOwnerNo.AutoSize = true;
            lblOwnerNo.Location = new Point(65, 57);
            lblOwnerNo.Name = "lblOwnerNo";
            lblOwnerNo.Size = new Size(58, 15);
            lblOwnerNo.TabIndex = 17;
            lblOwnerNo.Text = "OwnerNo";
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(240, 57);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(140, 15);
            lblOwnerName.TabIndex = 18;
            lblOwnerName.Text = "Owner Name (Complete)";
            // 
            // lblOwnerGender
            // 
            lblOwnerGender.AutoSize = true;
            lblOwnerGender.Location = new Point(68, 117);
            lblOwnerGender.Name = "lblOwnerGender";
            lblOwnerGender.Size = new Size(45, 15);
            lblOwnerGender.TabIndex = 19;
            lblOwnerGender.Text = "Gender";
            // 
            // lblOwnerCNIC
            // 
            lblOwnerCNIC.AutoSize = true;
            lblOwnerCNIC.Location = new Point(451, 115);
            lblOwnerCNIC.Name = "lblOwnerCNIC";
            lblOwnerCNIC.Size = new Size(105, 15);
            lblOwnerCNIC.TabIndex = 20;
            lblOwnerCNIC.Text = "CNIC(with dashes)";
            // 
            // lblOwnerEmail
            // 
            lblOwnerEmail.AutoSize = true;
            lblOwnerEmail.Location = new Point(68, 166);
            lblOwnerEmail.Name = "lblOwnerEmail";
            lblOwnerEmail.Size = new Size(36, 15);
            lblOwnerEmail.TabIndex = 21;
            lblOwnerEmail.Text = "Email";
            // 
            // lblOwnerDOB
            // 
            lblOwnerDOB.AutoSize = true;
            lblOwnerDOB.Location = new Point(508, 172);
            lblOwnerDOB.Name = "lblOwnerDOB";
            lblOwnerDOB.Size = new Size(37, 15);
            lblOwnerDOB.TabIndex = 22;
            lblOwnerDOB.Text = "D.O.B";
            // 
            // lblOwnerAddress
            // 
            lblOwnerAddress.AutoSize = true;
            lblOwnerAddress.Location = new Point(68, 225);
            lblOwnerAddress.Name = "lblOwnerAddress";
            lblOwnerAddress.Size = new Size(49, 15);
            lblOwnerAddress.TabIndex = 23;
            lblOwnerAddress.Text = "Address";
            // 
            // lblOwnerProvince
            // 
            lblOwnerProvince.AutoSize = true;
            lblOwnerProvince.Location = new Point(66, 298);
            lblOwnerProvince.Name = "lblOwnerProvince";
            lblOwnerProvince.Size = new Size(53, 15);
            lblOwnerProvince.TabIndex = 24;
            lblOwnerProvince.Text = "Province";
            // 
            // lblOwnerCity
            // 
            lblOwnerCity.AutoSize = true;
            lblOwnerCity.Location = new Point(68, 348);
            lblOwnerCity.Name = "lblOwnerCity";
            lblOwnerCity.Size = new Size(28, 15);
            lblOwnerCity.TabIndex = 25;
            lblOwnerCity.Text = "City";
            // 
            // lblOwnerPhnum
            // 
            lblOwnerPhnum.AutoSize = true;
            lblOwnerPhnum.Location = new Point(414, 348);
            lblOwnerPhnum.Name = "lblOwnerPhnum";
            lblOwnerPhnum.Size = new Size(88, 15);
            lblOwnerPhnum.TabIndex = 26;
            lblOwnerPhnum.Text = "Phone Number";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(576, 401);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.Lime;
            btnAddOwner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOwner.Location = new Point(652, 395);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(136, 36);
            btnAddOwner.TabIndex = 28;
            btnAddOwner.Text = "Update Owner";
            btnAddOwner.UseVisualStyleBackColor = false;
            btnAddOwner.Click += btnUpdateOwner_Click;
            // 
            // gbProvince
            // 
            gbProvince.Controls.Add(rbGilgitBaltistan);
            gbProvince.Controls.Add(rbAJK);
            gbProvince.Controls.Add(rbBalochistan);
            gbProvince.Controls.Add(rbKPK);
            gbProvince.Controls.Add(rbSindh);
            gbProvince.Controls.Add(rbPunjab);
            gbProvince.Location = new Point(125, 266);
            gbProvince.Name = "gbProvince";
            gbProvince.Size = new Size(649, 47);
            gbProvince.TabIndex = 0;
            gbProvince.TabStop = false;
            gbProvince.Text = "Province Group";
            // 
            // rbGilgitBaltistan
            // 
            rbGilgitBaltistan.AutoSize = true;
            rbGilgitBaltistan.Location = new Point(542, 18);
            rbGilgitBaltistan.Name = "rbGilgitBaltistan";
            rbGilgitBaltistan.Size = new Size(101, 19);
            rbGilgitBaltistan.TabIndex = 19;
            rbGilgitBaltistan.TabStop = true;
            rbGilgitBaltistan.Text = "Gilgit Baltistan";
            rbGilgitBaltistan.UseVisualStyleBackColor = true;
            // 
            // rbAJK
            // 
            rbAJK.AutoSize = true;
            rbAJK.Location = new Point(481, 18);
            rbAJK.Name = "rbAJK";
            rbAJK.Size = new Size(45, 19);
            rbAJK.TabIndex = 18;
            rbAJK.TabStop = true;
            rbAJK.Text = "AJK";
            rbAJK.UseVisualStyleBackColor = true;
            // 
            // rbBalochistan
            // 
            rbBalochistan.AutoSize = true;
            rbBalochistan.Location = new Point(389, 18);
            rbBalochistan.Name = "rbBalochistan";
            rbBalochistan.Size = new Size(86, 19);
            rbBalochistan.TabIndex = 17;
            rbBalochistan.TabStop = true;
            rbBalochistan.Text = "Balochistan";
            rbBalochistan.UseVisualStyleBackColor = true;
            // 
            // rbKPK
            // 
            rbKPK.AutoSize = true;
            rbKPK.Location = new Point(250, 18);
            rbKPK.Name = "rbKPK";
            rbKPK.Size = new Size(46, 19);
            rbKPK.TabIndex = 16;
            rbKPK.TabStop = true;
            rbKPK.Text = "KPK";
            rbKPK.UseVisualStyleBackColor = true;
            // 
            // rbSindh
            // 
            rbSindh.AutoSize = true;
            rbSindh.Location = new Point(154, 18);
            rbSindh.Name = "rbSindh";
            rbSindh.Size = new Size(55, 19);
            rbSindh.TabIndex = 15;
            rbSindh.TabStop = true;
            rbSindh.Text = "Sindh";
            rbSindh.UseVisualStyleBackColor = true;
            // 
            // rbPunjab
            // 
            rbPunjab.AutoSize = true;
            rbPunjab.Location = new Point(55, 16);
            rbPunjab.Name = "rbPunjab";
            rbPunjab.Size = new Size(62, 19);
            rbPunjab.TabIndex = 14;
            rbPunjab.TabStop = true;
            rbPunjab.Text = "Punjab";
            rbPunjab.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rbOther);
            gbGender.Controls.Add(rbMale);
            gbGender.Controls.Add(rbFemale);
            gbGender.Location = new Point(125, 100);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(320, 44);
            gbGender.TabIndex = 29;
            gbGender.TabStop = false;
            gbGender.Text = "Gender Group";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(154, 22);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(55, 19);
            rbOther.TabIndex = 6;
            rbOther.TabStop = true;
            rbOther.Text = "Other";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(11, 22);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 5;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(85, 22);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 4;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            // 
            // txtOwnerBankAccount
            // 
            txtOwnerBankAccount.Location = new Point(125, 401);
            txtOwnerBankAccount.Name = "txtOwnerBankAccount";
            txtOwnerBankAccount.Size = new Size(431, 23);
            txtOwnerBankAccount.TabIndex = 30;
            // 
            // lblOwnerBankAccount
            // 
            lblOwnerBankAccount.AutoSize = true;
            lblOwnerBankAccount.Location = new Point(4, 404);
            lblOwnerBankAccount.Name = "lblOwnerBankAccount";
            lblOwnerBankAccount.Size = new Size(119, 15);
            lblOwnerBankAccount.TabIndex = 31;
            lblOwnerBankAccount.Text = "Owner Bank Account";
            // 
            // EditOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(875, 439);
            Controls.Add(lblOwnerBankAccount);
            Controls.Add(txtOwnerBankAccount);
            Controls.Add(gbProvince);
            Controls.Add(gbGender);
            Controls.Add(btnAddOwner);
            Controls.Add(btnClear);
            Controls.Add(lblOwnerPhnum);
            Controls.Add(lblOwnerCity);
            Controls.Add(lblOwnerProvince);
            Controls.Add(lblOwnerAddress);
            Controls.Add(lblOwnerDOB);
            Controls.Add(lblOwnerEmail);
            Controls.Add(lblOwnerCNIC);
            Controls.Add(lblOwnerGender);
            Controls.Add(lblOwnerName);
            Controls.Add(lblOwnerNo);
            Controls.Add(txtOwnerPhnum);
            Controls.Add(dtpOwnerDOB);
            Controls.Add(txtOwnerCity);
            Controls.Add(txtOwnerAddress);
            Controls.Add(txtOwnerCNIC);
            Controls.Add(txtOwnerEmail);
            Controls.Add(txtOwnerNo);
            Controls.Add(txtOwnerName);
            Name = "EditOwnerForm";
            Text = "Add New Owner";
            gbProvince.ResumeLayout(false);
            gbProvince.PerformLayout();
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOwnerName;
        private TextBox txtOwnerNo;
        private TextBox txtOwnerEmail;
        private TextBox txtOwnerCNIC;
        private TextBox txtOwnerAddress;
        private TextBox txtOwnerCity;
        private DateTimePicker dtpOwnerDOB;
        private TextBox txtOwnerPhnum;
        private Label lblOwnerNo;
        private Label lblOwnerName;
        private Label lblOwnerGender;
        private Label lblOwnerCNIC;
        private Label lblOwnerEmail;
        private Label lblOwnerDOB;
        private Label lblOwnerAddress;
        private Label lblOwnerProvince;
        private Label lblOwnerCity;
        private Label lblOwnerPhnum;
        private Button btnClear;
        private Button btnAddOwner;
        private GroupBox gbProvince;
        private RadioButton rbGilgitBaltistan;
        private RadioButton rbAJK;
        private RadioButton rbBalochistan;
        private RadioButton rbKPK;
        private RadioButton rbSindh;
        private RadioButton rbPunjab;
        private GroupBox gbGender;
        private RadioButton rbOther;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtOwnerBankAccount;
        private Label lblOwnerBankAccount;
    }
}