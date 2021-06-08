using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Mikes Grade Book");
            book.AddGrade(90.5);
            book.AddGrade(90);
            book.AddGrade(77);
            book.ShowStatistics();
        }
    }
}
