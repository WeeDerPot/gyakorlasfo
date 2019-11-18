using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            // Hiányzó feladatok !!!

            /*15. Feladat:
            Console.Write("Adj meg egy számot: ");
            int bemenet = Int32.Parse(Console.ReadLine());*/
            // első megoldás
            /*string kimenet = "";
            for (int i = 1; i < bemenet; i++)
            {
                kimenet += i + " ";
            }
            Console.WriteLine(kimenet);*/
            // második megoldás (optimalizált)

            /*for (int i = 1; i < bemenet; i++)
            {
                Console.Write(i + " ");
            }*/
            /* elöl tezstelő ciklus
            int i = 1;
            while (i < bemenet)
            {
                Console.Write(i++ + " ");
                // (i = i + 1; i += 1; i++;)
            } */
            /* hátul tesztelő ciklus
            int i = 1;
            do
            {
                Console.Write(i++ + " ");
            } while (i < bemenet); */

            // 16. Feladat
            /*Console.Write("Adj meg egy számot: ");
            int bemenet = Int32.Parse(Console.ReadLine());*/
            /*string kimenet = "";
            for (int i = 1; i < bemenet; i++)
            {
                kimenet += i + "\n"; // (\n = sortörés)
            }
            Console.WriteLine(kimenet);*/
            // második megoldás (optimalizált)

            /*for (int i = 1; i < bemenet; i++)
            {
                Console.WriteLine(i);
            }*/
            // elöl tezstelő ciklus
            /*int i = 1;
            while (i < bemenet)
            {
                Console.Write(i++ + "\n");
                // (i = i + 1; i += 1; i++;)
            } */
            // hátul tesztelő ciklus
            /*int i = 1;
            do
            {
                Console.Write(i++ + "\n");
            } while (i < bemenet); */

            // 17. Feladat
            /*Console.Write("Adj meg egy számot: ");
            int bemenet = Int32.Parse(Console.ReadLine());
            Console.WriteLine("A szám egész osztói: ");*/
            // első
            /*for (int i = 1; i < bemenet +1; i++)
            {

                if (bemenet%i == 0)
                {
                    Console.Write(i +", ");
                }
            }*/
            // második
            /*int i = 1;
            while (i < bemenet)
            {
                if (bemenet%i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            // Plusz feladat: pozitív szám príme. 18. Feladat
            /*Console.Write("Adj meg egy számot: ");
            int bemenet = Int32.Parse(Console.ReadLine());
            int szamlalo = 0;
            int osztokOsszege = 0;
            for (int i = 1; i < bemenet + 1; i++)
            {
                if (bemenet % i == 0)
                {
                    szamlalo++;
                    osztokOsszege += i;
                }
            }
                if (szamlalo == 2)
                {
                    Console.WriteLine($"A szám {bemenet} prím.");
                    Console.WriteLine($"A szám {osztokOsszege} osztóinak összege.");
                }
                else
                {
                Console.WriteLine($"A szám {bemenet} nem prím.");
                Console.WriteLine($"A szám {osztokOsszege} osztóinak összege.");
                }*/

            // 19. Feladat
            /*Console.Write("Adj meg egy számot: ");
            int bemenet = Int32.Parse(Console.ReadLine());
            int osztokOsszege = 0;
            int i = 1;
            while (i < bemenet)
            {
                if (bemenet%i == 0)
                {
                    osztokOsszege += i;
                }
                i++;
            }
            if (osztokOsszege == bemenet)   // vagy 2*bemenet vagy while i <= bemenet
            {
                Console.WriteLine($"A szám {bemenet} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A szám {bemenet} nem tökéletes szám.");
            }*/

            // 20. Feladat
            /*int alap = -1;
            while (alap <0 || alap > 10)
            {
                Console.WriteLine("Adj meg egy kitevot");
                alap = Int32.Parse(Console.ReadLine());
            }
            int kitevo = -1;
            while (kitevo < 0 || kitevo > 10)
            {
                Console.WriteLine("Adj meg egy kitevot");
                kitevo = Int32.Parse(Console.ReadLine());
            }*/ // felső 0-10 között.
            /*Console.Write("Adj meg egy alapot: ");
            int alap = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy kitevot: ");
            int kitevo = Int32.Parse(Console.ReadLine());*/
            /*int hatvany = 1;
            for (int i = 0; i < kitevo; i++)
            {
                hatvany *= alap;
            }
            Console.Write($"A hatvány: {hatvany}");*/

            // 21. Feladat
            /*int szam = 0;
            while (szam % 2 == 1 || szam % 2 == -1)
            {
                Console.Write("Adj meg egy páros számot: ");
                szam = Int32.Parse(Console.ReadLine());
            }*/

            // Plusz feladat prímre lépjen ki a ciklusból
            /*int szam = 3;
            while (primszamE(szam))
            {
                Console.WriteLine("Kérek egy nem prím számot.");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            //22. Feladat
            /*int szam = 0;
            int osszeg = 0;

            while (szam <= 10)
            {
                osszeg += szam;
                Console.WriteLine("Kérek egy tíznél kisebb egész számot");
                szam = Int32.Parse(Console.ReadLine());
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott számok összege: {osszeg}");
                }
                else
                {
                    Console.WriteLine("Nem megfelelő szám!");
                    break;
                }
            }
            Console.WriteLine($"A beolvasott számok összege {osszeg}");

            Console.ReadKey(true);
        }

        static bool primszamE(int szam)
        {
            bool teljesul = true;
            int osztokszama = 0;
            for (int i = 1; i<=szam; i++)
			{
                if (szam % i == 0)
	            {
                    osztokszama++;
	            }
            }
            if (osztokszama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }*/

            // 23. feladat
            /*string kimenet = "";
            Console.WriteLine("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            kimenet += szam + " = ";
            while (szam % 2 == 0)
            {
                kimenet += 2 + " * ";
                szam /= 2;
            }
            kimenet += szam;
            Console.WriteLine(kimenet);
            Console.ReadKey(true);*/

            // 24. feladat
            /*string kimenet = "";
            while (kimenet != "alma");
            {
                Console.WriteLine(" Kérek egy almát: ");
                kimenet = Console.ReadLine();
            }
            Console.WriteLine("Az alma egy gyümölcs!");
            Console.ReadKey(true);*/




            // 25.feladat
            /*string kimenet = "";
            Console.WriteLine("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int egesz = 0;
            int tort = szam;
            kimenet += szam + " = ";
            while (szam - 3 >= 0)
            {
                szam -= 3;
                egesz++;
                tort = szam;
            }
            kimenet += egesz + " * 3 + " + tort;
            Console.WriteLine(kimenet);
            Console.ReadKey(true);*/


        }		
    }
}
