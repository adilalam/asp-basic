using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      //   var numbers = new double[3] {12.5, 13.5, 14.5 };
      // var numbers = new[] { 12.5, 13.5, 14.5 };
      //   numbers[0] = 12.5;
      //   numbers[1] = 13.5;
      //   numbers[1] = 15.5;

      // List<double> grades = new List<double>();
      // grades.Add(12.6);
      // grades.Add(13.6);
      // grades.Add(14.6);
      // grades.Add(15.6);

      // double result = 0.0;
      // foreach (double item in grades)
      // {
      //   result += item;
      // }

      // result /= grades.Count;
      // System.Console.WriteLine(result);


      var book = new Book("adil");
      book.AddGrade(10.1);
      book.AddGrade(9.1);
      book.AddGrade(8.1);

      var stats = book.GetStatics();

      Console.WriteLine("High Grade " + stats.HighGrade);
      Console.WriteLine("Low Grade " + stats.LowGrade);
      Console.WriteLine("Average " + stats.Average);
    }
  }
}
