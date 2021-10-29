using System;
using System.Collections;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Items = new ArrayList();
           
            Fruits Orange = new Fruits();
            Orange.Count = 10;
            Orange.Price = 23.10f;
            Orange.Name = "Orange";
            Items.Add(Orange);
            Console.WriteLine(Orange.Count);
            Orange.SellItem(Orange, 3);
            Console.WriteLine(Orange.Count);
            Orange.AddItem(Orange, 5);
            Console.WriteLine(Orange.Count);
            Orange.RevisionItem(Orange);

        }
        
    }
}
