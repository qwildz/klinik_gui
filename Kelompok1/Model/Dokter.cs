using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Dokter
    {
        public int id_dokter;
        public string nama_dokter, spesialis, alamat, no_telepon;

        public DataSet LoadDokter()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_dokter, nama_dokter, spesialis, alamat, no_telepon FROM tdokter";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tdokter");
                Koneksi.Tutup();
                return ds;
            }

            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public DataSet LoadDokter(string where)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = "SELECT id_dokter, nama_dokter, spesialis, alamat, no_telepon FROM tdokter" + where;
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tdokter");
                Koneksi.Tutup();
                return ds;
            }

            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return ds;
            }
        }

        public int InsertDokter()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tdokter (nama_dokter, spesialis, alamat, no_telepon, created, modified ) values('{0}', '{1}', '{2}', '{3}', NOW(), NOW());", nama_dokter, spesialis, alamat, no_telepon);
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Information : Data berhasil di simpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Warning : Data gagal di simpan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Koneksi.Tutup();
                return result;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public int UpdateDokter()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("UPDATE tdokter SET nama_dokter = '{0}', spesialis = '{1}', alamat = '{2}', no_telepon = '{3}', modified = NOW() WHERE id_dokter = '{4}';", nama_dokter, spesialis, alamat, no_telepon, id_dokter);
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Information : Data berhasil di ubah.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Warning : Data gagal di ubah.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Koneksi.Tutup();
                return result;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public void DeleteDokter(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tdokter WHERE id_dokter = {0};", id);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Data berhasil di hapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data gagal dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Koneksi.Tutup();
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
            }
        }
    }
}
