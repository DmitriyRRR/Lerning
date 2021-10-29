using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....*******....\n");
            Car myCar = new Car("Rustlerr", 90);
            try
            {
                myCar.Accelerate(50);   
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            
        }
    }
}
