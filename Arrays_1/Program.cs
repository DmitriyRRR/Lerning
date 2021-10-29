using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ArrayS=>");
            Console.WriteLine("Enter numbers elemetn of Array");
            int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("=>Simple Array Creation.");
            string[] Arr = new string[x];
            //string[] booksOnDotNet = new string[100];
            //Console.WriteLine(booksOnDotNet);
            for (int n = 0; n < x; n++)
            {
                Arr[n] = Console.ReadLine();
            }
            Console.WriteLine("This is your array");
            //foreach (string i in Arr)
            //    Console.WriteLine(i);
            for (int i=0; i<Arr.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, Arr[i]);

            
            Console.ReadLine();



            /*   int[][] ArrJagged = new int[5][];
               for (int i = 0; i < ArrJagged.Length; i++)
                   ArrJagged[i] = new int[i + 10];
               for (int i=0; i<5; i++)
               {
                   for (int j=0; j<ArrJagged[i].Length; j++)
                       Console.Write(ArrJagged[i][j] + " ");
                   Console.WriteLine();
               }
               Console.WriteLine();*/

        }
        //static void SimpleArrays()
        //{
        //    Console.WriteLine("=>Simple Array Creation.");
        //    int[] Arr = new int[3];
        //    string[] booksOnDotNet = new string[100];
        //    Console.WriteLine();
        //}
    }
}
