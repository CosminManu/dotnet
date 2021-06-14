using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_conferinta_paw
{
    public class Sectiuni
    {
        private int codS;           //private e tip default
        private string denumS;

        public Sectiuni(int _codS, string _denumS)
        {
            codS = _codS;
            denumS = _denumS;
        }

        public Sectiuni() { }

        //proprietati tip public tip_return nume
        //GET si SET pt campuri private
        public int CodS
        {
            get { return this.codS; }
            set { this.codS = value; }
        }

        public string DenumS
        {
            get { return this.denumS; }
            set { this.denumS = value; }
        }

    }
}
