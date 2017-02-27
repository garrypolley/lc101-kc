using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double width;
            double height;

            Console.WriteLine("We shall compute the area of a rectangle");

            Console.Write("What is the width? ");
            width = double.Parse(Console.ReadLine());

            Console.Write("What is the height? ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("Your rectangle area is {0}", (width * height)));

            // Pause execution until you're ready to end
            Console.Read();
        }
    }
}
