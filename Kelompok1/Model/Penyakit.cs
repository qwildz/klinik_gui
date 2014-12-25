using System.Data;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Penyakit
    {
        public int id_penyakit;
        public string nama_penyakit;
        public DataSet LoadPenyakit()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_penyakit, nama_penyakit FROM tpenyakit";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tpenyakit");
                Koneksi.Tutup();
                return ds;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public DataSet LoadPenyakit(string where)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_penyakit, nama_penyakit FROM tpenyakit" + where;
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tpenyakit");
                Koneksi.Tutup();
                return ds;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public int InsertPenyakit()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tpenyakit (nama_penyakit) values('{0}');", nama_penyakit);
                
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

        public int UpdateObat()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("UPDATE tpenyakit SET nama_penyakit = '{0}' WHERE id_penyakit = '{1}';", nama_penyakit, id_penyakit);
                
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

        public void DeletePenyakit(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tpenyakit WHERE id_penyakit = {0};", id);
                
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
