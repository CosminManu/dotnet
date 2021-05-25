using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_s4.Modele
{
    public class Angajat : Persoana, IComparable<Angajat>
    {
        // c-tor default

        public DateTime DataAngajarii { get; set; }     // DateTime: date and time of the day
        public double Salariu { get; set; }
        public String Adresa { get; set; }
        public EIncadrare Incadrare { get; set; }       //enum Incadrare

        public int CompareTo(Angajat ang)
        {
            return this.Salariu.CompareTo(ang.Salariu);
        }

        public override string GetDetalii()
        {
            return $"{this.Denumire} este angajat din {this.DataAngajarii.ToShortDateString()}";
        }
    }
}
