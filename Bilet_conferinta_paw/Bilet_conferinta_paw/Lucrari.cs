using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_conferinta_paw
{
    public class Lucrari
    {
        private int codL;
        private string denumL;
        private int sectiune;

        public Lucrari(int _codL, string _denumL, int _sectiuneL)
        {
            codL = _codL;
            denumL = _denumL;
            sectiune = _sectiuneL;
        }

        public Lucrari() { }

        public int CodL
        {
            get { return this.codL; }
            set { this.codL = value; }
        }

        public string DenumL
        {
            get { return this.denumL; }
            set { this.denumL = value; }
        }

        public int Sectiune
        {
            get { return this.sectiune; }
            set { this.sectiune = value; }
        }
    }
}
