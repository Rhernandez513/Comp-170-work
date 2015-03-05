using System;

class Interview
{
   static void Main() //basic user prompt and response
   {
      string username, settime, setmodifier;
      Console.WriteLine ("What is your name? ");
      username = Console.ReadLine();
      Console.WriteLine ("What time is your appointment? ");
      settime = Console.ReadLine();
      Console.WriteLine ("AM or PM? ");
      setmodifier = Console.ReadLine();
      Console.WriteLine (username + " has an appointment at " + settime + 
                        setmodifier + ".");
   }
}
