using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koperasi
{
    public partial class ImportNasabah : Form
    {
        DataTable dtImport = new DataTable();
        DBCustomerService dbCS = new DBCustomerService();
        
        public ImportNasabah()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileImport = new OpenFileDialog();
            fileImport.Filter = "XLS files (*.xls, *.xlsx)|*.xls;*.xlsx";
            fileImport.FilterIndex = 2;

            if (fileImport.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fileImport.FileName;
                String path = fileImport.FileName;
                String connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";
                OleDbConnection conn = new OleDbConnection(connStr);
                string strSQL = "SELECT * FROM [Sheet1$]";
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                conn.Open();
                try
                {
                    OleDbDataReader dR = cmd.ExecuteReader();
                    dtImport.Load(dR);
                    dgvImportNasabah.DataSource = dtImport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int noNasabah;
            String IdNasabah = "";
            for (int i = 0; i < dgvImportNasabah.Rows.Count; i++)
            {
                DateTime tglLahir = DateTime.Parse(dgvImportNasabah.Rows[i].Cells[5].Value.ToString());              
                noNasabah = dbCS.getLastNoNasabah() + 1;
                IdNasabah = DateTime.Today.Year.ToString().Substring(2, 2) + "" + DateTime.Today.Month.ToString("00") + "" + noNasabah.ToString("000000");
                dbCS.addNasabah(IdNasabah, DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"),
                                dgvImportNasabah.Rows[i].Cells[0].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[1].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[2].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[3].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[4].Value.ToString(),
                                tglLahir.ToString("yyyy-MM-dd"),
                                dgvImportNasabah.Rows[i].Cells[6].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[7].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[8].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[9].Value.ToString(),
                                dgvImportNasabah.Rows[i].Cells[10].Value.ToString());
                
            }
            MessageBox.Show("Import Sukses");
            this.Close();
        }
    }
}
