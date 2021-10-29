using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Class Types*****\n");

            Car ched = new Car();
            Motorcycle med = new Motorcycle();
            med.driverIntensity = 10;
            med.driverName = "Sonya";
            med.whellUp();
            Console.WriteLine(med.driverName);
            //Console.WriteLine(myCar.petName);
            //myCar.petName = "Fedya";
            //Car myCar = new Car();
            //myCar.petName = "Henry";
            //myCar.currentSpeed = 100;
            //for (int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(10);
            ched.PrintState();
            //}
            //Console.ReadLine();

        }
    }
}
