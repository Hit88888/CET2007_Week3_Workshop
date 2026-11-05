using System;

namespace CET2007_Week3_Workshop
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // virtual means child classes can replace this method
        public virtual void Describe()
        {
            Console.WriteLine(Name + " - £" + Price.ToString("F2"));
        }
    }
}