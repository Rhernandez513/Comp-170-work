using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
    class savingsexcercise
    {
        static void Main(string[] args)
        {
            decimal initial = UI.PromptDecimal("Initial balance? ");
            decimal rate = UI.PromptDecimal("APR? ");
            decimal final = UI.PromptDecimal("Desired final balance? ");
            YearsToGrow(initial, rate, final);
        }
        static void YearsToGrow(decimal initial, decimal rate, 
                                decimal final)
        {
            decimal runningBalance = initial;
            for (int i = 1; runningBalance < final; i++)
            {
                runningBalance = runningBalance * (1 + rate);
                Console.WriteLine("Year " + i + " $" + Math.Round(runningBalance, 2));
                if (runningBalance >= final)
                {
                    Console.WriteLine("It will take no more than {0} years " + 
                                     "to reach your desired final balance of " +
                                     "${1}", i, final);
                }
            }
        }
    }
}
