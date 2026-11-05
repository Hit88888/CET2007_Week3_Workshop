using System;

namespace CET2007_Week3_Workshop
{
    public class Meal : MenuItem
    {
        public Meal(string name, double price) : base(name, price)
        {
        }

        public override void Describe()
        {
            Console.WriteLine("Meal: " + Name + " - £" + Price.ToString("F2"));
        }

        public override double CalculateTotal(int quantity)
        {
            double subtotal = Price * quantity;
            double tax = subtotal * 0.10;   // 10 percent tax
            return subtotal + tax;
        }
    }
}