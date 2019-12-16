using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlofeladatok_középhaldó_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Feladat
        /*
            Console.WriteLine("Kérem a tömb elemszámát: ");
            int elemszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[elemszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }
            int maxkulonbseg = Int32.MinValue;
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int kulonbseg = Math.Abs(tomb[i] - tomb[i + 1]);
                if (maxkulonbseg <= kulonbseg)
                {
                    maxkulonbseg = kulonbseg;
                }
            }
            Console.WriteLine($"A maximális különbsége:{maxkulonbseg}");
        */

            // 2. Feladat
            Console.WriteLine("Kérem a tömb elemszámát: ");
            int elemszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[elemszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }
            int elso = 0;
            int masodik = 0;
            int minkulonbseg = Int32.MaxValue;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i+1; j < tomb.Length; j++)
                {

                }
            }
            Console.ReadKey(true);
        }
    }
}
