using System;

namespace number
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      bool right = false;
      Random num = new Random();
      int number = num.Next(1, 101);
      while (!right)
      {
        Console.Write("Guess a whole number between 1 and 100: ");
        string input = Console.ReadLine().ToLower();
        int guess;
        if (!Int32.TryParse(input, out guess) || guess < 1 || guess > 100)
        {
          Console.WriteLine("Give me a real number");
        }
        else
        {
          if (guess == number)
          {
            Console.WriteLine("You guessed it!");
            Console.Write("Do you want to play again? y/n: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
              Console.Clear();
              number = num.Next(1, 101);

            }
            else if (answer == "n")
            {
              Console.WriteLine("Thanks for playing!");
              Console.Clear();
              right = true;
            }
          }
          else if (guess < number)
          {
            Console.WriteLine("Guess higher");
          }
          else if (guess > number)
          {
            Console.WriteLine("Guess lower");

          }
        }

      }
    }
  }
}
