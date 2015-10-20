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
    public partial class DataBunga : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;

        public DataBunga()
        {
            InitializeComponent();
        }

        private void showMasterBunga()
        {
            dt = new DataTable();
            dt = dbCS.showDataBungaSimpanan();
            dgvDataBunga.DataSource = dt;
        }

        private void DataBunga_Load(object sender, EventArgs e)
        {
            showMasterBunga();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            BungaSimpanan bunga = new BungaSimpanan();
            bunga.ShowDialog();
            showMasterBunga();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 5)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = true;
                btnCari.Visible = true;
                dtpSearch.Value = DateTime.Now.Date;
                dtpSearch.Location = new Point(174, 538);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = false;
                btnCari.Visible = false;
                showMasterBunga();
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Text = "";
                dtpSearch.Visible = false;
                btnCari.Visible = true;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 1)//id bunga
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataBungaSimpananIDBunga(id);
                dgvDataBunga.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)//id nasabah
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.showDataBungaSimpananIDNasabah(nama);
                dgvDataBunga.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)//ID simpanan
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataBungaSimpananIDSimpanan(id);
                dgvDataBunga.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 4)//minimal bunga
            {
                dt = new DataTable();
                double bunga = Convert.ToDouble(txtSearch.Text.ToString());
                dt = dbCS.showDataBungaSimpananMinimalBunga(bunga);
                dgvDataBunga.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 5) //tanggal
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.showDataBungaSimpananTanggal(tgl);
                dgvDataBunga.DataSource = dt;
            }
        }
    }
}
