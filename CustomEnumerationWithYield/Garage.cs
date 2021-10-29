using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerationWithYield
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
            //return caArray.GetEnumerator();
            //throw new Exception("This won't get called");
            //return actualImplementation();
            //IEnumerator actualImplementation()
            { 
                    foreach (Car c in caArray)
                {
                    yield return c;
                }

            }

           
        }

        public IEnumerable GetTheCars (bool returnReversed)
        {
            return actualImplementation();
            IEnumerable actualImplementation()
            {
                if (returnReversed)
                {
                    for (int i = caArray.Length; i!=0; i--)
                    {
                        yield return caArray[i - 1];
                    }
                }
                else
                {
                    foreach (Car c in caArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}
