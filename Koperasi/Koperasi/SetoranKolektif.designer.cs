namespace Koperasi
{
    partial class SetoranKolektif
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtIDSimpanan = new System.Windows.Forms.TextBox();
            this.txtIDNasabah = new System.Windows.Forms.TextBox();
            this.dtpTanggalSetoran = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaKolektor = new System.Windows.Forms.TextBox();
            this.btnCariKolektor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDKolektor = new System.Windows.Forms.TextBox();
            this.btnCariNasabah = new System.Windows.Forms.Button();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetoran)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgvDataSetoran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column1});
            this.dgvDataSetoran.Location = new System.Drawing.Point(12, 170);
            this.dgvDataSetoran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataSetoran.Name = "dgvDataSetoran";
            this.dgvDataSetoran.ReadOnly = true;
            this.dgvDataSetoran.RowHeadersVisible = false;
            this.dgvDataSetoran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataSetoran.Size = new System.Drawing.Size(819, 283);
            this.dgvDataSetoran.TabIndex = 43;
            this.dgvDataSetoran.SelectionChanged += new System.EventHandler(this.dgvDataSetoran_SelectionChanged);
            this.dgvDataSetoran.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDataSetoran_MouseClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Nasabah";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Simpanan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo Awal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nominal Setoran";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Keterangan";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Image = global::Koperasi.Properties.Resources._1444273611_floppy_disk;
            this.btnSimpan.Location = new System.Drawing.Point(837, 460);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 34);
            this.btnSimpan.TabIndex = 113;
            this.btnSimpan.Text = "simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTambah.Location = new System.Drawing.Point(837, 170);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(80, 26);
            this.btnTambah.TabIndex = 114;
            this.btnTambah.Text = "tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Image = global::Koperasi.Properties.Resources.delete_1_icon;
            this.btnHapus.Location = new System.Drawing.Point(837, 234);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 26);
            this.btnHapus.TabIndex = 116;
            this.btnHapus.Text = "hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Koperasi.Properties.Resources.edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(837, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 26);
            this.btnEdit.TabIndex = 115;
            this.btnEdit.Text = "edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(345, 133);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(156, 20);
            this.txtSaldo.TabIndex = 120;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIDSimpanan
            // 
            this.txtIDSimpanan.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDSimpanan.Enabled = false;
            this.txtIDSimpanan.Location = new System.Drawing.Point(186, 133);
            this.txtIDSimpanan.Name = "txtIDSimpanan";
            this.txtIDSimpanan.Size = new System.Drawing.Size(153, 20);
            this.txtIDSimpanan.TabIndex = 119;
            // 
            // txtIDNasabah
            // 
            this.txtIDNasabah.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDNasabah.Enabled = false;
            this.txtIDNasabah.Location = new System.Drawing.Point(12, 133);
            this.txtIDNasabah.Name = "txtIDNasabah";
            this.txtIDNasabah.Size = new System.Drawing.Size(143, 20);
            this.txtIDNasabah.TabIndex = 118;
            // 
            // dtpTanggalSetoran
            // 
            this.dtpTanggalSetoran.Location = new System.Drawing.Point(481, 6);
            this.dtpTanggalSetoran.Name = "dtpTanggalSetoran";
            this.dtpTanggalSetoran.Size = new System.Drawing.Size(201, 20);
            this.dtpTanggalSetoran.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 122;
            this.label1.Text = "Setoran Kolektif";
            // 
            // txtNominal
            // 
            this.txtNominal.BackColor = System.Drawing.SystemColors.Window;
            this.txtNominal.Location = new System.Drawing.Point(507, 134);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(158, 20);
            this.txtNominal.TabIndex = 123;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNamaKolektor);
            this.panel1.Controls.Add(this.btnCariKolektor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIDKolektor);
            this.panel1.Controls.Add(this.dtpTanggalSetoran);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 70);
            this.panel1.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "Nama Kolektor";
            // 
            // txtNamaKolektor
            // 
            this.txtNamaKolektor.BackColor = System.Drawing.SystemColors.Control;
            this.txtNamaKolektor.Enabled = false;
            this.txtNamaKolektor.Location = new System.Drawing.Point(110, 32);
            this.txtNamaKolektor.Name = "txtNamaKolektor";
            this.txtNamaKolektor.Size = new System.Drawing.Size(142, 20);
            this.txtNamaKolektor.TabIndex = 148;
            // 
            // btnCariKolektor
            // 
            this.btnCariKolektor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCariKolektor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariKolektor.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCariKolektor.Location = new System.Drawing.Point(251, 6);
            this.btnCariKolektor.Name = "btnCariKolektor";
            this.btnCariKolektor.Size = new System.Drawing.Size(26, 20);
            this.btnCariKolektor.TabIndex = 147;
            this.btnCariKolektor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariKolektor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariKolektor.UseVisualStyleBackColor = false;
            this.btnCariKolektor.Click += new System.EventHandler(this.btnCariKolektor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Tanggal Setoran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "ID Kolektor";
            // 
            // txtIDKolektor
            // 
            this.txtIDKolektor.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDKolektor.Enabled = false;
            this.txtIDKolektor.Location = new System.Drawing.Point(110, 6);
            this.txtIDKolektor.Name = "txtIDKolektor";
            this.txtIDKolektor.Size = new System.Drawing.Size(142, 20);
            this.txtIDKolektor.TabIndex = 118;
            // 
            // btnCariNasabah
            // 
            this.btnCariNasabah.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCariNasabah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariNasabah.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCariNasabah.Location = new System.Drawing.Point(154, 133);
            this.btnCariNasabah.Name = "btnCariNasabah";
            this.btnCariNasabah.Size = new System.Drawing.Size(26, 20);
            this.btnCariNasabah.TabIndex = 148;
            this.btnCariNasabah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariNasabah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariNasabah.UseVisualStyleBackColor = false;
            this.btnCariNasabah.Click += new System.EventHandler(this.btnCariNasabah_Click);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeterangan.Location = new System.Drawing.Point(671, 133);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(160, 30);
            this.txtKeterangan.TabIndex = 149;
            // 
            // SetoranKolektif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 508);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnCariNasabah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtIDSimpanan);
            this.Controls.Add(this.txtIDNasabah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvDataSetoran);
            this.MaximizeBox = false;
            this.Name = "SetoranKolektif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setoran Kolektif";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetoran)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataSetoran;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtIDSimpanan;
        private System.Windows.Forms.TextBox txtIDNasabah;
        private System.Windows.Forms.DateTimePicker dtpTanggalSetoran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDKolektor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCariKolektor;
        private System.Windows.Forms.Button btnCariNasabah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaKolektor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtKeterangan;
    }
}