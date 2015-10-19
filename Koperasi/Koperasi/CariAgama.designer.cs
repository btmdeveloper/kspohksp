namespace Koperasi
{
    partial class CariAgama
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
            this.dgvDataAgama = new System.Windows.Forms.DataGridView();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAgama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataAgama
            // 
            this.dgvDataAgama.AllowUserToAddRows = false;
            this.dgvDataAgama.AllowUserToDeleteRows = false;
            this.dgvDataAgama.AllowUserToResizeColumns = false;
            this.dgvDataAgama.AllowUserToResizeRows = false;
            this.dgvDataAgama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataAgama.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataAgama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataAgama.Location = new System.Drawing.Point(12, 13);
            this.dgvDataAgama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataAgama.Name = "dgvDataAgama";
            this.dgvDataAgama.ReadOnly = true;
            this.dgvDataAgama.RowHeadersVisible = false;
            this.dgvDataAgama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataAgama.Size = new System.Drawing.Size(265, 317);
            this.dgvDataAgama.TabIndex = 97;
            this.dgvDataAgama.SelectionChanged += new System.EventHandler(this.dgvDataAgama_SelectionChanged);
            this.dgvDataAgama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDataAgama_MouseClick);
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUse.Enabled = false;
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.Image = global::Koperasi.Properties.Resources.Hands_One_Finger_icon;
            this.btnUse.Location = new System.Drawing.Point(197, 337);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(80, 24);
            this.btnUse.TabIndex = 102;
            this.btnUse.Text = "Pilih";
            this.btnUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Koperasi.Properties.Resources.add_1_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 26);
            this.btnAdd.TabIndex = 106;
            this.btnAdd.Text = "tambah";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CariAgama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 372);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.dgvDataAgama);
            this.MaximizeBox = false;
            this.Name = "CariAgama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariAgama";
            this.Load += new System.EventHandler(this.CariAgama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAgama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataAgama;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnAdd;
    }
}