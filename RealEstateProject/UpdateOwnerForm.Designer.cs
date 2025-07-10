namespace RealEstateProject
{
    partial class UpdateOwnerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearchOwner = new System.Windows.Forms.TextBox();
            lblSearchOwner = new System.Windows.Forms.Label();
            dgvOwner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOwner).BeginInit();
            SuspendLayout();
            // 
            // txtSearchOwner
            // 
            txtSearchOwner.Location = new System.Drawing.Point(275, 48);
            txtSearchOwner.Name = "txtSearchOwner";
            txtSearchOwner.Size = new System.Drawing.Size(499, 23);
            txtSearchOwner.TabIndex = 0;
            // 
            // lblSearchOwner
            // 
            lblSearchOwner.AutoSize = true;
            lblSearchOwner.BackColor = System.Drawing.SystemColors.Highlight;
            lblSearchOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSearchOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchOwner.Location = new System.Drawing.Point(21, 51);
            lblSearchOwner.Name = "lblSearchOwner";
            lblSearchOwner.Size = new System.Drawing.Size(229, 17);
            lblSearchOwner.TabIndex = 1;
            lblSearchOwner.Text = "Search by OwnerNo OR Name OR  CNIC";
            // 
            // dgvOwner
            // 
            dgvOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOwner.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwner.Location = new System.Drawing.Point(12, 114);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.ReadOnly = true;
            dgvOwner.Size = new System.Drawing.Size(917, 324);
            dgvOwner.TabIndex = 2;
            dgvOwner.CellDoubleClick += dgvOwner_CellDoubleClick;
            // 
            // UpdateOwnerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvOwner);
            Controls.Add(lblSearchOwner);
            Controls.Add(txtSearchOwner);
            Name = "UpdateOwnerForm";
            Text = "Update Owner Form";
            ((System.ComponentModel.ISupportInitialize)dgvOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearchOwner;
        private System.Windows.Forms.Label lblSearchOwner;
        private System.Windows.Forms.DataGridView dgvOwner;
    }
}
