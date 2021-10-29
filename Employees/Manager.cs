using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts) : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
            //ID = empID;
            //Age = age;
            //Name = fullName;
            //Pay = currPay;
           // SocialSecurityNumber = ssn;
        }
        public Manager() { }
    }
}
