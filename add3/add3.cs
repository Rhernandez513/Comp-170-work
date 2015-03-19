using System;

class add3
{
  ///prompts for 3 inputs, adds them, prints to console
  static void Main() // adding 3 numbers
  {
    string First, Second, Third;
    double x, y, z, sum;

    Console.WriteLine("Enter Three Numbers");
    Console.Write("1st? ");
    First = Console.ReadLine();
    x = double.Parse(First);
    Console.Write("2nd? ");
    Second = Console.ReadLine();
    y = double.Parse(Second);
    Console.Write("3rd? ");
    Third = Console.ReadLine();
    z = double.Parse(Third);
    sum = x + y + z;

    Console.WriteLine("You entered the following: {0} {1} {2}", First, Second, Third);
    Console.WriteLine("The sum of the entered value is " + sum);
  }
}
