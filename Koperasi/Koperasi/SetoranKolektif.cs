using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Koperasi
{
    public partial class SetoranKolektif : Form
    {
        DBCustomerService dbCS = new DBCustomerService();

        public SetoranKolektif()
        {
            InitializeComponent();
        }

        public void resetSetoranKolektif()
        {
            txtIDNasabah.Text = "";
            txtIDSimpanan.Text = "";
            txtSaldo.Text = "0";
            txtNominal.Text = "0";
            txtKeterangan.Text = "";
            

            btnTambah.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            btnCariNasabah.Focus();
        }

        private void btnCariKolektor_Click(object sender, EventArgs e)
        {
            CariKolektor cariKolektor = new CariKolektor(1, txtIDKolektor, txtNamaKolektor);
            cariKolektor.ShowDialog();
        }

        private void btnCariNasabah_Click(object sender, EventArgs e)
        {
            CariNasabahSetoran cariNasabah = new CariNasabahSetoran(2,txtIDNasabah,txtIDSimpanan,txtSaldo);
            cariNasabah.ShowDialog();
            txtNominal.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int n = dgvDataSetoran.Rows.Add();

            dgvDataSetoran.Rows[n].Cells[0].Value = txtIDNasabah.Text.ToString();
            dgvDataSetoran.Rows[n].Cells[1].Value = txtIDSimpanan.Text.ToString();
            dgvDataSetoran.Rows[n].Cells[2].Value = txtSaldo.Text.ToString();
            dgvDataSetoran.Rows[n].Cells[3].Value = txtNominal.Text.ToString();
            dgvDataSetoran.Rows[n].Cells[4].Value = txtKeterangan.Text.ToString();

            resetSetoranKolektif();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvDataSetoran.SelectedRows[0].Cells[0].Value = txtIDNasabah.Text.ToString();
            dgvDataSetoran.SelectedRows[0].Cells[1].Value = txtIDSimpanan.Text.ToString();
            dgvDataSetoran.SelectedRows[0].Cells[2].Value = txtSaldo.Text.ToString();
            dgvDataSetoran.SelectedRows[0].Cells[3].Value = txtNominal.Text.ToString();
            dgvDataSetoran.SelectedRows[0].Cells[4].Value = txtKeterangan.Text.ToString();

            resetSetoranKolektif();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin menghapus setoran ini?", "Peringatan", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                //MessageBox.Show("tidak jadi hapus data");
            }
            else
            {
                foreach (DataGridViewRow item in this.dgvDataSetoran.SelectedRows)
                {
                    dgvDataSetoran.Rows.RemoveAt(item.Index);
                }
            }

            resetSetoranKolektif();
        }

        private void dgvDataSetoran_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataSetoran.Rows.Count > 0)
            {
                txtIDNasabah.Text = dgvDataSetoran.SelectedRows[0].Cells[0].Value.ToString();
                txtIDSimpanan.Text = dgvDataSetoran.SelectedRows[0].Cells[1].Value.ToString();
                txtSaldo.Text = dgvDataSetoran.SelectedRows[0].Cells[2].Value.ToString();
                txtNominal.Text = dgvDataSetoran.SelectedRows[0].Cells[3].Value.ToString();

                btnTambah.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
                txtNominal.Focus();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void dgvDataSetoran_SelectionChanged(object sender, EventArgs e)
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id_setoran, tanggal_setoran, id_nasabah, id_simpanan;
            double saldo_awal, nominal_setoran, saldo_akhir;
            string penyetor, keterangan;

            tanggal_setoran = dtpTanggalSetoran.Value.ToString("yyyy-MM-dd HH:mm:ss");
            penyetor = txtIDKolektor.Text.ToString();

            int rows = dgvDataSetoran.Rows.Count;
            int i=0;
            do
            {
                int noSetoran = dbCS.getLastNoSetoran() + 1;
                id_setoran = "ST-" + DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noSetoran.ToString("000000");

                id_nasabah = dgvDataSetoran.Rows[i].Cells[0].Value.ToString();
                id_simpanan = dgvDataSetoran.Rows[i].Cells[1].Value.ToString();
                saldo_awal = Convert.ToDouble(dgvDataSetoran.Rows[i].Cells[2].Value.ToString());
                nominal_setoran = Convert.ToDouble(dgvDataSetoran.Rows[i].Cells[3].Value.ToString());
                saldo_akhir = saldo_awal + nominal_setoran;
                keterangan = dgvDataSetoran.Rows[i].Cells[4].Value.ToString();

                dbCS.addDataSetoran(id_setoran, tanggal_setoran, id_nasabah, id_simpanan, saldo_awal, nominal_setoran, saldo_akhir, penyetor, keterangan);
                dbCS.updateSaldo(id_simpanan, saldo_akhir);

                i++;
            } while (i < rows);

            dgvDataSetoran.Rows.Clear();
            dgvDataSetoran.Refresh();

            dtpTanggalSetoran.Value = DateTime.Now;
            txtIDKolektor.Text = "";
            txtNamaKolektor.Text = "";
            resetSetoranKolektif();
        }
    }
}
