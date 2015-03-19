using System;
using System.IO;

namespace IntroCS
{
  class SumFile 
  {
    /// <summary>
    /// Prompt User input
    /// Sum a file integers, one per line
    /// Output to console
    /// </summary>
    static void Main()
    {
      string fileName = UI.PromptLine("Enter the name of a file of integers: ");
      string inputCheck = PromptFile(fileName);
      if (inputCheck == null)
      {
        Console.WriteLine("No Input, program ending.");
        return;
      }
      Console.WriteLine("The sum is {0}", CalcSum(fileName));
    }

    static string PromptFile(string fileName)
    {
      while (!File.Exists(fileName))
      {
        if (fileName == "")
        {
          return null;
        }
        Console.WriteLine("Bad file name {0}", fileName);
        fileName = UI.PromptLine("Enter the name of a file of integers: ");
      }
      return fileName;
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
