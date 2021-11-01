using System;

namespace Shop
{
    public abstract class Item : Object
    {   
        public string Name { get; set; }
        public float Price { get; set; }

        public Item()
        { }

        public Item(string name, float price) : base()
        {
            this.Name = name;
            this.Price = price;
        }

    }

}
