using System;
using System.Collections.Generic;

namespace ExampleICompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets figure out which one is bigger.");

            var circle = new Circle(10);
            var square = new Square(10.2);
            var triangle = new Triangle(7, 7, 7);

            var shapes = new List<IArea>() {
                triangle,
                circle,
                square,
            };

            Console.WriteLine("List at start: ");
            PrintShapes(shapes);

            shapes.Sort(new AreaFirst());

            Console.WriteLine();

            Console.WriteLine("List after sort: ");
            PrintShapes(shapes);
        }

        static void PrintShapes(IEnumerable<IArea> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
