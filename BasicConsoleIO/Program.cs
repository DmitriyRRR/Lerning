using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BasicConsoleIO
{
    class Program
    {
        private static object b4;

        static void Main()
        {
            //Console.Write("please, enter your name - ");
            //string UserName = Console.ReadLine();
            //Console.Write("please, enter your age - ");
            //string UserAge = Console.ReadLine();
            //ConsoleColor prevColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Hello {0} , you are {1} old, and etc ", UserName, UserAge);
            //Console.ForegroundColor = prevColor;
            //string UserMessage = string.Format("100000 in HEX is {0:x}", 100000);
            //System.Windows.MessageBox.Show(UserMessage);
            Console.WriteLine("=> Data Declarations:");
            // Локальные переменные объявляются и инициализируются так:
            // типДанных имяПеременной - начальноеЗначение;
            int mylnt = 0;
            string myString;
            myString = "This is my character data";
            // Объявить три переменных типа bool в одной строке,
            bool bl = true, Ь2 = false, ЬЗ = bl;
            // Использовать тип данных System.Boolean для объявления булевской переменной.
            System.Boolean Ь4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {0}",
            mylnt, myString, bl, Ь2, ЬЗ, b4);
            Console.WriteLine();
        }
    }
}
