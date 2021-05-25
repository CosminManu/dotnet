using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_s4.Modele
{
    public abstract class Persoana
    {
        private String _Denumire;
        public String Denumire
        {
            get
            {
                return _Denumire;
            }
            set
            {
                _Denumire = value;
            }
        }

        public int Varsta { get; set; }

        public bool AreRaspundereDeplina()
        {
            return this.Varsta >= 18;
        }

        // orice clasa care mosteneste Persoana TREBUIE sa implementeze GetDetalii
        public abstract String GetDetalii();

        // orice clasa care mosteneste Persoana POATE implementa GetAdresa
        public virtual String GetAdresa()
        {
            return "Nu exista detalii despre adresa";
        }

    }
}
