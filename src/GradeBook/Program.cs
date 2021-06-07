using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(90.5);

            var grades = new List<double>(){12.5, 12.5, 10.5, 10.5};
            grades.Add(15.5);

            var result = 0.0;
            foreach(var number in grades)
            {
               result += number;
            }
            result /= result / grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
