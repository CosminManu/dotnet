using System;
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // se apeleaza la infinit
            // var p = new Program();
            // Program.Main(args);

            var book = new Book("Cartea Junglei");      // invoking consturctor
            book.AddBook(12.2);
            book.AddBook(99.9);
            //book.grades.Add(123);     // private modifier
            book.AddBook(123);
            book.PrintBook();
            book.Statistics();
           
        }
    }
}

