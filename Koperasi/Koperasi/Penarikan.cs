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
    public partial class Penarikan : Form
    {
        DBCustomerService dbCs = new DBCustomerService();
        DataTable dtTarik;
        public Penarikan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PenarikanSimpanan tambahPenarikan = new PenarikanSimpanan();
            tambahPenarikan.ShowDialog();
        }

        private void Penarikan_Load(object sender, EventArgs e)
        {
            showData();
        }

        public void showData()
        {
            dtTarik = new DataTable();
            dtTarik = dbCs.showDataPenarikan();
            dgvPenarikan.DataSource = dtTarik;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 2)
            {
                txtSearch.Visible = false;
                dtpTgl.Visible = true;
                dtpTgl.Location = new Point(204, 540);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = true;
                dtpTgl.Visible = false;

                txtSearch.Text = "";
                showData();
            }
            else
            {
                txtSearch.Visible = true;
                dtpTgl.Visible = false;
            }
        }
    }
}
