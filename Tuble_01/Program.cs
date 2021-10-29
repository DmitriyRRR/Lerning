using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuble_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////(char CharOne, int IntTwo, string StringThree)
            //var val = ("a", 12, "cv");
            //var valuesNamed = (CharOne: "a", IntTwo: 12, StringThree: "cv");
            //Console.WriteLine($"First item:{val.Item1}");
            //Console.WriteLine($"Second item:{val.Item2}");
            //Console.WriteLine($"Third item:{valuesNamed.StringThree}");
            //Console.WriteLine("TUPLE");
            //var foo = new { Prop1 = "first", Prop2 = "second" };
            //var bar = (foo.Prop1, foo.Prop2);
            //Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
            //(string first, string middle, string last) SplitNames (string fullName)
            //{
            //    return ("Philip", "F", "Japikse");
            //}
            //var (first, _, last) = SplitNames("Philip F Japikse");
            //Console.WriteLine($"{first}:{last}");

            Point p = new Point(7, 5);
            var pointValue = p.Deconstruct();
            Console.WriteLine($"X is: {pointValue.XPos}");
            Console.WriteLine($"Y is: {pointValue.YPos}");
         }
        struct Point
        {
            public int X;
            public int Y;
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }
    }
}
