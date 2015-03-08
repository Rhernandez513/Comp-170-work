using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class RoundoffExcercise2
  {
    /// Return the largest possible number y, so in C#: x+y = x
    /// If x is Infinity return Infinity.
    /// If x is -Infinity, return double.MaxValue.
    /// Assume x is not NaN (which is equal to nothing).
    static void Main(string[] args)
    {
      double x = UI.PromptDouble("Enter a value: ");
      Epsilon(x);
    }
    static double Epsilon(double x)
    {
      return 0; //so compiles
    }
  }
}
