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
            string sql = "INSERT INTO `cars` (`Brand`,`Type`,`Color`) VALUES (@brand, @type, @color)";

            MySqlCommand cmd = new MySqlCommand(sql,Conn);

            cmd.Parameters.AddWithValue("@brand", brand);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@color", color);

            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        public static void ReadData()
        {
            Conn.Open();
            string sql = "SELECT * FROM cars";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"Id: {dr.GetInt32(0)}, Brand: {dr.GetString(1)}, Type: {dr.GetString(2)}, Color: {dr.GetString(3)},  RegTime: {dr.GetDateTime(5)}");
            }
            Console.ReadKey();
            Conn.Close();
        }

        static void Main(string[] args)
        {
            
          
        }
    }
}
