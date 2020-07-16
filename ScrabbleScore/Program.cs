using System;
using ProjectName.Models;

namespace ProjectName
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter your Scrabble word:");
      string userInput = Console.ReadLine().ToUpper();
      Score newScore = new Score();
      int result = newScore.WordScore(userInput);
      Console.WriteLine("The word's Scrabble score is: " + result);
    }
  }
}