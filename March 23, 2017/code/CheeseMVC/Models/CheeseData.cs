using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();

        // GetAll
        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        // Add
        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }

        // Remove
        public static void Remove(string cheeseId)
        {
            Cheese cheeseToRemove = GetById(cheeseId);
            cheeses.Remove(cheeseToRemove);
        }

        // GetById
        public static Cheese GetById(string cheeseId)
        {
            return cheeses.Single(x => x.CheeseId == cheeseId);
        }

        public static void Save(Cheese cheese)
        {
            var cheeseIndex = cheeses.IndexOf(cheese);
            Remove(cheese.CheeseId);

            // Insert at the index of the removed cheese to ensure we keep order;
            cheeses.Insert(cheeseIndex, cheese);
        }


    }
}
