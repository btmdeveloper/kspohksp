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
    public partial class TambahDataSimpanan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();

        public TambahDataSimpanan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //decimal d = NumericUpDown.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCariNasabah_Click(object sender, EventArgs e)
        {
            CariNasabah cari = new CariNasabah(txtIDNasabah);
            cari.ShowDialog();
        }

        private void TambahDataSimpanan_Load(object sender, EventArgs e)
        {
            int noSimpanan = dbCS.getLastNoSimpanan() + 1;
            txtIDSimpanan.Text = "SA-" + DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noSimpanan.ToString("000000");
        }
    }
}
