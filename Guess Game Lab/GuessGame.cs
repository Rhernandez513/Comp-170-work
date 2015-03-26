using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class GuessGame
  {
    // Computer Gens random number, user guesses or vice versa
    private static void StartGame(int big)
    {
      while (big != 0)
      {
        Console.WriteLine("\nIn this game you guess a positive number less " + 
                          "than {0}", big);
        Game(big);
        big = UI.PromptInt("Enter a secret number limit (or zero to quit): ");
      }
      Console.WriteLine("Ending Game, Goodbye!");
    }
    // User thinks of number, computer guesses
    private static void StartReversedGame(int big)
    {
      while (big != 0)
      {
        Console.WriteLine("\nIn this game I will try to guess a number you imagine less than {0}", big);
        GameReversed(big);
        big = UI.PromptInt("Enter a secret number limit (or zero to quit): ");
      }
      Console.WriteLine("Ending Game, Goodbye!");
    }
    // User must guess randomly generated number
    static void Game(int big)
    {
      int secretNumber = randomNumber(1, big);
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
      Console.WriteLine("Correct! You Win on guess {0}!\n", i);
      PlayerChoice();
    }
    // Computer attempts to guess secret number
    static void GameReversed(int big)
    {
      string prompt = ("\nImagine and remember a positive number, then press " +
                       "return to continue.");
      string highLowPrompt = ("\nEnter H for High, L for Low, E if Equal: ");
      int i = 0, little = 1;
      string numberCheck = "placeholder";
      int computerGuessNumber = randomNumber(little, big);
      UI.PromptLine(prompt);

      while (numberCheck != "e")
      {
        Console.WriteLine("Is your number {0}? ", computerGuessNumber);
        numberCheck = (UI.PromptLine(highLowPrompt)).ToLower();
        if ((big - little) == 1 || (big - little) == 0 || big == 1)
        {
          Console.WriteLine("\nI can tell you're cheating!");
          i++;
          break;
        }
        i++;
        if (numberCheck == "h")
        {
          big = computerGuessNumber;
          computerGuessNumber = randomNumber(little, big);
        }
        else if (numberCheck == "l")
        {
          little = computerGuessNumber;
          computerGuessNumber = randomNumber(little + 1, big);
        }
        else if (numberCheck == "e")
        {
          break;
        }
        else
        {
          Console.WriteLine("\nInvalid Input! Try again: ");
        }
      }
      Console.WriteLine("\nI win! It took me {0} guesses.", i);
      PlayerChoice();
    }
    // Assign random number to secret from 1 to big
    private static int randomNumber(int little, int big)
    {
      Random r = new Random();
      int secret = r.Next(little, big);
      return secret;
    }
    static void Main(string[] args)
    {
      PlayerChoice();
    }

    private static void PlayerChoice()
    {
      int choice = UI.PromptIntInRange("Do you want to guess, or Should I? " +
                                       "\nEnter", 0, 1);
      int big = UI.PromptInt("\nEnter a secret number upper limit (or zero " + 
                             "to quit): ");
      if (choice == 0) { StartGame(big); }
      else if (choice == 1) { StartReversedGame(big); }
    }
  }
}