namespace Koperasi
{
    partial class SetoranSimpanan
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
            this.dgvDataSetoran = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnSetoranKolektif = new System.Windows.Forms.Button();
            this.btnEksport = new System.Windows.Forms.Button();
            this.btnSetoranTunai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetoran)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataSetoran
            // 
            this.dgvDataSetoran.AllowUserToAddRows = false;
            this.dgvDataSetoran.AllowUserToDeleteRows = false;
            this.dgvDataSetoran.AllowUserToResizeColumns = false;
            this.dgvDataSetoran.AllowUserToResizeRows = false;
            this.dgvDataSetoran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataSetoran.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataSetoran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSetoran.Location = new System.Drawing.Point(28, 62);
            this.dgvDataSetoran.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDataSetoran.Name = "dgvDataSetoran";
            this.dgvDataSetoran.ReadOnly = true;
            this.dgvDataSetoran.RowHeadersVisible = false;
            this.dgvDataSetoran.Size = new System.Drawing.Size(1031, 487);
            this.dgvDataSetoran.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(116, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Setoran";
            // 
            // dtpSearch
            // 
            this.dtpSearch.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch.Location = new System.Drawing.Point(168, 586);
            this.dtpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(204, 20);
            this.dtpSearch.TabIndex = 98;
            this.dtpSearch.Visible = false;
            // 
            // cmbSorting
            // 
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Tampilkan Seluruh Data",
            "ID Nasabah",
            "ID Simpanan",
            "ID Kolektor",
            "Tanggal"});
            this.cmbSorting.Location = new System.Drawing.Point(27, 557);
            this.cmbSorting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(135, 24);
            this.cmbSorting.TabIndex = 96;
            this.cmbSorting.Text = "Pencarian Berdasarkan";
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(168, 558);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 95;
            this.txtSearch.Text = "Cari...";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Koperasi.Properties.Resources.edit_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1065, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 32);
            this.btnEdit.TabIndex = 99;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCari.Location = new System.Drawing.Point(378, 558);
            this.btnCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 26);
            this.btnCari.TabIndex = 97;
            this.btnCari.Text = "cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnSetoranKolektif
            // 
            this.btnSetoranKolektif.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSetoranKolektif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetoranKolektif.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnSetoranKolektif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetoranKolektif.Location = new System.Drawing.Point(1065, 101);
            this.btnSetoranKolektif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetoranKolektif.Name = "btnSetoranKolektif";
            this.btnSetoranKolektif.Size = new System.Drawing.Size(123, 32);
            this.btnSetoranKolektif.TabIndex = 48;
            this.btnSetoranKolektif.Text = "setoran kolektif";
            this.btnSetoranKolektif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetoranKolektif.UseVisualStyleBackColor = false;
            this.btnSetoranKolektif.Click += new System.EventHandler(this.btnSetoranKolektif_Click);
            // 
            // btnEksport
            // 
            this.btnEksport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEksport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksport.Image = global::Koperasi.Properties.Resources.export_icon;
            this.btnEksport.Location = new System.Drawing.Point(1065, 179);
            this.btnEksport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(123, 32);
            this.btnEksport.TabIndex = 44;
            this.btnEksport.Text = "eksport";
            this.btnEksport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEksport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEksport.UseVisualStyleBackColor = false;
            // 
            // btnSetoranTunai
            // 
            this.btnSetoranTunai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSetoranTunai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetoranTunai.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnSetoranTunai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetoranTunai.Location = new System.Drawing.Point(1065, 61);
            this.btnSetoranTunai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetoranTunai.Name = "btnSetoranTunai";
            this.btnSetoranTunai.Size = new System.Drawing.Size(123, 32);
            this.btnSetoranTunai.TabIndex = 43;
            this.btnSetoranTunai.Text = "setoran tunai";
            this.btnSetoranTunai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetoranTunai.UseVisualStyleBackColor = false;
            this.btnSetoranTunai.Click += new System.EventHandler(this.btnSetoranTunai_Click);
            // 
            // SetoranSimpanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSetoranKolektif);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.btnSetoranTunai);
            this.Controls.Add(this.dgvDataSetoran);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SetoranSimpanan";
            this.Text = "Setoran Simpanan";
            this.Load += new System.EventHandler(this.SetoranSimpanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetoran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEksport;
        private System.Windows.Forms.Button btnSetoranTunai;
        private System.Windows.Forms.DataGridView dgvDataSetoran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetoranKolektif;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
    }
}