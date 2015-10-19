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
    public partial class Akun : Form
    {
        DBAkunting dbAcc = new DBAkunting();
        DataTable dtAkun, dt;

        public Akun()
        {
            InitializeComponent();
        }

        private void Akun_Load(object sender, EventArgs e)
        {
            showData();
        }

        public void showData()
        {
            dtAkun = new DataTable();
            dtAkun = dbAcc.showAkun();
            dgvAkun.DataSource = dtAkun;
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
                dt = dbAcc.showAkunID(id);
                dgvAkun.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbAcc.showAkunNama(nama);
                dgvAkun.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dt = new DataTable();
                string grup = txtSearch.Text.ToString();
                dt = dbAcc.showAkunGrup(grup);
                dgvAkun.DataSource = dt;
            }
        }
    }
}
