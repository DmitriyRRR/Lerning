using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Interfaces*****\n");
            //Hexagon hex = new Hexagon();
            //Console.WriteLine($"Points:{hex.Points}");

            Circle c = new Circle();
            IPointy itfPt = null;
            Hexagon h = new Hexagon("hhhh");
            IPointy itfpt2 = h as IPointy;
            //if (itfpt2 != null)
            //    Console.WriteLine($"Points:{itfpt2.Points}");
            //else
            //    Console.WriteLine("Miss!...");

            Console.WriteLine("*******Fun with interfaces*******\n");
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Fedya"), new Circle("Losharick"), new ThreeDCircle("Wha am I?!") };
            //for (int i=0; i<myShapes.Length; i++)
            //{
            //    myShapes[i].Draw();
            //    if (myShapes[i] is IPointy ip)
            //        Console.WriteLine($"points -> {ip.Points}");
            //    else
            //        Console.WriteLine($"{myShapes[i].PetName} has not pointy");
            //    if (myShapes[i] is IDraw3D)
            //        DrawIn3D((IDraw3D)myShapes[i]);
            //}
            //try
            //{
            //    itfPt = (IPointy) h;
            //    Console.WriteLine($"Points : {itfPt.Points}, name {h.PetName}");
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            IPointy firstPointyItem = FindFirstPointShape(myShapes);
            Console.WriteLine($"The item has {firstPointyItem.Points} points");
            IPointy[] myPointyobjects = { new Hexagon(),  new Fork("Second Fork"), new Fork(), new PitchFork() };
            foreach (IPointy i in myPointyobjects)
                Console.WriteLine($"Objects has {i.Points} points ");
            Console.WriteLine("**********Name Clshes*********");
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();
            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            Console.ReadLine();
        }
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("->>> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }
    }
}
