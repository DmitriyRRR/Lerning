using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Fruits : Item
    {

        public Fruits()
        { }
        //public static Array[] ArraYFruits()
        //{
        //    //Fruits[] arrFruits = new Fruits[3];
        //    Fruits apple = new Fruits("apple", 1111, 10.85f);
        //    Fruits orange = new Fruits("orange", 222, 20.85f);
        //    Fruits plum = new Fruits("plum", 1113331, 8.85f);
        //    return [apple, orange, plum];
        //}
        //Fruits[] arrFruits = { apple, orange, plum };

        public Fruits(string name, int count, float price) : base(name, count, price)
        {
        }
    }
}
