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
    public partial class SetoranSimpanan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;

        public SetoranSimpanan()
        {
            InitializeComponent();
        }

        private void btnSetoranTunai_Click(object sender, EventArgs e)
        {
            SetoranTunai tunai = new SetoranTunai();
            tunai.ShowDialog();
            showMasterSetoran();
        }

        private void btnSetoranKolektif_Click(object sender, EventArgs e)
        {
            SetoranKolektif kolektif = new SetoranKolektif();
            kolektif.ShowDialog();
            showMasterSetoran();
        }

        private void showMasterSetoran()
        {
            dt = new DataTable();
            dt = dbCS.cariDataSetoran();
            dgvDataSetoran.DataSource = dt;
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 4)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = true;
                dtpSearch.Value = DateTime.Now.Date;
                dtpSearch.Location = new Point(168, 558);
                btnCari.Location = new Point(378, 558);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = false;
                btnCari.Location = new Point(168, 558);
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Text = "";
                dtpSearch.Visible = false;
                btnCari.Location = new Point(378, 558);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0) //tampilkan semua
            {
                showMasterSetoran();
            }
            else if (cmbSorting.SelectedIndex == 1)//id nasabah
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.cariDataSetoranID(id);
                dgvDataSetoran.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)//id simpanan
            {
                dt = new DataTable();
                string simpanan = txtSearch.Text.ToString();
                dt = dbCS.cariDataSetoranSimpanan(simpanan);
                dgvDataSetoran.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)//ID Kolektor
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.cariDataSetoranKolektor(id);
                dgvDataSetoran.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 4) //tanggal
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.cariDataSetoranTanggal(tgl);
                dgvDataSetoran.DataSource = dt;
            }
        }

        private void SetoranSimpanan_Load(object sender, EventArgs e)
        {
            showMasterSetoran();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSetoran edit = new EditSetoran();
            edit.ShowDialog();
        }
    }
}
