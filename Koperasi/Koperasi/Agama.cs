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
    public partial class Agama : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;

        public Agama()
        {
            InitializeComponent();
        }

        public void resetAgama()
        {
            txtID.Text = "";
            txtAgama.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            showAgama();
        }

        public void showAgama()
        {
            dt = new DataTable();
            dt = dbCS.showAgama();
            dgvDataAgama.DataSource = dt;
        }

        private void dgvDataAgama_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvDataAgama.SelectedRows[0].Cells[0].Value.ToString();
            txtAgama.Text = dgvDataAgama.SelectedRows[0].Cells[1].Value.ToString();
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void Agama_Load(object sender, EventArgs e)
        {
            showAgama();
        }

        private void dgvDataAgama_SelectionChanged(object sender, EventArgs e)
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
            string agama = txtAgama.Text.ToString();
            dbCS.addAgama(id, agama);
            resetAgama();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.ToString());
            string agama = txtAgama.Text.ToString();
            dbCS.updateAgama(id, agama);
            resetAgama();
        }
    }
}
