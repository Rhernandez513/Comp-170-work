using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace IntroCS
{
  /// A main program to test the class BookList. 
  class TestBookList
  {
    /// Test BookList.
    public static void Main()
    {
      Console.SetBufferSize(80, Int16.MaxValue - 1);
      BookList books = new BookList();
      Book test = new Book("C# Yellow Book", "Rob Miles", 2011);
      Book softSolutions = new Book("C# Software Solutions", 
                                    "John Lewis", 2007);
      Book modernCompHistory = new Book("A History of Modern Computing", 
                                  "Paul E. Ceruzzi", 2003);
      Book uniCompHistory = new Book("Universal History of Computing",
                                     "Georges Ifrah", 2001);
      Book uniNumberHistory = new Book("Universal History of Numbers: From " + 
                                       "Prehistory to the Invention of the " +
                                       "Computer", "Georges Ifrah", 1994);
      books.Addbook(test);
      books.Addbook(softSolutions);
      books.Addbook(modernCompHistory);
      books.Addbook(uniCompHistory);
      books.Addbook(uniNumberHistory);

      //tests Book ToString Override
      Console.WriteLine("The following tests that we can output the contents " + 
                        "of one book object");
      Console.WriteLine(test);
      Console.WriteLine("No newline in preceding statement is intentional\n"); 

      //test books in Year func
      Console.WriteLine("\nAll books in list published between 1990 and 2005");
      books.PrintBooksInYears(1990, 2005);

      //test author func
      Console.WriteLine("\nAll the books in the list written by Georges Ifrah");
      books.PrintTitlesByAuthor("Georges Ifrah");

      //tests books class public method to print all books in the list
      Console.WriteLine("\nThe full list of all the books inside the list is:");
      books.PrintList();
      // Add more tests to fully test your code.
      // Make sure the correctness of the tests can be seen without reading
      // the source code -- comment on the meanings.
      // ...
    }
  }
}