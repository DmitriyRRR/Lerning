using System;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ElementNumber = rnd.Next();
            int Sum = 0;
            double Mult = 1;


            int[,] Numbers = new int[10, 10]; //array init, 10*10, random nubers
            for (int n = 0; n < 10; n++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Numbers[i, n] = rnd.Next(1, 100);
                }
            }


            for (int n = 0; n < 10; n++) // output array 
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{Numbers[i, n]}\t");
                }
                Console.WriteLine();
            }

          
           

            for (int n = 0; n < 10; n++) // sum line numbers and multiplay collumn numbers
            {
                for (int i = 0; i < 10; i++)
                {
                    Sum = Sum + Numbers[i, n];
                    Mult = (Numbers[n, i])*Mult;
                }
                Console.WriteLine($"Summa {Sum}, \t Multiply {Mult}");
                Sum = 0;
                Mult = 1;
                Console.WriteLine();
            }

            int[] diag_arr = new int[10];
            for (int n = 0; n < 10; n++)
            {
               
             //Console.Write($"Diagonal numbers {Numbers[n, n]}\t");
                diag_arr[n] = Numbers[n, n];
              
            }

            foreach (int nnn in diag_arr) //out on console main diagonal
            {
                Console.Write($"Diagonal numbers { nnn}\t");

            }

            Console.WriteLine("\n");

            int maxValue = diag_arr.Max<int>(); // maxvalue in main  diagonal first way

            Console.WriteLine($"Maximum value in main diagonal {maxValue}");

            Array.Sort(diag_arr); // maxvalue in main  diagonal second way
            maxValue = diag_arr[diag_arr.GetUpperBound(0)];
            Console.WriteLine($"Maximum value in main diagonal {maxValue}");


        }
        static int Sum(int[,] Numbers, int i = 0)
        {
            if (i >= Numbers.GetUpperBound(0))
                return 0;
            int result = Sum(Numbers, i++);
            return Numbers[i,0] + 1;
        }


    }
}
