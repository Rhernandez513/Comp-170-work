using System;
namespace quotient2
{
  class Quotient
  {
    static void Main() // simple program that calculates the quotient of two integers and also prints the remainder
    {
      string dividend, divisor;
      int x, y, q, r; // x is dividend, y is  divisor, q is quotient, r is remainder
      Console.WriteLine("Today we will be conducting a division problem using two integers.");
      Console.WriteLine("Please enter an integer to be divided. ");
      dividend = Console.ReadLine();
      x = int.Parse(dividend);
      Console.WriteLine("Please enter an integer that we will then use to to divide " + x + ". ");
      divisor = Console.ReadLine();
      y = int.Parse(divisor);
      q = x / y;
      r = x % y;
      Console.WriteLine("The quotient of the input integers is {0}.", q, r);
      Console.WriteLine("The remainder is " + r + ".");
    }
  }
}