using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Koperasi
{
    public partial class DataSimpanan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;

        public DataSimpanan()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahDataSimpanan tambah = new TambahDataSimpanan();
            tambah.ShowDialog();
            showMasterSimpanan();
        }

        private void showMasterSimpanan()
        {
            dt = new DataTable();
            dt = dbCS.showDataSimpanan();
            dgvDataSimpanan.DataSource = dt;
        }

        private void DataSimpanan_Load(object sender, EventArgs e)
        {
            showMasterSimpanan();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 4)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = true;
                dtpSearch.Value = DateTime.Now.Date;
                dtpSearch.Location = new Point(169, 552);
                btnCari.Location = new Point(379, 551);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = false;
                btnCari.Location=new Point(169, 552);
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Text = "";
                dtpSearch.Visible = false;
                btnCari.Location = new Point(379, 551);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                showMasterSimpanan();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataSimpananIDNasabah(id);
                dgvDataSimpanan.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.showDataSimpananNamaNasabah(nama);
                dgvDataSimpanan.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)//ID Kolektor
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataSimpananIDKolektor(id);
                dgvDataSimpanan.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 4) //tanggal
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.showDataSimpananTanggal(tgl);
                dgvDataSimpanan.DataSource = dt;
            }
        }
    }
}
