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
    public partial class TambahNasabah : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        int noNasabah;

        public TambahNasabah()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

            //cmbTanggalPembelian.Value.ToString("yyyy-MM-dd")
            //dateTimePicker1.Value = DateTime.Parse("03/08/2009 06:45:00"); 
            string id_nasabah =txtIDnasabah.Text.ToString();
            string tgl_daftar = dtpTanggalPendaftaran.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show(tgl_daftar);
            string nama = txtNamaNasabah.Text.ToString();
            string jenis_id = cmbJenisID.Text.ToString();
            string no_id = txtNoIDNasabah.Text.ToString();
            string alamat = txtAlamatNasabah.Text.ToString();
            string tempat_lahir = txtTempatLahirNasabah.Text.ToString();
            string tgl_lahir = dtpTanggalLahirNasabah.Text.ToString();
            MessageBox.Show(tgl_lahir);
            string jenis_kelamin = cmbJenisKelamin.Text.ToString();
            string agama = txtAgamaNasabah.Text.ToString();
            string pekerjaan = txtPekerjaanNasabah.Text.ToString();
            string no_telp = txtNoTelepon.Text.ToString();
            string no_hp = txtNoHp.Text.ToString();

            dbCS.addNasabah(id_nasabah, tgl_daftar, nama, jenis_id, no_id, alamat, tempat_lahir, tgl_lahir, jenis_kelamin, agama, pekerjaan, no_telp, no_hp);
            resetEdit();
            MessageBox.Show("Penambahan Sukses");

        }

        private void resetEdit()
        {
            txtIDnasabah.Text = "";
            dtpTanggalPendaftaran.Value = DateTime.Now;
            txtNamaNasabah.Text = "";
            cmbJenisID.Text = "Pilih Jenis Identitas";
            txtNoIDNasabah.Text = "";
            txtAlamatNasabah.Text = "";
            txtTempatLahirNasabah.Text = "";
            dtpTanggalLahirNasabah.Value = DateTime.Now.Date;
            cmbJenisKelamin.Text = "Pilih Jenis Kelamin";
            txtAgamaNasabah.Text = "";
            txtPekerjaanNasabah.Text = "";
            txtNoTelepon.Text = "";
            txtNoHp.Text = "";
        }

        private void TambahNasabah_Load(object sender, EventArgs e)
        {
            //dtpTanggalPendaftaran.Text.ToString("2015-10-17");
            //dtpTanggalPendaftaran.Value = DateTime.Parse("2015-10-17 06:45:00");
            //cmd.CommandText = "INSERT INTO person (birthdate) VALUES('" + dateTimePicker.Value.Date + "')";
            noNasabah = dbCS.getLastNoNasabah() + 1;
            txtIDnasabah.Text = DateTime.Today.Year.ToString().Substring(2,2) + "" + DateTime.Today.Month.ToString("00") + "" + noNasabah.ToString("000000");
        }

        private void btnCariAgama_Click(object sender, EventArgs e)
        {
            CariAgama ag = new CariAgama(txtAgamaNasabah);
            ag.ShowDialog();
        }

        private void btnCariPekerjaan_Click(object sender, EventArgs e)
        {
            CariPekerjaan kerja = new CariPekerjaan(txtPekerjaanNasabah);
            kerja.ShowDialog();
        }
    }
}
