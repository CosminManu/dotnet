using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_demo.Modele
{
    abstract class Person
    {
        private String nume;
        private String prenume;
        private int varsta;
        private char gender;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nume"></param>
        /*public Person(string nume, string prenume, int varsta, char gender)
        {
            if (string.IsNullOrEmpty(nume))
            {
                throw new ArgumentException($"'{nameof(nume)}' cannot be null or empty!", nameof(nume));
            }
            else if (string.IsNullOrEmpty(prenume))
            {
                throw new ArgumentException($"'{nameof(prenume)}' cannot be null or empty!", nameof(prenume));
            }
            else
            {
                Nume = nume;
                Prenume = prenume;
                Varsta = varsta;
                Gender = gender;
            }
        }*/


        public int Varsta { get => varsta; set => varsta = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Nume { get => nume; set => nume = value; }
        public char Gender { get => gender; set => gender = value; }
    }
}
