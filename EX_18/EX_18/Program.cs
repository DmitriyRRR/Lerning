using System;

namespace EX_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum = 0;
            float mult =0.0000000001f ;
            int[,] matrix = new int[10,10];
            for (int n = 0; n < 10; n++)
            { for (int i = 0; i < 10; i++)
                    matrix[n,i] = rnd.Next(1, 3);
            }

            for (int n = 0; n < 10; n++)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(matrix[n, i]+" ");

                Console.WriteLine();

            }
            for (int n = 0; n < 10; n++)
            {
                for (int i = 0; i < 10; i++)
                    sum += matrix[n, i];
            }
            for (int n = 0; n < 10; n++)
            {
                for (int i = 0; i < 10; i++)
                    mult *= matrix[n, i];
            }
            Console.WriteLine("Summ of matrix is "+ sum);
            Console.WriteLine("Multiplay of matrix is "+ mult+ "*e10");
        }
            
    }
}
