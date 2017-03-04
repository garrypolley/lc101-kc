using System;

namespace ConsoleApplication
{
    public class Area
    {
        public static void Main(string[] args)
        {
            double radius;

            Console.Write("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());

            double area;

            area = Math.PI * Math.Pow(radius, 2);

            string message = "The area of a circle with radius {0} is: {1:0.###}";

            Console.WriteLine(string.Format(message, radius, area));
        }
    }
}
