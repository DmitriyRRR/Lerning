using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerationWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage Gar = new Garage();
            //IEnumerator carEnumerator = Gar.GetEnumerator();

            foreach (Car c in Gar)
            {
                Console.WriteLine($"{c.PetName} speed {c.CurrentSpeed}");
            }
            Console.WriteLine();
            foreach (Car c in Gar.GetTheCars(true))
            {
                Console.WriteLine($"{c.PetName} speed {c.CurrentSpeed}");
            }
            Console.ReadLine();

        }
    }
}
