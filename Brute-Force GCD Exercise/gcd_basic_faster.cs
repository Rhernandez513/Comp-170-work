using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class BruteForceGCDExercise
  {
    static void Main(string[] args)
    {
      int one = UI.PromptInt("Enter an Integer: ");
      int two = UI.PromptInt("Enter another Integer: ");
      Console.WriteLine("GCD is: {0}", GreatestCommonDivisorTwo(one, two));
    }
    /// Return the greatest common divisor of positive numbers.
    public static int GreatestCommonDivisorTwo(int a, int b)
    {
      int n = Math.Min(a, b); // get min
      int i = n, gcd = 1; 
      while (i <= n && i > 0)
      {
        if (a % i == 0 && b % i == 0)
        {
          gcd = i;
          break;
        }
        i--;
      }
      return gcd;
    }
  }
}
