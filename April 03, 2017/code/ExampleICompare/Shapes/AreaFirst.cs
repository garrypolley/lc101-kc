using System.Collections.Generic;

namespace ExampleICompare
{
    public class AreaFirst : IComparer<IArea>
    {
        public int Compare(IArea shapeOne, IArea shapeTwo)
        {
            return shapeTwo.Area().CompareTo(shapeOne.Area());
        }
    }
}