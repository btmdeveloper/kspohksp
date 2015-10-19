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
    class DBAkunting
    {
        MySqlConnection con;
        String konfigurasi = "Server=" + GlobalVariabel.server + ";port=" + GlobalVariabel.port + ";UID=" + GlobalVariabel.username + ";PWD=" + GlobalVariabel.password + ";Database=" + GlobalVariabel.database + "";
        DataTable dt;

        public DataTable showHeader()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT h.id_header AS 'ID Header', h.nama AS 'Nama Header', g.`nama` AS 'Grup', h.`keterangan` AS 'Keterangan' FROM akunting_header h " +
                                    "INNER JOIN akunting_grup g ON h.`grup`=g.`id_grup`";
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

        public DataTable showHeaderID(String id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT h.id_header AS 'ID Header', h.nama AS 'Nama Header', g.`nama` AS 'Grup', h.`keterangan` AS 'Keterangan' FROM akunting_header h " +
                                    "INNER JOIN akunting_grup g ON h.`grup`=g.`id_grup` WHERE h.`id_header` LIKE '%" + id + "%'";
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

        public DataTable showHeaderNama(String nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT h.id_header AS 'ID Header', h.nama AS 'Nama Header', g.`nama` AS 'Grup', h.`keterangan` AS 'Keterangan' FROM akunting_header h " +
                                    "INNER JOIN akunting_grup g ON h.`grup`=g.`id_grup` WHERE h.nama LIKE '%" + nama + "%'";
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

        public DataTable showHeaderGrup(String grup)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT h.id_header AS 'ID Header', h.nama AS 'Nama Header', g.`nama` AS 'Grup', h.`keterangan` AS 'Keterangan' FROM akunting_header h " +
                                    "INNER JOIN akunting_grup g ON h.`grup`=g.`id_grup` WHERE g.`nama` LIKE '%" + grup + "%'";
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

        public void addHeader(String nmr, String nama, String grup, String ket)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO akunting_header VALUES('" + nmr + "','" + nama + "','" + grup + "','" + ket + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateHeader(String nmr, String nama, String grup, String ket)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE akunting_header SET id_header='" + nmr + "', nama='" + nama + "', grup='" + grup + "', keterangan='" + ket + "' WHERE id_header='" + nmr + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteHeader(String nmr)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "DELETE FROM akunting_header WHERE id_header='" + nmr + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getGrup()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_grup AS 'ID Grup', nama AS 'Nama' FROM akunting_grup";
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

        public DataTable showAkun()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT a.id_akun AS 'ID Akun', a.nama AS 'Nama Akun', h.nama AS 'Header', a.tipe AS 'Tipe' FROM akunting_akun a "+
                                    "INNER JOIN akunting_header h ON a.header=h.id_header";
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

        public DataTable showAkunID(String id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT a.id_akun AS 'ID Akun', a.nama AS 'Nama Akun', h.nama AS 'Header', a.tipe AS 'Tipe' FROM akunting_akun a " +
                                    "INNER JOIN akunting_header h ON a.header=h.id_header WHERE a.id_akun LIKE '%" + id + "%'";
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

        public DataTable showAkunNama(String nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT a.id_akun AS 'ID Akun', a.nama AS 'Nama Akun', h.nama AS 'Header', a.tipe AS 'Tipe' FROM akunting_akun a " +
                                    "INNER JOIN akunting_header h ON a.header=h.id_header WHERE a.nama LIKE '%" + nama + "%'";
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

        public DataTable showAkunGrup(String header)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT a.id_akun AS 'ID Akun', a.nama AS 'Nama Akun', h.nama AS 'Header', a.tipe AS 'Tipe' FROM akunting_akun a " +
                                    "INNER JOIN akunting_header h ON a.header=h.id_header WHERE h.nama LIKE '%" + header + "%'";
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
    }
}
