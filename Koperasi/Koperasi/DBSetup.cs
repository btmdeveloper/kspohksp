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
    class DBSetup
    {
        MySqlConnection con;
        String konfigurasi = "Server=" + GlobalVariabel.server + ";port=" + GlobalVariabel.port + ";UID=" + GlobalVariabel.username + ";PWD=" + GlobalVariabel.password + ";Database=" + GlobalVariabel.database + "";
        DataTable dt;

        public void updateProfil(String nama, String bk, String tgl, String alamat, String telp, String kab, String prov)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE profil SET nama_koperasi='" + nama + "', " +
                                    "badan_hukum='" + bk + "', " +
                                    "tgl_pengukuhan_pkp='" + tgl + "', " +
                                    "alamat='" + alamat + "', " +
                                    "telp_fax='" + telp + "', " +
                                    "kabupaten='" + kab + "', " +
                                    "provinsi='" + prov + "'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable selectProfil()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT * FROM profil";
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

        public void insertKolektor(String id, String nama, String alamat, String ktp, String telp, String hp, String status, String foto)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO kolektor (id_kolektor, nama, alamat, no_ktp, no_telp, no_hp, STATUS, foto) "+
                                    "VALUES('" + id + "','" + nama + "','" + alamat + "','" + ktp + "','" + telp + "','" + hp + "','" + status + "','" + foto + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insertUser(String id, String nama, String username, String password, String role, String status)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "INSERT INTO USER (id_user, nama, username, userpassword, role, STATUS) " +
                                    "VALUES('" + id + "','" + nama + "','" + username + "','" + password + "','" + role + "','" + status + "')";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateKolektor(String id, String nama, String alamat, String ktp, String telp, String hp, String status, String foto)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {
                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "UPDATE kolektor SET nama='"+nama+"', alamat='"+alamat+"', no_ktp='"+ktp+"', no_telp='"+telp+"', no_hp='"+hp+"', STATUS='"+status+"' "+
                                    "WHERE id_kolektor='"+id+"'";
                query.ExecuteNonQuery();
                query.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getDataRole()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT * FROM ref_role";
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

        public int getLastNo(String tabel)
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
                query.CommandText = "SELECT COUNT(*) FROM " + tabel + "";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public DataTable showDataKolektor()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'No Telp', no_hp AS 'No Hp' FROM kolektor";
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

        public DataTable showDataKolektorID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'No Telp', no_hp AS 'No Hp' " +
                                    "FROM kolektor WHERE id_kolektor LIKE '%" + id + "%'";
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

        public DataTable showDataKolektorID2(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'No Telp', no_hp AS 'No Hp', status as 'Status'" +
                                    "FROM kolektor WHERE id_kolektor LIKE '%" + id + "%'";
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

        public DataTable showDataKolektorNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'No Telp', no_hp AS 'No Hp' " +
                                    "FROM kolektor WHERE nama LIKE '%" + nama + "%'";
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

        public DataTable showDataKolektorAlamat(string alamat)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_kolektor AS 'ID', nama AS 'Nama Kolektor', alamat AS 'Alamat', no_ktp AS 'No KTP', no_telp AS 'No Telp', no_hp AS 'No Hp' " +
                                    "FROM kolektor WHERE alamat LIKE '%" + alamat + "%'";
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

        public DataTable showDataUser()
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_user AS 'ID User', nama AS 'Nama', username AS 'Username', userpassword AS 'Password', role AS 'Tugas', STATUS AS 'Status' "+
                                    "FROM `user`";
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

        public DataTable showDataUserID(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_user AS 'ID User', nama AS 'Nama', username AS 'Username', userpassword AS 'Password', role AS 'Tugas', STATUS AS 'Status' " +
                                    "FROM `user` WHERE id_user LIKE '%" + id + "%'";
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

        public DataTable showDataUserID2(string id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_user AS 'ID User', nama AS 'Nama', username AS 'Username', userpassword AS 'Password', role AS 'Tugas', STATUS AS 'Status' " +
                                    "FROM `user` WHERE id_user LIKE '%" + id + "%'";
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

        public DataTable showDataUserNama(string nama)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_user AS 'ID User', nama AS 'Nama', username AS 'Username', userpassword AS 'Password', role AS 'Tugas', STATUS AS 'Status' " +
                                    "FROM `user` WHERE nama LIKE '%" + nama + "%'";
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

        public DataTable showDataUserTugas(string tugas)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "SELECT id_user AS 'ID User', nama AS 'Nama', username AS 'Username', userpassword AS 'Password', role AS 'Tugas', STATUS AS 'Status' " +
                                    "FROM `user` WHERE alamat LIKE '%" + tugas + "%'";
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
