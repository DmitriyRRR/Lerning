using  System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTest;

namespace Test
{

   class Car
    {
        public readonly int maxSpeed;
        private int currentSpeed;
        public Car (int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return currentSpeed; }
            set
            {
                currentSpeed = value;
                if (currentSpeed> maxSpeed)
                {
                    currentSpeed = maxSpeed;
                }
            }
        }
    }
    class MiniVan : Car
    {

    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Basic Inheritance=======\n");
            Car myCar = new Car(80);
            myCar.Speed = 50;
            //myCar.currenSpeed = 10;
            Console.WriteLine($"My Car speed {myCar.maxSpeed} MPH");

            Console.WriteLine("======MiniVan=======\n");
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine($"My van current speed  {myVan.Speed} MPH");
            Console.ReadLine();

        }
    }

}

