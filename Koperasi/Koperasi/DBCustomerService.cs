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
    class DBCustomerService
    {
        MySqlConnection con;
        String konfigurasi = "Server=" + GlobalVariabel.server + ";port=" + GlobalVariabel.port + ";UID=" + GlobalVariabel.username + ";PWD=" + GlobalVariabel.password + ";Database=" + GlobalVariabel.database + "; convert zero datetime=True";
        DataTable dt;

        public DataTable showDataNasabah()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_nasabah AS 'ID', tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah ORDER BY tanggal_daftar DESC";//+
                    //"WHERE DATE(tanggal_daftar)=CURDATE()";
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

        public DataTable cariDataNasabah()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_nasabah AS 'ID', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah ";
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

        public DataTable cariDtNasabah()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah "+
                    "WHERE nasabah.id_nasabah NOT IN (SELECT id_nasabah FROM simpanan)";
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


        public DataTable cariDataNasabahID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp' " +
                    "FROM nasabah "+
                    "WHERE nasabah.id_nasabah NOT IN (SELECT id_nasabah FROM simpanan) AND nasabah.id_nasabah LIKE '%" + id + "%'";
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

        public DataTable cariDataNasabahNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah " +
                    "WHERE nasabah.id_nasabah NOT IN (SELECT id_nasabah FROM simpanan) AND nama_nasabah LIKE '%" + nama + "%'";
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

        public DataTable cariDataNasabahTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah " +
                    "WHERE nasabah.id_nasabah NOT IN (SELECT id_nasabah FROM simpanan) AND DATE(nasabah.tanggal_daftar) = '" + tanggal + "'";
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

        public DataTable cariDataNasabahSetoran()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', simpanan.id_simpanan AS 'ID Simpanan', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', alamat AS 'Alamat', simpanan.saldo AS 'Saldo'" +
                    "FROM nasabah INNER JOIN simpanan " +
                    "WHERE nasabah.id_nasabah = simpanan.id_nasabah";
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


        public DataTable cariDataNasabahSetoranID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', simpanan.id_simpanan AS 'ID Simpanan', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat', simpanan.saldo AS 'Saldo' " +
                    "FROM nasabah INNER JOIN simpanan " +
                    "WHERE nasabah.id_nasabah = simpanan.id_nasabah AND nasabah.id_nasabah LIKE '%" + id + "%'";
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

        public DataTable cariDataNasabahSetoranNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', simpanan.id_simpanan AS 'ID Simpanan', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat', simpanan.saldo AS 'Saldo' " +
                    "FROM nasabah INNER JOIN simpanan " +
                    "WHERE nasabah.id_nasabah = simpanan.id_nasabah AND nama_nasabah LIKE '%" + nama + "%'";
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

        public DataTable cariDataNasabahSetoranTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT nasabah.id_nasabah AS 'ID', simpanan.id_simpanan AS 'ID Simpanan', nasabah.tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat', simpanan.saldo AS 'Saldo' " +
                    "FROM nasabah INNER JOIN simpanan " +
                    "WHERE nasabah.id_nasabah = simpanan.id_nasabah AND DATE(nasabah.tanggal_daftar) = '" + tanggal + "'";
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

        public DataTable cariDataKolektor()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'Telp', no_hp AS 'HP' "+
                                    "FROM kolektor WHERE STATUS = '1'";
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

        public DataTable cariDataKolektorID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'Telp', no_hp AS 'HP' " +
                                    "FROM kolektor WHERE STATUS = '1' AND id_kolektor LIKE '%" + id + "%'";
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

        public DataTable cariDataKolektorNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'Telp', no_hp AS 'HP' " +
                                    "FROM kolektor WHERE STATUS = '1' AND nama LIKE '%" + nama + "%'";
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

        public DataTable showDataNasabahID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_nasabah AS 'ID', tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp' " +
                    "FROM nasabah " +
                    "WHERE nasabah.id_nasabah LIKE '%" + id + "%'";
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

        public DataTable showDataNasabahNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_nasabah AS 'ID', tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah " +
                    "WHERE nama_nasabah LIKE '%" + nama + "%'";
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

        public DataTable showDataNasabahTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_nasabah AS 'ID', tanggal_daftar AS 'Tanggal Daftar', nama_nasabah AS 'Nama Nasabah', jenis_id AS 'Jenis ID', no_id AS 'No ID', alamat AS 'Alamat'," +
                    "tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', pekerjaan AS 'Pekerjaan', no_telp AS 'No Telepon', no_hp AS 'No Hp'" +
                    "FROM nasabah " +
                    "WHERE DATE(tanggal_daftar) = '" + tanggal + "'";
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


        public void addNasabah(string id, string tgl_daftar, string nama, string jenis_id, string no_id, string alamat, string tempat_lahir, string tgl_lahir, string jenis_kelamin, string agama, string pekerjaan, string no_telp, string no_hp)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO nasabah (id_nasabah, tanggal_daftar, nama_nasabah, jenis_id, no_id, alamat, tempat_lahir, tanggal_lahir, jenis_kelamin, agama, pekerjaan, no_telp, no_hp) " +
                                    "VALUES('" + id + "','" + tgl_daftar + "','" + nama + "','" + jenis_id + "','" + no_id + "','" + alamat + "','" + tempat_lahir + "','" + tgl_lahir + "','" + jenis_kelamin + "','" + agama + "','" + pekerjaan + "','" + no_telp + "','" + no_hp + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateNasabah(string id, string tgl_daftar, string nama, string jenis_id, string no_id, string alamat, string tempat_lahir, string tgl_lahir, string jenis_kelamin, string agama, string pekerjaan, string no_telp, string no_hp)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE nasabah SET tanggal_daftar='" + tgl_daftar + "',nama_nasabah='" + nama + "',jenis_id='" + jenis_id + "',no_id='" + no_id + "',alamat='" + alamat + "',tempat_lahir='" + tempat_lahir + "',"+
                                    "tanggal_lahir='" + tgl_lahir + "',jenis_kelamin='" + jenis_kelamin + "',agama='" + agama + "',pekerjaan='" + pekerjaan + "',no_telp='" + no_telp + "',no_hp='" + no_hp + "'"+
                                    "WHERE id_nasabah='" + id + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int getLastNoNasabah()
        {
            dt = new DataTable();
            int result = 0;
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT CONVERT(SUBSTRING(MAX(id_nasabah), 5), SIGNED INTEGER) AS lastNo FROM nasabah " +
                                    "WHERE CONVERT(SUBSTRING(id_nasabah, 1,2), SIGNED INTEGER)=SUBSTRING(YEAR(NOW()), 3,2) AND " +
                                    "CONVERT(SUBSTRING(id_nasabah, 3,2), SIGNED INTEGER)=MONTH(NOW())";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = (dt.Rows[0][0].ToString() == "") ? 0 : int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public int getLastNoSimpanan()
        {
            dt = new DataTable();
            int result = 0;
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT CONVERT(SUBSTRING(MAX(id_simpanan), 8), SIGNED INTEGER) AS lastNo FROM simpanan "+
                                    "WHERE CONVERT(SUBSTRING(id_simpanan, 4,2), SIGNED INTEGER)=SUBSTRING(YEAR(NOW()), 3,2) AND "+
                                    "CONVERT(SUBSTRING(id_simpanan, 6,2), SIGNED INTEGER)=MONTH(NOW())";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = (dt.Rows[0][0].ToString() == "") ? 0 : int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public int getLastNoProposalPinjaman()
        {
            dt = new DataTable();
            int result = 0;
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT CONVERT(SUBSTRING(MAX(id_simpanan), 8), SIGNED INTEGER) AS lastNo FROM simpanan " +
                                    "WHERE CONVERT(SUBSTRING(id_simpanan, 4,2), SIGNED INTEGER)=SUBSTRING(YEAR(NOW()), 3,2) AND " +
                                    "CONVERT(SUBSTRING(id_simpanan, 6,2), SIGNED INTEGER)=MONTH(NOW())";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = (dt.Rows[0][0].ToString() == "") ? 0 : int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public int getLastNoSetoran()
        {
            dt = new DataTable();
            int result = 0;
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT CONVERT(SUBSTRING(MAX(id_setoran), 8), SIGNED INTEGER) AS lastNo FROM simpanan_setoran "+
                                    "WHERE CONVERT(SUBSTRING(id_setoran, 4,2), SIGNED INTEGER)=SUBSTRING(YEAR(NOW()), 3,2) AND "+
                                    "CONVERT(SUBSTRING(id_setoran, 6,2), SIGNED INTEGER)=MONTH(NOW())";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = (dt.Rows[0][0].ToString() == "") ? 0 : int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public void addDataSimpanan(string id_simpanan, string tgl_daftar, string id_nasabah, int jenis_simpanan, string id_kolektor, double bunga, double saldo)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO simpanan (id_simpanan, tanggal_daftar, id_nasabah, jenis_simpanan, id_kolektor, bunga, saldo) " +
                                    "VALUES('" + id_simpanan + "','" + tgl_daftar + "','" + id_nasabah + "','" + jenis_simpanan + "','" + id_kolektor + "','" + bunga + "','" + saldo + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable showDataSimpanan()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT simpanan.id_simpanan AS 'ID Simpanan', simpanan.tanggal_daftar AS 'Tanggal Daftar', simpanan.id_nasabah AS 'ID Nasabah', nasabah.nama_nasabah AS 'Nama Nasabah', simpanan.jenis_simpanan AS 'Jenis Simpanan', id_kolektor AS 'ID Kolektor', simpanan.bunga AS 'Bunga', simpanan.saldo AS 'Saldo Simpanan'" +
                    " FROM simpanan INNER JOIN nasabah" +
                    " WHERE simpanan.`id_nasabah`=nasabah.`id_nasabah`" +
                    " ORDER BY simpanan.tanggal_daftar DESC";
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

        public DataTable showDataSimpananIDNasabah(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT simpanan.id_simpanan AS 'ID Simpanan', simpanan.tanggal_daftar AS 'Tanggal Daftar', simpanan.id_nasabah AS 'ID Nasabah', nasabah.nama_nasabah AS 'Nama Nasabah', simpanan.jenis_simpanan AS 'Jenis Simpanan', id_kolektor AS 'ID Kolektor', simpanan.bunga AS 'Bunga', simpanan.saldo AS 'Saldo Simpanan'" +
                    " FROM simpanan INNER JOIN nasabah" +
                    " WHERE simpanan.`id_nasabah`=nasabah.`id_nasabah` AND nasabah.id_nasabah LIKE '%" + id + "%'";
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

        public DataTable showDataSimpananNamaNasabah(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT simpanan.id_simpanan AS 'ID Simpanan', simpanan.tanggal_daftar AS 'Tanggal Daftar', simpanan.id_nasabah AS 'ID Nasabah', nasabah.nama_nasabah AS 'Nama Nasabah', simpanan.jenis_simpanan AS 'Jenis Simpanan', id_kolektor AS 'ID Kolektor', simpanan.bunga AS 'Bunga', simpanan.saldo AS 'Saldo Simpanan'" +
                    " FROM simpanan INNER JOIN nasabah" +
                    " WHERE simpanan.`id_nasabah`=nasabah.`id_nasabah` AND nasabah.nama_nasabah LIKE '%" + nama + "%'";
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

        public DataTable showDataSimpananIDKolektor(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT simpanan.id_simpanan AS 'ID Simpanan', simpanan.tanggal_daftar AS 'Tanggal Daftar', simpanan.id_nasabah AS 'ID Nasabah', nasabah.nama_nasabah AS 'Nama Nasabah', simpanan.jenis_simpanan AS 'Jenis Simpanan', id_kolektor AS 'ID Kolektor', simpanan.bunga AS 'Bunga', simpanan.saldo AS 'Saldo Simpanan'" +
                    " FROM simpanan INNER JOIN nasabah" +
                    " WHERE simpanan.`id_nasabah`=nasabah.`id_nasabah` AND simpanan.id_kolektor LIKE '%" + id + "%'";
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

        public DataTable showDataSimpananTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT simpanan.id_simpanan AS 'ID Simpanan', simpanan.tanggal_daftar AS 'Tanggal Daftar', simpanan.id_nasabah AS 'ID Nasabah', nasabah.nama_nasabah AS 'Nama Nasabah', simpanan.jenis_simpanan AS 'Jenis Simpanan', id_kolektor AS 'ID Kolektor', simpanan.bunga AS 'Bunga', simpanan.saldo AS 'Saldo Simpanan'" +
                    " FROM simpanan INNER JOIN nasabah" +
                    " WHERE simpanan.`id_nasabah`=nasabah.`id_nasabah` AND DATE(simpanan.tanggal_daftar) = '" + tanggal + "'";
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

        public void addDataSetoran(string id_setoran, string tanggal_setoran, string id_nasabah, string id_simpanan, double saldo_awal, double nominal_setoran, double saldo_akhir, string penyetor, string keterangan)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO simpanan_setoran (id_setoran, tanggal, id_nasabah, id_simpanan, saldo_awal, nominal_setoran, saldo_akhir, penyetor, keterangan) " +
                                    "VALUES('" + id_setoran + "','" + tanggal_setoran + "','" + id_nasabah + "','" + id_simpanan + "','" + saldo_awal + "','" + nominal_setoran + "','" + saldo_akhir + "','" + penyetor + "','" + keterangan + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateSaldo(string id, double saldo)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE simpanan SET saldo='" + saldo + "' WHERE id_simpanan='" + id + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable cariDataSetoran()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_setoran AS 'ID Setoran', tanggal AS 'Tanggal Setoran', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', saldo_awal AS 'Saldo Awal', nominal_setoran AS 'Nominal Setoran', saldo_akhir AS 'Saldo Akhir', penyetor AS 'Penyetor', keterangan AS 'Keterangan'" +
                    " FROM simpanan_setoran"+
                    " ORDER BY tanggal DESC";
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

        public DataTable cariDataSetoranID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_setoran AS 'ID Setoran', tanggal AS 'Tanggal Setoran', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', saldo_awal AS 'Saldo Awal', nominal_setoran AS 'Nominal Setoran', saldo_akhir AS 'Saldo Akhir', penyetor AS 'Penyetor', keterangan AS 'Keterangan'" +
                    " FROM simpanan_setoran" +
                    " WHERE id_nasabah LIKE '%" + id + "%'" +
                    " ORDER BY tanggal DESC";
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

        public DataTable cariDataSetoranSimpanan(string simpanan)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_setoran AS 'ID Setoran', tanggal AS 'Tanggal Setoran', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', saldo_awal AS 'Saldo Awal', nominal_setoran AS 'Nominal Setoran', saldo_akhir AS 'Saldo Akhir', penyetor AS 'Penyetor', keterangan AS 'Keterangan'" +
                    " FROM simpanan_setoran" +
                    " WHERE id_simpanan LIKE '%" + simpanan + "%'" +
                    " ORDER BY tanggal DESC";
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

        public DataTable cariDataSetoranKolektor(string kolektor)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_setoran AS 'ID Setoran', tanggal AS 'Tanggal Setoran', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', saldo_awal AS 'Saldo Awal', nominal_setoran AS 'Nominal Setoran', saldo_akhir AS 'Saldo Akhir', penyetor AS 'Penyetor', keterangan AS 'Keterangan'" +
                    " FROM simpanan_setoran" +
                    " WHERE penyetor LIKE '%" + kolektor + "%'" +
                    " ORDER BY tanggal DESC";
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

        public DataTable cariDataSetoranTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_setoran AS 'ID Setoran', tanggal AS 'Tanggal Setoran', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', saldo_awal AS 'Saldo Awal', nominal_setoran AS 'Nominal Setoran', saldo_akhir AS 'Saldo Akhir', penyetor AS 'Penyetor', keterangan AS 'Keterangan'" +
                    " FROM simpanan_setoran" +
                    " WHERE DATE(tanggal) = '" + tanggal + "'"+
                    " ORDER BY tanggal DESC";
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

        public DataTable showAgama()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id AS 'ID Agama', agama AS 'Agama'"+
                    " FROM agama ORDER BY agama";
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

        public void addAgama(int id, string agama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO agama (id, agama) " +
                                    "VALUES('" + id + "','" + agama + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateAgama(int id, string agama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE agama SET agama='" + agama + "' WHERE id='" + id + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable showPekerjaan()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id AS 'ID Pekerjaan', pekerjaan AS 'Pekerjaan'" +
                    " FROM pekerjaan ORDER BY pekerjaan";
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

        public void addPekerjaan(int id, string pekerjaan)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO pekerjaan (id, pekerjaan) " +
                                    "VALUES('" + id + "','" + pekerjaan + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updatePekerjaan(int id, string pekerjaan)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE pekerjaan SET pekerjaan='" + pekerjaan + "' WHERE id='" + id + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void addBungaSimpanan(string id_bunga, string tgl, string id_nasabah, string id_simpanan, double persen_bunga, double saldo_awal, double jml_bunga, double saldo_akhir)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO simpanan_bunga (id_bunga, tgl_bunga, id_nasabah, id_simpanan, persen_bunga, saldo_awal, jumlah_bunga, saldo_akhir)" +
                                    " VALUES('" + id_bunga + "','" + tgl + "','" + id_nasabah + "','" + id_simpanan + "','" + persen_bunga + "','" + saldo_awal + "','" + jml_bunga + "','" + saldo_akhir + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable showDataBungaSimpanan()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga ORDER BY tgl_bunga DESC";
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

        public DataTable showDataBungaSimpananIDBunga(string id_bunga)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga"+
                    " WHERE id_bunga LIKE '%" + id_bunga + "%'" +
                    " ORDER BY tgl_bunga DESC";
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

        public DataTable showDataBungaSimpananIDNasabah(string id_nasabah)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga" +
                    " WHERE id_nasabah LIKE '%" + id_nasabah + "%'" +
                    " ORDER BY tgl_bunga DESC";
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

        public DataTable showDataBungaSimpananIDSimpanan(string id_simpanan)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga" +
                    " WHERE id_simpanan LIKE '%" + id_simpanan + "%'" +
                    " ORDER BY tgl_bunga DESC";
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

        public DataTable showDataBungaSimpananMinimalBunga(double bunga)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga" +
                    " WHERE persen_bunga>=" + bunga + "" +
                    " ORDER BY tgl_bunga DESC";
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

        public DataTable showDataBungaSimpananTanggal(string tanggal)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_bunga AS 'ID Bunga Simpanan', tgl_bunga AS 'Tanggal', id_nasabah AS 'ID Nasabah', id_simpanan AS 'ID Simpanan', persen_bunga AS 'Bunga (%)', saldo_awal AS 'Saldo Awal', saldo_akhir AS 'Saldo Akhir'" +
                    " FROM simpanan_bunga" +
                    " WHERE DATE(tgl_bunga) = '" + tanggal + "'" +
                    " ORDER BY tgl_bunga DESC";
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

        public int getLastNoPenarikan()
        {
            dt = new DataTable();
            int result = 0;
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT CONVERT(SUBSTRING(MAX(id_transaksi), 8), SIGNED INTEGER) AS lastNo FROM simpanan_penarikan " +
                                    "WHERE CONVERT(SUBSTRING(id_transaksi, 4,2), SIGNED INTEGER)=SUBSTRING(YEAR(NOW()), 3,2) AND " +
                                    "CONVERT(SUBSTRING(id_transaksi, 6,2), SIGNED INTEGER)=MONTH(NOW())";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = (dt.Rows[0][0].ToString() == "") ? 0 : int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public DataTable showDataPenarikan()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_transaksi AS 'ID Transaksi', tanggal AS 'Tanggal', no_bukti AS 'No Bukti', id_simpanan AS 'ID Simpanan', id_kolektor AS 'ID Kolektor', nominal AS 'Nominal' " +
                                    "FROM simpanan_penarikan";
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

        public DataTable showDataPenarikanID()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_transaksi AS 'ID Transaksi', tanggal AS 'Tanggal', no_bukti AS 'No Bukti', id_simpanan AS 'ID Simpanan', id_kolektor AS 'ID Kolektor', nominal AS 'Nominal' " +
                                    "FROM simpanan_penarikan";
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

        public DataTable showDataPenarikanTanggal()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_transaksi AS 'ID Transaksi', tanggal AS 'Tanggal', no_bukti AS 'No Bukti', id_simpanan AS 'ID Simpanan', id_kolektor AS 'ID Kolektor', nominal AS 'Nominal' " +
                                    "FROM simpanan_penarikan";
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


        /*public void addPegawai(String idPegawai, String namaDepan, String namaBelakang, String telp, String alamat, int status)
        {
            con = new MySqlConnection(konf);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO tb_master_pegawai (id_pegawai, nama_depan, nama_belakang, no_telp, alamat, STATUS) VALUES('" + idPegawai + "', '" + namaDepan + "', '" + namaBelakang + "', '" + telp + "', '" + alamat + "', '" + status + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updatePegawai(String idPegawai, String namaDepan, String namaBelakang, String telp, String alamat, int status)
        {
            con = new MySqlConnection(konf);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE tb_master_pegawai SET nama_depan='" + namaDepan + "',nama_belakang='" + namaBelakang + "',no_telp='" + telp + "',alamat='" + alamat + "',status='" + status + "' WHERE id_pegawai='" + idPegawai + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

    }
}
