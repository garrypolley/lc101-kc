using System.Text;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem : BaseClass {
        public static List<string> Categories = new List<string>{
            "Appetizer",
            "Entree",
            "Side",
            "Dessert",
            "Drink"
        };

        public static List<string> Types = new List<string>{
            "Beverage",
            "Food"
        };

        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private string _type;
        public string Type { get { return _type; }
            set {
                if (!Types.Contains(value)) {
                    _type = "Food";
                } else {
                    _type = value;
                }
            }
        }
        private string _category;
        public string Category { get { return _category; }
            set {
                if (!Categories.Contains(value)) {
                    _category = "Entree";
                } else {
                    _category = value;
                }
            }
        }
        private bool _isNew;
        public bool IsNew { get { return _isNew; }
            set {
                UpdateMade();
                _isNew = value;
            }
        }

        public MenuItem(decimal price, string name, string description, string type, string category, bool isNew) : base() {
            Price = price;
            Name = name;
            Description = description;
            Type = type;
            Category = category;
            IsNew = isNew;
        }

        public MenuItem(decimal price, string name, string description, string type, string category) : this(price, name, description, type, category, true) {}

        public MenuItem(decimal price, string name, string description, string type) : this(price, name, description, type, "Entree", true) {}

        public MenuItem(decimal price, string name, string description) : this(price, name, description, "Food") {}

        public MenuItem(decimal price, string name) : this(price, name, "", "Food") {}

        public override string ToString() {
            if (string.IsNullOrWhiteSpace(Description)) {
                return $"{Name} ({Price})";
            }
            return $"{Name} ({Price})\n{Description}";
        }
    }
}