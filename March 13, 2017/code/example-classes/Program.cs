using System;
using Fun;

namespace example_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Name = "Garry";

            Console.WriteLine(string.Format("Hello to {0}", student));
        }
    }
}
