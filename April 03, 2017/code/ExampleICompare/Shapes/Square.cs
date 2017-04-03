namespace ExampleICompare
{
    class Square : Shape, IArea
    {
        public double Side { get; set;}

        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}