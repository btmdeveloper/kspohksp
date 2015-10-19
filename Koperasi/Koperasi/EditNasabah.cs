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
    public partial class EditNasabah : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        string id;

        public EditNasabah(string id_edit)
        {
            InitializeComponent();
            this.id = id_edit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id_nasabah = txtIDnasabah.Text.ToString();
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

            dbCS.updateNasabah(id_nasabah, tgl_daftar, nama, jenis_id, no_id, alamat, tempat_lahir, tgl_lahir, jenis_kelamin, agama, pekerjaan, no_telp, no_hp);
            this.Close();
        }

        private void EditNasabah_Load(object sender, EventArgs e)
        {
            dt = dbCS.showDataNasabahID(id);
            //cmbTanggalPembelian.Value.ToString("yyyy-MM-dd")
            //dateTimePicker1.Value = DateTime.Parse("03/08/2009 06:45:00"); 
            //dtpTanggalPendaftaran.Value = DateTime.Parse("2015-10-17 06:45:00");
            txtIDnasabah.Text=dt.Rows[0][0].ToString();
            dtpTanggalPendaftaran.Value = DateTime.Parse(dt.Rows[0][1].ToString());
            txtNamaNasabah.Text=dt.Rows[0][2].ToString();
            cmbJenisID.Text=dt.Rows[0][3].ToString();
            txtNoIDNasabah.Text=dt.Rows[0][4].ToString();
            txtAlamatNasabah.Text=dt.Rows[0][5].ToString();
            txtTempatLahirNasabah.Text=dt.Rows[0][6].ToString();
            dtpTanggalLahirNasabah.Value = DateTime.Parse(dt.Rows[0][7].ToString());
            cmbJenisKelamin.Text=dt.Rows[0][8].ToString();
            txtAgamaNasabah.Text=dt.Rows[0][9].ToString();
            txtPekerjaanNasabah.Text=dt.Rows[0][10].ToString();
            txtNoTelepon.Text=dt.Rows[0][11].ToString();
            txtNoHp.Text = dt.Rows[0][12].ToString();
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
