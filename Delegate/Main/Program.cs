using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    //def delegat pt o metoda care primeste un int si returneaza string
    public delegate String myDelegate(int a);

    class Program
    {
        //definim instance method (metoda care are nevoi de un obiect creat pt a fi apelata)
        //si o metoda statica (n are nev de obiect, specifica clasei)
        public String tipNumar(int nr)
        {
            if (nr > 0)
            {
                return ("pozitiv");
            }
            else if (nr < 0)
            {
                return ("negativ");
            }
            else return ("zero");
        }

        public static String staticTipNumar(int nr)
        {
            if (nr > 0)
            {
                return (" + ");
            }
            else if (nr < 0)
            {
                return (" - ");
            }
            else return ("");
        }


        static void Main()
        {
            //creeam cate un delegat pt fiecare metoda
            Program p = new Program();
            myDelegate d1 = new myDelegate(p.tipNumar);
            myDelegate d2 = new myDelegate(Program.staticTipNumar);

            //apelam delegatii
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, d1(5), d2(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, d1(-3), d2(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, d1(0), d2(0));

        }
    }
}
