using System.Drawing;
using System.Windows.Forms;
namespace RealEstateProject
{
    partial class EditClientForm
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
            txtClientName = new TextBox();
            txtClientNo = new TextBox();
            txtClientEmail = new TextBox();
            txtClientCNIC = new TextBox();
            txtClientAddress = new TextBox();
            txtClientCity = new TextBox();
            dtpClientDOB = new DateTimePicker();
            txtClientPhnum = new TextBox();
            lblClientNo = new Label();
            lblClientName = new Label();
            lblClientGender = new Label();
            lblClientCNIC = new Label();
            lblClientEmail = new Label();
            lblClientDOB = new Label();
            lblClientAddress = new Label();
            lblClientProvince = new Label();
            lblClientCity = new Label();
            lblClientPhnum = new Label();
            btnClear = new Button();
            btnAddClient = new Button();
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
            gbProvince.SuspendLayout();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(382, 54);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(406, 23);
            txtClientName.TabIndex = 0;
            // 
            // txtClientNo
            // 
            txtClientNo.Location = new Point(125, 54);
            txtClientNo.Name = "txtClientNo";
            txtClientNo.ReadOnly = true;
            txtClientNo.Size = new Size(100, 23);
            txtClientNo.TabIndex = 1;
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(125, 166);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(364, 23);
            txtClientEmail.TabIndex = 5;
            // 
            // txtClientCNIC
            // 
            txtClientCNIC.Location = new Point(562, 112);
            txtClientCNIC.Name = "txtClientCNIC";
            txtClientCNIC.Size = new Size(236, 23);
            txtClientCNIC.TabIndex = 6;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(125, 222);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(663, 23);
            txtClientAddress.TabIndex = 7;
            // 
            // txtClientCity
            // 
            txtClientCity.Location = new Point(125, 345);
            txtClientCity.Name = "txtClientCity";
            txtClientCity.Size = new Size(262, 23);
            txtClientCity.TabIndex = 14;
            // 
            // dtpClientDOB
            // 
            dtpClientDOB.Location = new Point(552, 166);
            dtpClientDOB.Name = "dtpClientDOB";
            dtpClientDOB.Size = new Size(200, 23);
            dtpClientDOB.TabIndex = 15;
            // 
            // txtClientPhnum
            // 
            txtClientPhnum.Location = new Point(508, 345);
            txtClientPhnum.Name = "txtClientPhnum";
            txtClientPhnum.Size = new Size(280, 23);
            txtClientPhnum.TabIndex = 16;
            // 
            // lblClientNo
            // 
            lblClientNo.AutoSize = true;
            lblClientNo.Location = new Point(65, 57);
            lblClientNo.Name = "lblClientNo";
            lblClientNo.Size = new Size(54, 15);
            lblClientNo.TabIndex = 17;
            lblClientNo.Text = "ClientNo";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(240, 57);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(136, 15);
            lblClientName.TabIndex = 18;
            lblClientName.Text = "Client Name (Complete)";
            // 
            // lblClientGender
            // 
            lblClientGender.AutoSize = true;
            lblClientGender.Location = new Point(68, 117);
            lblClientGender.Name = "lblClientGender";
            lblClientGender.Size = new Size(45, 15);
            lblClientGender.TabIndex = 19;
            lblClientGender.Text = "Gender";
            // 
            // lblClientCNIC
            // 
            lblClientCNIC.AutoSize = true;
            lblClientCNIC.Location = new Point(451, 115);
            lblClientCNIC.Name = "lblClientCNIC";
            lblClientCNIC.Size = new Size(105, 15);
            lblClientCNIC.TabIndex = 20;
            lblClientCNIC.Text = "CNIC(with dashes)";
            // 
            // lblClientEmail
            // 
            lblClientEmail.AutoSize = true;
            lblClientEmail.Location = new Point(68, 166);
            lblClientEmail.Name = "lblClientEmail";
            lblClientEmail.Size = new Size(36, 15);
            lblClientEmail.TabIndex = 21;
            lblClientEmail.Text = "Email";
            // 
            // lblClientDOB
            // 
            lblClientDOB.AutoSize = true;
            lblClientDOB.Location = new Point(508, 172);
            lblClientDOB.Name = "lblClientDOB";
            lblClientDOB.Size = new Size(37, 15);
            lblClientDOB.TabIndex = 22;
            lblClientDOB.Text = "D.O.B";
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Location = new Point(68, 225);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(49, 15);
            lblClientAddress.TabIndex = 23;
            lblClientAddress.Text = "Address";
            // 
            // lblClientProvince
            // 
            lblClientProvince.AutoSize = true;
            lblClientProvince.Location = new Point(66, 298);
            lblClientProvince.Name = "lblClientProvince";
            lblClientProvince.Size = new Size(53, 15);
            lblClientProvince.TabIndex = 24;
            lblClientProvince.Text = "Province";
            // 
            // lblClientCity
            // 
            lblClientCity.AutoSize = true;
            lblClientCity.Location = new Point(68, 348);
            lblClientCity.Name = "lblClientCity";
            lblClientCity.Size = new Size(28, 15);
            lblClientCity.TabIndex = 25;
            lblClientCity.Text = "City";
            // 
            // lblClientPhnum
            // 
            lblClientPhnum.AutoSize = true;
            lblClientPhnum.Location = new Point(414, 348);
            lblClientPhnum.Name = "lblClientPhnum";
            lblClientPhnum.Size = new Size(88, 15);
            lblClientPhnum.TabIndex = 26;
            lblClientPhnum.Text = "Phone Number";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(112, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.Lime;
            btnAddClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClient.Location = new Point(652, 395);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(136, 36);
            btnAddClient.TabIndex = 28;
            btnAddClient.Text = "UPDATE CLIENT";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnUpdateClient_Click;
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
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(gbProvince);
            Controls.Add(gbGender);
            Controls.Add(btnAddClient);
            Controls.Add(btnClear);
            Controls.Add(lblClientPhnum);
            Controls.Add(lblClientCity);
            Controls.Add(lblClientProvince);
            Controls.Add(lblClientAddress);
            Controls.Add(lblClientDOB);
            Controls.Add(lblClientEmail);
            Controls.Add(lblClientCNIC);
            Controls.Add(lblClientGender);
            Controls.Add(lblClientName);
            Controls.Add(lblClientNo);
            Controls.Add(txtClientPhnum);
            Controls.Add(dtpClientDOB);
            Controls.Add(txtClientCity);
            Controls.Add(txtClientAddress);
            Controls.Add(txtClientCNIC);
            Controls.Add(txtClientEmail);
            Controls.Add(txtClientNo);
            Controls.Add(txtClientName);
            Name = "EditClientForm";
            Text = "Update Client";
            gbProvince.ResumeLayout(false);
            gbProvince.PerformLayout();
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClientName;
        private TextBox txtClientNo;
        private TextBox txtClientEmail;
        private TextBox txtClientCNIC;
        private TextBox txtClientAddress;
        private TextBox txtClientCity;
        private DateTimePicker dtpClientDOB;
        private TextBox txtClientPhnum;
        private Label lblClientNo;
        private Label lblClientName;
        private Label lblClientGender;
        private Label lblClientCNIC;
        private Label lblClientEmail;
        private Label lblClientDOB;
        private Label lblClientAddress;
        private Label lblClientProvince;
        private Label lblClientCity;
        private Label lblClientPhnum;
        private Button btnClear;
        private Button btnAddClient;
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
    }
}