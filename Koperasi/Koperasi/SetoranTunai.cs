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
    public partial class SetoranTunai : Form
    {
        DBCustomerService dbCS = new DBCustomerService();

        public SetoranTunai()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id_setoran, tanggal_setoran, id_nasabah, id_simpanan;
            double saldo_awal, nominal_setoran, saldo_akhir;
            string penyetor, keterangan;

            id_setoran = txtIDSetoran.Text.ToString();
            tanggal_setoran = dtpTanggalSetoran.Value.ToString("yyyy-MM-dd HH:mm:ss");
            id_nasabah = txtIDNasabah.Text.ToString();
            id_simpanan = txtIDSimpanan.Text.ToString();
            saldo_awal = Convert.ToDouble(txtSaldo.Text.ToString());
            nominal_setoran = Convert.ToDouble(txtNominalSetoran.Text.ToString());
            saldo_akhir = saldo_awal + nominal_setoran;
            penyetor = txtPenyetor.Text.ToString();
            keterangan = txtKeterangan.Text.ToString();

            dbCS.addDataSetoran(id_setoran, tanggal_setoran, id_nasabah, id_simpanan, saldo_awal, nominal_setoran, saldo_akhir, penyetor, keterangan);
            dbCS.updateSaldo(id_simpanan, saldo_akhir);
            resetSetoran();
        }

        private void resetSetoran()
        {
            int noSetoran = dbCS.getLastNoSetoran() + 1;
            txtIDSetoran.Text = "ST-" + DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noSetoran.ToString("000000");
            dtpTanggalSetoran.Value = DateTime.Now;
            txtIDSimpanan.Text = "";
            txtIDNasabah.Text = "";
            txtNamaNasabah.Text = "";
            txtAlamatNasabah.Text = "";
            txtSaldo.Text = "0";
            txtNominalSetoran.Text = "0";
            txtPenyetor.Text = "";
            radioKolektor.Checked = false;
            radioNasabah.Checked = false;
            txtKeterangan.Text = "";
        }

        private void SetoranTunai_Load(object sender, EventArgs e)
        {
            int noSetoran = dbCS.getLastNoSetoran() + 1;
            txtIDSetoran.Text = "ST-" + DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noSetoran.ToString("000000");
        }

        private void btnCariNasabah_Click(object sender, EventArgs e)
        {
            CariNasabahSetoran cari = new CariNasabahSetoran(1,txtIDNasabah,txtIDSimpanan,txtNamaNasabah,txtAlamatNasabah,txtSaldo);
            cari.ShowDialog();
            cekBox();
        }

        private void cekBox()
        {
            if (radioNasabah.Checked == true)
            {
                txtPenyetor.Text = txtIDNasabah.Text.ToString();
                btnSearchPenyetor.Visible = false;
            }
            else if (radioKolektor.Checked == true)
            {
                txtPenyetor.Text = "";
                btnSearchPenyetor.Visible = true;
            }
        }

        private void radioNasabah_CheckedChanged(object sender, EventArgs e)
        {
            cekBox();
        }

        private void radioKolektor_CheckedChanged(object sender, EventArgs e)
        {
            cekBox();
        }

        private void btnSearchPenyetor_Click(object sender, EventArgs e)
        {
            CariKolektor kolektor = new CariKolektor(2, txtPenyetor);
            kolektor.ShowDialog();
        }
    }
}
