using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerator
{
   public class Garage : IEnumerable
    {
        private Car[] caArray = new Car[4];
        public Garage()
        {
            caArray[0] = new Car("Erondondon", 30);
            caArray[1] = new Car("Toretto", 330);
            caArray[2] = new Car("Zippy", 230);
            caArray[3] = new Car("Emonda", 301);

        }
        public IEnumerator GetEnumerator()
        {
            return caArray.GetEnumerator();
        }
    }
}
