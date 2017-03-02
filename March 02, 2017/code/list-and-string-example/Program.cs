using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Which length of word would you like to see? ");

            // "inline" assignment of a variable
            int wordLength = int.Parse(Console.ReadLine());

            // Literal creation of a list of strings.
            List<string> words = new List<string>{
                "OneWord",
                "TwoWord",
                "FiveWord",
                "Silly",
                "Bobby",
                "Jim Carl",
                "JimBob",
                "GarryP",
                "Johnny",
                "Garry",
                "With Last",
                "Polley",
                "the",
                "a",
                "Jay",
                "Art",
            };

            Program.PrintWordsWithCount(words, wordLength);

            Console.Read();
        }

        public static void PrintWordsWithCount(List<string> words, int count)
        {
            int wordCount = 0;

            // Foreach for a given word in our words.
            foreach(string word in words) {
                if (word.Length == count) {
                    Console.WriteLine(word);
                    wordCount++;
                }
            }

            if (wordCount == 0) {
                Console.WriteLine("No words matched your count");
            }
        }
    }
}
