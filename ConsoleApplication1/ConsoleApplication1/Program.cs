using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Kérek az elso szamot");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(elsoSzam);
            Console.Write("Kérem a msodik szamot");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());
            Elso masodik = new Elso(masodikSzam);

            Console.WriteLine($"a ket szam osszege: {Sum(elsoSzam, masodikSzam)}");
            Console.WriteLine($"a ket szam osszege: {elso.Sum(masodik)}");
            Console.WriteLine($"a ket szam osszege: {masodik.Sum(elso)}");*/

            /* Console.Write("Kérek egy szamot");
             int elsoSzam = Convert.ToInt32(Console.ReadLine());
             Elso elso = new Elso(elsoSzam);

             Console.WriteLine($"a megadott szam visszateresi erteke:{PluszEgy(elsoSzam)}");
             Console.WriteLine($"a megadott szam visszateresi erteke:{elso.Kovetkezo()}");

             Console.ReadKey(true);

         }

         static int PluszEgy(int elsoSzam)
         {

             return elsoSzam + 1;
         }*/
            /*Console.Write("Kérem a haromszog alapjat");
            int alap = Convert.ToInt32(Console.ReadLine());
            Haromszoog haromszoog = new Haromszoog(alap, magassag);
            Console.Write("Kérem a haromszog magassagat");
            int magassag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A haromszog terulete:{HaromSzog(alap, magassag)}");
            //Console.WriteLine($"A haromszog terulete:{}");

            Console.ReadKey(true);

        }
        static int HaromSzog(int a, int b)
        {
            return a * b / 2;
        }*/
            /* Console.Write("Kérem az elso szamot");
             int elsoszam = Convert.ToInt32(Console.ReadLine());
             Console.Write("Kérem a masodik szamot");
             int masodikszam = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine($"A maradekos osztas eredmenye:{Maradek(elsoszam, masodikszam)}");
             Console.ReadKey(true);
         }
         static int Maradek(int a, int b)
         {
             return a % b;
         }*/

            //feladat
            /*Console.WriteLine("Kérek a Logikai értéket");
            bool elsoSzam = Convert.ToBoolean(Console.ReadLine());
            Elso elso = new Elso(elsoSzam);
            Console.WriteLine($"A logikai érték negáltja:{Megfordit(elsoSzam)}");
            Console.ReadKey(true);*/


            //feladat
            /*Console.WriteLine("Kérem a számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(elsoSzam);
            Elso masodik = new Elso(5);
            Console.WriteLine($"A szám osztható-e öttel: {OttelOszthato(elsoSzam)}");

            Console.ReadKey(true);*/


            //feladat
            /*Console.WriteLine("Kérem az első sztringet: ");
            string elsoSzoveg = Console.ReadLine();
            Sztringek elso = new Sztringek(elsoSzoveg);
            Console.WriteLine("Kérem a második sztringet: ");
            string masodikSzoveg = Console.ReadLine();
            Sztringek masodik = new Sztringek(masodikSzoveg);
            Console.WriteLine($"A két string egyenlő hosszú: {elso.Egyenlohosszuak(masodik)}");

            Console.ReadKey(true);*/


            //feladat
            Console.WriteLine("Kérem az első sztringet: ");
            string elsoSzoveg = Console.ReadLine();
            Sztringek elso = new Sztringek(elsoSzoveg);
            Console.WriteLine("Kérem a második sztringet: ");
            string masodikSzoveg = Console.ReadLine();
            Sztringek masodik = new Sztringek(masodikSzoveg);
            Console.WriteLine($"A teljes név: ");
            Sztringek egyutt = new Sztringek(elsoSzoveg, masodikSzoveg);
            Console.WriteLine($"Az elso stringben van e space: {egyutt.vanSpace}");

            Console.ReadKey(true);


            
            Console.WriteLine($"Az elso stringben van e space: {egyutt.vanSpace}");
        }
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static bool Megfordit(bool logikaiErtek)
    {
        return !logikaiErtek;
    }
        static bool OttelOszthato(int a)
        {
            if (a % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

}
}
