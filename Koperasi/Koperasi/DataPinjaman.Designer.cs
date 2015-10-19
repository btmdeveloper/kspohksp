namespace Koperasi
{
    partial class DataPinjaman
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDataSimpanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnEksport = new System.Windows.Forms.Button();
            this.btnPengajuanPinjaman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSimpanan)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 558);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "Pencarian Berdasarkan";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(166, 560);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvDataSimpanan.Location = new System.Drawing.Point(29, 62);
            this.dgvDataSimpanan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDataSimpanan.Name = "dgvDataSimpanan";
            this.dgvDataSimpanan.ReadOnly = true;
            this.dgvDataSimpanan.RowHeadersVisible = false;
            this.dgvDataSimpanan.Size = new System.Drawing.Size(1038, 472);
            this.dgvDataSimpanan.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(192, 44);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data Pinjaman";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCari.Location = new System.Drawing.Point(376, 558);
            this.btnCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 26);
            this.btnCari.TabIndex = 40;
            this.btnCari.Text = "cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // btnEksport
            // 
            this.btnEksport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEksport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksport.Image = global::Koperasi.Properties.Resources.export_icon;
            this.btnEksport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEksport.Location = new System.Drawing.Point(1084, 102);
            this.btnEksport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(104, 32);
            this.btnEksport.TabIndex = 37;
            this.btnEksport.Text = "eksport";
            this.btnEksport.UseVisualStyleBackColor = false;
            // 
            // btnPengajuanPinjaman
            // 
            this.btnPengajuanPinjaman.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPengajuanPinjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengajuanPinjaman.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnPengajuanPinjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengajuanPinjaman.Location = new System.Drawing.Point(1084, 62);
            this.btnPengajuanPinjaman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPengajuanPinjaman.Name = "btnPengajuanPinjaman";
            this.btnPengajuanPinjaman.Size = new System.Drawing.Size(104, 32);
            this.btnPengajuanPinjaman.TabIndex = 36;
            this.btnPengajuanPinjaman.Text = "pengajuan";
            this.btnPengajuanPinjaman.UseVisualStyleBackColor = false;
            this.btnPengajuanPinjaman.Click += new System.EventHandler(this.btnPengajuanPinjaman_Click);
            // 
            // DataPinjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.btnPengajuanPinjaman);
            this.Controls.Add(this.dgvDataSimpanan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataPinjaman";
            this.Text = "DataPinjaman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSimpanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEksport;
        private System.Windows.Forms.Button btnPengajuanPinjaman;
        private System.Windows.Forms.DataGridView dgvDataSimpanan;
        private System.Windows.Forms.Label label1;
    }
}