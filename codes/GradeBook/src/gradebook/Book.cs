using System;
using System.Collections.Generic;


namespace gradebook
{
    class Book
    {
        private List<double> grades;       //field
        private string name;               //field

        public Book(string name)    // construc
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddBook(double gr)
        {
            grades.Add(gr);
        }

        public void PrintBook() {
            Console.WriteLine("Each number is: ");
            for(int i =0; i<grades.Count; i++) {
                Console.Write(grades[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public void Statistics(){
            var s = 0.0;
            var highGrade = double.MinValue;        //the smallest possible val of a double
            double smallGrade = double.MaxValue;    //the largest
            foreach (var number in grades)
            {
                if(number > highGrade){
                    highGrade = number;
                }

                if(number < smallGrade){
                    smallGrade = number;
                }
                s += number;
            }
            s = s / grades.Count;
            Console.WriteLine($"The average grade is: {s:N1}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The smallest grade is: {smallGrade}");
        }
    }

}