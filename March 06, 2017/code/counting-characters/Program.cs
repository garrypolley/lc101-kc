using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string charactersToCount = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut
            ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo.
            Aliquam erat volutpat. Donec sit amet suscipit metus,
                 non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel,
                 volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            string lowerCharactersToCount = charactersToCount.ToLower();

            // Begin counting the characters
            foreach(char character in lowerCharactersToCount) {
                if (character >= 'a' && character <= 'z') {
                    if (characterCounts.ContainsKey(character)) {
                        characterCounts[character] += 1;
                    } else {
                        characterCounts.Add(character, 1);
                    }
                }
            }

            Console.WriteLine("Characters: ");

            // Start printing out characters
            foreach(KeyValuePair<char, int> characterCount in characterCounts) {
                string message = string.Format("{0}: {1}", characterCount.Key, characterCount.Value);
                Console.WriteLine(message);
            }
        }
    }
}
