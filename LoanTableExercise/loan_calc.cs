using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class loan_calc
  { 
    /// Print a loan table, showing payment number, principal at the
    /// beginning of the payment period, interest over the period, and
    /// payment at the end of the period.
    /// The principal is the initial amount of the loan.
    /// The rate is fraction representing the rate of interest per PAYMENT.
    /// The periodic regular payment is also specified.
    /// If the payment is insufficient, merely prints "payment too low" and ends
    static void Main(string[] args)
    {
      decimal principal = UI.PromptDecimal("Principal? ");
      decimal rate = UI.PromptDecimal("Rate? ");
      decimal payment = UI.PromptDecimal("Payment? ");
      try
      {
        LoanTable(principal, rate, payment);
      }
      catch (OverflowException)
      {
        Console.WriteLine("Payment too Low.");
      }
    }
    public static void LoanTable(decimal principal, decimal rate,
                                 decimal payment)
    {
      Console.WriteLine("{0,7} {1,10} {2,9} {3,8}", "Number", "Principal", "Interest", "Payment");
      for (int i = 1; principal != 0; i++)
      {
        decimal interest = Math.Round(principal * rate, 2);
        Console.WriteLine("{0,7} {1,10:F2} {2,9:F2} {3,8:F2}", i, 
                          principal, interest, payment);
        decimal newPrincipal = (principal + interest) - payment;
        if (principal < newPrincipal)
        {
          Console.WriteLine("Payment too Low.");
          break;
        }
        else if(newPrincipal < payment)
        {
          payment = newPrincipal;
        }
        principal = newPrincipal;
      }
    }
  }
}
