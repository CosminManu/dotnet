using System;
using System.Collections.Generic;

namespace gradebook
{
    class Book
    {        

    }
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            var x = 34.2;
            var y = 1.1;
            var z = x + y;
            Console.WriteLine(z);

            // var numbers = new[] {31, 33.9, 34.5, 12};
            // for(int i =0; i<numbers.Length; i++)
            // {
            //     s = s + numbers[i];
            // }
            // Console.WriteLine(s);

            var s = 0.0;
            var grades = new List<double>() {8, 8, 9.5, 9};
            grades.Add(55.7);
            foreach(var number in grades)
            {
                s += number;
            }
            s = s /grades.Count;
            Console.WriteLine($"The average grade is {s:N1}");


            // if(args.Length > 0)
            // {
            //     Console.WriteLine($"Hello, {args[0]}!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello!");
            // }
        }
    }
}
