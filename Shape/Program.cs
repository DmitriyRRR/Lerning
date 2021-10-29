using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Polumorphism******\n");
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            object triangle = new Circle("No sun");
            Shape moon = new Circle("Moonlight");
            moon.Draw();
            void Draw2(Shape shape)
            {
                Console.WriteLine($"this shape is {shape.PetName}");
            }
            Draw2((Circle)triangle);

            Console.ReadLine();
        }
    }
}
