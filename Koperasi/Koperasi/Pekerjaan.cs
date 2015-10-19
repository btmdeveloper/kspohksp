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
    public partial class Pekerjaan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;

        public Pekerjaan()
        {
            InitializeComponent();
        }

        private void resetPekerjaan()
        {
            txtID.Text = "";
            txtPekerjaan.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            showPekerjaan();
        }

        private void showPekerjaan()
        {
            dt = new DataTable();
            dt = dbCS.showPekerjaan();
            dgvDataPekerjaan.DataSource = dt;
        }

        private void Pekerjaan_Load(object sender, EventArgs e)
        {
            showPekerjaan();
        }

        private void dgvDataPekerjaan_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvDataPekerjaan.SelectedRows[0].Cells[0].Value.ToString();
            txtPekerjaan.Text = dgvDataPekerjaan.SelectedRows[0].Cells[1].Value.ToString();
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void dgvDataPekerjaan_SelectionChanged(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.ToString());
            string pekerjaan = txtPekerjaan.Text.ToString();
            dbCS.addPekerjaan(id, pekerjaan);
            resetPekerjaan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.ToString());
            string pekerjaan = txtPekerjaan.Text.ToString();
            dbCS.updatePekerjaan(id, pekerjaan);
            resetPekerjaan();
        }
    }
}
