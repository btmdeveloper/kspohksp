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
    public partial class PenarikanSimpanan : Form
    {
        DBCustomerService dbCS = new DBCustomerService();

        public PenarikanSimpanan()
        {
            InitializeComponent();
        }

        private void PenarikanSimpanan_Load(object sender, EventArgs e)
        {
            int noTransaksi = dbCS.getLastNoPenarikan() + 1;
            txtIDTransaksi.Text = "PS-" + DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noTransaksi.ToString("000000");
        }

        private void btnCariSimpanan_Click(object sender, EventArgs e)
        {
            CariNasabahSetoran simpanan = new CariNasabahSetoran(2, txtNoNasabah, txtNoSimpanan, txtSaldo);
            simpanan.ShowDialog();
        }
    }
}
