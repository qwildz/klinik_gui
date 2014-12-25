using System.Data;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Obat
    {
        public int id_obat;
        public string nama_obat, jenis_obat;
        public DataSet LoadObat()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_obat, nama_obat, jenis_obat FROM tobat";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tobat");
                Koneksi.Tutup();
                return ds;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public DataSet LoadObat(string where)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_obat, nama_obat, jenis_obat FROM tobat" + where;
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tobat");
                Koneksi.Tutup();
                return ds;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public int InsertObat()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tobat (nama_obat, jenis_obat) values('{0}', '{1}');", nama_obat, jenis_obat);
                
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
                string query = string.Format("UPDATE tobat SET nama_obat = '{0}', jenis_obat = '{1}' WHERE id_obat = {2};", nama_obat, jenis_obat, id_obat);
                
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

        public void DeleteObat(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tobat WHERE id_obat = {0};", id);
                
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