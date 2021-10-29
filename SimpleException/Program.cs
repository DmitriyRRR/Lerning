using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
        class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car (string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes (bool state)
        {
            theMusicBox.TurnON(state);
        }
        public void Accelerate (int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed>=MaxSpeed)
                {
                    //Console.WriteLine($"{PetName} has overheated!");
                    CurrentSpeed = 0;
                    carIsDead = true;

                    Exception ex = new Exception($"{PetName} has overheated!");
                    ex.HelpLink = "http://www.CarsRus.com";
                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                    //throw new Exception($"{PetName} has overheated!");
                }
                else
                    Console.WriteLine($"=> CurrentSpeedd = {CurrentSpeed}");
            }
        }
    }
    class Radio
    {
        public void TurnON (bool on)
        {
            Console.WriteLine(on? "Jamming..." : "Quiet time...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Simple Exception Example======");
            Console.WriteLine("=> Creating a car and stepping on it");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            
             catch(Exception e)
            {
                Console.WriteLine("\n*** Error!***");
                Console.WriteLine($"Member name: {e.TargetSite}");
                Console.WriteLine($"Class defining member:{e.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
                Console.WriteLine($"Stack: {e.StackTrace}");

                Console.WriteLine($"Method: {e.TargetSite}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");

                Console.WriteLine($"Help Link: {e.HelpLink}");

                Console.WriteLine("\n->Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine($"->{de.Key}:{de.Value}");
            }
            Console.WriteLine("\n*****Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
