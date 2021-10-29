using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public string petName;
        public int currentSpeed;
        public void PrintState() => Console.WriteLine($"{petName} is going {currentSpeed} KMH");
        public void SpeedUp(int deltaSpeed) => currentSpeed += deltaSpeed;
        public Car()
        {
            petName = "Ched";
            currentSpeed = 55;
        }
        
    }
    
}
