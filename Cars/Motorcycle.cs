using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        public void whellUp()
        {
        for (int i =0; i<=driverIntensity; i++)
            {
                Console.WriteLine("gooooooooo!");
            }
        }

        public void SetDriverName ( string name)
        {
            driverName = name;
        }
        public Motorcycle()
        {

        }
        public Motorcycle(int intensity)
        {
           SetIntensity(intensity);
        }
        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            driverName = name;
        }
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }


    }
}
