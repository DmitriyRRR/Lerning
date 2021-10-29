using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== A first look at interfaces ==============");
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();

        }
        private static void CloneMe (ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
        }
    }
}
