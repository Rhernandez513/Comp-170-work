using System;

namespace IntroCS
{
  /// A main program to test the class BookList. 
  internal class TestBookList
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

      //test books in year func
      Console.WriteLine("\nAll books in list published between 1990 and 2005");
      books.PrintBooksInYears(1990, 2005);

      //test print by author func
      Console.WriteLine("\nAll the books in the list written by Georges Ifrah");
      books.PrintTitlesByAuthor("Georges Ifrah");

      //tests books class public method to print all books in the list
      Console.WriteLine("\nThe full list of all the books inside the list is:");
      books.PrintList();

      //tests extra credit version of book_list ToString
      string extraCreditToString = books.ToString().ToUpper();
      Console.WriteLine("Extra Credit ToString test \n" + extraCreditToString);

      //test extra credit streamreader
      Console.WriteLine("\nTesting building and printing a book using a " + 
                        "Steamreader");
      Book streamTest = new Book(FIO.OpenReader("books.txt"));
      Console.WriteLine(streamTest);

      //test new Booklist using streamreader
      Console.WriteLine("\nTesting that we can create a booklist from a text " +
                        "containing books WITH spaces");
      BookList listStreamTest = new BookList(FIO.OpenReader("books.txt"));
      Console.WriteLine(listStreamTest);

      Console.WriteLine("\nTesting that we can create a booklist from a text " +
                  "containing books WITHOUT spaces");
      BookList listStreamTest2 = new BookList(FIO.OpenReader("morebooks.txt"));
      Console.WriteLine(listStreamTest2);

      Console.WriteLine("\nTesting if we can compare two different books");
      if (test.IsEqual(test))
      {
        Console.WriteLine("True test works");
      }
      if (!(test.IsEqual(uniCompHistory)))
      {
        Console.WriteLine("False test works");
      }

      Console.WriteLine("\nTesting if Addbook Bool value works");
      if (books.Addbook(test) == false)
      {
        Console.WriteLine("Addbook Bool test works");
      }
      else
      {
        Console.WriteLine("Addbook Bool test failed");
      }

      Console.WriteLine("\nTesting Add all function, to add a list of books " +
                        "to a BookList");
      BookList addAllTestList = new BookList();
      if (addAllTestList.AddAll(books))
      {
        Console.WriteLine("Original list changed");
      }
      else
      {
        Console.WriteLine("Something went wrong");
      }

      Console.WriteLine("\nTesting Add all function where all the books in a " +
                        "list are contained within the list being added to");
      BookList someBooks = new BookList(FIO.OpenReader("morebooks.txt"));
      BookList theSameBooks = new BookList(FIO.OpenReader("morebooks.txt"));
      if (!(someBooks.AddAll(theSameBooks)))
      {
        Console.WriteLine("Both lists are equal, test works");
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine("Something went wrong");
      }

    }
  }
}