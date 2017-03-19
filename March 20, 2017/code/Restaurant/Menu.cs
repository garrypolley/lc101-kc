using System.Text;
using System.Collections.Generic;

namespace Restaurant
{
    public class Menu : BaseClass {
        public List<MenuItem> Items { get; private set; }

        public Menu() : base() {
            Items = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item) {
            UpdateMade();
            Items.Add(item);
        }

        public void RemoveMenuItem(MenuItem item) {
            UpdateMade();
            Items.Remove(item);
        }

        public void ItemNoLongerNew(MenuItem item) {
            UpdateMade();
            item.IsNew = false;
        }

        public override string ToString() {
            var appetizerBuilder = new StringBuilder("");
            var entreeBuilder = new StringBuilder("");
            var sideBuilder = new StringBuilder("");
            var dessertBuilder = new StringBuilder("");
            var drinkBuilder = new StringBuilder("");
            var beverageBuilder = new StringBuilder("");


            // Setup standard Menu
            foreach (var item in Items)
            {
                if (item.Category.Equals("Appetizer")) {
                    appetizerBuilder.AppendLine(MakeItem(item));
                }
                if (item.Category.Equals("Entree")) {
                    entreeBuilder.AppendLine(MakeItem(item));
                }
                if (item.Category.Equals("Side")) {
                    sideBuilder.AppendLine(MakeItem(item));
                }
                if (item.Category.Equals("Dessert")) {
                    dessertBuilder.AppendLine(MakeItem(item));
                }
                if (item.Category.Equals("Drink") || item.Type.Equals("Beverage")) {
                    drinkBuilder.AppendLine(MakeItem(item));
                }
            }

            var apps = MakeSection("Appetizers", appetizerBuilder);
            var entrees = MakeSection("Entrees", entreeBuilder);
            var sides = MakeSection("Sides", sideBuilder);
            var deserts = MakeSection("Desserts", dessertBuilder);
            var drinks = MakeSection("Drinks", drinkBuilder);

            return $"{apps}{entrees}{sides}{deserts}{drinks}";
        }

        private string MakeSection( string name, StringBuilder section) {
            return $"-- {name} -- \n\n{section}\n\n\n";
        }

        private string MakeItem(MenuItem item) {
            if (item.IsNew) {
                return $"{item} -- NEW";
            }
            return $"{item}";
        }
    }
}