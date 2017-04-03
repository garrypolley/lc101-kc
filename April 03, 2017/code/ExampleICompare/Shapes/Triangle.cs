using System;

namespace ExampleICompare
{
    class Triangle : Shape, IArea
    {
        public double SideOne { get; set; }
        public double SideTwo { get; set; }
        public double SideThree { get; set; }

        public Triangle(double one, double two, double three)
        {
            SideOne = one;
            SideTwo = two;
            SideThree = three;
        }

        public override double Area()
        {
            // Formula taken from: http://www.mathopenref.com/heronsformula.html
            double p = (SideOne + SideTwo +	SideThree) / 2;
            double area = Math.Sqrt(p * (p - SideOne) * (p - SideTwo) * (p - SideThree));

            return area;
        }

    }
}