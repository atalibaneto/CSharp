using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConectarBD
{
    internal class Conn
    {
        //O @ é usado sempre que temos caracteres especiais dentro da string de conexão
        
        private static string server = "BOT0626783W10-1";    
        private static string database = "db_Biblioteca";
        private static string user = "sa";
        private static string password = "sasenac";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=false; Initial Catalog={database}; User ID={user}; Password={password}"; }
        }
    }
}
