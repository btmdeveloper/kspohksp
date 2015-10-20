namespace Koperasi
{
    partial class BungaSimpanan
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
            this.btnCariSimpanan = new System.Windows.Forms.Button();
            this.nmrBunga = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNasabah = new System.Windows.Forms.TextBox();
            this.dtpTanggalBunga = new System.Windows.Forms.DateTimePicker();
            this.txtIDSimpanan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDBungaSimpanan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldoAwal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJumlahBunga = new System.Windows.Forms.TextBox();
            this.txtSaldoAkhir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBunga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCariSimpanan
            // 
            this.btnCariSimpanan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCariSimpanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariSimpanan.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCariSimpanan.Location = new System.Drawing.Point(435, 136);
            this.btnCariSimpanan.Name = "btnCariSimpanan";
            this.btnCariSimpanan.Size = new System.Drawing.Size(26, 20);
            this.btnCariSimpanan.TabIndex = 100;
            this.btnCariSimpanan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariSimpanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariSimpanan.UseVisualStyleBackColor = false;
            this.btnCariSimpanan.Click += new System.EventHandler(this.btnCariSimpanan_Click);
            // 
            // nmrBunga
            // 
            this.nmrBunga.DecimalPlaces = 2;
            this.nmrBunga.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrBunga.Location = new System.Drawing.Point(144, 215);
            this.nmrBunga.Name = "nmrBunga";
            this.nmrBunga.Size = new System.Drawing.Size(79, 20);
            this.nmrBunga.TabIndex = 99;
            this.nmrBunga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrBunga.ValueChanged += new System.EventHandler(this.nmrBunga_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Saldo Akhir Nasabah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Bunga (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "ID Nasabah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Tanggal Daftar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "ID Simpanan";
            // 
            // txtIDNasabah
            // 
            this.txtIDNasabah.Enabled = false;
            this.txtIDNasabah.Location = new System.Drawing.Point(144, 162);
            this.txtIDNasabah.Name = "txtIDNasabah";
            this.txtIDNasabah.ReadOnly = true;
            this.txtIDNasabah.Size = new System.Drawing.Size(293, 20);
            this.txtIDNasabah.TabIndex = 89;
            // 
            // dtpTanggalBunga
            // 
            this.dtpTanggalBunga.Location = new System.Drawing.Point(144, 110);
            this.dtpTanggalBunga.Name = "dtpTanggalBunga";
            this.dtpTanggalBunga.Size = new System.Drawing.Size(293, 20);
            this.dtpTanggalBunga.TabIndex = 88;
            // 
            // txtIDSimpanan
            // 
            this.txtIDSimpanan.Enabled = false;
            this.txtIDSimpanan.Location = new System.Drawing.Point(144, 136);
            this.txtIDSimpanan.Name = "txtIDSimpanan";
            this.txtIDSimpanan.ReadOnly = true;
            this.txtIDSimpanan.Size = new System.Drawing.Size(293, 20);
            this.txtIDSimpanan.TabIndex = 87;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Image = global::Koperasi.Properties.Resources._1444273611_floppy_disk;
            this.btnSimpan.Location = new System.Drawing.Point(373, 342);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(88, 34);
            this.btnSimpan.TabIndex = 86;
            this.btnSimpan.Text = "simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(98, 41);
            this.label1.TabIndex = 85;
            this.label1.Text = "Bunga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "ID Bunga Simpanan";
            // 
            // txtIDBungaSimpanan
            // 
            this.txtIDBungaSimpanan.Location = new System.Drawing.Point(144, 84);
            this.txtIDBungaSimpanan.Name = "txtIDBungaSimpanan";
            this.txtIDBungaSimpanan.ReadOnly = true;
            this.txtIDBungaSimpanan.Size = new System.Drawing.Size(293, 20);
            this.txtIDBungaSimpanan.TabIndex = 106;
            this.txtIDBungaSimpanan.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Saldo Nasabah";
            // 
            // txtSaldoAwal
            // 
            this.txtSaldoAwal.Enabled = false;
            this.txtSaldoAwal.Location = new System.Drawing.Point(144, 188);
            this.txtSaldoAwal.Name = "txtSaldoAwal";
            this.txtSaldoAwal.ReadOnly = true;
            this.txtSaldoAwal.Size = new System.Drawing.Size(293, 20);
            this.txtSaldoAwal.TabIndex = 108;
            this.txtSaldoAwal.Text = "0";
            this.txtSaldoAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldoAwal.TextChanged += new System.EventHandler(this.txtSaldoAwal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Jumlah Bunga";
            // 
            // txtJumlahBunga
            // 
            this.txtJumlahBunga.Enabled = false;
            this.txtJumlahBunga.Location = new System.Drawing.Point(144, 241);
            this.txtJumlahBunga.Name = "txtJumlahBunga";
            this.txtJumlahBunga.ReadOnly = true;
            this.txtJumlahBunga.Size = new System.Drawing.Size(293, 20);
            this.txtJumlahBunga.TabIndex = 110;
            this.txtJumlahBunga.Text = "0";
            this.txtJumlahBunga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJumlahBunga.TextChanged += new System.EventHandler(this.txtJumlahBunga_TextChanged);
            // 
            // txtSaldoAkhir
            // 
            this.txtSaldoAkhir.Enabled = false;
            this.txtSaldoAkhir.Location = new System.Drawing.Point(144, 267);
            this.txtSaldoAkhir.Name = "txtSaldoAkhir";
            this.txtSaldoAkhir.ReadOnly = true;
            this.txtSaldoAkhir.Size = new System.Drawing.Size(293, 20);
            this.txtSaldoAkhir.TabIndex = 112;
            this.txtSaldoAkhir.Text = "0";
            this.txtSaldoAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BungaSimpanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 405);
            this.Controls.Add(this.txtSaldoAkhir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJumlahBunga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSaldoAwal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDBungaSimpanan);
            this.Controls.Add(this.btnCariSimpanan);
            this.Controls.Add(this.nmrBunga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDNasabah);
            this.Controls.Add(this.dtpTanggalBunga);
            this.Controls.Add(this.txtIDSimpanan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BungaSimpanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bunga Simpanan";
            ((System.ComponentModel.ISupportInitialize)(this.nmrBunga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariSimpanan;
        private System.Windows.Forms.NumericUpDown nmrBunga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNasabah;
        private System.Windows.Forms.DateTimePicker dtpTanggalBunga;
        private System.Windows.Forms.TextBox txtIDSimpanan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDBungaSimpanan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoAwal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJumlahBunga;
        private System.Windows.Forms.TextBox txtSaldoAkhir;
    }
}