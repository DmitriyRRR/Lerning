using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            fred.DisplayStats();
            Manager chucky = new Manager("Chaky", 50, 92, 10000, "333-22-232232", 9000);
            double cost = chucky.GetBenefitsCost();
            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();
            OuterClass.PrivateInnerClass inner2;


            Console.ReadLine();

        }
    }
}
