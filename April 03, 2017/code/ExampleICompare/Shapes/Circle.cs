using System;

namespace ExampleICompare
{
    class Circle : Shape, IArea
    {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}