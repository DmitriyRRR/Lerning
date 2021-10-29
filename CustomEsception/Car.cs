using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Car
    {
        
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnON(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    //Console.WriteLine($"{PetName} has overheated!");
                    CurrentSpeed = 0;
                    carIsDead = true;

                    //Exception ex = new Exception($"{PetName} has overheated!");
                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!!!", "You have a lead foot", DateTime.Now);
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
}
