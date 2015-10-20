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
    public partial class BungaSimpanan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();

        public BungaSimpanan()
        {
            InitializeComponent();
        }

        private void resetBunga()
        {
            txtIDBungaSimpanan.Text = "";
            txtIDNasabah.Text = "";
            txtIDSimpanan.Text = "";
            txtSaldoAwal.Text = "0";
            txtJumlahBunga.Text = "0";
            txtSaldoAkhir.Text = "0";
            dtpTanggalBunga.Value = DateTime.Now;
            nmrBunga.Value = 0;
        }

        private void btnCariSimpanan_Click(object sender, EventArgs e)
        {
            CariNasabahSetoran cari = new CariNasabahSetoran(2, txtIDNasabah, txtIDSimpanan, txtSaldoAwal);
            cari.ShowDialog();
            nmrBunga.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id_bunga, tgl, id_nasabah, id_simpanan;
            double persen_bunga, saldo_awal, jml_bunga, saldo_akhir;

            id_bunga = txtIDBungaSimpanan.Text.ToString();
            tgl = dtpTanggalBunga.Value.ToString("yyyy-MM-dd HH:mm:ss");
            id_nasabah = txtIDNasabah.Text.ToString();
            id_simpanan = txtIDSimpanan.Text.ToString();
            saldo_awal = Convert.ToDouble(txtSaldoAwal.Text.ToString());
            persen_bunga = Convert.ToDouble(nmrBunga.Value.ToString());
            jml_bunga = Convert.ToDouble(txtJumlahBunga.Text.ToString());
            saldo_akhir = Convert.ToDouble(txtSaldoAkhir.Text.ToString());

            dbCS.addBungaSimpanan(id_bunga, tgl, id_nasabah, id_simpanan, persen_bunga, saldo_awal, jml_bunga, saldo_akhir);
            dbCS.updateSaldo(id_simpanan, saldo_akhir);
            resetBunga();
        }

        private void hitungJumlahBunga()
        {
            double saldo_awal, persen_bunga, jml_bunga;
            saldo_awal = Convert.ToDouble(txtSaldoAwal.Text.ToString());
            persen_bunga = Convert.ToDouble(nmrBunga.Value.ToString());

            jml_bunga = saldo_awal * (persen_bunga / 100);
            txtJumlahBunga.Text = Convert.ToString(jml_bunga.ToString());
        }

        private void hitungSaldoAkhir()
        {
            double saldo_awal, jml_bunga, saldo_akhir;
            saldo_awal = Convert.ToDouble(txtSaldoAwal.Text.ToString());
            jml_bunga = Convert.ToDouble(txtJumlahBunga.Text.ToString());

            saldo_akhir = saldo_awal + jml_bunga;
            txtSaldoAkhir.Text = Convert.ToString(saldo_akhir.ToString());
        }

        private void nmrBunga_ValueChanged(object sender, EventArgs e)
        {
            hitungJumlahBunga();
        }

        private void txtJumlahBunga_TextChanged(object sender, EventArgs e)
        {
            hitungSaldoAkhir();
        }

        private void txtSaldoAwal_TextChanged(object sender, EventArgs e)
        {
            hitungJumlahBunga();
        }

    }
}
