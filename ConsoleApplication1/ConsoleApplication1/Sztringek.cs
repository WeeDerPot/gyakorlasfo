using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Sztringek
    {
        public string Szoveg { get; set; }
        public string elso { get; set; }
        public string masodik { get; set; }
        //feladat: egyenlő hosszúak e
        public Sztringek(string szoveg)
        {
            this.Szoveg = szoveg;
        }
        /*public Sztringek(string a, string b)
        {
            this.elso = a;
            this.masodik = b;
        }*/
        /*public bool Egyenlohosszuak(Sztringek masik)
        {
            if (this.Szoveg.Length == masik.Szoveg.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        /*public bool Egyenlohosszuak()
        {
            if (this.elso.Length == this.masodik.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        //feladat nev kiírása
        public string TeljesNev()
        {
            return this.masodik + "," + this.elso;
        }
        public bool vanSpace ()
        {
            if (this.Szoveg.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool vanSpaceMasodik()
        {
            bool vanE = false;
            for (int i = 0; i < this.elso.Length; i++)
            {
                if (this.elso[i] == ' ')
                {
                    vanE = true;
                }
            }
            return vanE;
        }
    }
}
