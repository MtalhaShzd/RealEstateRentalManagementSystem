namespace RealEstateProject
{
    partial class UpdateClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearchClient = new System.Windows.Forms.TextBox();
            lblSearchClient = new System.Windows.Forms.Label();
            dgvClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            SuspendLayout();
            // 
            // txtSearchClient
            // 
            txtSearchClient.Location = new System.Drawing.Point(275, 48);
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.Size = new System.Drawing.Size(499, 23);
            txtSearchClient.TabIndex = 0;
            // 
            // lblSearchClient
            // 
            lblSearchClient.AutoSize = true;
            lblSearchClient.BackColor = System.Drawing.SystemColors.Highlight;
            lblSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSearchClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchClient.Location = new System.Drawing.Point(21, 51);
            lblSearchClient.Name = "lblSearchClient";
            lblSearchClient.Size = new System.Drawing.Size(223, 17);
            lblSearchClient.TabIndex = 1;
            lblSearchClient.Text = "Search by ClientNo OR Name OR  CNIC";
            // 
            // dgvClient
            // 
            dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClient.Location = new System.Drawing.Point(12, 114);
            dgvClient.Name = "dgvClient";
            dgvClient.ReadOnly = true;
            dgvClient.Size = new System.Drawing.Size(917, 324);
            dgvClient.TabIndex = 2;
            dgvClient.CellDoubleClick += dgvClient_CellDoubleClick;
            // 
            // UpdateClientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvClient);
            Controls.Add(lblSearchClient);
            Controls.Add(txtSearchClient);
            Name = "UpdateClientForm";
            Text = "Update Client Form";
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.DataGridView dgvClient;
    }
}
