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
    }
}