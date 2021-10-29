using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleCTOR
{
    class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount (double balance)
        {
            currBalance = balance;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        public static void SetInterestRate (double newRate)
        { currInterestRate = newRate; }
        static SavingAccount()
        {
            Console.WriteLine("In static CTOR!");
            currInterestRate = 0.04;
        }
    }
}
