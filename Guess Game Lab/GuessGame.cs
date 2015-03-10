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
      int big = UI.PromptInt("Enter a secret number high limit: ");
      Console.WriteLine("In this game you guess a positive number less than " +
                        big);
      Game(big);
    }
    static void Game(int big)
    {
      int secretNumber = randomNumer(big);
      int userGuess = UI.PromptInt("Enter a guess: ");
      while (userGuess != secretNumber)
      {
        if (userGuess < secretNumber)
        {
          Console.WriteLine("Too Low!");
          userGuess = UI.PromptInt("Enter a guess: ");
        }
        else
        {
          Console.WriteLine("Too Low!");
          userGuess = UI.PromptInt("Enter a guess: ");
        }
      }
      Console.WriteLine("Correct! You Win!");
    }

    private static int randomNumer(int big)
    {
      Random r = new Random();
      int secret = r.Next(1, big);
      throw new NotImplementedException();
    }
  }
}