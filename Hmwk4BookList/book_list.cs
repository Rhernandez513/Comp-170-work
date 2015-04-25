using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IntroCS
{
  /// <summary>
  /// A class that maintains a list of books. 
  /// </summary>
  public class BookList
  {
    public List<Book> list { get; set; }

    /// <summary>
    /// Create an empty list of books. 
    /// </summary>
    public BookList()
    {
      list = new List<Book>();
    }

    /// <summary>
    ///Add book to the list.
    /// Adds aBook to the list if aBook is not already in the list.
    /// Return true if aBook is added, and false if it was already 
    /// in the list.
    /// </summary> <param name="book">The Book to Add to the
    /// List</param> <returns></returns>
    public bool Addbook(Book book)
    {
      if (this.Contains(book))
      {
        return false;
      }
      else
      {
      this.list.Add(book);
      return true;
      }
    }
    /// <summary>
    /// Used in conjunction with creating a Booklist via StreamReader
    /// </summary>
    private void AddBookToStreamReadList(BookList bookList , Book book)
    {
      bookList.list.Add((Book)book);
    }

    /// <summary>
    /// List the full descriptions of each book,
    /// With each book separated by a blank line.
    /// </summary>
    public void PrintList() 
    {
      Console.WriteLine(this);
    }

    //PrintTitlesByAuthor chunk
    // List the titles (only!), one per line, of each book
    // in the list that is by the specified author.
    public void PrintTitlesByAuthor(string author)
    {  //code
      foreach (Book a in list)
      {
        if (a.author == author)
        {
          Console.WriteLine(a.title);
        }
      }
    }

    //PrintBooksInYears chunk
    // List the full descriptions of each book printed
    // in the range of years specified,
    // with each book separated by a blank line.
    public void PrintBooksInYears(int firstYear, int lastYear)
    {
      foreach (Book a in list)
      {
        if (a.year >= firstYear && a.year <= lastYear)
        {
          Console.WriteLine("" + a);
        }
      }
    }

    ////////////////////////////
    // Extra Credit past here //
    ////////////////////////////
    // extra credit ToString chunk
    /// Return a single string containing the same data as printed by
    /// PrintList, including a final newline.
    public override string ToString()
    {
      StringBuilder builder = new StringBuilder();
      foreach (Book a in list)
      {
        builder.Append(a + "\n");
      }
      string booklist = builder.ToString();
      return booklist;
    }

    // extra credit BookList chunk Construct a new BookList using Book
    // data read from reader. The data coming from reader will contain
    // groups of three line descriptions useful for the Book
    // constructor that reads from a stream. Each three-line book description
    // * may or may not* be preceded by an empty line.
    public BookList(StreamReader reader)
    {
      var list = new BookList();
      while (!(reader.EndOfStream))
      {
        list.AddBookToStreamReadList(list, new Book(reader));
      }
      this.list = list.list;
    }

    // extra credit Contains chunk Test if aBook is contained in this
    // BookList. Return true if book IsEqual to a Book in the list,
    // false otherwise.
    public bool Contains(Book book)
    {
      foreach (Book a in this.list)
      {
        if (book.IsEqual(a))
        {
          return true;
        }
      }
      return false;
    }

    // extra credit AddAll chunk Add each Book in books to this
    // BookList. if it is not already contained in this BookList.
    // Return true if the current list was changed. Return false if
    // each Book in books is a duplicate of a Book in the current list.
    public bool AddAll(BookList books)
    {
      bool duplicateTest = false;
      foreach (Book a in books.list)
      {
        if (this.Contains(a))
        {
          continue;
        }
        else
        {
          this.Addbook(a);
          duplicateTest = true;
        }
      }
      return duplicateTest;
    }
  }
}