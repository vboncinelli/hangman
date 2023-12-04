using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of words that the player has to guess
            string[] words = { "csharp", "visualstudio", "language", "array", "variable", "parsing", "constant" };

            // To verify that the player's input is within 'a' and 'z'
            var validCharacters = new Regex("^[a-z]$");

            // Find a random number
            int myRandomNumber = new Random().Next(0, words.Length - 1);

            // Pick a random word from the arrary
            string wordToGuess = words[myRandomNumber];

            // Number of lives
            int lives = 3;

            // List of letters submitted by the player
            List<string> letters = new();

            // As long as the player has lives left, the game continues
            while (lives != 0)
            {

            }
        }
    }
}
