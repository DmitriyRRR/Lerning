using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine($"{c.PetName} speed {c.CurrentSpeed}");
            }
            Console.ReadLine();

            //IEnumerator i = carLot.GetEnumerator();
            
            //i.MoveNext();
            //Car mC = (Car)i.Current;
            //Console.WriteLine($"{mC.PetName} spd {mC.CurrentSpeed}____{i.MoveNext()}");
            
            
        }
    }
}
