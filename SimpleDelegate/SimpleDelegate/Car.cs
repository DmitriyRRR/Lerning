using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDelegate
{
    public class Car
    {
        public int CurrentSpedd { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; } = "Noname";
        private bool carIsDead;
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpedd = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine (CarEngineHandler methodToCall)
        {
            //listOfHandlers += methodToCall;
            if (listOfHandlers == null)
                listOfHandlers = methodToCall;
            else
                listOfHandlers = Delegate.Combine(listOfHandlers, methodToCall) as CarEngineHandler;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            { if (listOfHandlers != null)
                    listOfHandlers($"Sorry, this car is broken..... car");
                
            }
            else
            {
                CurrentSpedd += delta;
                if (10==(MaxSpeed - CurrentSpedd) && listOfHandlers!=null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!!!");
                }
                if (CurrentSpedd >= MaxSpeed)
                    carIsDead = true;
                else 
                    Console.WriteLine($"CurrentSpeed = {CurrentSpedd}, carIsDead =  {carIsDead}" );
            }
        }

    }
}
