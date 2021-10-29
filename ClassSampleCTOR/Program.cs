using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleCTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Data usage******************");

            SavingAccount s1 = new SavingAccount(50);
            Console.WriteLine("Interest Rate is; {0}", SavingAccount.GetInterestRate());
            SavingAccount.SetInterestRate(0.08);
            SavingAccount s2 = new SavingAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingAccount.GetInterestRate());
            SavingAccount s3 = new SavingAccount(999);
            Console.WriteLine($"Interest Rate is:{SavingAccount.currInterestRate}");
            Console.WriteLine($"Interest Rate is:{SavingAccount.GetInterestRate()}");
            Console.ReadLine();
        }
    }
}
