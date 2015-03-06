using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class StringOperationsLab
  {
    static void Main(string[] args)
    {
      TypeOfSentence();
      for (int i = 0; i < 2; i++)
      {
        string userName = GetUserName();
        NameReverse(userName);
      }
    }

    // Gets initial string and decides on sentence type
    public static void TypeOfSentence()
    {
      string type, s = UIF.PromptLine("Please enter a sentence ");
      Console.WriteLine("The length of the string is " + s.Length +
                        " characters.");
      if (s.EndsWith("."))
      {
        type = ("declarative");
      }
      else if (s.EndsWith("!"))
      {
        type = ("exclamation");
      }
      else if (s.EndsWith("?"))
      {
        type = ("interrogatory");
      }
      else
      {
        type = ("not a sentence");
      }
      Console.WriteLine("The sentence is " + type);
    }

    // Gets user name from input
    public static string GetUserName()
    {
      string userInput = UIF.PromptLine("Please enter your first and " +
                                        "last name on one line: ");
      return userInput;
    }

    // Performs name reversal if space exists, if not no change
    public static void NameReverse(string userName)
    {
      int whitespace = userName.IndexOf(" ");
      if (whitespace != -1)
      {
        string first = userName.Substring(0, (whitespace));
        string last = userName.Substring((whitespace + 1));
        string reversedName = (last + ", " + first);
        userName = reversedName;
        Console.WriteLine(userName);
      }
      else if (whitespace == -1)
      {
        Console.WriteLine(userName);
      }
    }
  }
}
