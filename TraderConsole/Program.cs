using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TraderConsole
{
    internal class Program
    {
        public static string ConnectionString = "server=localhost;database=trader;user=root;password=";
        public static MySqlConnection Conn = new MySqlConnection(ConnectionString);

        public static void InsertData(string brand, string type, string color)
        {
            Conn.Open();
            string sql = "INSERT INTO `cars` (`Brand`,`Type`,`Color`) VALUES (@brand, @type, @password)";

            MySqlCommand cmd = new MySqlCommand(sql,Conn);

            cmd.Parameters.AddWithValue("@brand", brand);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@color", color);

            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
