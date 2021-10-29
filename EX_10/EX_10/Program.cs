using System;

namespace EX_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr_int = new int[n];
            int count = 0;
            Random rnd = new Random();
            for( int i =0; i<arr_int.Length;i++)
            {
                arr_int[i] = rnd.Next(-200, 200); 
            }
            foreach (int c in arr_int) Console.Write(c+" ");
            Console.WriteLine();
            for (int i = 0; i < arr_int.Length; i++)
            {
                if (arr_int[i] >= (-100) && arr_int[i] <= 100) count++;
            }
            Console.WriteLine("\n"+count);

        }
    }
}
