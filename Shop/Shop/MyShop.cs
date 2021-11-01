using System;
using System.Collections.Generic;
using System.Collections;
namespace Shop
{
    public class MyShop
    {

        private List<Item> _shopItems { get; set; }

        public MyShop()
        {
            _shopItems = new List<Item>();
        }

        public MyShop(List<Item> items)
        {
            _shopItems = new List<Item>(items);
        }

        public void status()
        {
            foreach(Item item in this._shopItems)
            {
                System.Console.WriteLine($"{item.Name} " + $"{item.Price} ");
            }
        }


        public void add(Item newItem)
        {
            _shopItems.Add(newItem);
        }

        //1. мы може вернуть только при наличии товара
        public T sell<T>(int count) where T : Item
        {
            T returnObject = null;

            //Filter array of all objects by T type object
            List<T> filteredByType = new List<T>();
            for (int i = 0; i < this._shopItems.Count; i++)
            {
                object someObject = this._shopItems[i];

                if (someObject is T)
                {
                    filteredByType.Add((T)someObject);
                }
            }

            List<int> itemsToRemove = new List<int>();

            //Find and add needed items
            if (filteredByType.Count >= count) {
                for (int i = 0; i < this._shopItems.Count; i++)
                {
                    if (itemsToRemove.Count < count)
                    {
                        if (this._shopItems[i] is T)
                        {
                            T item = (T)this._shopItems[i];
                            if (returnObject == null)
                            {
                                returnObject = item;
                            }
                            else
                            {
                                returnObject.Price = returnObject.Price + item.Price;
                            }
                            itemsToRemove.Add(i);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (itemsToRemove.Count > 0)
            {
                itemsToRemove.Reverse();
                for (int i = 0; i < itemsToRemove.Count; i++) {
                    this._shopItems.RemoveAt(itemsToRemove[i]);
                }
            }

            return returnObject;
        }

    }
}

