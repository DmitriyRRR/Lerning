using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public SalesPerson() { }

    }
}
