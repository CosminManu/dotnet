using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3_box_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxin/unboxing
            //  Boxing = converteste din Value -> Reference type
            //  UN boxing = converteste din Reference -> Value type => nevoie CAST in value type
                                                                  // => nevoie de try catch  
            try
            {
                long val = 1054;
                object ob = val;    // boxing (din val in ref-type object ob)
                Console.WriteLine($"long {val} ob {ob}");   //long 1054 ob 1054

                long value2 = (long)ob;  // UN boxing (din object ob in val-type long)
                Console.WriteLine($"long {val} ob {ob} val2 {value2}");

                int i = 16;
                object o = i;

                int j = (short)o;       //InvalidCastException
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Dupa executie try catch");

            //==============================================================
            //upcast, downcast
            //upcast = copil -> parinte
            //downcast = invers

            Angajat parinte = new Angajat();
            parinte.Name = "Toma";

            try
            {
                Programator copil = (Programator)parinte;       //Downcast (parinte in copil)
                Console.WriteLine("Conversie 1 cu succes");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversie downcast angajat->program esuata");
            }

            Programator copil1 = new Programator();
            copil1.Name = "Cosmin";
            copil1.Salariul = 15000;

            Angajat a2 = copil1;        // Upcast (copil in parinte)
            try
            {
                Programator c = (Programator)a2;       //Downcast (parinte care era la baza copil in copil)
                Console.WriteLine("Conversie 2 ( downcast angajat(program)->program ) cu succes");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversie esuata");
            }


            Angajat a3 = null;
            try
            {
                Programator c = a3 as Programator;       //Downcast (parinte(null) in copil)
                if(c != null)
                {
                    Console.WriteLine("Conversie 3 ( downcast angajat(null)->program ) cu succes");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversie 3 esuata");
            }


            //==============================================================
            //comparable/comparer
            List<int> listaIntregi = new List<int> { 20, 30, 5};
            foreach(int i in listaIntregi)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            listaIntregi.Sort();            //apeleaza automat IComparable
            foreach(int i in listaIntregi)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Adresa ad1 = new Adresa();
            ad1.Numar = 10;  

            Adresa ad2 = new Adresa();
            ad2.Numar = 8;

            Adresa ad3 = new Adresa();
            ad3.Numar = 9;

            List<Adresa> listaAdresa = new List<Adresa>();
            listaAdresa.Add(ad1);
            listaAdresa.Add(ad2);
            listaAdresa.Add(ad3);

            foreach (Adresa i in listaAdresa)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();

            listaAdresa.Sort();     //apeleaza CompareTo(Adresa) din IComparable
            foreach (Adresa i in listaAdresa)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();

            Persoana p1 = new Persoana();
            p1.Nume = "Tim";
            p1.Varsta = 22;

            Persoana p2 = new Persoana();
            p2.Nume = "Catalin";
            p2.Varsta = 19;

            Persoana p3 = new Persoana();
            p3.Nume = "Marius";
            p3.Varsta = 29;

            //parcurgere normala
            List<Persoana> listaVarsta = new List<Persoana> { p1, p2, p3};
            foreach(Persoana i in listaVarsta)
            {
                Console.WriteLine($"{i} ");
            }
            
            //sortare dupa Varsta din cauza instantei create
            PersonComparer pers = new PersonComparer();
            listaVarsta.Sort(pers);       //specif ce vrem sa comparam (dupa Varsta)
            foreach(Persoana i in listaVarsta)
            {
                Console.WriteLine($"{i} ");
            }
            
            Console.WriteLine();
            
            //sortare dupa nume
            PersonNameComparer persN = new PersonNameComparer();
            listaVarsta.Sort(persN);      //specif ce vrem sa comparam (dupa Nume)
            foreach (Persoana i in listaVarsta)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }

    class Angajat
    {
        public String Name { get; set; }
    }
    //orice instanta din Angajat va avea atrib: Name

    class Programator: Angajat
    {
        public double Salariul { get; set; }
    }
    //orice instanta din Prog va avea atrib: Name, Salariul

}
