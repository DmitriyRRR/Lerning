using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(50, 40);
            Point p2 = p1;
            Point p3 = new Point(99, 99, "Dot");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine($"p3 {p3}");
            Console.WriteLine($"p4 {p4}");
            p4.X = 7777;
            p2.X = 0;
            p4.desc.PetName = "Three";
           
            Console.WriteLine($"p3{p3}");
            Console.WriteLine($"p4 {p4}");
            Console.ReadLine();
        }
    }
}
