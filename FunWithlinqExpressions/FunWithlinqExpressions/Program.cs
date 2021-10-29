using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace FunWithlinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Query Expressions*****\n");
            ProductInfo[] ItemInStock = new[]
            {
                new ProductInfo {Name = "Mac's Coffee", Description = "Cofee with TEETH", NumberinStock = 24},
                new ProductInfo {Name = "Milk Maid Milk", Description = "Milk cow's love", NumberinStock = 122},
                new ProductInfo {Name = "Pure Silk Tofu", Description = "Not good for me", NumberinStock = 277},
                new ProductInfo {Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberinStock = 77},
                new ProductInfo {Name = "Classic Valpo Pizza", Description = "From the tap to your wallet", NumberinStock = 2},
                new ProductInfo {Name = "Mac's Coffee", Description = "Everyone loves pizza! (maybe)", NumberinStock = 4},
                new ProductInfo {Name = "Honey", Description = "Sweetty!!!", NumberinStock = 55},
                new ProductInfo {Name = "Coffee!", Description = "Everyone needs coffee in the morning! (maybe)", NumberinStock = 10000},

            };
            //Array objects_new = GetNamesAndDescriptions(ItemInStock);
            //foreach (object o in objects_new)
            //{
            //    Console.WriteLine($"New object >>>>  {o}");
            //}
            GetOverstock(ItemInStock);
            Console.WriteLine();
            Console.ReadLine();


            static void ListProductNames(ProductInfo[] products)
            {
                Console.WriteLine("Product names (all fields):");
                var allProducts = from p in products select p;
                foreach (var prod in allProducts)
                {
                    Console.WriteLine(prod.ToString());
                }
            }
            static void ListProductNamesOnly(ProductInfo[] products)
            {
                Console.WriteLine("Product names (ONLY names):\n");
                var names = from p in products select p.Name;
                foreach (var prod in names)
                {
                    Console.WriteLine($"Name: {prod}");
                }
            }
            
            static void GetOverstock(ProductInfo[] products)
            {
                int overS = 25;

                Console.WriteLine($"The overstock items more than {overS}:\n");
                var overstock = from p in products where p.NumberinStock > overS && p.Name.Contains ("a") select p;
                foreach (var c in overstock.Reverse())
                {
                    //Console.WriteLine(c.ToString());
                    Console.WriteLine($"overstock {c}");
                }
            }

            static Array GetNamesAndDescriptions (ProductInfo[] products)
            {
                Console.WriteLine("Names & Descriptions\n");
                var nameDesc = from p in products select new { p.Name, p.Description };
                /*  foreach(var item in nameDesc)
                  {
                      Console.WriteLine(item.ToString());
                  }*/
                string SSS;
                return nameDesc.ToArray();
            }

            static void GetCountFromQuery(ProductInfo[] products)
            {
            }
        }
    }
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberinStock { get; set; } = 0;
        public override string ToString() => $"Name = {Name}      Description = {Description}      Number in Stock = {NumberinStock}";
    }
    

}
