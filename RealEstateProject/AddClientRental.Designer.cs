namespace RealEstateProject
{
    partial class AddClientRental
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
            cbClientNo = new System.Windows.Forms.ComboBox();
            cbPropertyNo = new System.Windows.Forms.ComboBox();
            dtpRentFinish = new System.Windows.Forms.DateTimePicker();
            dtpRentStart = new System.Windows.Forms.DateTimePicker();
            txtDepositAmount = new System.Windows.Forms.TextBox();
            txtMonthlyRent = new System.Windows.Forms.TextBox();
            gbPaymentStatus = new System.Windows.Forms.GroupBox();
            rbPaid = new System.Windows.Forms.RadioButton();
            rbPending = new System.Windows.Forms.RadioButton();
            rbOngoing = new System.Windows.Forms.RadioButton();
            txtRentalDesc = new System.Windows.Forms.TextBox();
            lblClientNo = new System.Windows.Forms.Label();
            lblPropertyNo = new System.Windows.Forms.Label();
            lblRentStart = new System.Windows.Forms.Label();
            lblRentFinish = new System.Windows.Forms.Label();
            lblDepositAmount = new System.Windows.Forms.Label();
            lblMonthlyRent = new System.Windows.Forms.Label();
            lblPaymentStatus = new System.Windows.Forms.Label();
            lblRentalDesc = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            gbPaymentStatus.SuspendLayout();
            SuspendLayout();
            // 
            // cbClientNo
            // 
            cbClientNo.FormattingEnabled = true;
            cbClientNo.Location = new System.Drawing.Point(157, 22);
            cbClientNo.Name = "cbClientNo";
            cbClientNo.Size = new System.Drawing.Size(200, 23);
            cbClientNo.TabIndex = 0;
            // 
            // cbPropertyNo
            // 
            cbPropertyNo.FormattingEnabled = true;
            cbPropertyNo.Location = new System.Drawing.Point(478, 22);
            cbPropertyNo.Name = "cbPropertyNo";
            cbPropertyNo.Size = new System.Drawing.Size(200, 23);
            cbPropertyNo.TabIndex = 1;
            // 
            // dtpRentFinish
            // 
            dtpRentFinish.Location = new System.Drawing.Point(478, 97);
            dtpRentFinish.Name = "dtpRentFinish";
            dtpRentFinish.Size = new System.Drawing.Size(200, 23);
            dtpRentFinish.TabIndex = 3;
            // 
            // dtpRentStart
            // 
            dtpRentStart.Location = new System.Drawing.Point(157, 97);
            dtpRentStart.Name = "dtpRentStart";
            dtpRentStart.Size = new System.Drawing.Size(200, 23);
            dtpRentStart.TabIndex = 4;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new System.Drawing.Point(157, 168);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new System.Drawing.Size(200, 23);
            txtDepositAmount.TabIndex = 5;
            // 
            // txtMonthlyRent
            // 
            txtMonthlyRent.Location = new System.Drawing.Point(478, 164);
            txtMonthlyRent.Name = "txtMonthlyRent";
            txtMonthlyRent.Size = new System.Drawing.Size(200, 23);
            txtMonthlyRent.TabIndex = 6;
            // 
            // gbPaymentStatus
            // 
            gbPaymentStatus.Controls.Add(rbPaid);
            gbPaymentStatus.Controls.Add(rbPending);
            gbPaymentStatus.Controls.Add(rbOngoing);
            gbPaymentStatus.Location = new System.Drawing.Point(166, 239);
            gbPaymentStatus.Name = "gbPaymentStatus";
            gbPaymentStatus.Size = new System.Drawing.Size(519, 39);
            gbPaymentStatus.TabIndex = 7;
            gbPaymentStatus.TabStop = false;
            gbPaymentStatus.Text = "Payment Status";
            // 
            // rbPaid
            // 
            rbPaid.AutoSize = true;
            rbPaid.Location = new System.Drawing.Point(66, 14);
            rbPaid.Name = "rbPaid";
            rbPaid.Size = new System.Drawing.Size(48, 19);
            rbPaid.TabIndex = 0;
            rbPaid.TabStop = true;
            rbPaid.Text = "Paid";
            rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Location = new System.Drawing.Point(418, 14);
            rbPending.Name = "rbPending";
            rbPending.Size = new System.Drawing.Size(69, 19);
            rbPending.TabIndex = 1;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            // 
            // rbOngoing
            // 
            rbOngoing.AutoSize = true;
            rbOngoing.Location = new System.Drawing.Point(199, 14);
            rbOngoing.Name = "rbOngoing";
            rbOngoing.Size = new System.Drawing.Size(141, 19);
            rbOngoing.TabIndex = 2;
            rbOngoing.TabStop = true;
            rbOngoing.Text = "Ongoing/Installments";
            rbOngoing.UseVisualStyleBackColor = true;
            // 
            // txtRentalDesc
            // 
            txtRentalDesc.Location = new System.Drawing.Point(157, 333);
            txtRentalDesc.Name = "txtRentalDesc";
            txtRentalDesc.Size = new System.Drawing.Size(604, 23);
            txtRentalDesc.TabIndex = 3;
            // 
            // lblClientNo
            // 
            lblClientNo.AutoSize = true;
            lblClientNo.Location = new System.Drawing.Point(43, 30);
            lblClientNo.Name = "lblClientNo";
            lblClientNo.Size = new System.Drawing.Size(57, 15);
            lblClientNo.TabIndex = 8;
            lblClientNo.Text = "Client No";
            // 
            // lblPropertyNo
            // 
            lblPropertyNo.AutoSize = true;
            lblPropertyNo.Location = new System.Drawing.Point(379, 30);
            lblPropertyNo.Name = "lblPropertyNo";
            lblPropertyNo.Size = new System.Drawing.Size(71, 15);
            lblPropertyNo.TabIndex = 9;
            lblPropertyNo.Text = "Property No";
            // 
            // lblRentStart
            // 
            lblRentStart.AutoSize = true;
            lblRentStart.Location = new System.Drawing.Point(43, 105);
            lblRentStart.Name = "lblRentStart";
            lblRentStart.Size = new System.Drawing.Size(58, 15);
            lblRentStart.TabIndex = 10;
            lblRentStart.Text = "Rent Start";
            // 
            // lblRentFinish
            // 
            lblRentFinish.AutoSize = true;
            lblRentFinish.Location = new System.Drawing.Point(379, 105);
            lblRentFinish.Name = "lblRentFinish";
            lblRentFinish.Size = new System.Drawing.Size(65, 15);
            lblRentFinish.TabIndex = 11;
            lblRentFinish.Text = "Rent Finish";
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Location = new System.Drawing.Point(43, 176);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new System.Drawing.Size(94, 15);
            lblDepositAmount.TabIndex = 12;
            lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblMonthlyRent
            // 
            lblMonthlyRent.AutoSize = true;
            lblMonthlyRent.Location = new System.Drawing.Point(379, 171);
            lblMonthlyRent.Name = "lblMonthlyRent";
            lblMonthlyRent.Size = new System.Drawing.Size(79, 15);
            lblMonthlyRent.TabIndex = 13;
            lblMonthlyRent.Text = "Monthly Rent";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new System.Drawing.Point(43, 253);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new System.Drawing.Size(89, 15);
            lblPaymentStatus.TabIndex = 14;
            lblPaymentStatus.Text = "Payment Status";
            // 
            // lblRentalDesc
            // 
            lblRentalDesc.AutoSize = true;
            lblRentalDesc.Location = new System.Drawing.Point(43, 336);
            lblRentalDesc.Name = "lblRentalDesc";
            lblRentalDesc.Size = new System.Drawing.Size(106, 15);
            lblRentalDesc.TabIndex = 15;
            lblRentalDesc.Text = "Rental  Description";
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(124, 389);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(84, 33);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Lime;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(629, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(140, 33);
            btnSave.TabIndex = 17;
            btnSave.Text = "Add Rental";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddClientRental
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(lblRentalDesc);
            Controls.Add(lblPaymentStatus);
            Controls.Add(lblMonthlyRent);
            Controls.Add(lblDepositAmount);
            Controls.Add(lblRentFinish);
            Controls.Add(lblRentStart);
            Controls.Add(lblPropertyNo);
            Controls.Add(lblClientNo);
            Controls.Add(txtRentalDesc);
            Controls.Add(gbPaymentStatus);
            Controls.Add(txtMonthlyRent);
            Controls.Add(txtDepositAmount);
            Controls.Add(dtpRentStart);
            Controls.Add(dtpRentFinish);
            Controls.Add(cbPropertyNo);
            Controls.Add(cbClientNo);
            Name = "AddClientRental";
            Text = "AddClientRental";
            gbPaymentStatus.ResumeLayout(false);
            gbPaymentStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientNo;
        private System.Windows.Forms.ComboBox cbPropertyNo;
        private System.Windows.Forms.DateTimePicker dtpRentFinish;
        private System.Windows.Forms.DateTimePicker dtpRentStart;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.GroupBox gbPaymentStatus;
        private System.Windows.Forms.TextBox txtRentalDesc;
        private System.Windows.Forms.RadioButton rbOngoing;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.Label lblClientNo;
        private System.Windows.Forms.Label lblPropertyNo;
        private System.Windows.Forms.Label lblRentStart;
        private System.Windows.Forms.Label lblRentFinish;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblMonthlyRent;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblRentalDesc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}