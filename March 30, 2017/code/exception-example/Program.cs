using System;

namespace exception_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add number together");

            Console.Write("First Number: ");
            var numberOneStr = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Second Number: ");
            var numberTwoStr = Console.ReadLine();

            int numberTwo;
            try {
                numberTwo = int.Parse(numberTwoStr);
            } catch (FormatException) {
                numberTwo = 0;
            }

            int numberOne;
            try {
                numberOne = int.Parse(numberOneStr);
            } catch (FormatException) {
                numberOne = 0;
            }


            var sumNumbers =  numberOne + numberTwo;

            Console.WriteLine();
            Console.WriteLine($"{sumNumbers} Done");
            Console.Read();
        }
    }
}
