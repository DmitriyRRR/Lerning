using System;

namespace Shop
{
    public class Drinks : Item
    {
        public float Volume { get; set; }

        public Drinks()
        {
        }

        public Drinks(string name, float price ,float volume) : base(name, price)
        {
            this.Volume = volume;
        }
    }
}

