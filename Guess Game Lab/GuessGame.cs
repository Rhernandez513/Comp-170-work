using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class GuessGame
  {
    static void Main(string[] args)
    {
      int big = UI.PromptInt("Enter a secret number bound (or zero to quit): ");
      while (big != 0)
      {
        Console.WriteLine("In this game you guess a positive number less than "+
                  big);
        Game(big);
      }
      Console.Write("Ending Game, Goodbye!");
    }
    static void Game(int big)
    {
      int secretNumber = randomNumer(big);
      int userGuess = UI.PromptInt("Enter a guess: ");
      int i = 0;
      while (userGuess != secretNumber)
      {
        if (userGuess < secretNumber)
        {
          Console.WriteLine("Too Low!");
          userGuess = UI.PromptInt("Enter a guess: ");
        }
        else
        {
          Console.WriteLine("Too High!");
          userGuess = UI.PromptInt("Enter a guess: ");
        }
        i++;
      }
      Console.WriteLine("Correct! You Win on guess {0}!", i);
    }
    // Assign random number to secret from 1 to big
    private static int randomNumer(int big)
    {
      Random r = new Random();
      int secret = r.Next(1, big);
      return secret;
    }
  }
}