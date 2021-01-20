using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    private List<double> grades;
    private string name;

    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatics()
    {
      double result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;

      foreach (var item in grades)
      {
        highGrade = Math.Max(item, highGrade);

        lowGrade = Math.Min(item, lowGrade);

        // if (item > highGrade)
        // {
        //   highGrade = item;
        // }
        result += item;
      }
      Console.WriteLine("Result " + result);
      Console.WriteLine("Name " + this.name);
      Console.WriteLine("High Grade " + highGrade);
      Console.WriteLine("Low Grade " + lowGrade);
    }

  }
}