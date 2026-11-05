using System;

namespace CET2007_Week3_Workshop
{
    public class Drink : MenuItem
    {
        public string Size { get; set; }

        public Drink(string name, string size, double price) : base(name, price)
        {
            Size = size;
        }

        public override void Describe()
        {
            Console.WriteLine("Drink: " + Name + " (" + Size + ") - £" + Price.ToString("F2"));
        }

        public override double CalculateTotal(int quantity)
        {
            double subtotal = Price * quantity;
            double tax = subtotal * 0.05;   // 5 percent tax
            return subtotal + tax;
        }
    }
}