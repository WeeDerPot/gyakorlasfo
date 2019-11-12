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

            Console.WriteLine("2-tol 100-ig a primszamok: ");
            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
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

        static bool primszamE(int szam)
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
            return primE;
        }
    }
}
