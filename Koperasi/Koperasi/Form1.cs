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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Home formHome = new Home();
            formHome.MdiParent = this;
            formHome.StartPosition = FormStartPosition.CenterScreen;
            formHome.Show();
        }

        private void simpananAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            DataSimpanan formSimpanan = new DataSimpanan();
            formSimpanan.MdiParent = this;
            formSimpanan.StartPosition = FormStartPosition.CenterScreen;
            formSimpanan.Show();
        }

        private void setoranAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            SetoranSimpanan formSetoran = new SetoranSimpanan();
            formSetoran.MdiParent = this;
            formSetoran.StartPosition = FormStartPosition.CenterScreen;
            formSetoran.Show();
        }

        private void tarikanAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Penarikan formPenarikan = new Penarikan();
            formPenarikan.MdiParent = this;
            formPenarikan.StartPosition = FormStartPosition.CenterScreen;
            formPenarikan.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                Home formHome = new Home();
                formHome.MdiParent = this;
                formHome.StartPosition = FormStartPosition.CenterScreen;
                formHome.Show();
            }
            userToolStripMenuItem1.Text = GlobalVariabel.uname;
        }

        private void toolStripAkunting_ButtonClick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text =  DateTime.Today.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void pinjamanAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            DataPinjaman formSimpanan = new DataPinjaman();
            formSimpanan.MdiParent = this;
            formSimpanan.StartPosition = FormStartPosition.CenterScreen;
            formSimpanan.Show();
        }

        private void pengajuanPinjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void invoiceAktifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceJatuhTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceAkanDatangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembayaranAngsuranToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jurnalUmumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bukuBesarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rugiLabaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neracaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Profil formProfil = new Profil();
            formProfil.MdiParent = this;
            formProfil.StartPosition = FormStartPosition.CenterScreen;
            formProfil.Show();
        }

        private void dataNasabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            DataNasabah formMarketing = new DataNasabah();
            formMarketing.MdiParent = this;
            formMarketing.StartPosition = FormStartPosition.CenterScreen;
            formMarketing.Show();
        }

        private void manajemenUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ManageUser formUser = new ManageUser();
            formUser.MdiParent = this;
            formUser.StartPosition = FormStartPosition.CenterScreen;
            formUser.Show();
        }

        private void dataKolektorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Marketing formMarketing = new Marketing();
            formMarketing.MdiParent = this;
            formMarketing.StartPosition = FormStartPosition.CenterScreen;
            formMarketing.Show();
        }

    }
}
