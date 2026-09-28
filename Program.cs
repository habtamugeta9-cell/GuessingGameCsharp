using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberToGuess = random.Next(1,101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100.");

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine();
                    continue;
                }

                attempts++;

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }

        }
    }
}