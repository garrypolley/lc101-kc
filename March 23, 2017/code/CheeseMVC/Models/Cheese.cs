using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string CheeseId { get; set; }

        public Cheese()
        {
            // Remove the hyphens because the routing does not allow them by default.
            CheeseId = Guid.NewGuid().ToString().Replace("-", string.Empty);
        }

        // Overridden so the List check in CheeseData works.
        public override bool Equals (object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Cheese passedCheese = (Cheese)obj;

            return CheeseId.Equals(passedCheese.CheeseId);
        }

    }
}
