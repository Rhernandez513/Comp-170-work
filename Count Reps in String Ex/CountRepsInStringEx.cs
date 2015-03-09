using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class CountRepsInStringEx
  { /// does not work, ask Prof
    static void Main(string[] args)
    {
      string s = UI.PromptLine("enter string: ");
      string target = UI.PromptLine("enter target: ");
      Console.WriteLine(""+ CountRep(s, target));
    }
    // Return the number of separate repetitions of target in s
    static int CountRep(string s, string target)
    {
      if (s.Contains(target))
      {
        int i = 0;
        for (int next = s.IndexOf(target); target.Length < next; i++)
        {
          next = s.IndexOf(target, (next + target.Length));
        }
        return i;
      }
      else
      {
        return 0;
      }
    }
  }
}
