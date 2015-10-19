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
    public partial class DeleteHeader : Form
    {
        DBAkunting dbAcc = new DBAkunting();
        DataTable dtHeader;
        String id;
        public DeleteHeader(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DeleteHeader_Load(object sender, EventArgs e)
        {
            dtHeader = dbAcc.showHeaderID(id);
            dgvHeader.Rows.Add(dtHeader.Rows[0][0].ToString(), dtHeader.Rows[0][1].ToString(), dtHeader.Rows[0][2].ToString());
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dbAcc.deleteHeader(id);
            MessageBox.Show("Header telah dihapus");
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
