using System;
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101); // 1 to 100
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Basic input safety (optional but nice)
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid whole number.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().Trim().ToLower();
        }
    }
}
