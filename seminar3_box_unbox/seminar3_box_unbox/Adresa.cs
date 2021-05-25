using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3_box_unbox
{
    //default modifier pt clase: internal
    //default modifier pt atribute: private
    internal class Adresa : IComparable<Adresa>, IComparable
    {
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Oras { get; set; }

        public override string ToString()
        {
            return Numar.ToString();
        }

        //varianta IComparable 
        //intoarce
        //1 daca Numar(this) > obj.Numar (urm elem din lista)
        //0 daca Numar(this) = obj.Numar
        //-1 daca Numar(this) < obj.Numar 
        public int CompareTo(object obj)
         {
             return this.Numar.CompareTo((obj as Adresa).Numar);
             //tipuri nongenerice (nu fol in mod explicit tipul)
         }

        //varianta IComparable<>
        //1 daca Numar(this) > other.Numar (urm elem din lista)
        //0 daca Numar(this) = other.Numar
        //-1 daca Numar(this) < other.Numar 
        public int CompareTo(Adresa other)
        {
            return this.Numar.CompareTo(other.Numar);
        }
    }
}
