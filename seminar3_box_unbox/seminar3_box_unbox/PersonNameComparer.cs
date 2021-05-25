using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3_box_unbox
{
    class PersonNameComparer : IComparer<Persoana>
    {
        public int Compare(Persoana x, Persoana y)
        {
            return x.Nume.CompareTo(y.Nume); 
        }
    }
}
