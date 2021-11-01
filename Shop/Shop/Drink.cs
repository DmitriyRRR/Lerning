using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Drinks : Item
    {

        private Drinks[] arrDrinks = new Drinks[3];
        public Drinks()
        {
            arrDrinks[0] = new Drinks("cola", 210, 15.15f);
            arrDrinks[1] = new Drinks("beer", 112, 77.07f);
            arrDrinks[2] = new Drinks("water", 760, 0.15f);
        }

        public Drinks(string name, int count, float price) : base(name, count, price)
        {
        }
    }
}

