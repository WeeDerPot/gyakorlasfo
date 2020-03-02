using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoForm
{
    class Auto
    {
        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int Evjarat { get; set; }
        public string Uzemanyag { get; set; }
        public Auto(string rsz, string marka, string tip, int ej, string ua)
        {
            this.Rendszam = rsz;
            this.Marka = marka;
            this.Tipus = tip;
            this.Evjarat = ej;
            this.Uzemanyag = ua;
        }
        public string Kiir()
        {
            return $"{this.Rendszam},{this.Marka},{this.Tipus},{this.Evjarat},{this.Uzemanyag}";
        }
    }
}
