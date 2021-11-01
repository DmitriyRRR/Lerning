using System;
using System.Collections;

namespace Shop
{
    class Program
    {



        static void Main(string[] args)
        {

            MyShop shop = new MyShop();

            shop.add(new Drinks("Beer", 4, 2.50f));
            shop.add(new Drinks("Beer 1", 4, 4.50f));
            shop.add(new Drinks("Beer 2", 4, 5.50f));
            shop.add(new Drinks("Beer 3", 4, 3.50f));


            shop.add(new Fruits("Apple", 4, 2.50f));
            shop.add(new Fruits("Lemon", 4, 4.50f));
            shop.add(new Fruits("Cherry", 4, 5.50f));
            shop.add(new Fruits("Orange", 4, 3.50f));


            shop.add(new Vegetables("Carrot", 4, 2.50f));
            shop.add(new Vegetables("Potato", 4, 4.50f));
            shop.add(new Vegetables("Pomodore", 4, 5.50f));
            shop.add(new Vegetables("Beetroot", 4, 3.50f));


            System.Console.WriteLine("Init");
            shop.status();

            Fruits someVeg = shop.sell<Fruits>(2);

            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("Left");
            
            shop.status();

            System.Console.WriteLine("Sell");
            System.Console.WriteLine($"{someVeg.Price}");
        }



    }
}
