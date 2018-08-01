using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune_my
{
    public class Puzzle
    {
        public bool unsolvedStatus { get; set; }
        public bool uncompletedStatus { get; set; }
        public HashSet<string> guessedCorrectLetters { get; set; }
        public string solution { get; private set; }
        public HashSet<string> uniqueLettersInPuzzle;
        public string guessOrSolve { get; set; }

        // Constructor Functions
        public Puzzle()
        {
            this.unsolvedStatus = true;
            this.uncompletedStatus = true;
            this.guessedCorrectLetters = new HashSet<string>();
            this.solution = "one possible puzzle";
            this.uniqueLettersInPuzzle = new HashSet<string>();
            this.guessOrSolve = "g";

            foreach (char letter in solution)
            {
                if (letter != ' ')
                {
                    uniqueLettersInPuzzle.Add(letter.ToString());
                }
            }
        }

        /// <summary>
        /// Displays solution at any state to the user
        /// </summary>
        public void DisplaySolution()
        {
            var displayedSolution = new StringBuilder();

            foreach (char letter in solution)
            {
                if (letter == ' ')
                {
                    displayedSolution.Append(" ");
                }
                else if (guessedCorrectLetters.Contains(letter.ToString()))
                {
                    displayedSolution.Append(letter);
                }
                else
                {
                    displayedSolution.Append("-");
                }
            }

            Console.WriteLine(displayedSolution);
        }

        /// <summary>
        /// Keep track of correctly guessed letters
        /// </summary>
        public void AddToGuessedCorrectLetters(Guess guess)
        {
            guessedCorrectLetters.Add(guess.self);
        }

        public HashSet<string> SolveToHashSet(string solve)
        {
            HashSet<string> SolveHash = new HashSet<string>();

            foreach (char letter in solve)
            {
                if (letter != ' ')
                {
                    SolveHash.Add(letter.ToString());
                }
            }

            return SolveHash;
        }

    }
}
