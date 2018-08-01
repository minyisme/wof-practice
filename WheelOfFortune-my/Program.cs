using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune_my
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating User

            Console.WriteLine("Welcome to Wheel of Fortune");

            // Question: better to do this or ask for a name outside class and create name when instantiating User object?
            Console.WriteLine("First, what is your name?");
            string name = Console.ReadLine();
            var user = new User(name);

            Console.WriteLine($"Thanks {user.Name}");

            // Play Puzzle

            Console.WriteLine("Guess the following phrase.");
            var puzzle = new Puzzle();


            while (puzzle.unsolvedStatus)
            {
                // Show Puzzle to user
                puzzle.DisplaySolution();

                // Setting guess or solve
                if (puzzle.uncompletedStatus)
                {
                    Console.WriteLine("Would you like to [g]uess a letter or [s]olve the puzzle?");
                    puzzle.guessOrSolve = Console.ReadLine();
                }
                else
                {
                    puzzle.guessOrSolve = "s";
                }
                
                // User guesses or solves
                if (puzzle.guessOrSolve == "g")
                {
                    // User Guesses Letter
                    Console.WriteLine("Guess a letter.");
                    var guess = new Guess(Console.ReadLine());

                    while (guess.isNotValidGuess())
                    {
                        Console.WriteLine("Guess a letter.");
                        guess = new Guess(Console.ReadLine());
                    }

                    // Add Guess to Puzzle
                    if (puzzle.uniqueLettersInPuzzle.Contains(guess.self))
                    {
                        puzzle.AddToGuessedCorrectLetters(guess);
                    }


                    // Check completed status
                    if (puzzle.uniqueLettersInPuzzle.SetEquals(puzzle.guessedCorrectLetters))
                    {
                        puzzle.uncompletedStatus = false;
                    }
                }
                
                else if (puzzle.guessOrSolve == "s")
                {
                    Console.WriteLine("Guess the phrase.");
                    var solve = Console.ReadLine();

                    HashSet<string> solveHash = puzzle.SolveToHashSet(solve);

                    if (puzzle.uniqueLettersInPuzzle.SetEquals(solveHash))
                    {
                        puzzle.unsolvedStatus = false;
                    }
                }
            }

            Console.WriteLine("Congratulations you've solved the puzzle.");

            Console.ReadKey();
        }

    }
}
