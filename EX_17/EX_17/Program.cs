using System;
using System.Linq;
using System.Collections.Generic;

namespace EX_17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] SecondNames = new string[] { "Rozumenko", "Chekusov", "Ivanov", "Holodnyak", "Tereshenko", "Dubina", "Troelsen", "Nesterenko"};
            int count = 0;
            
            for (int i = 0; i < SecondNames.Length; i++)
            {
                if (count <= SecondNames[i].Length)
                    count = SecondNames[i].Length;
            }
            for (int i = 0; i < SecondNames.Length; i++)
            {
                if (count == SecondNames[i].Length)
                    Console.WriteLine(SecondNames[i]); ;
            }
            Console.WriteLine("Count >>"+count);
            

        }
    }
}
