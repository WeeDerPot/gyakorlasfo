using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace egy_tanar_naploja_0210
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[30];
            int osszeg = 0;
            int negativSzamok = 0;
            List<int> paratlanok = new List<int>();
            using (StreamReader sr = new StreamReader("szamok30.txt", Encoding.UTF8))
            {
                for (int i = 0; i < 30; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());
                    osszeg += tomb[i];
                    if (tomb[i] < 0)
                    {
                        negativSzamok++;
                    }
                    if (tomb[i] % 2 == 1)
                    {
                        paratlanok.Add(tomb[i]);
                    }
                }
            }
            Console.WriteLine($"A számok összege:{osszeg}");
            Console.WriteLine($"A negatív értékek száma:{negativSzamok}");
            Console.WriteLine($"A páratlan számok: ");
            foreach (var item in paratlanok)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine("\nA kétszámjegyű számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                if (Math.Abs(tomb[i]) > 9 && Math.Abs(tomb[i]) < 100)
                {
                    Console.Write($"{tomb[i]}");
                }
            }
            Console.Write("\nAdj egy számot 50 és 100 között.");
            int eddig = Int32.Parse(Console.ReadLine());
            int szamlal = 0;
            string kiir = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                szamlal += tomb[i];
                if (szamlal < eddig)
                {
                    kiir += $"({tomb[i]}) +";
                }
                else
                {
                    kiir += $"({tomb[i]}) >= {eddig}";
                    break;
                }
            }
            Console.WriteLine(kiir);

            Console.ReadKey(true);
        }
    }
}
