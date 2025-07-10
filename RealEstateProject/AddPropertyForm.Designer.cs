namespace RealEstateProject
{
    partial class AddPropertyForm
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
            txtPropertyAddress = new System.Windows.Forms.TextBox();
            txtPropertyNo = new System.Windows.Forms.TextBox();
            gbProvince = new System.Windows.Forms.GroupBox();
            rbBalochistan = new System.Windows.Forms.RadioButton();
            rbAJK = new System.Windows.Forms.RadioButton();
            rbPunjab = new System.Windows.Forms.RadioButton();
            rbSindh = new System.Windows.Forms.RadioButton();
            rbKPK = new System.Windows.Forms.RadioButton();
            rbGilgitBaltistan = new System.Windows.Forms.RadioButton();
            txtPropertyCity = new System.Windows.Forms.TextBox();
            txtPropertyRent = new System.Windows.Forms.TextBox();
            txtPropertySize = new System.Windows.Forms.TextBox();
            gbPropertyType = new System.Windows.Forms.GroupBox();
            rbApartment = new System.Windows.Forms.RadioButton();
            rbHouse = new System.Windows.Forms.RadioButton();
            rbShop = new System.Windows.Forms.RadioButton();
            gbPropertyStatus = new System.Windows.Forms.GroupBox();
            rbAvailable = new System.Windows.Forms.RadioButton();
            rbRented = new System.Windows.Forms.RadioButton();
            dtpPropertyDateListed = new System.Windows.Forms.DateTimePicker();
            txtPropertyDesc = new System.Windows.Forms.TextBox();
            cbPropertyOwner = new System.Windows.Forms.ComboBox();
            lblPropertyNo = new System.Windows.Forms.Label();
            lblPropertyAddress = new System.Windows.Forms.Label();
            lblPropertyProvince = new System.Windows.Forms.Label();
            lblPropertyCity = new System.Windows.Forms.Label();
            lblPropertyRent = new System.Windows.Forms.Label();
            lblPropertySize = new System.Windows.Forms.Label();
            lblPropertyType = new System.Windows.Forms.Label();
            lblPropertyStatus = new System.Windows.Forms.Label();
            lblDateListed = new System.Windows.Forms.Label();
            lblPropertyOwner = new System.Windows.Forms.Label();
            lblPropertyDescription = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            gbProvince.SuspendLayout();
            gbPropertyType.SuspendLayout();
            gbPropertyStatus.SuspendLayout();
            SuspendLayout();
            // 
            // txtPropertyAddress
            // 
            txtPropertyAddress.Location = new System.Drawing.Point(293, 12);
            txtPropertyAddress.Name = "txtPropertyAddress";
            txtPropertyAddress.Size = new System.Drawing.Size(507, 23);
            txtPropertyAddress.TabIndex = 0;
            // 
            // txtPropertyNo
            // 
            txtPropertyNo.Location = new System.Drawing.Point(85, 12);
            txtPropertyNo.Name = "txtPropertyNo";
            txtPropertyNo.Size = new System.Drawing.Size(100, 23);
            txtPropertyNo.TabIndex = 1;
            // 
            // gbProvince
            // 
            gbProvince.Controls.Add(rbBalochistan);
            gbProvince.Controls.Add(rbAJK);
            gbProvince.Controls.Add(rbPunjab);
            gbProvince.Controls.Add(rbSindh);
            gbProvince.Controls.Add(rbKPK);
            gbProvince.Location = new System.Drawing.Point(67, 63);
            gbProvince.Name = "gbProvince";
            gbProvince.Size = new System.Drawing.Size(733, 46);
            gbProvince.TabIndex = 2;
            gbProvince.TabStop = false;
            gbProvince.Text = "Province";
            // 
            // rbBalochistan
            // 
            rbBalochistan.AutoSize = true;
            rbBalochistan.Location = new System.Drawing.Point(279, 15);
            rbBalochistan.Name = "rbBalochistan";
            rbBalochistan.Size = new System.Drawing.Size(86, 19);
            rbBalochistan.TabIndex = 18;
            rbBalochistan.TabStop = true;
            rbBalochistan.Text = "Balochistan";
            rbBalochistan.UseVisualStyleBackColor = true;
            // 
            // rbAJK
            // 
            rbAJK.AutoSize = true;
            rbAJK.Location = new System.Drawing.Point(499, 15);
            rbAJK.Name = "rbAJK";
            rbAJK.Size = new System.Drawing.Size(45, 19);
            rbAJK.TabIndex = 19;
            rbAJK.TabStop = true;
            rbAJK.Text = "AJK";
            rbAJK.UseVisualStyleBackColor = true;
            // 
            // rbPunjab
            // 
            rbPunjab.AutoSize = true;
            rbPunjab.Location = new System.Drawing.Point(38, 15);
            rbPunjab.Name = "rbPunjab";
            rbPunjab.Size = new System.Drawing.Size(62, 19);
            rbPunjab.TabIndex = 15;
            rbPunjab.TabStop = true;
            rbPunjab.Text = "Punjab";
            rbPunjab.UseVisualStyleBackColor = true;
            // 
            // rbSindh
            // 
            rbSindh.AutoSize = true;
            rbSindh.Location = new System.Drawing.Point(122, 15);
            rbSindh.Name = "rbSindh";
            rbSindh.Size = new System.Drawing.Size(55, 19);
            rbSindh.TabIndex = 16;
            rbSindh.TabStop = true;
            rbSindh.Text = "Sindh";
            rbSindh.UseVisualStyleBackColor = true;
            // 
            // rbKPK
            // 
            rbKPK.AutoSize = true;
            rbKPK.Location = new System.Drawing.Point(200, 15);
            rbKPK.Name = "rbKPK";
            rbKPK.Size = new System.Drawing.Size(46, 19);
            rbKPK.TabIndex = 17;
            rbKPK.TabStop = true;
            rbKPK.Text = "KPK";
            rbKPK.UseVisualStyleBackColor = true;
            // 
            // rbGilgitBaltistan
            // 
            rbGilgitBaltistan.AutoSize = true;
            rbGilgitBaltistan.Location = new System.Drawing.Point(434, 78);
            rbGilgitBaltistan.Name = "rbGilgitBaltistan";
            rbGilgitBaltistan.Size = new System.Drawing.Size(101, 19);
            rbGilgitBaltistan.TabIndex = 20;
            rbGilgitBaltistan.TabStop = true;
            rbGilgitBaltistan.Text = "Gilgit Baltistan";
            rbGilgitBaltistan.UseVisualStyleBackColor = true;
            // 
            // txtPropertyCity
            // 
            txtPropertyCity.Location = new System.Drawing.Point(52, 131);
            txtPropertyCity.Name = "txtPropertyCity";
            txtPropertyCity.Size = new System.Drawing.Size(270, 23);
            txtPropertyCity.TabIndex = 21;
            // 
            // txtPropertyRent
            // 
            txtPropertyRent.Location = new System.Drawing.Point(402, 131);
            txtPropertyRent.Name = "txtPropertyRent";
            txtPropertyRent.Size = new System.Drawing.Size(166, 23);
            txtPropertyRent.TabIndex = 22;
            // 
            // txtPropertySize
            // 
            txtPropertySize.Location = new System.Drawing.Point(640, 131);
            txtPropertySize.Name = "txtPropertySize";
            txtPropertySize.Size = new System.Drawing.Size(160, 23);
            txtPropertySize.TabIndex = 23;
            // 
            // gbPropertyType
            // 
            gbPropertyType.Controls.Add(rbApartment);
            gbPropertyType.Controls.Add(rbHouse);
            gbPropertyType.Controls.Add(rbShop);
            gbPropertyType.Location = new System.Drawing.Point(63, 169);
            gbPropertyType.Name = "gbPropertyType";
            gbPropertyType.Size = new System.Drawing.Size(305, 37);
            gbPropertyType.TabIndex = 24;
            gbPropertyType.TabStop = false;
            gbPropertyType.Text = "Property Type";
            // 
            // rbApartment
            // 
            rbApartment.AutoSize = true;
            rbApartment.Location = new System.Drawing.Point(6, 18);
            rbApartment.Name = "rbApartment";
            rbApartment.Size = new System.Drawing.Size(82, 19);
            rbApartment.TabIndex = 29;
            rbApartment.TabStop = true;
            rbApartment.Text = "Apartment";
            rbApartment.UseVisualStyleBackColor = true;
            // 
            // rbHouse
            // 
            rbHouse.AutoSize = true;
            rbHouse.Location = new System.Drawing.Point(106, 18);
            rbHouse.Name = "rbHouse";
            rbHouse.Size = new System.Drawing.Size(59, 19);
            rbHouse.TabIndex = 30;
            rbHouse.TabStop = true;
            rbHouse.Text = "House";
            rbHouse.UseVisualStyleBackColor = true;
            // 
            // rbShop
            // 
            rbShop.AutoSize = true;
            rbShop.Location = new System.Drawing.Point(211, 18);
            rbShop.Name = "rbShop";
            rbShop.Size = new System.Drawing.Size(52, 19);
            rbShop.TabIndex = 31;
            rbShop.TabStop = true;
            rbShop.Text = "Shop";
            rbShop.UseVisualStyleBackColor = true;
            // 
            // gbPropertyStatus
            // 
            gbPropertyStatus.Controls.Add(rbAvailable);
            gbPropertyStatus.Controls.Add(rbRented);
            gbPropertyStatus.Location = new System.Drawing.Point(463, 169);
            gbPropertyStatus.Name = "gbPropertyStatus";
            gbPropertyStatus.Size = new System.Drawing.Size(311, 37);
            gbPropertyStatus.TabIndex = 25;
            gbPropertyStatus.TabStop = false;
            gbPropertyStatus.Text = "Property Status";
            // 
            // rbAvailable
            // 
            rbAvailable.AutoSize = true;
            rbAvailable.Location = new System.Drawing.Point(100, 12);
            rbAvailable.Name = "rbAvailable";
            rbAvailable.Size = new System.Drawing.Size(73, 19);
            rbAvailable.TabIndex = 32;
            rbAvailable.TabStop = true;
            rbAvailable.Text = "Available";
            rbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbRented
            // 
            rbRented.AutoSize = true;
            rbRented.Location = new System.Drawing.Point(217, 12);
            rbRented.Name = "rbRented";
            rbRented.Size = new System.Drawing.Size(62, 19);
            rbRented.TabIndex = 33;
            rbRented.TabStop = true;
            rbRented.Text = "Rented";
            rbRented.UseVisualStyleBackColor = true;
            // 
            // dtpPropertyDateListed
            // 
            dtpPropertyDateListed.Location = new System.Drawing.Point(122, 227);
            dtpPropertyDateListed.Name = "dtpPropertyDateListed";
            dtpPropertyDateListed.Size = new System.Drawing.Size(200, 23);
            dtpPropertyDateListed.TabIndex = 26;
            // 
            // txtPropertyDesc
            // 
            txtPropertyDesc.Location = new System.Drawing.Point(85, 291);
            txtPropertyDesc.Name = "txtPropertyDesc";
            txtPropertyDesc.Size = new System.Drawing.Size(703, 23);
            txtPropertyDesc.TabIndex = 28;
            // 
            // cbPropertyOwner
            // 
            cbPropertyOwner.FormattingEnabled = true;
            cbPropertyOwner.Location = new System.Drawing.Point(515, 230);
            cbPropertyOwner.Name = "cbPropertyOwner";
            cbPropertyOwner.Size = new System.Drawing.Size(213, 23);
            cbPropertyOwner.TabIndex = 29;
            // 
            // lblPropertyNo
            // 
            lblPropertyNo.AutoSize = true;
            lblPropertyNo.Location = new System.Drawing.Point(8, 15);
            lblPropertyNo.Name = "lblPropertyNo";
            lblPropertyNo.Size = new System.Drawing.Size(71, 15);
            lblPropertyNo.TabIndex = 30;
            lblPropertyNo.Text = "Property No";
            // 
            // lblPropertyAddress
            // 
            lblPropertyAddress.AutoSize = true;
            lblPropertyAddress.Location = new System.Drawing.Point(190, 15);
            lblPropertyAddress.Name = "lblPropertyAddress";
            lblPropertyAddress.Size = new System.Drawing.Size(97, 15);
            lblPropertyAddress.TabIndex = 31;
            lblPropertyAddress.Text = "Property Address";
            // 
            // lblPropertyProvince
            // 
            lblPropertyProvince.AutoSize = true;
            lblPropertyProvince.Location = new System.Drawing.Point(8, 82);
            lblPropertyProvince.Name = "lblPropertyProvince";
            lblPropertyProvince.Size = new System.Drawing.Size(53, 15);
            lblPropertyProvince.TabIndex = 32;
            lblPropertyProvince.Text = "Province";
            // 
            // lblPropertyCity
            // 
            lblPropertyCity.AutoSize = true;
            lblPropertyCity.Location = new System.Drawing.Point(8, 134);
            lblPropertyCity.Name = "lblPropertyCity";
            lblPropertyCity.Size = new System.Drawing.Size(28, 15);
            lblPropertyCity.TabIndex = 33;
            lblPropertyCity.Text = "City";
            // 
            // lblPropertyRent
            // 
            lblPropertyRent.AutoSize = true;
            lblPropertyRent.Location = new System.Drawing.Point(358, 134);
            lblPropertyRent.Name = "lblPropertyRent";
            lblPropertyRent.Size = new System.Drawing.Size(31, 15);
            lblPropertyRent.TabIndex = 34;
            lblPropertyRent.Text = "Rent";
            // 
            // lblPropertySize
            // 
            lblPropertySize.AutoSize = true;
            lblPropertySize.Location = new System.Drawing.Point(577, 134);
            lblPropertySize.Name = "lblPropertySize";
            lblPropertySize.Size = new System.Drawing.Size(59, 15);
            lblPropertySize.TabIndex = 35;
            lblPropertySize.Text = "Size(Sq ft)";
            // 
            // lblPropertyType
            // 
            lblPropertyType.AutoSize = true;
            lblPropertyType.Location = new System.Drawing.Point(16, 187);
            lblPropertyType.Name = "lblPropertyType";
            lblPropertyType.Size = new System.Drawing.Size(31, 15);
            lblPropertyType.TabIndex = 36;
            lblPropertyType.Text = "Type";
            // 
            // lblPropertyStatus
            // 
            lblPropertyStatus.AutoSize = true;
            lblPropertyStatus.Location = new System.Drawing.Point(419, 181);
            lblPropertyStatus.Name = "lblPropertyStatus";
            lblPropertyStatus.Size = new System.Drawing.Size(39, 15);
            lblPropertyStatus.TabIndex = 37;
            lblPropertyStatus.Text = "Status";
            // 
            // lblDateListed
            // 
            lblDateListed.AutoSize = true;
            lblDateListed.Location = new System.Drawing.Point(16, 233);
            lblDateListed.Name = "lblDateListed";
            lblDateListed.Size = new System.Drawing.Size(65, 15);
            lblDateListed.TabIndex = 38;
            lblDateListed.Text = "Date Listed";
            // 
            // lblPropertyOwner
            // 
            lblPropertyOwner.AutoSize = true;
            lblPropertyOwner.Location = new System.Drawing.Point(402, 233);
            lblPropertyOwner.Name = "lblPropertyOwner";
            lblPropertyOwner.Size = new System.Drawing.Size(90, 15);
            lblPropertyOwner.TabIndex = 39;
            lblPropertyOwner.Text = "Property Owner";
            // 
            // lblPropertyDescription
            // 
            lblPropertyDescription.AutoSize = true;
            lblPropertyDescription.Location = new System.Drawing.Point(12, 294);
            lblPropertyDescription.Name = "lblPropertyDescription";
            lblPropertyDescription.Size = new System.Drawing.Size(67, 15);
            lblPropertyDescription.TabIndex = 40;
            lblPropertyDescription.Text = "Description";
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(76, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 28);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Lime;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(611, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(131, 37);
            btnSave.TabIndex = 42;
            btnSave.Text = "Add Property";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(lblPropertyDescription);
            Controls.Add(lblPropertyOwner);
            Controls.Add(lblDateListed);
            Controls.Add(lblPropertyStatus);
            Controls.Add(lblPropertyType);
            Controls.Add(lblPropertySize);
            Controls.Add(lblPropertyRent);
            Controls.Add(lblPropertyCity);
            Controls.Add(lblPropertyProvince);
            Controls.Add(lblPropertyAddress);
            Controls.Add(lblPropertyNo);
            Controls.Add(cbPropertyOwner);
            Controls.Add(txtPropertyDesc);
            Controls.Add(dtpPropertyDateListed);
            Controls.Add(gbPropertyStatus);
            Controls.Add(gbPropertyType);
            Controls.Add(txtPropertySize);
            Controls.Add(txtPropertyRent);
            Controls.Add(txtPropertyCity);
            Controls.Add(rbGilgitBaltistan);
            Controls.Add(gbProvince);
            Controls.Add(txtPropertyNo);
            Controls.Add(txtPropertyAddress);
            Name = "AddPropertyForm";
            Text = "AddPropertyForm";
            gbProvince.ResumeLayout(false);
            gbProvince.PerformLayout();
            gbPropertyType.ResumeLayout(false);
            gbPropertyType.PerformLayout();
            gbPropertyStatus.ResumeLayout(false);
            gbPropertyStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPropertyAddress;
        private System.Windows.Forms.TextBox txtPropertyNo;
        private System.Windows.Forms.GroupBox gbProvince;
        private System.Windows.Forms.RadioButton rbPunjab;
        private System.Windows.Forms.RadioButton rbSindh;
        private System.Windows.Forms.RadioButton rbKPK;
        private System.Windows.Forms.RadioButton rbBalochistan;
        private System.Windows.Forms.RadioButton rbAJK;
        private System.Windows.Forms.RadioButton rbGilgitBaltistan;
        private System.Windows.Forms.TextBox txtPropertyCity;
        private System.Windows.Forms.TextBox txtPropertyRent;
        private System.Windows.Forms.TextBox txtPropertySize;
        private System.Windows.Forms.GroupBox gbPropertyType;
        private System.Windows.Forms.GroupBox gbPropertyStatus;
        private System.Windows.Forms.RadioButton rbRented;
        private System.Windows.Forms.DateTimePicker dtpPropertyDateListed;
        private System.Windows.Forms.TextBox txtPropertyDesc;
        private System.Windows.Forms.RadioButton rbApartment;
        private System.Windows.Forms.RadioButton rbHouse;
        private System.Windows.Forms.RadioButton rbShop;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.ComboBox cbPropertyOwner;
        private System.Windows.Forms.Label lblPropertyNo;
        private System.Windows.Forms.Label lblPropertyAddress;
        private System.Windows.Forms.Label lblPropertyProvince;
        private System.Windows.Forms.Label lblPropertyCity;
        private System.Windows.Forms.Label lblPropertyRent;
        private System.Windows.Forms.Label lblPropertySize;
        private System.Windows.Forms.Label lblPropertyType;
        private System.Windows.Forms.Label lblPropertyStatus;
        private System.Windows.Forms.Label lblDateListed;
        private System.Windows.Forms.Label lblPropertyOwner;
        private System.Windows.Forms.Label lblPropertyDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}