using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Generator {
        private static Random Rnd = new Random();
        private static List<string> Names = new List<string>{
            "Steak",
            "Coke",
            "Chicken",
            "Eggs",
            "Mutton"
        };
        private static List<decimal> Prices = new List<decimal>{
            1.00m,
            2.00m,
            3.99m,
            10.00m
        };

        public static MenuItem GenerateMenuItem() {
            int categoryIndex = Rnd.Next(MenuItem.Categories.Count);
            var category = MenuItem.Categories[categoryIndex];

            int typeIndex = Rnd.Next(MenuItem.Types.Count);
            var type = MenuItem.Types[typeIndex];

            int nameIndex = Rnd.Next(Names.Count);
            var name = Names[nameIndex];

            int priceIndex = Rnd.Next(Prices.Count);
            var price = Prices[priceIndex];

            var isNew = Rnd.NextDouble() > 0.8;

            return new MenuItem(price, name, "", type, category, isNew);
        }
    }
}