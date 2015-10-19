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
    public partial class Login : Form
    {
        DBUser dbUser = new DBUser();
        DBSetup dbSetup = new DBSetup();
        DataTable dtUser, dtProfil;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String result = dbUser.loginUser(txtUsername.Text, txtPassword.Text);
            if (result.Equals("1"))
            {
                this.Hide();
                
                dtUser = dbUser.getDataUser(txtUsername.Text, txtPassword.Text);
                GlobalVariabel.id = dtUser.Rows[0][0].ToString();
                GlobalVariabel.nama = dtUser.Rows[0][1].ToString();
                GlobalVariabel.uname = dtUser.Rows[0][2].ToString();
                GlobalVariabel.role = dtUser.Rows[0][4].ToString();
                GlobalVariabel.jabatan = dtUser.Rows[0][5].ToString();
                dbUser.updateLastLogin(GlobalVariabel.id);
                Form1 formMain = new Form1();
                formMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username dan password tidak cocok");
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingKoneksi formSetting = new SettingKoneksi();
            formSetting.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dtProfil = new DataTable();
            dtProfil = dbSetup.selectProfil();
            GlobalVariabel.koperasiNama = dtProfil.Rows[0][0].ToString();
            GlobalVariabel.koperasiBK = dtProfil.Rows[0][1].ToString();
            GlobalVariabel.kopersaiTgl = dtProfil.Rows[0][2].ToString();
            GlobalVariabel.koperasiAlamat = dtProfil.Rows[0][3].ToString();
            GlobalVariabel.koperasiTelp = dtProfil.Rows[0][4].ToString();
            GlobalVariabel.koperasiKabupaten = dtProfil.Rows[0][5].ToString();
            GlobalVariabel.koperasiProvinsi = dtProfil.Rows[0][6].ToString();
            lblNama.Text = GlobalVariabel.koperasiNama;
            lblBk.Text = "BK " + GlobalVariabel.koperasiBK;
        }
    }
}
