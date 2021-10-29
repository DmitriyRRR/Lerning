using System;
using System.Collections;

namespace EX_21
{

    class Program
    {
        static void Main(string[] args)
        {
            //int[,] ArrRND = new int[7, 14];
            //int[] fff = { 4, 3, 2, };
            //int[] ArrOddRow = new int[ArrRND.GetLength(0)];

            //Random rnd = new Random();
            //for (int i = 0; i < ArrRND.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ArrRND.GetLength(1); j++)
            //        ArrRND[i, j] = rnd.Next(0, 99);
            //}

            //PrintMultyArray(ArrRND);
            //Console.WriteLine();

            //for (int i = 0; i < ArrRND.GetLength(0); i++)
            //{
            //    if (i % 2 != 0)
            //        ArrayByRow(ArrRND, i);
            //    else
            //        ArrayByRowREvers(ArrRND, i);
            //}

            //Console.WriteLine("Changed array");
            //PrintMultyArray(ArrRND);
            //Console.WriteLine();

            //int x = 0;
            //for (int i = 0; i < ArrRND.GetLength(1); i++)
            //    Console.WriteLine(" " + ArrRND[i, x]);



            //void ArrayByRow(int[,] arr, int row)
            //{

            //    int[] TempArray = new int[ArrRND.GetLength(1)];


            //    for (int j = 0; j < ArrRND.GetLength(1); j++)
            //        TempArray[j] = ArrRND[row, j];
            //    Array.Sort(TempArray);
            //    for (int j = 0; j < ArrRND.GetLength(1); j++)
            //        ArrRND[row, j] = TempArray[j];
            //}


            //void ArrayByRowREvers(int[,] arr, int row)
            //{

            //    int[] TempArray = new int[ArrRND.GetLength(1)];


            //    for (int j = 0; j < ArrRND.GetLength(1); j++)
            //        TempArray[j] = ArrRND[row, j];
            //    Array.Sort(TempArray);
            //    Array.Reverse(TempArray);
            //    for (int j = 0; j < ArrRND.GetLength(1); j++)
            //        ArrRND[row, j] = TempArray[j];
            //}

            //void PrintMultyArray(int[,] arr)
            //{
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //            Console.Write(" " + arr[i, j]);
            //        Console.WriteLine();
            //    }
            //}

            var arrayHelper = new ArrayWorkFlow();

            ArrayList twoLayerArray = arrayHelper.newArrayWithSize(5, 10);
            arrayHelper.printArrayList(twoLayerArray);
            arrayHelper.sortedtArray(twoLayerArray);
            arrayHelper.printArrayList(twoLayerArray);

        }

        static void PrintMultyArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(" " + arr[i, j]);
                Console.WriteLine();
            }
        }

    

    }

}

