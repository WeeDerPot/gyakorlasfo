using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorláscsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            // 41. Feladat
            for (int i = 0; i < 26; i++)
            {
                for (int j = 65; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                for (int k = 65; k < 65+i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
