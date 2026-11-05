using System;

namespace CET2007_Week3_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meal burger = new Meal("Burger", 5.99);
            Drink cola = new Drink("Cola", "500ml", 1.50);

            burger.Describe();
            cola.Describe();

            Console.ReadLine(); // keeps the window open
        }
    }
}