using System;

namespace CET2007_Week3_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One list that holds both Meals and Drinks
            MenuItem[] menu = new MenuItem[3];

            menu[0] = new Meal("Burger", 5.99);
            menu[1] = new Drink("Cola", "500ml", 1.50);
            menu[2] = new Meal("Pizza", 7.49);

            Console.WriteLine("=== Full Menu ===");

            // Go through every item in the list, one by one
            foreach (MenuItem item in menu)
            {
                item.Describe();
            }

            Console.WriteLine();
            Console.WriteLine("=== Order Totals ===");

            Meal burger = new Meal("Burger", 5.99);
            Drink cola = new Drink("Cola", "500ml", 1.50);

            Console.WriteLine("2 Burgers: £" + burger.CalculateTotal(2).ToString("F2"));
            Console.WriteLine("3 Colas: £" + cola.CalculateTotal(3).ToString("F2"));

            Console.ReadLine(); // keeps the window open
        }
    }
}