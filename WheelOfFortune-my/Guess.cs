using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune_my
{
    public class Guess
    {
        public string self { get; private set; }

        // Constructor Functions
        public Guess(string userInput)
        {
            this.self = userInput;
        }
        /// <summary>
        /// Ask user for guess and get it
        /// </summary>
        /// <returns>guess</returns>
        public string GetSelf()
        {
            Console.WriteLine("Guess a letter.");
            return Console.ReadLine();
        }

        /// <summary>
        /// Validates if guess is 1 letter
        /// </summary>
        /// <param name="guess">user's guess</param>
        /// <returns>t/f if guess is valid</returns>
        public bool isNotValidGuess()
        {
            if (self.Length != 1)
            {
                Console.WriteLine("Your guess needs to be 1 letter in length.");
                return true;
            }
            if ((Convert.ToChar(self) <= 'A' && Convert.ToChar(self) >= 'Z') || (Convert.ToChar(self) <= 'a' && Convert.ToChar(self) >= 'z'))
            {
                Console.WriteLine("Your guess needs to be an alphabetical letter");
                return true;
            }
            return false;
        }
    }


}
