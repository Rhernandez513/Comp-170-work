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
      string CourseAbbreviation = GetAbbrev(args);
      string catFileName = ("categories_" + CourseAbbreviation + ".txt");

      string classRosterFile = ("students_" + CourseAbbreviation + ".txt");

      List<string []> classInfo = GetFileInfo(catFileName, args);

      List<string []> studentInfo = GetFileInfo(classRosterFile, args);

      string[] studentIDs = GetSpecificArray(studentInfo, 0);

      int totWeights = GetWeightTotals(classInfo);
    }
    /// <summary>
    /// Gets string of Student ID's array out of List<string[]>
    /// </summary>
    /// <param name="stringArray">List to extract String[] from</param>
    /// <param name="x">IndexOf desired String[] to Extract</param>
    /// <returns></returns>
    public static string[] GetSpecificArray(List<string[]> stringArray, int x)
    {
      string[] IDs = new string [stringArray.Count];
      for (int i = 0; i < stringArray.Count; i++)
      {
        IDs[i] = (stringArray[i])[x];
      }
      return IDs;
    }
    /// <summary>
    /// Calculates Weight totals for the Class
    /// </summary>
    /// <param name="MasterList"></param>
    /// <returns></returns>
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
    private static List<string[]> GetFileInfo(string fileID, string [] args)
    {
      StreamReader codeReader = FIO.OpenReader(FIO.GetLocation(fileID),
                                               fileID);
      List<string[]> MasterList = null;
      if (GetAbbrev(args) == "comp170")
      {
        string[] a = codeReader.ReadLine().Trim().Split(',');
        string[] b = codeReader.ReadLine().Trim().Split(',');
        string[] c = codeReader.ReadLine().Trim().Split(',');
        MasterList = new List<string[]> { a, b, c };
      }
      else if (GetAbbrev(args) == "comp150")
      {
        string[] a = codeReader.ReadLine().Trim().Split(',');
        string[] b = codeReader.ReadLine().Trim().Split(',');
        MasterList = new List<string[]> { a, b };
      }
      codeReader.Close();
      foreach (string[] x in MasterList)
      {
        whiteSpaceRemove(x);
      }
      return MasterList;
    }
    /// <summary>
    /// Trims Whitespace from array elements
    /// </summary>
    /// <param name="s"></param>
    static void whiteSpaceRemove(string[] s)
    {
      for (int i = 0; i < s.Length; i++)
      {
        s[i] = s[i].Trim();
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
