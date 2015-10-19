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
    class DBUser
    {
        MySqlConnection con;
        String konfigurasi = "Server="+GlobalVariabel.server+";port="+GlobalVariabel.port+";UID="+GlobalVariabel.username+";PWD="+GlobalVariabel.password+";Database="+GlobalVariabel.database+"";
        DataTable dt;

        public String loginUser(String user, String pass)
        {
            dt = new DataTable();
            String result = "0";
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "select count(*) from user where username='" + user + "' and userpassword='" + pass + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query);
                adapter.Fill(dt);
                result = dt.Rows[0][0].ToString();
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
        }

        public DataTable getDataUser(String user, String pass)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            dt = new DataTable();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "select * from user WHERE username ='" + user + "' and userpassword='" + pass + "'";
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

        public void updateLastLogin(String id)
        {
            con = new MySqlConnection(konfigurasi);
            MySqlCommand query;
            con.Open();
            try
            {

                query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = "update user set last_login=NOW() where id_user='" + id + "'";
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
