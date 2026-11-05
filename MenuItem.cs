using System;

namespace CET2007_Week3_Workshop
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Describe()
        {
            Console.WriteLine(Name + " - £" + Price.ToString("F2"));
        }

        // Rule: every child class must write its own version of this
        public abstract double CalculateTotal(int quantity);
    }
}