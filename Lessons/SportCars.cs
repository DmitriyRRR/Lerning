using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons
{
    public class SportCars : Car
    {
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}