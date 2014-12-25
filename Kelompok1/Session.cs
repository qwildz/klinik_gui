using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kelompok1
{
    class Session
    {
        public static string username;
        public static string level;
        public static int id_user, id_dokter;

        public static bool isAdmin()
        {
            return level == "admin";
        }

        public static bool isDokter()
        {
            return level == "dokter";
        }

        public static bool isResepsionis()
        {
            return level == "resepsionis";
        }

        public static void Hancur()
        {
            username = "";
            level = "";
            id_dokter = 0;
            id_user = 0;
        }
    }
}
