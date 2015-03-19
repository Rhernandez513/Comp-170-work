using System;
using System.IO;
/// work in progress, needs to be tested with an actual file at this point and debugged.


//to do instructions

//9.3.2.1. Safe Sum File Exercise

//    Copy sum_file.cs to a file safe_sum_file.cs in a new project of yours. Modify the program: Write a new function with the heading below. Use it in Main, in place of the if statement that checks (only once) for a legal file:

//    // Prompt the user to enter a file name to open for reading.
//    // Repeat until the name of an existing file is given.
//    // Open and return the file.
//    public static StreamReader PromptFile(string prompt)

//    A user who forgot the file name woud be stuck! Elaborate the function and program, so that an empty line entered means “give up”, and null (no object) should be returned. The main program needs to test for this and quit gracefully in that case.

//end instructions 
namespace IntroCS
{
  class SumFile // sum a file integers, one per line
  {
    static void Main()
    {
      string filename = UserPrompt();
      if (filename == "quit")
      {
        Console.WriteLine("No input given, program will now close.");
        return;
      }
      Console.WriteLine("The sum is {0}", CalcSum(filename));
    }

    private static string UserPrompt()
    {
      string filename = UI.PromptLine(
      "Enter the name of a file of integers: ");
      if (filename == "")
      {
        return "quit";
      }
      while (!File.Exists(filename))
      {
        Console.WriteLine("Bad file name {0}", filename);
        filename = UserPrompt();
      }
      return filename;
    }
    /// Read the named file and
    /// return the sum of an int
    /// from each line that is not just white space.
    static int CalcSum(string filename)
    {
      int sum = 0;
      var reader = new StreamReader(filename);
      while (!reader.EndOfStream)
      {
        string sVal = reader.ReadLine().Trim();
        if (sVal.Length > 0)
        {
          sum += int.Parse(sVal);
        }
      }
      reader.Close();
      return sum;
    }
  }
}
