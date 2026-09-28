using System;
using System.Collections.Generic;

namespace GuessingGame
{
    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    record GameResult(
        bool Won,
        int Attempts,
        int Number
    );

    class GuessingGame
    {
        // Properties
        public Difficulty Difficulty { get; }
        public int NumberToGuess { get; }
        public int Attempts { get; private set; }

        // Collection
        private readonly List<int> GuessHistory = new();

        // Constructor
        public GuessingGame(Difficulty difficulty)
        {
            Difficulty = difficulty;
            NumberToGuess = GenerateNumber(difficulty);
        }

        // Method
        private static int GenerateNumber(Difficulty difficulty)
        {
            int maxNumber = difficulty switch
            {
                Difficulty.Easy => 50,
                Difficulty.Medium => 100,
                Difficulty.Hard => 500,
                _ => 100
            };

            return Random.Shared.Next(1, maxNumber + 1);
        }

        // Main game method
        public GameResult Start()
        {
            Console.WriteLine();
            Console.WriteLine($"Difficulty: {Difficulty}");
            Console.WriteLine("Start guessing!");

            while (true)
            {
                Console.Write("Enter your guess: ");

                string? input = Console.ReadLine();

                // Nullable + TryParse
                if (!int.TryParse(input, out int userGuess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                Attempts++;

                // Add guess to collection
                GuessHistory.Add(userGuess);

                // Pattern matching
                if (userGuess < NumberToGuess)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userGuess > NumberToGuess)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine(
                        $"Correct! You found it in {Attempts} attempts."
                    );

                    return new GameResult(
                        true,
                        Attempts,
                        NumberToGuess
                    );
                }
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine();
            Console.WriteLine("Your guesses:");

            foreach (int guess in GuessHistory)
            {
                Console.WriteLine($"- {guess}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       GUESSING GAME");
            Console.WriteLine("================================");

            Difficulty difficulty = ChooseDifficulty();

            // Create object
            GuessingGame game = new GuessingGame(difficulty);

            // Run game
            GameResult result = game.Start();

            // Show result
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("GAME RESULT");
            Console.WriteLine("================================");

            Console.WriteLine($"Won: {result.Won}");
            Console.WriteLine($"Attempts: {result.Attempts}");

            game.ShowHistory();
        }

        static Difficulty ChooseDifficulty()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose difficulty:");
                Console.WriteLine("1. Easy   (1-50)");
                Console.WriteLine("2. Medium (1-100)");
                Console.WriteLine("3. Hard   (1-500)");

                Console.Write("Choice: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return Difficulty.Easy;

                    case "2":
                        return Difficulty.Medium;

                    case "3":
                        return Difficulty.Hard;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}