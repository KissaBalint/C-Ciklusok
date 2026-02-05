using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderConsole
{
    internal class Program
    {
        public static string ConnectionString = "server=localhost;database=trader;user=root;password=";
        public static MySqlConnection Conn = new MySqlConnection(ConnectionString);



        static void Main(string[] args)
        {
            
        }
    }
}
