using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Koperasi
{
    class DBPinjaman
    {
        MySqlConnection con;
        String konfigurasi = "Server=" + GlobalVariabel.server + ";port=" + GlobalVariabel.port + ";UID=" + GlobalVariabel.username + ";PWD=" + GlobalVariabel.password + ";Database=" + GlobalVariabel.database + "; convert zero datetime=True";
        DataTable dt;

        public DataTable showDataPinjaman()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT * FROM pinjaman";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }

        public DataTable showDataProposalPinjaman()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();

            try 
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT * FROM pinjaman_pengajuan WHERE status_disetujui='belum' ORDER BY tanggal_pengajuan";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }

        public DataTable showDataProposalPinjamanID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT * FROM pinjaman_pengajuan WHERE id_pengajuan ='"+ id +"'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }

        public void addDataProposalPinjaman(string id_pengajuan, string tgl_pengajuan, string id_nasabah, string plafon, string jangka_waktu, string satuan_waktu, string bunga, string jenis_angsuran, string jumlah_angsuran, string tanggal_pembayaran, string id_kolektor)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO pinjaman_pengajuan (id_pengajuan, tanggal_pengajuan, id_nasabah, plafon, jangka_waktu, satuan_waktu, bunga, jenis_angsuran, jumlah_angsuran, tanggal_pembayaran, id_kolektor) " +
                                    "VALUES('" + id_pengajuan + "','" + tgl_pengajuan + "','" + id_nasabah + "','" + plafon + "','" + jangka_waktu + "','" + satuan_waktu + "','" + bunga + "','" + jenis_angsuran + "','" + jumlah_angsuran + "','"+ tanggal_pembayaran +"','" + id_kolektor + "')";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void editDataProposalPinjaman(string id, string id_pengajuan, string tgl_pengajuan, string id_nasabah, string plafon, string jangka_waktu, string satuan_waktu, string bunga, string jenis_angsuran, string jumlah_angsuran, string tgl_pembayaran, string id_kolektor)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE pinjaman_pengajuan SET id_pengajuan ='" +id_pengajuan+ "', tanggal_pengajuan ='"+tgl_pengajuan+"', id_nasabah='"+id_nasabah+"', plafon='"+plafon+"', jangka_waktu='"+jangka_waktu+"', satuan_waktu='"+satuan_waktu+"', bunga='"+bunga+"', jenis_angsuran='"+jenis_angsuran+"', jumlah_angsuran='"+jumlah_angsuran+"', tanggal_pembayaran='"+tgl_pembayaran+"', id_kolektor='"+id_kolektor+"'  WHERE id_pengajuan ='" + id + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteDataProposalPinjaman(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "DELETE FROM pinjaman_pengajuan WHERE id_pengajuan = '" + id + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateStatusProposalPinjaman(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();

            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE pinjaman_pengajuan SET status_disetujui='setuju' WHERE id_pengajuan = '" + id + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
