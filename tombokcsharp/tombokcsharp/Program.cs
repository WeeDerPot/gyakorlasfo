using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombokcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 42-43-44. Feladat
            /*
                    Console.WriteLine("Mennyi adattal dolgozzak?: ");
                    int darabszam = Int32.Parse(Console.ReadLine());
                    // tömb létrehozása
                    int[] tomb = new int[darabszam];
                    // tömb feltöltése
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        Console.Write($"Kérem az ({i + 1}). számot: ");
                        int szam = Int32.Parse(Console.ReadLine());
                        tomb[i] = szam;
                    }
                    // megszámoljuk a páratlan tömbelemeket
                    int paratlanokSzama = 0;
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        if (tomb[i]%2==1)
                        {
                            paratlanokSzama++;
                        }
                    }
                    Console.WriteLine($"A páratlanok száma:{paratlanokSzama}");
                    // páros számok összege
                    int parosokOsszege = 0;
                    for (int i = 0; i < tomb.Length; i++)
                    {
                        if (tomb[i]%2==0)
                        {
                            parosokOsszege += tomb[i];
                            console.writeline( az tomb[i]edik szám páros)
                        }
                    }
                    Console.WriteLine($"Aa páros számok összege:{parosokOsszege}");
                    // Két ifet egy foron belül meg lehet valósítani
         */
            // 45. Feladat
            /*
                   Console.WriteLine("Mennyi adattal dolgozzak?: ");
                   int darabszam = Int32.Parse(Console.ReadLine());
                   int[] tomb = new int[darabszam];
                   for (int i = 0; i < tomb.Length; i++)
                   {
                       Console.Write($"Kérem az ({i + 1}). számot: ");
                       int szam = Int32.Parse(Console.ReadLine());
                       tomb[i] = szam;
                   }
                   Console.Write("Kérem a próbaszámot");
                   int probaszam = Convert.ToInt32(Console.ReadLine());
                   int tombindex = -1;
                   bool vanE = false;

                   for (int i = 0; i < tomb.Length; i++)
                   {
                       if (tomb[i] == probaszam)
                       {
                           tombindex = i + 1;
                           vanE = true;
                           break;
                       }
                   }
                   if (vanE)
                   {
                       Console.WriteLine($"Találtam ilyen számot a {tombindex} pozicíóban.");
                   }

               else
                   {
                       Console.WriteLine("Nincs ilyen szám");
                   }
           */

            // 46. Feladat
            /*
                Console.WriteLine("Mennyi adattal dolgozzak?: ");
                int darabszam = Int32.Parse(Console.ReadLine());
                int[] tomb = new int[darabszam];
                for (int i = 0; i < tomb.Length; i++)
                {
                    Console.Write($"Kérem az ({i + 1}). számot: ");
                    int szam = Int32.Parse(Console.ReadLine());
                    tomb[i] = szam;
                }
                Console.Write("Kérem a próbaszámot");
                int probaszam = Convert.ToInt32(Console.ReadLine());
                int szamlalo = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] == probaszam)
                    {
                        szamlalo++;
                    }
                }
                if (szamlalo !=0)
                {
                    Console.WriteLine($"A {probaszam} ennyiszer szerepel {szamlalo}");
                }
                else
                {
                    Console.WriteLine("Ilyen szám nincs a tömbben.");
                }
           */
            // 47. Feladat
            /*
               Console.WriteLine("Mennyi adattal dolgozzak?: ");
               int darabszam = Int32.Parse(Console.ReadLine());
               string[] tomb = new string[darabszam];
               for (int i = 0; i < tomb.Length; i++)
               {
                   Console.Write($"Kérem az ({i + 1}). számot: ");
                   string keresztnev = (Console.ReadLine());
                   tomb[i] = keresztnev;
               }
               Console.Write("Kérem a próbanevet");
               string probanev = (Console.ReadLine());
               int szamlalo = 0;
               for (int i = 0; i < tomb.Length; i++)
               {
                   if (tomb[i] == probanev)
                   {
                       szamlalo++;
                   }
               }
               if (szamlalo != 0)
               {
                   Console.WriteLine($"A {probanev} ennyiszer szerepel {szamlalo}");
               }
               else
               {
                   Console.WriteLine("Ilyen név nincs a tömbben.");
               }
           */

            // 48. Feladat    (eljárással vagy levi féle min max)
        /*
            Console.WriteLine("Mennyi adattal dolgozzak?: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
             //extra megoldás 
            int maxkulonbseg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    int kulonbseg = Math.Abs(tomb[i] - tomb[j]);
                    if (maxkulonbseg <= kulonbseg)
                    {
                        maxkulonbseg = kulonbseg;
                    }
                }
            }
            Console.WriteLine($"A  ciklusok különbség: "+ maxkulonbseg);

            Array.Sort(tomb);
            Console.WriteLine($"A  eljárás különbség: {tomb[tomb.Length-1] - tomb[0]}");
            // Levié
            Console.WriteLine($"A  Levi kulonbség: {tomb.Max() - tomb.Min()}");
        */

            Console.ReadKey(true);
        }

        static void tombkiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
}
