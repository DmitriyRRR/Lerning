using System;

namespace EX_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of side lenght: ");
            string str = Console.ReadLine();
            int n= int.Parse(str);
            int cnt_positive = 0;
            int cnt_negative = 0;
            int cnt_zero = 0;

            Random rnd = new Random();
            int[,] Arr_SQR = new int[n, n];

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Arr_SQR[i, j] = rnd.Next(-10, 10);
                }
            }

            foreach(int c in Arr_SQR)
            {
                if (c > 0) cnt_positive++;
                if (c < 0) cnt_negative++;
                if (c==0) cnt_zero++;
            }


            for (int j = 0; j < n; j++) //вывод полученого массива
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("  "+Arr_SQR[i, j]+"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Positive count {cnt_positive}\nNegative count {cnt_negative}\nZero count {cnt_zero} ");
        }
    }
}
