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
    public partial class AkuntingHeader : Form
    {
        DBAkunting dbAcc = new DBAkunting();
        DataTable dtHeader, dt;
        string idEdit = "";
        public AkuntingHeader()
        {
            InitializeComponent();
        }

        private void AkuntingHeader_Load(object sender, EventArgs e)
        {
            showData();
            
        }

        public void showData()
        {
            dtHeader = new DataTable();
            dtHeader = dbAcc.showHeader();
            dgvHeader.DataSource = dtHeader;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageHeader formHeader = new ManageHeader(1);
            formHeader.ShowDialog();
        }

        private void dgvHeader_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvHeader.Rows.Count > 0)
            {
                idEdit = dgvHeader.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ManageHeader formHeader = new ManageHeader(2, idEdit);
            formHeader.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DeleteHeader confirmDelete = new DeleteHeader(idEdit);
            confirmDelete.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                showData();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbAcc.showHeaderID(id);
                dgvHeader.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbAcc.showHeaderNama(nama);
                dgvHeader.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dt = new DataTable();
                string grup = txtSearch.Text.ToString();
                dt = dbAcc.showHeaderGrup(grup);
                dgvHeader.DataSource = dt;
            }
        }
    }
}
