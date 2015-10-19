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
    public partial class ManageHeader : Form
    {
        DBAkunting dbAcc = new DBAkunting();
        DataTable dtGrup, dtHeader;
        int mode;
        String id;
        public ManageHeader(int mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        public void resetField()
        {
            dtGrup = new DataTable();
            dtGrup = dbAcc.getGrup();
            cmbGrup.ValueMember = "ID Grup";
            cmbGrup.DisplayMember = "Nama";
            cmbGrup.DataSource = dtGrup;

            txtNmr.Clear();
            txtNama.Clear();
            txtKet.Clear();
        }

        public ManageHeader(int mode, String id)
        {
            InitializeComponent();
            this.mode = mode;
            this.id = id;
        }

        private void ManageHeader_Load(object sender, EventArgs e)
        {
            //label1.Text = (mode == 1) ? "Tambah Header" : "Edit Header";
            resetField();
            if (mode == 1)
            {
                label1.Text = "Tambah Header";
            }
            else if (mode == 2)
            {
                label1.Text = "Edit Header";
                dtHeader = dbAcc.showHeaderID(id);
                txtNmr.Text = dtHeader.Rows[0][0].ToString();
                txtNama.Text = dtHeader.Rows[0][1].ToString();
                txtKet.Text = dtHeader.Rows[0][3].ToString();
                cmbGrup.SelectedIndex = cmbGrup.FindStringExact(dtHeader.Rows[0][2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (txtNmr.Text != "" && txtNama.Text != "")
                {
                    dbAcc.addHeader(txtNmr.Text, txtNama.Text, (cmbGrup.SelectedIndex + 1).ToString(), txtKet.Text);
                    resetField();
                }
                else 
                {
                    MessageBox.Show("Lengkapi data!");
                }
            }
            else if (mode == 2)
            {
                MessageBox.Show(cmbGrup.SelectedIndex.ToString());
            }
        }
    }
}
