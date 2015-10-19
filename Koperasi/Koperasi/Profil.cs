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
    public partial class Profil : Form
    {
        DBSetup setup_model;
        public Profil()
        {
            InitializeComponent();
            setup_model = new DBSetup();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            txtNama.Text = GlobalVariabel.koperasiNama;
            txtBk.Text = GlobalVariabel.koperasiBK;
            //dtpTgl.Value = 
            txtAlamat.Text = GlobalVariabel.koperasiAlamat;
            txtTelp.Text = GlobalVariabel.koperasiTelp;
            txtProvinsi.Text = GlobalVariabel.koperasiProvinsi;
            txtKab.Text = GlobalVariabel.koperasiKabupaten;
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text != "" && txtBk.Text != "" && txtAlamat.Text != "" && txtTelp.Text != "" && txtProvinsi.Text != "" && txtKab.Text != "")
            {
                setup_model.updateProfil(txtNama.Text, txtBk.Text, dtpTgl.Value.ToString("yyyy-MM-dd"), txtAlamat.Text, txtTelp.Text, txtKab.Text, txtProvinsi.Text);
                MessageBox.Show("Data berhasil disimpan\n Restart aplikasi untuk melihat perubahan");
            }
            else 
            {
                MessageBox.Show("Harap lengkapi field!");
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
