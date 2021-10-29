using System;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string STR = "All you need is time";
            string STR = Console.ReadLine();
            //int count = 0;
            char separate = ' ';
            var count = STR.Split(separate, StringSplitOptions.RemoveEmptyEntries); // собираем массив из слов в строке STR  считая пробелы, если за пробелом идет путоста и получается пустое слово, состоящие и зпробела  - удаляем
            foreach (var v in count)
            Console.WriteLine(v);

            Console.WriteLine($"Количество слов в строке: {STR} равно {count.Length}");
           
        }
    }   
}
