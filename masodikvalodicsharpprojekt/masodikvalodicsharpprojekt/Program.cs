using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikvalodicsharpprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Feladat
            /*int szam = 0;
            while (szam <= 0)
            {
                Console.Write("Kérek egy pozitív egész számot:");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            if (osszeghettel(szam))
            {
                Console.WriteLine($"{szam} valódi sztóinak összege osztható 7-el");
            }
            else
            {
                Console.WriteLine($"{szam} valódi sztóinak összege  nem osztható 7-el");
            }*/


            //2. feladat
            /*Console.Write("1-100 ig számok amiknek osztoinak osszege osztaható 7-el:");
            
            for (int i = 1; i < 101; i++)
            {
                if (osszeghettel(i))
                {
                    Console.WriteLine($"{i} valódi sztóinak összege osztható 7-el");
                }
            }*/

            /*Console.WriteLine("2-tol 100-ig a primszamok: ");
            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }*/
            //11.18. első feladat
            /* int szam = -89;
             bool egeszSzam = true;

             do
             {
                 Console.Write("Kérek egy számot: ");
                 egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);

             } while (!egeszSzam);          

             Console.WriteLine($"A bekért szám: {szam}");


             Console.ReadKey(true);
         } */

            /*static bool osszeghettel(int szam)
            {
                int osszeg = 0;
                bool hettel = true;

                for (int i = 1; i < szam; i++)
                {
                    if (szam % i == 0)
                    {
                        osszeg += i;
                    }
                }

                if (osszeg % 7 != 0)
                {
                    hettel = false;
                }
                return hettel;

            }*/

            /*static bool primszamE(int szam)
            {
                bool primE = true;
                int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;
                for (int i = 2; i < hatar; i++)
                {
                    if (szam%i == 0)
                    {
                        primE = false;
                        break;
                    }
                }
                return primE;*/

            // 28.-29. Fealadat
            /*Console.Write("Kérek egy számot: ");
            string kimenet = "";
            int szam = Convert.ToInt32(Console.ReadLine());
            int meddig = (int)(Math.Floor(Math.Sqrt(szam))) + 1;
            kimenet += szam + " = ";
            for (int i = 2; i < meddig; i++)
            {
                if (szam % i == 0)
                {
                    if (szam == 1)
                    {
                        kimenet += i;
                    }
                    else
                    {
                        kimenet += i + " * ";
                        szam = szam / i;
                        i--;
                    }
                }
            }
            Console.WriteLine(kimenet);
            Console.ReadKey(true);*/

            // 32. Feladat
            /*Console.Write("Kérek egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < szam+1; i++)
            {
                for (int j = 1; j < szam+1; j++)
                {
                    Console.SetCursorPosition(3 * (j - 1) + 1, i);
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);*/

            // 34. Feladat
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {

                }
                for (int k = 10; k < 100; k++)
                {

                }
            }
        }
    }
}
