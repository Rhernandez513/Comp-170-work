using System;

class DoTheMath
{
   static void Main(string[] args)
   {
      string prompt = "Please enter a number: ";

      Console.WriteLine(prompt);
      string numeratorString = Console.ReadLine();
      int numerator = int.Parse(numeratorString);

      Console.WriteLine("Thank you, one more time. " + prompt);
      string denominatorString = Console.ReadLine();
      int denominator = int.Parse(denominatorString);

      int quotient = numerator/denominator;
      int remainder = numerator%denominator;
      Console.WriteLine("Integer division result = " + quotient + " with a remainder of " + remainder);

      double numeratorDouble = numerator;
      double quotientDouble = numeratorDouble/denominator;
      Console.WriteLine("Floating point division result = " + quotientDouble);

      string mixedFraction = quotient + " " + remainder + "/" + denominator;
      Console.WriteLine("The result as a mixed fraction is = " + mixedFraction);

   }
}