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
    public partial class AddMarketing : Form
    {
        DBSetup dbSetup;
        DataTable dtKolektor;
        public AddMarketing()
        {
            InitializeComponent();
            dbSetup = new DBSetup();
        }

        private void AddMarketing_Load(object sender, EventArgs e)
        {
            dtKolektor = new DataTable();
            int lastNo = dbSetup.getLastNo("user");
            txtId.Text = "0000" + (lastNo + 1);
            txtId.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtKtp.Text != "" && txtTelp.Text != "" && txtHp.Text != "")
            {
                String statusAktif = "1";
                dbSetup.insertKolektor(txtId.Text, txtNama.Text, txtAlamat.Text, txtKtp.Text, txtTelp.Text, txtHp.Text, statusAktif, lblFoto.Text);
                txtNama.Text = txtAlamat.Text = txtKtp.Text = txtTelp.Text = txtHp.Text = "";
                lblFoto.Text = "Tidak ada file dipilih";
                cbStatus.Checked = true;
            }
            else
            {
                MessageBox.Show("Data belum lengkap");
            }
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Pilih file foto";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                openFileDialog1.Dispose();
            }
        }
    }
}
