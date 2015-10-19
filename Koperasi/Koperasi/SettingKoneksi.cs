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
    public partial class SettingKoneksi : Form
    {
        public SettingKoneksi()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != "" && txtPort.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtDb.Text != "")
            {
                GlobalVariabel.server = txtServer.Text;
                GlobalVariabel.port = txtPort.Text;
                GlobalVariabel.username = txtUsername.Text;
                GlobalVariabel.password = txtPassword.Text;
                GlobalVariabel.database = txtDb.Text;
                MessageBox.Show("Setting berhasil");
                this.Close();
            }
            else 
            {
                MessageBox.Show("lengkapi konfigurasi!");
            }
        }
    }
}
