using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_comandaPizza
{
    class Toping
    {
        private string denumire;
        private double pret;
        private double cantitate;
        public const int cod = 3001;


        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }

        public double Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public double Cantitate
        {
            get { return this.cantitate; }
            set { this.cantitate = value; }
        }

    }
}
