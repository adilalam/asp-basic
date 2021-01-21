using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    private List<double> grades;
    public string Name;

    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
      }
      else
      {
        // System.Console.WriteLine("Invalid value");
        throw new ArgumentException($"Invalid {nameof(grade)}");
      }
    }

    public Statistics GetStatics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.HighGrade = double.MinValue;
      result.LowGrade = double.MaxValue;

      foreach (var grade in grades)
      {
        result.HighGrade = Math.Max(grade, result.HighGrade);

        result.LowGrade = Math.Min(grade, result.LowGrade);

        // if (grade > result.HighGrade)
        // {
        //   result.HighGrade = grade;
        // }
        result.Average += grade;
      }
      result.Average = result.Average / grades.Count;
      return result;
    }

  }
}