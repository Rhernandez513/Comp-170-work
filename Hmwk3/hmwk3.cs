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

      List<string[]> classInfo = GetFileInfo(catFileName, 3);

      List<string[]> studentInfo = new List<string[]>();
      if (CourseAbbreviation == "comp170")
      {
        studentInfo = GetFileInfo(classRosterFile, 4);
      }
      else if (CourseAbbreviation == "comp150")
      {
        studentInfo = GetFileInfo(classRosterFile, 2);
      }

      int totWeights = GetWeightTotals(classInfo);

      int[] assignmentCategoryCodes = GetCategoryCodes(classInfo);

    }
    /// Take the first letter code for a catagory, and 
    /// return the index of that category in categories.
    static int codeIndex(string code, string[] categories)
    {
      for (int i = 0; i < categories.Length; i++)
      {
        if (categories[i].Trim().StartsWith(code))
        {
          return i;
        }
      }
      return -1; //required by compiler: shouldn't reach
    }
    /// <summary>
    /// Uses codeIndex to return the indexOf each classCategory
    /// </summary>
    /// <param name="ClassInfo"></param>
    /// <returns></returns>
    public static int[] GetCategoryCodes(List<string[]>ClassInfo)
    {
      string [] classCategoryCodes = new string [] {"E", "L", "H", "P", "C"};
      string[] classCategories = GetSpecificArray(ClassInfo, 0);
      int[] categoryLabel = new int[classCategoryCodes.Length];
      for(int i = 0; i < classCategoryCodes.Length; i++)
      {
      categoryLabel[i] = codeIndex((classCategoryCodes[i]) ,classCategories);
      }
      return categoryLabel;
    }
    public void GetStudentGrades(List<string[]> StudentInfo, string courseAbbreviation)
    {
      string[] studentIDs = GetSpecificArray(StudentInfo, 0);
      for (int i = 0; i < studentIDs.Length; i++)
      {
        string studentGradeFile = (studentIDs[i] + courseAbbreviation + ".data");
        StreamReader gradeReader = FIO.OpenReader(FIO.GetLocation(studentGradeFile), studentGradeFile);
        while (!gradeReader.EndOfStream)
        {
        string[] eachLine = gradeReader.ReadLine().Trim().Split(',');
        }

      }
    }
    /// <summary>
    /// Gets a String array out of List<string[]>
    /// </summary>
    /// <param name="stringArray">List to extract String[] from</param>
    /// <param name="x">IndexOf desired String[] to Extract</param>
    /// <returns></returns>
    public static string[] GetSpecificArray(List<string[]> stringArray, int x)
    {
      string[] desiredArray = new string [stringArray[x].Length];
      for (int i = 0; i < stringArray[x].Length; i++)
      {
        desiredArray[i] = (stringArray[x])[i];
      }
      return desiredArray;
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
    private static List<string[]> GetFileInfo(string fileID, int numberofArrays)
    {
      List<string[]> MasterList = null;
      StreamReader codeReader = FIO.OpenReader(FIO.GetLocation(fileID),
                                               fileID);
      if (numberofArrays == 4)
      {
        string[] a = codeReader.ReadLine().Trim().Split(',');
        string[] b = codeReader.ReadLine().Trim().Split(',');
        string[] c = codeReader.ReadLine().Trim().Split(',');
        string[] d = codeReader.ReadLine().Trim().Split(',');
        MasterList = new List<string[]> { a, b, c, d };
      }
      if (numberofArrays == 3)
      {
        string[] a = codeReader.ReadLine().Trim().Split(',');
        string[] b = codeReader.ReadLine().Trim().Split(',');
        string[] c = codeReader.ReadLine().Trim().Split(',');
        MasterList = new List<string[]> { a, b, c };
      }
      else if (numberofArrays == 2)
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
