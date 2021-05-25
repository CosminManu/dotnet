using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_s4.Modele
{
    class Translator : Angajat, ICloneable
    {
        public List<String> LimbiVorbite { get; set; }

        public override String GetDetalii()
        {
            return base.GetDetalii();
        }

        // suprascriere de metoda (overriding)
        // runtime polymorphism
        public override string GetAdresa()
        {
            return $"{this.Denumire} locuieste la: {this.Adresa}";
        }

        // supraincarcare de metode (overloading)
        // compile time polymorphism
        public double GetSalariu()
        {
            return this.Salariu;
        }

        public double GetSalariu(float oreSuplimentare)
        {
            return this.Salariu * (160 + oreSuplimentare) / 160;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
