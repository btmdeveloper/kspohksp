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
    public partial class AddUser : Form
    {
        DBSetup dbSetup;
        DataTable dtComboRole, dtPegawai;
        int mode; //1=add; 2=edit
        int lastNo;
        public AddUser(int mode)
        {
            InitializeComponent();
            dbSetup = new DBSetup();
            this.mode = mode;
            dtComboRole = new DataTable();
            dtPegawai = new DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            dtComboRole = dbSetup.getDataRole();
            cbRole.DisplayMember = "role";
            cbRole.ValueMember = "id";
            cbRole.DataSource = dtComboRole;

            if (mode == 1)
            {
                lastNo = dbSetup.getLastNo("user");
                txtId.Text = (lastNo + 1).ToString("00000");
                txtId.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNama.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String statusAktif = "1";
                dbSetup.insertUser(txtId.Text, txtNama.Text, txtUsername.Text, txtPassword.Text, (cbRole.SelectedIndex+1).ToString(), statusAktif);
                txtNama.Text = txtUsername.Text = txtPassword.Text = "";
                cbStatus.Checked = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Data belum lengkap");
            }
        }
    }
}
