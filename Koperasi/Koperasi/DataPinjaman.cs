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
    public partial class DataPinjaman : Form
    {
        public DataPinjaman()
        {
            InitializeComponent();
        }

        private void btnPengajuanPinjaman_Click(object sender, EventArgs e)
        {
            PengajuanPinjaman pinjam = new PengajuanPinjaman();
            pinjam.ShowDialog();
        }
    }
}
