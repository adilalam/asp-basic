using System;
using Xunit;

namespace GradeBook.Tests
{
  public class TypeTests
  {

    [Fact]
    public void ValueTypeAlsoPassByValue()
    {
      var x = GetInt();
      SetInt(ref x);

      Assert.Equal(45, x);
    }

    private void SetInt(ref int z)
    {
      z = 45;
    }

    private int GetInt()
    {
      return 3;
    }

    [Fact]
    public void CanSetCanNameFromRef()
    {
      var book1 = GetBook("Book 1");
      GetBookSetName(ref book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetName(ref Book book, string name)
    {
      book = new Book(name);
    }

    [Fact]
    public void CanSetNameFromValue()
    {
      var book1 = GetBook("Book 1");
      GetBookSetName1(out book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetName1(out Book book, string name)
    {
      book = new Book(name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
      var book1 = GetBook("Book 1");
      SetName(book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }

    [Fact]
    public void GetBookReturnDifferentObjects()
    {
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
    }

    [Fact]
    public void TwoVarCanReferenceSameObject()
    {
      var book1 = GetBook("Book 1");
      var book2 = book1;

      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
    }

    Book GetBook(string name)
    {
      return new Book(name);
    }
  }
}
