using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_s4.Modele
{
    public class Programator : Angajat, ICloneable
    {
        public List<String> LimbajeProgramare { get; set; }

        // c-tor (constructor) fara parametri
        public Programator() {}

        
        // c-tor cu parametri
        public Programator(String nume, int varsta, String adresa, 
            DateTime data, EIncadrare i, List<String> lista)
        {
            this.Denumire = nume;
            this.Varsta = varsta;
            this.Adresa = adresa;
            this.DataAngajarii = data;
            this.Incadrare = i;
            this.LimbajeProgramare = lista;

            switch (lista.Count)
            {
                case 1:
                    this.Salariu = 4500;
                    break;
                case 2:
                    this.Salariu = 6500;
                    break;
                case 3:
                    this.Salariu = 9000;
                    break;
                default:
                    this.Salariu = 12000;
                    break;
            }

        }

        // deep clone
        public object Clone()
        {
            Programator clona = new Programator
            {
                Denumire = this.Denumire,
                Varsta = this.Varsta,
                Adresa = this.Adresa,
                Salariu = this.Salariu,
                DataAngajarii = this.DataAngajarii,
                Incadrare = this.Incadrare,

                LimbajeProgramare = new List<String>()
            };

            //for(int i=0; i<this.LimbajeProgramare.Count; i++)
            //{
            //   daca LimbajeProgramare ar fi un array
            //   clona.LimbajeProgramare[i] = this.LimbajeProgramare[i];
            //}

            foreach (String limbaj in this.LimbajeProgramare)
            {
                clona.LimbajeProgramare.Add(limbaj);
            }

            return clona;
        }
    }
}
