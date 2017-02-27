using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            // This is what string interpolation looks like in CSharp
            // Found it here: http://stackoverflow.com/a/9354166/1686511
            Console.WriteLine(string.Format("Hello, {0}", name));

            // Make the program "pause" until you end it.
            Console.Read();
        }
    }
}
