using System;
using System.Collections;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables arrF = new Vegetables();

            foreach (Item c in arrF)
               Console.WriteLine(c.Name +" "+ c.CountItem + " " +c.Price);
     
        }
        
    }
}
