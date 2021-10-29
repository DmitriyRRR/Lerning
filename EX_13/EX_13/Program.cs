using System;

namespace EX_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 4; 
            int column = 5;
            int temp = 0;
            int[,] arr_orig = new int[row, column];
            
         
            Random rnd = new Random();
            for (int j = 0; j < row; j++)
            
                for (int i = 0; i < column; i++)
                    arr_orig[j, i] = rnd.Next(0, 100);
            

            for (int j = 0; j < row; j++)
            {

                for (int i = 0; i < column; i++)
                { Console.Write(arr_orig[j, i] + " "); }
                Console.WriteLine();
            }

          

                for (int i = 0; i < column; i++) // замена строк
                {
                    temp = arr_orig[0, i];
                    arr_orig[0, i] = arr_orig[1, i];
                    arr_orig[1, i] = temp;
                    temp = arr_orig[2, i];
                    arr_orig[2, i] = arr_orig[3, i];
                    arr_orig[3, i] = temp;

            }
           
            Console.WriteLine();
            for (int j = 0; j < row; j++)
            {

                for (int i = 0; i < column; i++)
                { Console.Write(arr_orig[j, i] + " "); }
                Console.WriteLine();

                
            }

            Console.WriteLine();
            Console.WriteLine(arr_orig.GetValue(0, 0));
            Console.WriteLine();
            Console.WriteLine(arr_orig[0, 0]);


        }
    }
}
