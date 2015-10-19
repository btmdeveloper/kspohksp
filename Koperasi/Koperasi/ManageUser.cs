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
    public partial class ManageUser : Form
    {
        DataTable dtUser;
        DBSetup dbSetup = new DBSetup();
        String id_edit = "";

        public ManageUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser formAdd = new AddUser(1);
            formAdd.ShowDialog();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            showData();
        }

        public void showData()
        {
            dtUser = new DataTable();
            dtUser = dbSetup.showDataUser();
            dgvUser.DataSource = dtUser;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                showData();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dtUser = new DataTable();
                string id = txtSearch.Text.ToString();
                dtUser = dbSetup.showDataUserID(id);
                dgvUser.DataSource = dtUser;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dtUser = new DataTable();
                string nama = txtSearch.Text.ToString();
                dtUser = dbSetup.showDataUserNama(nama);
                dgvUser.DataSource = dtUser;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dtUser = new DataTable();
                string tugas = txtSearch.Text.ToString();
                dtUser = dbSetup.showDataUserTugas(tugas);
                dgvUser.DataSource = dtUser;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showData();
            }
        }

        private void dgvUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvUser.Rows.Count > 0)
            {
                id_edit = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
