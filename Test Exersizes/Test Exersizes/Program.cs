using System;

namespace Test_Exersizes
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            char ChR = 'c';
            string read;
            read = Console.ReadLine();
            ChR = char.Parse(Console.ReadLine());
            Console.WriteLine($"Input string   including {read.Length} symbols");

            for (int i = 0; i < read.Length; i++)
            {
                if (read[i] == ChR) count++;

            }
            Console.WriteLine($"{ChR} in tis string: {count}");
            double percent =0.00d;
            
            percent = (100*count)/(read.Length);
            Console.WriteLine( percent +  "%") ;         
            Console.WriteLine(System.Math.Round((double)(count / (read.Length))*100));         
            Console.ReadLine();

        }
    }
}
