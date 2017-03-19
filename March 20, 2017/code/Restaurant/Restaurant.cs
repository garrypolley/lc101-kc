using System;
using System.Text;
using System.Collections.Generic;

namespace Restaurant
{
    public class Restaurant : BaseClass {
        private string _name;
        public string Name {
            get {return _name;}
            set {
                UpdateMade();
                _name = value;
            }
        }
        private string _address;
        public string Address {
            get {return _address;}
            set {
                UpdateMade();
                _address = value;
            }
        }
        private string _description;
        public string Description {
            get {return _description;}
            set {
                UpdateMade();
                _description = value;
            }
        }
        private string _history;
        public string History {
            get {return _history;}
            set {
                UpdateMade();
                _history = value;
            }
        }

        private Dictionary<string, Menu> _menus;
        public Dictionary<string, Menu> Menus {
            get { return _menus; }
            private set { _menus = value; }
        }

        public Restaurant(string name, string description, string history, string address) : base() {
            Name = name;
            Description = description;
            History = history;
            Address = address;
            Menus = new Dictionary<string, Menu>();
        }

        public Restaurant(string name, string description, string history) : this(name, description, history, "") {}

        public Restaurant(string name, string description) : this(name, description, "") {}

        // Have the default basic constructor do nothing but call our
        // super class constructor
        public Restaurant(string name) : this(name, "") {}

        public void AddMenu(String name, Menu menu) {
            UpdateMade();
            _menus.Add(name, menu);
        }

        public void RemoveMenu(String name) {
            UpdateMade();
            _menus.Remove(name);
        }

        public void RemoveMenu(Menu menu) {
            UpdateMade();
            foreach (var item in _menus)
            {
                if (item.Value.Equals(menu)) {
                    _menus.Remove(item.Key);
                    break;
                }
            }
        }

        public override string ToString() {
            var menusPrinted = new StringBuilder("");
            foreach (var menu in _menus)
            {
                menusPrinted.AppendLine($"{menu.Key}: \n\n{menu.Value}");
            }

            if (string.IsNullOrWhiteSpace(History)) {
                return $"\n{Name}\n{Address}\n{Description}\n\n\n{menusPrinted}";
            }

            return $"\n{Name}\n{Address}\n{Description}\n\n\n{menusPrinted}\n\n{History}";
        }

        public string ShowIdentities() {
            var menusIdentities = new StringBuilder("");
            foreach (var menu in _menus)
            {
                menusIdentities.AppendLine($"{menu.Value.Identity}\n");
                foreach (var menuItem in menu.Value.Items) {
                    menusIdentities.AppendLine(menuItem.Identity);
                }

                menusIdentities.AppendLine();
                menusIdentities.AppendLine();
            }

            return $"{Identity}\n{menusIdentities}";
        }
    }
}