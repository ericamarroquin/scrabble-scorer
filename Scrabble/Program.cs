using System;
using Scrabble.Models;
using System.Text.RegularExpressions;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Scorer! Please enter a word [! to quit]");
      string userInput = Console.ReadLine();
      if (userInput == "!")
      {
        Console.WriteLine("Goodbye");
      } else if (Regex.IsMatch(userInput, @"^[a-zA-Z]+$"))
      {
        int result = Scorer.ScrabbleScore(userInput);
        Console.WriteLine("Your scrabble word score is " + result);
        Main();
      } else
      {
        Console.WriteLine("Please only use letters a-z or A-Z in your word");
        Main();
      }
    }
  }
}