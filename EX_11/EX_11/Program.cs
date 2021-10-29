using System;

namespace EX_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = Convert(Int32(Console.ReadLine()));
            int[] arr_handle = { 1, 2, 3, 4, 5, 6, 9, 11, 10 , 122, 14 , 15, 32, 29, 17, 255, 111, 144, 7 };
            int[] arr_rnd= new int[50];
            int[] arr_select = new int[5];
            string res="По порядку!";
             Random rnd = new Random();
            for (int i = 0; i < arr_rnd.Length; i++) arr_rnd[i] = rnd.Next(0, 150);
            for (int i = 0; i < arr_select.Length; i++) arr_select[i] = arr_handle[rnd.Next(0, arr_handle.Length)];
            //for (int i = 0; i < arr_select.Length; i++) arr_select[i] = arr_handle[i];
            foreach (int i in arr_select) Console.Write(i + " ");
            for (int i=0; i<4; i++)
            {
                if (arr_select[i] >= arr_select[i + 1])
                {
                    res = "Не по порядку";
                    i = 4;                } 
            }
            Console.WriteLine();
            Console.WriteLine(res);



        }
    }
}
