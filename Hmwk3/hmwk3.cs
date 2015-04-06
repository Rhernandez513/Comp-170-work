using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroCS
{
  class Hmwk3
  {
    static void Main(string[] args)
    {
      string catFileName = ("categories_" + GetAbbrev(args) + ".txt");
      string studentFileName = ("students_" + GetAbbrev(args) + ".txt");
      var classInfo = GetFileInfo(catFileName);
      int totWeights = GetWeightTotals(classInfo);
    }

    private static int GetWeightTotals(List<string[]> MasterList)
    {
      int weight = 0;
      foreach (string a in MasterList[1])
      {
        weight += int.Parse(a);
      }
      return weight;
    }
    /// <summary>
    /// Gets Categories, Weights, and Number of grades 
    /// per category based on Input class code
    /// </summary>
    /// <returns>List of Arrays, each containing relavent info</returns>
    private static List<string[]> GetFileInfo(string fileID)
    {
      StreamReader codeReader = FIO.OpenReader(FIO.GetLocation(fileID),
                                               fileID);
      string[] a = codeReader.ReadLine().Trim().Split(',');
      string[] b = codeReader.ReadLine().Trim().Split(',');
      string[] c = codeReader.ReadLine().Trim().Split(',');
      List<string[]> MasterList = new List<string[]> { a, b, c };
      codeReader.Close();
      foreach (string[] x in MasterList)
      {
        whiteSpaceRemove(x);
      }
      return MasterList;
    }
    static void whiteSpaceRemove(string[] s)
    {
      for (int i = 0; i < s.Length; i++)
      {
        s[i] = s[i].Trim();
        Console.WriteLine(s[i]);
      }
    }
    /// <summary>
    /// Gets command line args and returns as a string
    /// </summary>
    /// <param name="args">CMD Line Args</param>
    /// <returns></returns>
    private static string GetAbbrev(string[] args)
    {
      if (args.Any<string>())
      {
        StringBuilder Abbrev = new StringBuilder();
        foreach (string s in args)
        {
          Abbrev.Append(s);
        }
        return ("" + Abbrev).Trim();
      }
      else
      {
        string Abbrev = UI.PromptLine("Please enter a course Abbreviation: ");
        return Abbrev.Trim();
      }
    }
  }
}
