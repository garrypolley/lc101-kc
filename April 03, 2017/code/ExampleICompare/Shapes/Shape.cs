namespace ExampleICompare
{
    public abstract class Shape
    {
        public abstract double Area();

        public override string ToString()
        {
            var type = this.GetType();

            return $"{type.Name} -- {this.Area()}";
        }
    }
}