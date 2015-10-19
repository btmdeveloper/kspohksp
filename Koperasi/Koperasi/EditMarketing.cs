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
    public partial class EditMarketing : Form
    {
        String id_kolektor;
        DBSetup dbSetup = new DBSetup();
        DataTable dtKolektor;
        public EditMarketing(String id_kolektor)
        {
            InitializeComponent();
            this.id_kolektor = id_kolektor;
        }

        private void EditMarketing_Load(object sender, EventArgs e)
        {
            dtKolektor = new DataTable();
            dtKolektor = dbSetup.showDataKolektorID2(id_kolektor);
            txtId.Text = dtKolektor.Rows[0][0].ToString();
            txtNama.Text = dtKolektor.Rows[0][1].ToString();
            txtAlamat.Text = dtKolektor.Rows[0][2].ToString();
            txtKtp.Text = dtKolektor.Rows[0][3].ToString();
            txtTelp.Text = dtKolektor.Rows[0][4].ToString();
            txtHp.Text = dtKolektor.Rows[0][5].ToString();
            if (dtKolektor.Rows[0][6].ToString() == "1")
            {
                cbStatus.Checked = true;
            }
            else
            {
                cbStatus.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtKtp.Text != "" && txtTelp.Text != "" && txtHp.Text != "")
            {
                String statusAktif = "1";
                dbSetup.updateKolektor(txtId.Text, txtNama.Text, txtAlamat.Text, txtKtp.Text, txtTelp.Text, txtHp.Text, statusAktif, lblFoto.Text);
                txtNama.Text = txtAlamat.Text = txtKtp.Text = txtTelp.Text = txtHp.Text = "";
                lblFoto.Text = "Tidak ada file dipilih";
                cbStatus.Checked = true;
            }
            else
            {
                MessageBox.Show("Data belum lengkap");
            }
        }
    }
}
