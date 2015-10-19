using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;


namespace Koperasi
{
    public partial class DataNasabah : Form
    {
        DBCustomerService dbCS = new DBCustomerService();
        DataTable dt;
        string id_edit = "";

        public DataNasabah()
        {
            InitializeComponent();
        }

        private void DataNasabah_Load(object sender, EventArgs e)
        {
            ShowMaster();
        }

        private void ShowMaster()
        {
            dt = new DataTable();
            dt = dbCS.showDataNasabah();
            dgvDataNasabah.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TambahNasabah tambah = new TambahNasabah();
            tambah.ShowDialog();
            ShowMaster();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditNasabah edit = new EditNasabah(id_edit);
            edit.ShowDialog();
            ShowMaster();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 0)
            {
                ShowMaster();
            }
            else if (cmbSorting.SelectedIndex == 1)
            {
                dt = new DataTable();
                string id = txtSearch.Text.ToString();
                dt = dbCS.showDataNasabahID(id);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 2)
            {
                dt = new DataTable();
                string nama = txtSearch.Text.ToString();
                dt = dbCS.showDataNasabahNama(nama);
                dgvDataNasabah.DataSource = dt;
            }
            else if (cmbSorting.SelectedIndex == 3)
            {
                dt = new DataTable();
                string tgl = dtpSearch.Text.ToString();
                dt = dbCS.showDataNasabahTanggal(tgl);
                dgvDataNasabah.DataSource = dt;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowMaster();
            }
        }

        private void dgvDataNasabah_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDataNasabah.Rows.Count > 0)
            {
                id_edit = dgvDataNasabah.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportNasabah formImport = new ImportNasabah();
            formImport.ShowDialog();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i <= dGV.RowCount-1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Data Nasabah.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dgvDataNasabah, sfd.FileName); // Here dataGridview1 is your grid view name
            }
            MessageBox.Show("Eksport Berhasil");

        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex == 3)
            {
                txtSearch.Visible = false;
                dtpSearch.Visible = true;
                dtpSearch.Location = new Point(150, 12);
            }
            else if (cmbSorting.SelectedIndex == 0)
            {
                txtSearch.Visible = true;
                dtpSearch.Visible = false;

                txtSearch.Text = "";
                ShowMaster();
            }
            else
            {
                txtSearch.Visible = true;
                dtpSearch.Visible = false;
            }
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMaster();
        }  

    }
}
