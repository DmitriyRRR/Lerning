using System;

namespace Shop
{
    public class Plants : Item
    {
        public float Weight { get; set; }
        public Plants() : base()
        {
        }

        public Plants(string name, float weight, float price) : base(name, price)
        {
            this.Weight = weight;
        }

    }
}
