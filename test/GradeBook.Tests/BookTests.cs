using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void Test1()
    {
      // arrange
      var book = new Book("");
      book.AddGrade(1.0);
      book.AddGrade(2.0);
      book.AddGrade(3.0);

      // act
     var result =  book.GetStatics();

      // assert
      Assert.Equal(2.0, result.Average, 1);
      Assert.Equal(3.0, result.HighGrade, 1);
      Assert.Equal(1.0, result.LowGrade, 1);
    }
  }
}
