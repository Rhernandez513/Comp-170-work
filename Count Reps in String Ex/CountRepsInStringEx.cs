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
        int next = (1 + s.IndexOf(target));
        while (target.Length < next)
        {
          next = s.IndexOf(target, (next + target.Length));
          i++;
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
