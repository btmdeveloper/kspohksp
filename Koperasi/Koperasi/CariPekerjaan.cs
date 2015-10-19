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
    public partial class CariPekerjaan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        TextBox _txtBoxPekerjaan;
        string pekerjaanSelected;

        public CariPekerjaan(TextBox txtBoxPekerjaan)
        {
            InitializeComponent();
            this._txtBoxPekerjaan = txtBoxPekerjaan;
        }

        private void showPekerjaan()
        {
            dt = new DataTable();
            dt = dbCS.showPekerjaan();
            dgvDataPekerjaan.DataSource = dt;
        }

        private void CariPekerjaan_Load(object sender, EventArgs e)
        {
            showPekerjaan();
        }

        private void dgvDataAgama_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataPekerjaan.Rows.Count > 0)
            {
                pekerjaanSelected = dgvDataPekerjaan.SelectedRows[0].Cells[1].Value.ToString();
                btnUse.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Data");
            }
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
            _txtBoxPekerjaan.Text = pekerjaanSelected;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pekerjaan kerja = new Pekerjaan();
            kerja.ShowDialog();
            showPekerjaan();
        }
    }
}
