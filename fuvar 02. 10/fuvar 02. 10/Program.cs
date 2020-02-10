using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fuvar_02._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string elsoSor = "";

            List<FuvarInfo> lista = new List<FuvarInfo>();

            //using (StreamReader sr = new StreamReader(@"C:\Users\bozot\Asztali gép\Programozás gyakorlat\November19\C#projektek\githubgyakffo\Fuvar\fuvar.csv", Encoding.UTF8))
            using (StreamReader sr = new StreamReader("fuvar.csv", Encoding.UTF8))
            {
                elsoSor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    int az = Int32.Parse(sor.Split(';')[0]);
                    string ib = sor.Split(';')[1];
                    int it = Int32.Parse(sor.Split(';')[2]);
                    double mt = Double.Parse(sor.Split(';')[3]);
                    double vt = Double.Parse(sor.Split(';')[4]);
                    double bv = Double.Parse(sor.Split(';')[5]);
                    string fm = sor.Split(';')[6];
                    FuvarInfo fi = new FuvarInfo(az, ib, it, mt, vt, bv, fm);
                    lista.Add(fi);
                }
            }

            Console.WriteLine($"3.feladat: {lista.Count} fuvar");



            double osszViteldij = 0.0d;
            int fuvarSzam = 0;
            foreach (var item in lista)
            {
                fuvarSzam++;
                osszViteldij = osszViteldij + item.Viteldij; // <= ugyan az:  osszViteldij += item.Viteldij;
            }

            Console.WriteLine($"4.feladat: {fuvarSzam} fuvar alatt {osszViteldij}$");



            Dictionary<string, int> mivelHanyszor = new Dictionary<string, int>();
            foreach (var item in lista)
            {
                string fizetesiMod = item.FizetesModja;
                int darabSzam = 0;

                foreach (KeyValuePair<string, int> elem in mivelHanyszor)
                {
                    if (elem.Key == fizetesiMod)
                    {
                        darabSzam = elem.Value;
                        mivelHanyszor.Remove(fizetesiMod);
                        break;
                    }
                }
                mivelHanyszor.Add(fizetesiMod, ++darabSzam);
            }

            Console.WriteLine("5.feladat:");



            foreach (KeyValuePair<string, int> item in mivelHanyszor)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} fuvar");
            }

            double osszFutottMerfold = 0.0d;
            foreach (var item in lista)
            {
                osszFutottMerfold += item.MegtettTavolsag;
            }

            Console.WriteLine($"6.feladdat: {osszFutottMerfold * 1.6:F2}km");



            FuvarInfo leghosszabb = new FuvarInfo();

            foreach (var item in lista)
            {
                if (item.MegtettTavolsag >= leghosszabb.MegtettTavolsag)
                {
                    leghosszabb = item;
                }
            }

            Console.WriteLine("7.feladat: Leghosszabb fuvar: ");
            Console.WriteLine($"\t Fuvar hossza: {leghosszabb.Idotartam} masodperc");
            Console.WriteLine($"\t Taxi azonosito: {leghosszabb.Azonosito}");
            Console.WriteLine($"\t Megtett tavolsag: {leghosszabb.MegtettTavolsag * 1.6} km");
            Console.WriteLine($"\t Viteldij: {leghosszabb.Viteldij}$");


            Console.WriteLine("8.Feladat: hibak.txt");

            List<FuvarInfo> nullasok = new List<FuvarInfo>();
            FuvarInfo fiNullas = new FuvarInfo("3");
            nullasok.Add(fiNullas);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Idotartam != 0 && lista[i].Viteldij != 0 && lista[i].MegtettTavolsag != 0)
                {
                    for (int j = 0; j < nullasok.Count; j++)
                    {
                        if (String.Compare(lista[i].IdoBelyegzo, nullasok[j].IdoBelyegzo) < 0)
                        {
                            nullasok.Insert(j, lista[i]);
                            break;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter("hibak.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(elsoSor);
                foreach (var item in nullasok)
                {
                    sw.WriteLine(item.kiiroString());
                }
            }

            Console.ReadKey(true);

        }
    }
}
