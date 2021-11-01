using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Vegetables : Item
    {
        public Vegetables(string name, int count, float price) : base(name, count, price)
        {
        }

        //private static Vegetables potato = new Vegetables("potato", 200, 10.1f);
        //private static Vegetables onion = new Vegetables("onion", 111, 7.77f);
        //private static Vegetables carrot = new Vegetables("carrot", 76, 8.15f);

        //public Vegetables[] arrVegetables = { potato, onion, carrot };

        private Vegetables[] vegArr = new Vegetables[3];
        public Vegetables()
        { 
        vegArr[0]=new Vegetables("potato", 200, 10.1f);
        vegArr[1]=new Vegetables("onion", 111, 7.77f);
        vegArr[2]=new Vegetables("carrot", 76, 8.15f);
        }
        public IEnumerator GetEnumerator()
        {
            return vegArr.GetEnumerator();
        }
    }
}
