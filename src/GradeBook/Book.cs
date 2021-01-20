using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
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