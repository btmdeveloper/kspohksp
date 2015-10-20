﻿namespace Koperasi
{
    partial class DataBunga
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
            this.dgvDataBunga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnEksport = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBunga)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSearch
            // 
            this.dtpSearch.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch.Location = new System.Drawing.Point(174, 572);
            this.dtpSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(204, 20);
            this.dtpSearch.TabIndex = 102;
            this.dtpSearch.Visible = false;
            // 
            // cmbSorting
            // 
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Tampilkan Seluruh Data",
            "ID Bunga",
            "ID Nasabah",
            "ID Simpanan",
            "Minimal Bunga",
            "Tanggal"});
            this.cmbSorting.Location = new System.Drawing.Point(33, 536);
            this.cmbSorting.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(135, 24);
            this.cmbSorting.TabIndex = 100;
            this.cmbSorting.Text = "Pencarian Berdasarkan";
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 538);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 99;
            this.txtSearch.Text = "Cari...";
            // 
            // dgvDataBunga
            // 
            this.dgvDataBunga.AllowUserToAddRows = false;
            this.dgvDataBunga.AllowUserToDeleteRows = false;
            this.dgvDataBunga.AllowUserToResizeColumns = false;
            this.dgvDataBunga.AllowUserToResizeRows = false;
            this.dgvDataBunga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataBunga.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataBunga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBunga.Location = new System.Drawing.Point(34, 67);
            this.dgvDataBunga.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvDataBunga.Name = "dgvDataBunga";
            this.dgvDataBunga.ReadOnly = true;
            this.dgvDataBunga.RowHeadersVisible = false;
            this.dgvDataBunga.Size = new System.Drawing.Size(1047, 460);
            this.dgvDataBunga.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 18, 0, 0);
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 95;
            this.label1.Text = "Data Bunga";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCari.Location = new System.Drawing.Point(384, 536);
            this.btnCari.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 32);
            this.btnCari.TabIndex = 101;
            this.btnCari.Text = "cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnEksport
            // 
            this.btnEksport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEksport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksport.Image = global::Koperasi.Properties.Resources.export_icon;
            this.btnEksport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEksport.Location = new System.Drawing.Point(1101, 117);
            this.btnEksport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(93, 39);
            this.btnEksport.TabIndex = 98;
            this.btnEksport.Text = "eksport";
            this.btnEksport.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(1101, 67);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(93, 39);
            this.btnTambah.TabIndex = 97;
            this.btnTambah.Text = "tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // DataBunga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvDataBunga);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataBunga";
            this.Text = "DataBunga";
            this.Load += new System.EventHandler(this.DataBunga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBunga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEksport;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgvDataBunga;
        private System.Windows.Forms.Label label1;
    }
}