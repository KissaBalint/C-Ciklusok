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
                Console.WriteLine($"A nagyobb szám a: {szam1} és a különbségük {szam1-szam2}");

            }
            else
            {
                Console.WriteLine($"A nagyobb szám a: {szam2} és a különbségük {szam2 - szam1}");
            }

            Console.WriteLine("---------------------------------------------");
        }
    }
}
