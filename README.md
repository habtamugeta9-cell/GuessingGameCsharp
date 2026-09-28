# Guessing Game

A simple and fun number guessing game built with C# and .NET. In this console-based game, the program selects a random number between 1 and 100, and the player tries to guess it. After each guess, the game tells the player whether the hidden number is too high or too low, until the correct answer is found.

## Description

This project is a beginner-friendly C# programming example that demonstrates:

- random number generation
- user input handling
- loop-based game logic
- conditional statements
- console application development with .NET

It is ideal for students, beginners, and anyone learning C# fundamentals or building small console projects.

## Keywords

C# guessing game, .NET console game, number guessing game, random number game in C#, beginner C# project, console app tutorial, guessing game example, .NET 10 app

## Features

- Random number selection between 1 and 100
- Input validation for non-numeric entries
- Feedback for each guess: too low, too high, or correct
- Tracks the number of attempts made
- Lightweight console application with no external dependencies

## Prerequisites

Before running this project, make sure you have the .NET SDK installed on your machine.

- .NET 10 SDK or compatible version

## How to Run

1. Open a terminal in the project folder.
2. Run the following command:

```bash
dotnet run
```

3. Enter your guess when prompted.
4. Continue guessing until you find the correct number.

## Example Gameplay

```text
Welcome to the Guessing Game!
I have selected a number between 1 and 100.
Enter your guess: 50
Too low!
Enter your guess: 75
Too high!
Enter your guess: 63
Congratulations! You guessed the number in 3 attempts.
```

## Project Structure

```text
GuessingGame/
├── Program.cs
├── GuessingGame.csproj
├── README.md
└── bin/
```

## Learning Purpose

This repository is useful for learning:

- C# syntax and console I/O
- working with loops and conditionals
- using `Random` in .NET
- building and running a .NET console application

## License

This project is provided as-is for educational and personal use.

## Author

Created as a simple C# guessing game project for learning and practice.
