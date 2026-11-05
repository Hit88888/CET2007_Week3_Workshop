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
    }
}