namespace Koperasi
{
    partial class CariKolektor
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
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDataKolektor = new System.Windows.Forms.DataGridView();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataKolektor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSorting
            // 
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Tampilkan Seluruh Data",
            "ID Kolektor",
            "Nama Kolektor"});
            this.cmbSorting.Location = new System.Drawing.Point(10, 14);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(135, 21);
            this.cmbSorting.TabIndex = 98;
            this.cmbSorting.Text = "Pencarian Berdasarkan";
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(151, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 97;
            this.txtSearch.Text = "Cari...";
            // 
            // dgvDataKolektor
            // 
            this.dgvDataKolektor.AllowUserToAddRows = false;
            this.dgvDataKolektor.AllowUserToDeleteRows = false;
            this.dgvDataKolektor.AllowUserToResizeColumns = false;
            this.dgvDataKolektor.AllowUserToResizeRows = false;
            this.dgvDataKolektor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataKolektor.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataKolektor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataKolektor.Location = new System.Drawing.Point(13, 85);
            this.dgvDataKolektor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataKolektor.Name = "dgvDataKolektor";
            this.dgvDataKolektor.ReadOnly = true;
            this.dgvDataKolektor.RowHeadersVisible = false;
            this.dgvDataKolektor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataKolektor.Size = new System.Drawing.Size(787, 317);
            this.dgvDataKolektor.TabIndex = 96;
            this.dgvDataKolektor.SelectionChanged += new System.EventHandler(this.dgvDataKolektor_SelectionChanged);
            this.dgvDataKolektor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDataKolektor_MouseClick);
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUse.Enabled = false;
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.Image = global::Koperasi.Properties.Resources.Hands_One_Finger_icon;
            this.btnUse.Location = new System.Drawing.Point(720, 409);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(80, 24);
            this.btnUse.TabIndex = 101;
            this.btnUse.Text = "Pilih";
            this.btnUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Image = global::Koperasi.Properties.Resources.search_icon;
            this.btnCari.Location = new System.Drawing.Point(361, 14);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 21);
            this.btnCari.TabIndex = 99;
            this.btnCari.Text = "cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // CariKolektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDataKolektor);
            this.Name = "CariKolektor";
            this.Text = "CariKolektor";
            this.Load += new System.EventHandler(this.CariKolektor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataKolektor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDataKolektor;
    }
}