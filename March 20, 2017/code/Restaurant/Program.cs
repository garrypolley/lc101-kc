using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPlace = new Restaurant("My Place");
            myPlace.Address = "42 wallaby way Sydney";
            myPlace.Description = "The best place to eat. Period.";
            myPlace.History = "We've been around, for some time.";

            var myMenu = new Menu();

            for(int i = 0; i < 20; i++) {
                var menuItem = Generator.GenerateMenuItem();
                myMenu.AddMenuItem(menuItem);
            }

            myPlace.AddMenu("Lunch", myMenu);


            Console.WriteLine(myPlace);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("done... press 'enter' to exit");
            var showMore = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(showMore)) {
                Console.WriteLine(myPlace.ShowIdentities());
                Console.Read();

                Console.WriteLine("done... press 'enter' to exit");
            }
        }
    }
}
