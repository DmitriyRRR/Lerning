using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleEsceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions*****\n");
                Car myCar = new Car("Rustlerr", 85);
            myCar.Accelerate(2000);
            try
            {
                //myCar.Accelerate(90);
            }
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                Console.WriteLine("Catching car engine is dead");
                Console.WriteLine(e.Message);
                //throw;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("What's wrong?");
            }
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}
