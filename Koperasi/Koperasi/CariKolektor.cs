using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koperasi
{
    public partial class CariKolektor : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        TextBox _txtBoxId, _txtBoxNama;
        string idSelected, namaSelected;
        int parameter;

        public CariKolektor(int param, TextBox txtBoxIdKolektor, TextBox txtBoxNamaKolektor)
        {
            InitializeComponent();
            this._txtBoxId = txtBoxIdKolektor;
            this._txtBoxNama = txtBoxNamaKolektor;
            parameter = param;
        }

        public CariKolektor(int param, TextBox txtBoxIdKolektor)
        {
            InitializeComponent();
            this._txtBoxId = txtBoxIdKolektor;
            parameter = param;
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
                dt = dbCS.cariDataKolektorID(id);
                dgvDataKolektor.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.cariDataKolektorNama(nama);
                dgvDataKolektor.DataSource = dt;
            }
        }

        private void showMaster()
        {
            dt = dbCS.cariDataKolektor();
            dgvDataKolektor.DataSource = dt;
        }

        private void dgvDataKolektor_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataKolektor.Rows.Count > 0)
            {
                idSelected = dgvDataKolektor.SelectedRows[0].Cells[0].Value.ToString();
                namaSelected = dgvDataKolektor.SelectedRows[0].Cells[1].Value.ToString();
                btnUse.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (parameter == 2)
            {
                _txtBoxId.Text = idSelected;
                this.Close();
            }
            else if (parameter == 1)
            {
                _txtBoxId.Text = idSelected;
                _txtBoxNama.Text = namaSelected;
                this.Close();
            }
        }

        private void dgvDataKolektor_SelectionChanged(object sender, EventArgs e)
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

        private void CariKolektor_Load(object sender, EventArgs e)
        {
            showMaster();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                btnCari.Location = new Point(150, 12);
                //ShowMaster();
            }
            else
            {
                txtSearch.Visible = true;
                btnCari.Location = new Point(360, 11);
            }
        }
    }
}
