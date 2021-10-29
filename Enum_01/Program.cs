using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_01
{
    enum Days
    {
        Monday = 5,
        Tuesday,
        Wednesday,
        Thursday = 14,
        Friday = Tuesday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days day = Days.Sunday;
            Console.WriteLine((double)day);
        }
    }
}

