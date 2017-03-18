using System;

namespace Restaurant
{
    public class Restaurant : BaseClass {
        public string Name {get; set;}
        public string Description {get; set;}
        public string History {get; set;}

        // Have the default basic constructor do nothing but call our
        // super class constructor
        public Restaurant() : base() {}

    }
}