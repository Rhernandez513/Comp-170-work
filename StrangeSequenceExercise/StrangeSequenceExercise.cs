using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class StrangeSequence
  {
    // Single sequence jump
    static int Jump(int n)
    {
      int x = (n % 2);
      if (x == 0)
      {
        n = (n / 2);
      }
      else if (x == 1)
      {
        n = (3 * n + 1);
      }
      return n;
    }
    // Iterates until 1, prints
    static void PrintStrangeSequence(int n)
    {
      while (n != 1)
      {
        n = Jump(n);
        Console.WriteLine(n);
      }
    }
    // Counts amount of jumps, yes i know its redundant
    static int CountStrangeSequence(int n)
    {
      for (int i = 1; n != 1; i++)
      {
        n = Jump(n);
        if (n == 1)
        {
          return i;
        }
      }
      return 0;
    }

    private static int GetUserInteger()
    {
      int n = UI.PromptInt("Enter a positive integer: ");
      while (n <= 0)
      {
        Console.WriteLine("Not a positive integer.");
        n = UI.PromptInt("Enter a positive integer: ");
      }
      return n;
    }

    static void Main()
    {
      int n = GetUserInteger();
      Console.WriteLine(n);
      Console.WriteLine("One jump from {0} is {1}.", n, Jump(n));
      Console.WriteLine("Sequence until 1:");
      PrintStrangeSequence(n);
      Console.WriteLine("{0} elements in the sequence.",
                        CountStrangeSequence(n));
    }
  }
}