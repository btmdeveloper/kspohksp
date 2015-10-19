using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Koperasi
{
    public partial class PengajuanPinjaman : Form
    {
        DBPinjaman dbP = new DBPinjaman();

        public PengajuanPinjaman()
        {
            InitializeComponent();
        }

        private void btnPengajuanPinjaman_Click(object sender, EventArgs e)
        {
            string id_pengajuan = txtIDPengajuan.Text.ToString();
            string tgl_pengajuan = dtpTanggalPengajuan.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string id_nasabah = txtIDNasabah.Text.ToString();
            string plafon = Decimal.Parse(txtPlafon.Text.ToString(), NumberStyles.Currency).ToString();
            string jangka_waktu = txtJangkaWaktu.Text.ToString();
            string satuan_waktu = cmbSatuanWaktu.Text.ToString();
            string bunga = nmrBunga.Text.ToString();
            string jenis_angsuran = cmbJenisAngsuran.Text.ToString();
            string jumlah_angsuran = Decimal.Parse(txtJumlahAngsuran.Text.ToString(), NumberStyles.Currency).ToString();
            string tgl_pembayaran = dpTanggalPembayaran.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string id_kolektor = txtKolektor.Text.ToString();
            dbP.addDataProposalPinjaman(id_pengajuan, tgl_pengajuan, id_nasabah, plafon, jangka_waktu, satuan_waktu, bunga, jenis_angsuran, jumlah_angsuran, tgl_pembayaran, id_kolektor);
            MessageBox.Show("Penambahan Sukses");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJumlahAngsuran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPlafon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPlafon_TextChanged(object sender, EventArgs e)
        {
            string str = txtPlafon.Text;
            txtPlafon.Text = string.Format("{0:n0}", double.Parse(txtPlafon.Text));
            txtPlafon.SelectionStart =str.Length + 1;
        }

        private void txtJumlahAngsuran_TextChanged(object sender, EventArgs e)
        {
            string str = txtJumlahAngsuran.Text;
            txtJumlahAngsuran.Text = string.Format("{0:n0}", double.Parse(txtJumlahAngsuran.Text));
            txtJumlahAngsuran.SelectionStart = str.Length + 1;
        }
    }
}
