using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_demo
{
    /// <summary>
    /// denumire, pret per item, cantitate
    /// </summary>
    class Items
    {

        public int Cantitate { get; set; }
        public double Pret { get; set; }
        public double Total { get; set; }
        public string Denumire { get; set; }

        public Items(string den, double p, int c)
        {
            this.Denumire = den;
            this.Pret = p;
            this.Cantitate = c;
        }

        public Items(string den, double p, int c, double t)
            :this(den, p, c)
        {
            this.Total = t;
        }
    }
}
