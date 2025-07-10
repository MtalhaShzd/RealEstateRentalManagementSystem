namespace RealEstateProject
{
    partial class SearchPropertyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            dgvProperty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProperty).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(228, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(546, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = System.Drawing.SystemColors.Highlight;
            lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearch.Location = new System.Drawing.Point(21, 51);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(178, 17);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by Property No OR City";
            // 
            // dgvProperty
            // 
            dgvProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperty.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperty.Location = new System.Drawing.Point(12, 114);
            dgvProperty.Name = "dgvProperty";
            dgvProperty.ReadOnly = true;
            dgvProperty.Size = new System.Drawing.Size(917, 324);
            dgvProperty.TabIndex = 2;
            // 
            // SearchPropertyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvProperty);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Name = "SearchPropertyForm";
            Text = "Search Property Form";
            ((System.ComponentModel.ISupportInitialize)dgvProperty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvProperty;
    }
}
