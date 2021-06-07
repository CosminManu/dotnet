using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_demo.Modele
{
    class Order
    {
        public long Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int here { get; set; }
        public int away { get; set; }
        public double total { get; set; }

        public Order(string f, string l, int h, int a)
        {
            firstname = f;
            lastname = l;
            here = h;
            away = a;
        }

        public Order( double tot)
        {
            total = tot;
        }


    }
}
