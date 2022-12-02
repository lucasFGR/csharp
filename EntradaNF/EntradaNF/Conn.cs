using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaNF
{
    internal class Conn
    {
        private static string server = @"EDB01";
        private static string dataBase = "Emphasis";
        private static string user = "usrReport";
        private static string password = "3j34ns@Psql18";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }
    }
}
