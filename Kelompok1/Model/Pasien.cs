using System.Data;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Pasien
    {
        public int id_pasien;
        public string nama_pasien, jenis_kelamin, alamat, gol_darah, no_telepon;
        public string tgl_lahir;

        public DataSet LoadPasien()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_pasien, nama_pasien, jenis_kelamin, tgl_lahir, alamat, gol_darah, no_telepon FROM tpasien";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tpasien");
                Koneksi.Tutup();
                return ds;
            }

            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }
        public DataSet LoadPasien(string where)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_pasien, nama_pasien, jenis_kelamin, tgl_lahir, alamat, gol_darah, no_telepon FROM tpasien" + where;
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tpasien");
                Koneksi.Tutup();
                return ds;
            }

            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public int InsertPasien()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tpasien (nama_pasien, jenis_kelamin, tgl_lahir, alamat, gol_darah, no_telepon) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",  nama_pasien, jenis_kelamin, tgl_lahir, alamat, gol_darah, no_telepon);
                
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

        public void DeletePasien(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tpasien WHERE id_pasien = {0};", id);
                
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

        public int UpdatePasien()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("UPDATE tpasien SET nama_pasien = '{0}', jenis_kelamin = '{1}', tgl_lahir = '{2}', alamat = '{3}',gol_darah = '{4}', no_telepon = '{5}' WHERE id_pasien = {6};", nama_pasien, jenis_kelamin, tgl_lahir, alamat, gol_darah, no_telepon, id_pasien);
                
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
    }
}
