using System;
using System.IO;

namespace IntroCS
{
  /// <summary>
  /// A Class that maintains information on a Book 
  /// </summary>
  public class Book
  {
    /// <summary>
    /// Title of Book 
    /// </summary>
    public String title { get; set; }

    /// <summary>
    /// Author of Book 
    /// </summary>
    public String author { get; set; }

    /// <summary>
    /// Year of Publication 
    /// </summary>
    public int year { get; set; }

    /// <summary>
    /// A Simple Book 
    /// </summary>
    /// <param name="title"> Title of Book </param>
    /// <param name="author"> Author of Book </param>
    /// <param name="year"> Year of Publication </param>
    public Book(String title, String author, int year)
    {
      this.title = title;
      this.author = author;
      this.year = year;
    }
    /// <summary>
    /// Creates new book from a book
    /// </summary>
    /// <param name="book">A book to copy</param>
    public Book(Book book)
    {
      this.title = book.title;
      this.author = book.author;
      this.year = book.year;
    }

    /// <summary>
    /// Returns a multi-line String labeling all Book information. 
    /// </summary>
    /// <returns> A multi-line String labeling all Book information </returns>
    public override string ToString()
    {
      string bookData = (@"Title: " + title + @"
Author: " + author + @"
Year: " + year);
      return bookData;
    }

    /// <summary>
    /// Parses info from text file to construct book
    /// Does NOT close the reader
    /// </summary>
    /// <param name="reader">Steamreader open at file</param>
    public Book(StreamReader reader)
    {
      string contents = string.Empty;
      for (int i = 0; i < 3; i++)
      {
        contents = reader.ReadLine();
        if (contents != string.Empty && contents != "")
        {
          if (i == 0)
          {
            this.title = contents;
          }
          else if (i == 1)
          {
            this.author = contents;
          }
          else if (i == 2)
          {
            this.year = int.Parse(contents);
          }
        }
        else
        {
          i--;
        }
      }
    }

    // extra credit IsEqual chunk Return true if all the corresponding
    // fields in this Book and in aBook are equal. Return false otherwise.
    public bool IsEqual(Book aBook)
    {
      if(this.author == aBook.author &&
         this.title  == aBook.title  &&
         this.year   == aBook.year)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}