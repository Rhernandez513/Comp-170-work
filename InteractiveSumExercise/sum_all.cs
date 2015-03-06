using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class sum_all
  {
    static void Main(string[] args)
    {
      int runningTotal = 0;
      int userNumberInput = UI.PromptInt("Enter numbers to sum, one per line " +
                                         ". Enter 0 to get sum: ");
      for (int i = 0; userNumberInput != 0; i++)
      {
        runningTotal += userNumberInput;
        userNumberInput = UI.PromptInt("Enter numbers to sum, one per line " +
                                       ". Enter 0 to get sum: ");
      }
      string sum = runningTotal.ToString();
      Console.WriteLine("The sum total is " + sum);
    }
  }
}
