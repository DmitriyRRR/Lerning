using System;
using System.Collections;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int ArrayNumbers = 20;
            int[] Arr = new int[ArrayNumbers];
            double[] Arr_real = new double[ArrayNumbers];// ex5

            Random  rnd= new Random();
            int[] Arr_pair= new int[ArrayNumbers];
            int[] Arr_single= new int[ArrayNumbers];
            int iii = 0;
            int nnn = 0;
            double rrr = 0;
            for (int i = 0; i < ArrayNumbers; i++) //  наполняем массив рандомными действиетльными числами от -100 до 100
            {
                rrr = rnd.Next(-10000, 10000);
                Arr_real[i] = rrr / 100;
            }

            for (int i = 0; i< ArrayNumbers; i++) //  наполняем массив рандомными целыми числами от 0 до 50
            {
                Arr[i] = rnd.Next(0, 500);
            }

            foreach (int c in Arr)
            {
                Console.Write($"{c} ");
                if ((c % 2)==0)
                {
                    Arr_pair[iii] = c;
                        iii++;
                }
                else 
                { Arr_single[nnn] = c;
                    nnn++;
                }
            }
            Console.WriteLine();
            
            Array.Resize(ref Arr_single, nnn);
            Array.Resize(ref Arr_pair, iii);
            Array.Sort(Arr_single);
            Array.Sort( Arr_pair);
            Console.WriteLine("\nМассив действительных числе \n");
            int next = 0;
            foreach (double real in Arr_real)
            {
                if (next == 5)
                {
                    next = 0;
                    Console.WriteLine();
                }
                Console.Write($"{real}\t");
                next++;
            }
            Console.WriteLine("\n");

            Array.Sort( Arr_real); // ex5
            double min = Arr_real[0];// ex5
            double max = Arr[Arr_real.GetUpperBound(0)];// ex5
            double res = max - min;// ex5
            Console.WriteLine("Single array:\n ");
          
            foreach (int x in Arr_single) Console.Write($"{x} ");

            Console.WriteLine("Pair array: \n");
            foreach (int x in Arr_pair) Console.Write($"{x} ");
            Console.WriteLine($"SINGLE {nnn}, PAIR {iii}");

            Console.WriteLine($"Минимальное значение массива {min}\nМаксимально значением массива {max}\n" +
              $"Разница между минмиальным и максимальным элементом {res}");// ex5
        }
    }
}
