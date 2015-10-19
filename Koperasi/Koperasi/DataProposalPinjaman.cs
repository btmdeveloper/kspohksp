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
    public partial class DataProposalPinjaman : Form
    {
        DBPinjaman dbP = new DBPinjaman();
        DataTable dt;
        string id_select = "";

        public DataProposalPinjaman()
        {
            InitializeComponent();
        }

        private void showMaster()
        {
            dt = new DataTable();
            dt = dbP.showDataProposalPinjaman();
            dgvProposalPinjaman.DataSource = dt;
        }

        private void DataProposalPinjaman_Load(object sender, EventArgs e)
        {
            showMaster();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            PengajuanPinjaman tambah = new PengajuanPinjaman();
            tambah.ShowDialog();
            showMaster();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apa anda yakin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dgvProposalPinjaman.SelectedRows)
                {
                    dbP.deleteDataProposalPinjaman(id_select);
                    dgvProposalPinjaman.Rows.RemoveAt(item.Index);
                    showMaster();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPengajuanPinjaman edit = new EditPengajuanPinjaman(id_select);
            edit.ShowDialog();
            showMaster();
        }

        private void dgvProposalPinjaman_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProposalPinjaman.Rows.Count > 0)
            {
                id_select = dgvProposalPinjaman.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apa anda yakin menyetujui pinjaman ini?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbP.updateStatusProposalPinjaman(id_select);
                showMaster();
            }
        }
    }
}
