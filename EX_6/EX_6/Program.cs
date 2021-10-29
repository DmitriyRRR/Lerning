using System;

namespace EX_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[100];
            int next = 0;
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
                Arr[i] = rnd.Next(-150,150);

            Console.WriteLine("Array:\n");
            foreach (int a in Arr) // вывод массива на консоль
            {
                if (next == 10)
                {
                    next = 0;
                    Console.WriteLine("\n");
                }
                Console.Write($"{a}\t");
                next++;
                
            }

            foreach(int a in Arr)// подсчет количетва чисел, удовлетворяющих условию

            {
                if (a > 0 && a < 125)
                    count++;

            }
            Console.WriteLine();
            Console.WriteLine($"\nКоличество чисел удовлетворяющих условию 0<X<125, где Х - искомое число, равняется {count}\n");
        }
    }
}
