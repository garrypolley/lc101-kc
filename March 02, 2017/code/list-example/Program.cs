using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare what variables we will need
            Random rnd = new Random();
            List<int> numbersToSum = new List<int>();
            int randomNum;
            int sum = 0;

            // Begin creating numbers
            Console.Write("Creating Numbers: ");
            for (int i = 0; i < 10; i++) {
                randomNum = rnd.Next(1, 50);
                numbersToSum.Add(randomNum);
                Console.Write(string.Format("{0} ", randomNum));
            }

            // Add up the numbers
            foreach (int num in numbersToSum) {
                sum += num;
            }

            // Print out our results
            Console.WriteLine(string.Format("\nWe have added up to: {0}", sum));
        }
    }
}
