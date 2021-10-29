using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Delegate as event enables********\n");
            Car c1 = new Car("Wroom", 100, 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Console.WriteLine("Speed up!");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(10);
            Console.ReadLine();
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }

    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string  PetName { get; set; }

        private bool carIsDead;
        public Car() { }
        public Car(string name, int maxSp, int currSp) 
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine (CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate (int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if (10==(MaxSpeed - CurrentSpeed) && listOfHandlers !=null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"CurrentSpeeed={CurrentSpeed}");
            }
        }

    }
}
