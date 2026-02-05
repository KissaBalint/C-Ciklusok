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

        public static void UpdateCar(int id, string Brand, string Type, string Color)
        {
            Conn.Open();
            string sql = "UPDATE `cars` SET `Brand` = @brand, `Type` = @Type, `Color` = @color WHERE `id` = @id";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);

            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@color", Color);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteCar(int id)
        {
            Conn.Open();

            string sql = "DELETE FROM cars WHERE Id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, Conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            Conn.Close();
        }


        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1. Lekérdezés");
                Console.WriteLine("2. Beszúrás");
                Console.WriteLine("3. Módosítás");
                Console.WriteLine("4. Törlés");
                Console.WriteLine("5. Kilépés");
                Console.Write("Válassz menüpontot: ");
                byte menu = byte.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1: Console.Clear(); ReadData(); Console.Clear(); break;
                    case 2:
                        #region bekeres
                        Console.Clear();

                        Console.Write($"Kérem a márkat: ");
                        string brand = Console.ReadLine();

                        Console.Write($"Kérem a típust: ");
                        string type = Console.ReadLine();

                        Console.Write($"Kérem a színt: ");
                        string color = Console.ReadLine();
                        #endregion 
                        InsertData(brand, type, color); Console.Clear(); break;
                    case 3:
                        Console.Clear();
                        #region bekeres
                        Console.Clear();

                        Console.Write($"Kérem az azonosítót: ");
                        int id1 = int.Parse(Console.ReadLine());

                        Console.Write($"Kérem a márkát: ");
                        string brand1 = Console.ReadLine();

                        Console.Write($"Kérem az típust: ");
                        string type1 = Console.ReadLine();

                        Console.Write($"Kérem a színt: ");
                        string color1 = Console.ReadLine();
                        #endregion 
                        UpdateCar(id1, brand1, type1, color1); Console.Clear(); break;
                    case 4:
                        Console.Clear();
                        #region bekeres
                        Console.Write("Kérem a törlendő user Id-jét: ");
                        int id = int.Parse(Console.ReadLine());
                        #endregion
                        DeleteCar(id); Console.Clear(); break;
                    case 5: System.Environment.Exit(0); break;
                    default: Console.Clear(); Console.WriteLine("Nincs ilyen menüpont! A felsorolt menüpontok közül válasszon!"); break;
                }
            }


        }
    }
}
