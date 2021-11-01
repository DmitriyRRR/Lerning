using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Shop
{
    abstract class Item : IEnumerable
    {   
        public string Name { get; set; }
        public int CountItem { get; set; }// method wich name ".Count" exist as basic method of parent class ArrayList
        public float Price { get; set; }// so I renamed Count(int) => CountItem
        public Item()
        { }
        public Item(string name, int count, float price)
        {
            Name = name;
            CountItem = count;
            Price = price;
        }
        public void AddItem(Item Item, int addCount)
        {
            Item.CountItem += addCount;

        }
     
        public void SellItem(Item Item, int sellCount)
        {
            if (sellCount < Item.CountItem)
            {
                for (int i = 0; i < sellCount; i++)
                {
                    Item.CountItem--;
                }
            }
            else
                Console.WriteLine($"It's not enought of {Item.Name} to sale {sellCount} of it.");
        
        }
        public void RevisionItem(Item Item)
        {
            Console.WriteLine($"Revision count of {Item.Name} is {Item.CountItem} ");
        }

        public IEnumerator GetEnumerator(string Name)
        {
            return ((IEnumerable)Name).GetEnumerator();
        }
    }
}
