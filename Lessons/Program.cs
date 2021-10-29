using System;
using System.Windows.Forms;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            //Console.WriteLine("So");
            //string a;
            //a =  Console.ReadLine(); // initialization
            //Console.WriteLine("Hi " + a + "!");
            //Console.Title = "My World";
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*****************************");
            //Console.WriteLine("*****Welcom to My world******");
            //Console.WriteLine("*****************************");
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ReadLine();
            //MessageBox.Show("All done!");
            string str; // объявление переменной типа строка str
            int a, b;// объявление переменных а и б типа инт
            Console.WriteLine("Enter first number: ");//
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Enter second number: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("The summ of numbers = " + result);
            


            

        }
    }
}
