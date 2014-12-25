using System.Data;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Cekup
    {
        public long id_cekup;
        public int id_pasien, id_dokter, biaya_cekup;
        public string tanggal_cekup;

        public DataSet LoadCekup()
        {
            DataSet data = new DataSet();

            try
            {
                MySqlConnection conn = Koneksi.Buka();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string query = "SELECT tcekup.id_cekup, tdokter.nama_dokter, tcekup.biaya_cekup, tcekup.tanggal_cekup " +
                        "FROM tcekup " +
                        "LEFT JOIN tdokter ON (tcekup.id_dokter = tdokter.id_dokter) " +
                        "LEFT JOIN tpasien ON (tcekup.id_pasien = tpasien.id_pasien) ";

                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "tcekup");

                Koneksi.Tutup();
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
            }

            return data;
        }

        public DataSet LoadCekup(int id)
        {
            DataSet data = new DataSet();

            try
            {
                MySqlConnection conn = Koneksi.Buka();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string query = "SELECT tcekup.id_cekup, tdokter.nama_dokter, tcekup.biaya_cekup, tcekup.tanggal_cekup " +
                        "FROM tcekup " +
                        "LEFT JOIN tdokter ON (tcekup.id_dokter = tdokter.id_dokter) " +
                        "LEFT JOIN tpasien ON (tcekup.id_pasien = tpasien.id_pasien) " + 
                        "WHERE tcekup.id_pasien = " + id;

                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "tcekup");

                Koneksi.Tutup();
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
            }

            return data;
        }

        public DataSet LoadDetailCekup(int id)
        {
            DataSet data = new DataSet();

            try
            {
                MySqlConnection conn = Koneksi.Buka();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string query = "SELECT tcekup.id_cekup, tpasien.nama_pasien, tdokter.nama_dokter, tdokter.spesialis, tcekup.biaya_cekup, tcekup.tanggal_cekup " +
                        "FROM tcekup " +
                        "LEFT JOIN tdokter ON (tcekup.id_dokter = tdokter.id_dokter) " +
                        "LEFT JOIN tpasien ON (tcekup.id_pasien = tpasien.id_pasien) " +
                        "WHERE tcekup.id_cekup = " + id;

                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "tcekup");

                string query2 = "SELECT tobat.id_obat, tobat.nama_obat, tresep.dosis " +
                        "FROM tresep " +
                        "LEFT JOIN tobat ON (tobat.id_obat = tresep.id_obat) " +
                        "WHERE tresep.id_cekup = " + id;

                cmd.CommandText = query2;
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "tresep");

                string query3 = "SELECT tpenyakit.id_penyakit, tpenyakit.nama_penyakit " +
                        "FROM tcekuppenyakit " +
                        "LEFT JOIN tpenyakit ON (tpenyakit.id_penyakit = tcekuppenyakit.id_penyakit) " +
                        "WHERE tcekuppenyakit.id_cekup = " + id;

                cmd.CommandText = query3;
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "tcekuppenyakit");

                Koneksi.Tutup();
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
            }

            return data;
        }

        public long InsertCekup()
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tcekup (id_pasien, id_dokter, biaya_cekup, tanggal_cekup) values({0}, {1}, {2}, '{3}');", id_pasien, id_dokter, biaya_cekup, tanggal_cekup);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    TampilanPesan.Info("Data berhasil disimpan.");
                else
                    TampilanPesan.Warning("Data gagal disimpan.");
                Koneksi.Tutup();
                this.id_cekup = cmd.LastInsertedId;
                return 1;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public long InsertPenyakit(int id_penyakit)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tcekuppenyakit (id_cekup, id_penyakit, created, modified) values({0}, {1}, NOW(), NOW());", id_cekup, id_penyakit);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                Koneksi.Tutup();
                return 1;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public long InsertObat(int id_obat, string dosis)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("INSERT INTO tresep (id_cekup, id_obat, dosis, created, modified) values({0}, {1}, '{2}', NOW(), NOW());", id_cekup, id_obat, dosis);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                Koneksi.Tutup();
                return 1;
            }
            catch (MySqlException err)
            {
                TampilanPesan.ErrorMysql(err);
                return 0;
            }
        }

        public void DeleteCekup(int id)
        {
            try
            {
                MySqlConnection conn = Koneksi.Buka();
                string query = string.Format("DELETE FROM tcekup WHERE id_cekup = {0};", id);

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
