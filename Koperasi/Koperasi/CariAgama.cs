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
    public partial class CariAgama : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        TextBox _txtBoxAgama;
        string agamaSelected;

        public CariAgama(TextBox txtBoxAgama)
        {
            InitializeComponent();
            this._txtBoxAgama = txtBoxAgama;
        }

        private void showAgama()
        {
            dt = new DataTable();
            dt = dbCS.showAgama();
            dgvDataAgama.DataSource = dt;
        }

        private void dgvDataAgama_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataAgama.Rows.Count > 0)
            {
                agamaSelected = dgvDataAgama.SelectedRows[0].Cells[1].Value.ToString();
                btnUse.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void CariAgama_Load(object sender, EventArgs e)
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

        private void btnUse_Click(object sender, EventArgs e)
        {
            _txtBoxAgama.Text = agamaSelected;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agama ag = new Agama();
            ag.ShowDialog();
            showAgama();
        }
    }
}
