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
    public partial class CariNasabahSetoran : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        TextBox _txtBoxId, _txtBoxIdSimpanan, _txtBoxNama, _txtBoxAlamat, _txtBoxSaldo;
        SetoranTunai tunai ;
        string idSelected, simpananSelected, namaSelected, alamatSelected, saldoSelected;
        int parameter;

        public CariNasabahSetoran(int param, TextBox txtBoxId, TextBox txtBoxIdSimpanan, TextBox txtBoxNama, TextBox txtBoxAlamat, TextBox txtBoxSaldo)
        {
            InitializeComponent();
            _txtBoxId = txtBoxId;
            _txtBoxIdSimpanan = txtBoxIdSimpanan;
            _txtBoxNama = txtBoxNama;
            _txtBoxAlamat = txtBoxAlamat;
            _txtBoxSaldo = txtBoxSaldo;
            parameter = param;
            tunai = new SetoranTunai();
        }

        public CariNasabahSetoran(int param, TextBox txtBoxId, TextBox txtBoxIdSimpanan, TextBox txtBoxSaldo)
        {
            InitializeComponent();
            _txtBoxId = txtBoxId;
            _txtBoxIdSimpanan = txtBoxIdSimpanan;
            _txtBoxSaldo = txtBoxSaldo;
            parameter = param;
            tunai = new SetoranTunai();
        }

        private void showMaster()
        {
            dt = dbCS.cariDataNasabahSetoran();
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
                dt = dbCS.cariDataNasabahSetoranID(id);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.cariDataNasabahSetoranNama(nama);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.cariDataNasabahSetoranTanggal(tgl);
                dgvDataNasabah.DataSource = dt;
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (parameter == 1)
            {
                _txtBoxId.Text = idSelected;
                _txtBoxIdSimpanan.Text = simpananSelected;
                _txtBoxNama.Text = namaSelected;
                _txtBoxAlamat.Text = alamatSelected;
                _txtBoxSaldo.Text = saldoSelected;
                this.Close();
            }
            else if(parameter==2)
            {
                _txtBoxId.Text = idSelected;
                _txtBoxIdSimpanan.Text = simpananSelected;
                _txtBoxSaldo.Text = saldoSelected;
                this.Close();
            }
        }

        private void CariNasabahSetoran_Load(object sender, EventArgs e)
        {
            showMaster();
        }

        private void dgvDataNasabah_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataNasabah.Rows.Count > 0)
            {
                idSelected = dgvDataNasabah.SelectedRows[0].Cells[0].Value.ToString();
                simpananSelected = dgvDataNasabah.SelectedRows[0].Cells[1].Value.ToString();
                namaSelected = dgvDataNasabah.SelectedRows[0].Cells[3].Value.ToString();
                alamatSelected = dgvDataNasabah.SelectedRows[0].Cells[4].Value.ToString();
                saldoSelected = dgvDataNasabah.SelectedRows[0].Cells[5].Value.ToString();
                btnUse.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Data");
            }
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
