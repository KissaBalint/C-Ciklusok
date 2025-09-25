using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok_Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat1
            Console.WriteLine("Első feladat:");
            Console.Write("Kérem az első számot:");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem az második számot:");
            int szam2 = int.Parse(Console.ReadLine());



            if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobb szám a: {szam1} és a különbségük {szam1 - szam2}");

            }
            else
            {
                Console.WriteLine($"A nagyobb szám a: {szam2} és a különbségük {szam2 - szam1}");
            }

            Console.WriteLine("---------------------------------------------");

            //Második feladat
            Console.WriteLine("Második feladat:");
            List<int> szamok = new List<int>();
            int szam;


            Console.Write("Adjon meg egy számot: ");
            szam = int.Parse(Console.ReadLine());

            while (szam != 0)
            {
                szamok.Add(szam);

                Console.Write("Adjon meg egy számot: ");
                szam = int.Parse(Console.ReadLine());
            }


            int maxSzam = 0;
            int maxDb = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                int aktualis = szamok[i];
                int db = 0;


                for (int j = 0; j < szamok.Count; j++)
                {
                    if (szamok[j] == aktualis)
                    {
                        db++;
                    }
                }


                if (db > maxDb)
                {
                    maxDb = db;
                    maxSzam = aktualis;
                }
            }

            Console.WriteLine($"A legtöbbször beírt szám: {maxSzam}, ennyiszer: {maxDb}");

            Console.WriteLine("---------------------------------------------");

            //Harmadik feladat
            Console.WriteLine("Harmadik feladat:");
            List<int> ParosPart = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Adja meg az {i}. számot:");
                szam = int.Parse(Console.ReadLine());
                ParosPart.Add(szam);
            }

            int pardb = 0;
            int partdb = 0;


            foreach (int sam in ParosPart)
            {
                if (sam % 2 == 0)
                {
                    pardb += 1;
                }
                else
                {
                    partdb += 1;
                }
            }
            Console.WriteLine($"{pardb} db páros szám van és {partdb} páratlanszám van.");

            Console.WriteLine("---------------------------------------------");

            //Negyedik feladat
            Console.WriteLine("Negyedik feladat:");

            int szodb = 0;

            Console.Write("Adjon meg egy szót:");
            string szo1 = Console.ReadLine();

            while (szo1 != "vége")
            {
                if (szo1.Length >= 5)
                {
                    szodb += 1;
                }
                Console.Write("Adjon meg még egy szót:");
                szo1 = Console.ReadLine();
            }
            Console.WriteLine($"{szodb} db 5 karakternél hosszabb szó van.");

            Console.WriteLine("---------------------------------------------");

            //Ötödik feladat
            Console.WriteLine("Ötödik feladat:");
            Console.Write("Adja meg az osztályzatot:");

            List<int> osztalyzatok = new List<int>();

            int bekert_osztalyzat = int.Parse(Console.ReadLine());
            while (bekert_osztalyzat != -1)
            {

                osztalyzatok.Add(bekert_osztalyzat);
                Console.Write("Adjon meg még egy osztályzatot:");
                bekert_osztalyzat = int.Parse(Console.ReadLine());

            }

            int jegy1 = 0;
            int jegy2 = 0;
            int jegy3 = 0;
            int jegy4 = 0;
            int jegy5 = 0;

            foreach (int osztalyzat in osztalyzatok)
            {
                if (osztalyzat == 1)
                {
                    jegy1 += 1;
                }
                else if (osztalyzat == 2)
                {
                    jegy2 += 1;
                }
                else if (osztalyzat == 3)
                {
                    jegy3 += 1;
                }
                else if (osztalyzat == 4)
                {
                    jegy4 += 1;
                }
                else if (osztalyzat == 5)
                {
                    jegy5 += 1;
                }
            }

            Console.WriteLine($"1 osztályzatból {jegy1} db");
            Console.WriteLine($"2 osztályzatból {jegy2} db");
            Console.WriteLine($"3 osztályzatból {jegy3} db");
            Console.WriteLine($"4 osztályzatból {jegy4} db");
            Console.WriteLine($"5 osztályzatból {jegy5} db");

            Console.WriteLine($"Az átlaga az osztályzatoknak: {osztalyzatok.Average()}");
            Console.WriteLine("---------------------------------------------");

            //Hatodik feladat
            Console.WriteLine("Hatodik feladat:");
            Console.Write("Adj meg egy számot 1 és 10 között: ");
            int szams = int.Parse(Console.ReadLine());

            if (szams < 1 || szams > 10)
            {
                Console.WriteLine("Hibás szám! Csak 1 és 10 közötti számot adhatsz meg.");
                return;
            }

            Console.WriteLine($"\nA(z) {szams} szorzótáblájának 3-mal osztható elemei:");

            for (int i = 1; i <= 10; i++)
            {
                int szorzat = szams * i;
                if (szorzat % 3 == 0)
                {
                    Console.WriteLine($"{szams} × {i} = {szorzat}");
                }
            }

            Console.WriteLine("---------------------------------------------");

            //Hetedik feladat
            Console.WriteLine("Hetedik feladat:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. szám: ");
                int pozneg = int.Parse(Console.ReadLine());

                if (pozneg > 0)
                {
                    Console.WriteLine("A szám pozitív.");
                }
                else if (pozneg < 0)
                {
                    Console.WriteLine("A szám negatív.");
                }
                else
                {
                    Console.WriteLine("A szám nulla.");
                }

                if (pozneg % 2 == 0)
                {
                    Console.WriteLine("Páros szám.");
                }
                else
                {
                    Console.WriteLine("Páratlan szám.");
                }

                if (pozneg % 3 == 0)
                {
                    Console.WriteLine("Osztható 3-mal.");
                }
                else
                {
                    Console.WriteLine("Nem osztható 3-mal.");
                }
            }

            Console.WriteLine("---------------------------------------------");

            Console.Write("Adja meg a jelszót:");

            string jelszo1 = Console.ReadLine();
            Console.Write("Adja meg újra a jelszót:");
            string jelszo2 = Console.ReadLine();

            if (jelszo1 == jelszo2)
            {
                string szoveg = Console.ReadLine();
                Console.WriteLine(new string(szoveg.Reverse().ToArray()));
            }

            else
            {
                Console.WriteLine("Nem egyezik a jelszó!");
            }

            Console.WriteLine("---------------------------------------------");

            //Kilencedik feladat

            List<int> primszamok = new List<int>();

            int db_prim = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i % j == 0)
                    {
                        db_prim++;
                    }
                }

                if (db_prim <= 2)
                {
                    primszamok.Add(i);
                }

                db_prim = 0;
            }

            foreach (var item in primszamok)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine($"{primszamok.Count} prím szám van.");

            Console.WriteLine("---------------------------------------------");



        }


    }
}
