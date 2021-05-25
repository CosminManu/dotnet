using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3_box_unbox
{
    class Persoana 
    {
        //String si string acelasi lucru
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public Adresa Domiciliu { get; set; }       //HAS A (o pers are o adresa)

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}