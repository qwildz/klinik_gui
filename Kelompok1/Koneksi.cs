using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class Koneksi
    {
        private static bool opened;
        private static string myConnString = "SERVER = localhost;" +
                                             "DATABASE = kelompok1_cekup;" +
                                             "UID = root;" +
                                             "PASSWORD = 02624701363;";
        public static MySqlConnection conn = new MySqlConnection(myConnString);

        public static MySqlConnection Buka()
        {
            if (opened) return conn;

            conn.Open();
            opened = true;
            return conn;
        }

        public static void Tutup()
        {
            conn.Close();
            opened = false;
        }
    }
}
