using System;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Delegates as event enablers*****\n");

            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            Console.WriteLine("********GOOOOO!!!!!!********");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

           

            Console.ReadLine();
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n**************** Message From Car Object **************** ");
            Console.WriteLine("=>{0}", msg);
            Console.WriteLine("************************************************\n");
        }
        public static void OnCarEngineEvent2 (string msg)
        {
        Console.WriteLine("=>{0}", msg.ToUpper());
        }
       
    }
}
