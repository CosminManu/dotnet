using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fast_Food_demo.Modele;

namespace Fast_Food_demo.Modele
{
    /// <summary>
    /// nume, prenume, varsta, gen (persoana.cs)
    /// email, telefon, nrComanda, totalPlata
    /// username, parola
    /// se va face legatura la Register cu atributele(fereastra logare MDI)
    /// la fel Log In (username si parola)
    /// </summary>
    class Customer : Person
    {
        public string Email { get; set; }
        public string TelNum { get; set; }
        public float TotalPay { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Customer(String nume, String prenume, int varsta, char gen)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Varsta = varsta;
            this.Gender = gen;
        }
    }
}
