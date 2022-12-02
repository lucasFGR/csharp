using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaNF
{
    internal class Conn
    {
        private static string server = @"DESKTOP-8GOC3GU\SQLEXPRESS";
        private static string dataBase = "Teste";
        private static string user = "sa";
        private static string password = "teste123";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }
    }
}
