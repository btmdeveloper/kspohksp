namespace Koperasi
{
    partial class CariSimpanan
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
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDataSimpanan = new System.Windows.Forms.DataGridView();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSimpanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSearch
            // 
            this.dtpSearch.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch.Location = new System.Drawing.Point(151, 38);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(204, 20);
            this.dtpSearch.TabIndex = 100;
            this.dtpSearch.Visible = false;
            // 
            // cmbSorting
            // 
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Tampilkan Seluruh Data",
            "ID Nasabah",
            "Nama Nasabah",
            "Tanggal"});
            this.cmbSorting.Location = new System.Drawing.Point(10, 11);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(135, 21);
            this.cmbSorting.TabIndex = 98;
            this.cmbSorting.Text = "Pencarian Berdasarkan";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(151, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 97;
            this.txtSearch.Text = "Cari...";
            // 
            // dgvDataSimpanan
            // 
            this.dgvDataSimpanan.AllowUserToAddRows = false;
            this.dgvDataSimpanan.AllowUserToDeleteRows = false;
            this.dgvDataSimpanan.AllowUserToResizeColumns = false;
            this.dgvDataSimpanan.AllowUserToResizeRows = false;
            this.dgvDataSimpanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataSimpanan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataSimpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSimpanan.Location = new System.Drawing.Point(13, 82);
            this.dgvDataSimpanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataSimpanan.Name = "dgvDataSimpanan";
            this.dgvDataSimpanan.ReadOnly = true;
            this.dgvDataSimpanan.RowHeadersVisible = false;
            this.dgvDataSimpanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataSimpanan.Size = new System.Drawing.Size(787, 317);
            this.dgvDataSimpanan.TabIndex = 96;
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUse.Enabled = false;
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.Image = global::Koperasi.Properties.Resources.Hands_One_Finger_icon;
            this.btnUse.Location = new System.Drawing.Point(720, 406);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(80, 27);
            this.btnUse.TabIndex = 101;
            this.btnUse.Text = "Piih";
            this.btnUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUse.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCari.Location = new System.Drawing.Point(361, 11);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 32);
            this.btnCari.TabIndex = 99;
            this.btnCari.Text = "cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // CariSimpanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDataSimpanan);
            this.Name = "CariSimpanan";
            this.Text = "CariSimpanan";
            this.Load += new System.EventHandler(this.CariSimpanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSimpanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDataSimpanan;
    }
}