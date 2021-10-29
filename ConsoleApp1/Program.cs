using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            // Добавить две переменные типа short и вывести результат,
                       
            int numb1 = 30000000 , numb2 = 300000000;
            short answer = unchecked((short)Add(numb1, numb2));
            int answ = Add(answer, numb2);
            Console.WriteLine(answer);
            Console.WriteLine(answ);
            int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
