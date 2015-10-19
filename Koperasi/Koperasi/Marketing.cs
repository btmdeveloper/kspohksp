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
    public partial class Marketing : Form
    {
        DBSetup dbSetup = new DBSetup();
        DataTable dtKolektor;
        string id_edit = "";
        public Marketing()
        {
            InitializeComponent();
        }

        private void Marketing_Load(object sender, EventArgs e)
        {
            showData();
        }

        public void showData()
        {
            dtKolektor = new DataTable();
            dtKolektor = dbSetup.showDataKolektor();
            dgvKolektor.DataSource = dtKolektor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMarketing formAdd = new AddMarketing();
            formAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                showData();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dtKolektor = new DataTable();
                string id = txtSearch.Text.ToString();
                dtKolektor = dbSetup.showDataKolektorID(id);
                dgvKolektor.DataSource = dtKolektor;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dtKolektor = new DataTable();
                string nama = txtSearch.Text.ToString();
                dtKolektor = dbSetup.showDataKolektorNama(nama);
                dgvKolektor.DataSource = dtKolektor;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dtKolektor = new DataTable();
                string alamat = txtSearch.Text.ToString();
                dtKolektor = dbSetup.showDataKolektorAlamat(alamat);
                dgvKolektor.DataSource = dtKolektor;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMarketing edit = new EditMarketing(id_edit);
            edit.ShowDialog();
            showData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showData();
            }
        }

        private void dgvKolektor_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvKolektor.Rows.Count > 0)
            {
                id_edit = dgvKolektor.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }
    }
}
