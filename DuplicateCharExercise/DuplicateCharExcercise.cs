using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class DuplicateCharExcercise
  {
    /// Checks if two consecutive characters in a string are the same
    static void Main(string[] args)
    {
      string s = UI.PromptLine("enter string: ");
      if (HasDoubleChar(s))
      {
        Console.WriteLine("Success!");
      }
      else
      {
        Console.WriteLine("Fail!");
      }
    }
    static bool HasDoubleChar(string s)
    {
      int i = (s.Length - 1);
      while (i < s.Length && i != 0)
      {
        if (s[i] == s[i - 1])
        {
          return true;
        }
        i--;
      }
      return false;
    }
  }
}
