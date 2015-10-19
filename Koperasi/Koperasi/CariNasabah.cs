using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace Koperasi
{
    public partial class CariNasabah : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        TextBox _txtBoxId;
        TambahDataSimpanan simpan;
        string idSelected;

        public CariNasabah(TextBox txtBoxId)
        {
            InitializeComponent();
            _txtBoxId = txtBoxId;
            simpan = new TambahDataSimpanan();
        }

        private void showMaster()
        {
            dt = dbCS.cariDataNasabah();
            dgvDataNasabah.DataSource = dt;
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 3)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = true;
                dtpSearch.Location = new Point(150, 12);
                btnCari.Location = new Point(360, 11);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = false;
                btnCari.Location = new Point(150, 12);
                //ShowMaster();
            }
            else
            {
                txtSearch.Visible = true;
                dtpSearch.Visible = false;
                btnCari.Location = new Point(360, 11);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                showMaster();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataNasabahID(id);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.showDataNasabahNama(nama);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.showDataNasabahTanggal(tgl);
                dgvDataNasabah.DataSource = dt;
            }
          
        }

        private void CariNasabah_Load(object sender, EventArgs e)
        {
            showMaster();
        }

        private void dgvDataNasabah_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataNasabah.Rows.Count > 0)
            {
                idSelected = dgvDataNasabah.SelectedRows[0].Cells[0].Value.ToString();
                btnUse.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            _txtBoxId.Text = idSelected;
            this.Close();
        }

        private void dgvDataNasabah_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {
                    BackColor = Color.White,
                    ForeColor = SystemColors.WindowText,
                    SelectionBackColor = Color.Firebrick,
                    SelectionForeColor = SystemColors.HighlightText
                };
            }
        }
    }
}
