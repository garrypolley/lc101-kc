using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            int times;

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("What number do you like? ");
            times = int.Parse(Console.ReadLine());

            // This is what string interpolation looks like in CSharp
            // Found it here: http://stackoverflow.com/a/9354166/1686511
            Console.WriteLine(times + "Hello, " + name + " you like: ");

            // Make the program "pause" until you end it.
            Console.Read();
        }
    }
}
