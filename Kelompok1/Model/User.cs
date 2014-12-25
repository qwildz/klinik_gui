using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kelompok1
{
    class User
    {
        public int id_user, id_dokter;
        public string username, password, level;
        public DataSet LoadUser()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT tuser.id_user, tuser.username, tuser.level, tdokter.id_dokter, nama_dokter FROM tuser " +
                               "LEFT JOIN tdokter ON (tuser.id_dokter = tdokter.id_dokter)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tuser");
                Koneksi.Tutup();
                return ds;
            }

            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public bool LoginCek(object[] data)
        {
            try
            {
                bool response;
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_user, username, level, id_dokter " +
                               "FROM tuser " +
                               "WHERE username = '" + data[0].ToString() +
                               "' AND password = md5('" + data[1].ToString() + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                if (result.Read() == true)
                {
                    TampilanPesan.Info("Login sukses");
                    Session.id_user = Convert.ToInt32(result["id_user"]);
                    Session.level = result["level"].ToString();
                    Session.username = result["username"].ToString();
                    if(! result["id_dokter"].GetType().ToString().Equals("System.DBNull"))
                        Session.id_dokter = Convert.ToInt32(result["id_dokter"]);
                    result.Close();
                    response = true;
                }
                else
                {
                    TampilanPesan.Warning("Password atau username salah!");
                    response = false;
                }

                Koneksi.Tutup();
                return response;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return false;
            }
        }

        public bool CekUsername(string username)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT username " +
                               "FROM tuser " +
                               "WHERE username = '" + username +
                               "' ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                bool ada = false;

                if (result.Read() == true)
                {
                    ada = result.HasRows;
                }
                
                Koneksi.Tutup();
                return ada;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return false;
            }
        }

        public int InsertUser()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tuser (username, password, level, id_dokter) values('{0}', MD5('{1}'), '{2}', {3});", username, password, level, id_dokter);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    TampilanPesan.Info("Data berhasil disimpan.");
                else
                    TampilanPesan.Warning("Data gagal disimpan.");
                Koneksi.Tutup();
                return result;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public int UpdateUser()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("UPDATE tuser SET username = '{0}', level = '{1}', id_dokter = {2} WHERE id_user = '{3}';", username, level, id_dokter, id_user);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    TampilanPesan.Info("Data berhasil diubah.");
                else
                    TampilanPesan.Warning("Data gagal diubah.");
                Koneksi.Tutup();
                return result;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public int UpdatePassword()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("UPDATE tuser SET password = MD5('{0}') WHERE id_user = '{1}';", password, id_user);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    TampilanPesan.Info("Password berhasil diubah.");
                else
                    TampilanPesan.Warning("Password gagal diubah.");
                Koneksi.Tutup();
                return result;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tuser WHERE id_user = {0};", id);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    TampilanPesan.Info("Data berhasil dihapus.");
                else
                    TampilanPesan.Warning("Data gagal dihapus.");
                Koneksi.Tutup();
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
            }
        }
    }
}
