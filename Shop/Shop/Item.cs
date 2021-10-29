using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Shop
{
    abstract class Item :ArrayList
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public Item(string name, int count, float price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
        public void AddItem(Item Item, int addCount)
        {
            Item.Count += addCount;

        }public void AddItemNew(Item Item, string name, int addCount, float price)
        {
            Item.Add(name, addCount, price);


        }
        public void SellItem(Item Item, int sellCount)
        {  
            for(int i=0; i<sellCount;i++)
            {
                Item.Count--;
            }
        
        }
        public void RevisionItem(Item Item)
        {
            Console.WriteLine($"Revision count of {Item.Name} is {Item.Count} ");
        }

    }
}
