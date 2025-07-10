namespace RealEstateProject
{
    partial class UpdateClientRental
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearchClientRental = new System.Windows.Forms.TextBox();
            lblSearchClientRental = new System.Windows.Forms.Label();
            dgvClientRental = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientRental).BeginInit();
            SuspendLayout();
            // 
            // txtSearchClientRental
            // 
            txtSearchClientRental.Location = new System.Drawing.Point(365, 48);
            txtSearchClientRental.Name = "txtSearchClientRental";
            txtSearchClientRental.Size = new System.Drawing.Size(409, 23);
            txtSearchClientRental.TabIndex = 0;
            // 
            // lblSearchClientRental
            // 
            lblSearchClientRental.AutoSize = true;
            lblSearchClientRental.BackColor = System.Drawing.SystemColors.Highlight;
            lblSearchClientRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSearchClientRental.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchClientRental.Location = new System.Drawing.Point(21, 51);
            lblSearchClientRental.Name = "lblSearchClientRental";
            lblSearchClientRental.Size = new System.Drawing.Size(319, 17);
            lblSearchClientRental.TabIndex = 1;
            lblSearchClientRental.Text = "Search by Property No OR Client No OR Rent Start Date";
            // 
            // dgvClientRental
            // 
            dgvClientRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientRental.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvClientRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientRental.Location = new System.Drawing.Point(12, 114);
            dgvClientRental.Name = "dgvClientRental";
            dgvClientRental.ReadOnly = true;
            dgvClientRental.Size = new System.Drawing.Size(917, 324);
            dgvClientRental.TabIndex = 2;
            dgvClientRental.CellDoubleClick += dgvClientRental_CellDoubleClick;
            // 
            // UpdateClientRental
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvClientRental);
            Controls.Add(lblSearchClientRental);
            Controls.Add(txtSearchClientRental);
            Name = "UpdateClientRental";
            Text = "Update Client Rental";
            ((System.ComponentModel.ISupportInitialize)dgvClientRental).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearchClientRental;
        private System.Windows.Forms.Label lblSearchClientRental;
        private System.Windows.Forms.DataGridView dgvClientRental;
    }
}
