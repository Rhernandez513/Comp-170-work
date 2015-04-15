using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

// Names:
// Help from:
/* Help details:

*/

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
    /// <param name="title">Title of Book</param>
    /// <param name="author">Author of Book</param>
    /// <param name="year">Year of Publication</param>
    public Book(String title, String author, int year)
    {
      this.title = title;
      this.author = author;
      this.year = year;
   }

    /// <summary>
    /// Returns a multi-line String labeling all Book information.
    /// </summary>
    /// <returns>A multi-line String labeling all Book information</returns>
    public override string ToString()
    {
      string bookData = (@"Title: " + title + @"
Author: " + author + @"
Year: " + year);
      return bookData;
    }

    ////////////////////////////////////
    // Extra credit methods hereafter //
    ////////////////////////////////////
    // extra credit Book chunk
    /// Construct a Book, taking data from reader.
    /// Read through three lines that contain the
    /// title, author, and year of publication, respectively.
    /// There may be an extra blank line at the beginning.
    /// If so ignore it.
    /// Nothing beyond the line with the year is read. 
    public Book(StreamReader reader)
    {  // code for extra credit!

    }
    // extra credit IsEqual chunk
    // Return true if all the corresponding fields in this Book
    // and in aBook are equal.  Return false otherwise.  
    public bool IsEqual(Book aBook)
    {// code for extra credit

      return true; //so skeleton compiles
    }
  }
}
