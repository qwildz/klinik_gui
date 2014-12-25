using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    class TampilanPesan
    {
        public static void ErrorMysql(MySqlException err)
        {
            switch (err.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Erorr Database : " + err, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static void Error(string err)
        {
            MessageBox.Show("Erorr : " + err, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string warn)
        {
            MessageBox.Show(warn, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(string info, string judul = "Informasi")
        {
            MessageBox.Show(info, judul, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
