using System;

namespace Temp_1
{
    class Program
    {
        /*    static void RemoveAt(ref int[] array, int index)
            {
                int[] newArray = new int[array.Length - 1];
                for (int i = 0; i < index; i++)
                    newArray[i] = array[i];

                for (int i = index + 1; i < array.Length; i++)
                    newArray[i - 1] = array[i];

                array = newArray;
                foreach (int a in array)
                    Console.Write(a + " ");

                int x = 1;
                int y = 1;
                Console.WriteLine();
                Console.WriteLine(x=+y);
                Console.WriteLine(x + " " + y);

            }
            static void Main(string[] args)
            {
                int[] myArray = { 0, 1, 2, 3, 4, 5, 6 };

                RemoveAt(ref myArray, 3);
                foreach(int a in myArray)
                    Console.Write(a + " ");
            }*/
        static void Main(string[] args)
        {
            int Nth = 6;
            long SumOfRow = 0;
            int[] TriangleOdd = new int[20];
            for(int i=0; i<20; i++)
            {
                TriangleOdd[i] =2 * i + 1;
            }

            SumOfRow =(long) Math.Pow(Nth, 3);
            Console.WriteLine(SumOfRow);
            
            
        }




    }
}
