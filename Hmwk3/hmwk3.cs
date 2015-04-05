using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class Hmwk3
  {
    static void Main(string[] args)
    {
      string CourseAbbreviation = GetAbbrev(args);
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
        return "" + Abbrev;
      }
      else
      {
        string Abbrev = UI.PromptLine("Please enter a course Abbreviation: ");
        return Abbrev;
      }
    }
  }
}
