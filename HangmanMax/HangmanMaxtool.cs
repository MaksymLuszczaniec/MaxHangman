using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HangmanMax
{
    internal class HangmanMaxtool
    {
        public string TakeSomeWord()
        {
            Random r = new Random();
            string word = "";

            List<string> words = new List<string>()
            {
                "infamous",
                "fabulous",
                "puzzling",
                "shut",
                "interesting",
                "grumpy",
                "dirty",
                "well-off",
                "scarce",
                "overrated",
            };

            word = words[r.Next(words.Count)]; //words[r.Next(10)];, but l want dynamic
            // we get a random word
            return word;
        }

        public bool ValidGuess(string guess, string lettersGuessed)
        {
            bool result = true; // defult to valid quess

            if (guess.Length != 1) // for one char
            {
                Console.WriteLine("Wrong, only one letter can be choose. again");
                result = false;
            }
            else if (!Char.IsLetter(guess[0]))
            {
                Console.WriteLine("Wrong, It's neeed to be a letter. again");
                result = false;
            }
            else if (lettersGuessed.Contains(guess)) // if already choosen (letter)
            {
                Console.WriteLine("Wrong, you already choose that letter. again");
                result = false;
            }

            return result;
        }

        public string UpdateWord(string playerGuessed, string rozwiazanie) 
        {
            string result = "";

            for (int i = 0; i < rozwiazanie.Length; i++)
            {
                if (playerGuessed.Contains(rozwiazanie[i])) // Is a letter from list?
                {
                    result += rozwiazanie[i];
                }
                else
                {
                    result += "_";
                }
            }

            return result;
        }
    }
}
