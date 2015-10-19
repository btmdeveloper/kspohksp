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
    public partial class EditPengajuanPinjaman : Form
    {
        DBPinjaman dbP = new DBPinjaman();
        DataTable dt;
        string id;

        public EditPengajuanPinjaman( string id_edit)
        {
            InitializeComponent();
            this.id = id_edit;
        }

        private void EditPengajuanPinjaman_Load(object sender, EventArgs e)
        {
            dt = dbP.showDataProposalPinjamanID(id);

            txtIDPengajuan.Text = dt.Rows[0][0].ToString();
            dtpTanggalPengajuan.Value = DateTime.Parse(dt.Rows[0][1].ToString());
            txtIDNasabah.Text = dt.Rows[0][2].ToString();
            txtPlafon.Text = dt.Rows[0][3].ToString();
            txtJangkaWaktu.Text = dt.Rows[0][4].ToString();
            cmbSatuanWaktu.Text = dt.Rows[0][5].ToString();
            nmrBunga.Value = Decimal.Parse(dt.Rows[0][6].ToString());
            cmbJenisAngsuran.Text = dt.Rows[0][7].ToString();
            txtJumlahAngsuran.Text = dt.Rows[0][8].ToString();
            dtpTanggalPengajuan.Value = DateTime.Parse(dt.Rows[0][1].ToString());
            txtKolektor.Text = dt.Rows[0][10].ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
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
            dbP.editDataProposalPinjaman(id,id_pengajuan, tgl_pengajuan, id_nasabah, plafon, jangka_waktu, satuan_waktu, bunga, jenis_angsuran, jumlah_angsuran, tgl_pembayaran, id_kolektor);
            MessageBox.Show("Penambahan Sukses");
            this.Close();
        }

        private void txtPlafon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtJumlahAngsuran_KeyPress(object sender, KeyPressEventArgs e)
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
            txtPlafon.SelectionStart = str.Length + 1;
        }

        private void txtJumlahAngsuran_TextChanged(object sender, EventArgs e)
        {
            string str = txtJumlahAngsuran.Text;
            txtJumlahAngsuran.Text = string.Format("{0:n0}", double.Parse(txtJumlahAngsuran.Text));
            txtJumlahAngsuran.SelectionStart = str.Length + 1;
        }
    }
}
