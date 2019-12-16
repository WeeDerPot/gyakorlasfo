using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._16.karacsonyi_gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
                int szelesseg = Console.WindowWidth;
                int magassag = Console.WindowHeight;
                int x = szelesseg / 2;
                int y = magassag / 2;
                int[] xCoord = new int[5];
                int[] yCoord = new int[5];
            // Új (food)
            int[] pontokx = new int[10];
            int[] pontoky = new int[10];
            for (int i = 0; i < 10; i++)
            {
                pontokx[i] = rnd.Next(0, szelesseg);
                pontoky[i] = rnd.Next(0, magassag);
            }
                for (int i = 0; i < 5; i++)
                {
                    xCoord[i] = x + i;
                    yCoord[i] = y;
                }
                Megrajzol(xCoord, yCoord);
                //Console.WriteLine($"{szelesseg} és {magassag}");
                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                while (cki.Key != ConsoleKey.Escape)
                {
                    cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            Console.Clear();
                            Megrajzol(pontokx, pontoky);
                            Balfele(ref xCoord, ref yCoord);
                            Megrajzol(xCoord, yCoord);
                            for (int i = 0; i < pontokx.Length; i++)
                            {
                                if (pontokx[i] == xCoord[xCoord.Length -1] && pontoky[i] == yCoord[yCoord.Length - 1])
                                {
                                    pontokx = egyelcsokkent(pontokx[i], pontoky);
                                    pontoky = egyelcsokkent(pontoky[i], pontokx);
                                }
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            Console.Clear();
                            Megrajzol(pontokx, pontoky);
                            Felfele(ref xCoord, ref yCoord);
                            Megrajzol(xCoord, yCoord);
                        
                        break;
                        case ConsoleKey.RightArrow:                   
                            Console.Clear();
                            Megrajzol(pontokx, pontoky);
                            Jobbfele(ref xCoord, ref yCoord);
                            Megrajzol(xCoord, yCoord);
                        
                        break;
                        case ConsoleKey.DownArrow:
                            Console.Clear();
                            Megrajzol(pontokx, pontoky);
                            Lefele(ref xCoord, ref yCoord);
                            Megrajzol(xCoord, yCoord);

                        break;
                    }
                }
                Console.ReadKey(true);
            }
            static void Megrajzol(int[] x, int[] y)
            {
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i], y[i]);
                    Console.Write("*");
                }
            }
            static void Felfele(ref int[] x, ref int[] y)
            {
                int[] atmenetX = x;
                int[] atmenetY = y;
                for (int i = 0; i < 4; i++)
                {
                    x[i] = atmenetX[i + 1];
                    y[i] = atmenetY[i + 1];
                }
                x[4] = atmenetX[4];
                y[4] = atmenetY[4] - 1;
            }
            static void Lefele(ref int[] x, ref int[] y)
            {
                int[] atmenetX = x;
                int[] atmenetY = y;
                for (int i = 0; i < 4; i++)
                {
                    x[i] = atmenetX[i + 1];
                    y[i] = atmenetY[i + 1];
                }
                x[4] = atmenetX[4];
                y[4] = atmenetY[4] + 1;
            }
            static void Jobbfele(ref int[] x, ref int[] y)
            {
                int[] atmenetX = x;
                int[] atmenetY = y;
                for (int i = 0; i < 4; i++)
                {
                    x[i] = atmenetX[i + 1];
                    y[i] = atmenetY[i + 1];
                }
                x[4] = atmenetX[4] + 1;
                y[4] = atmenetY[4];
            }
            static void Balfele(ref int[] x, ref int[] y)
            {
                int[] atmenetX = x;
                int[] atmenetY = y;
                for (int i = 0; i < 4; i++)
                {
                    x[i] = atmenetX[i + 1];
                    y[i] = atmenetY[i + 1];
                }
                x[4] = atmenetX[4] - 1;
                y[4] = atmenetY[4];
            }
            static int[] egyelcsokkent(int szam, int[] a)
            {
            int[] b = new int[a.Length - 1];
            for (int i = 0; i < b.Length; i++)
            {
                if (szam != a[i])
                {
                    b[i] = a[i];
                }
                else if (szam == a[i] && i != a.Length -1)
                {
                    b[i] = a[i + 1]; // b[i++] = a[i + 1]; Így is működne
                    i++;
                }
            }
            }
    }
}
