using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_00
{
    class Program
    {
        static void Main(string[] args)
        /*{

            Console.WriteLine("F**ing methods");
            int x = 9, y = 10;
            Console.WriteLine("Before call X={0}, Y={1}", x, y);
            int ans2;
            Add(x, y, out ans2);
            Console.WriteLine("Answer is:{0}", ans2);
            Console.WriteLine("After call X={0}, Y={1}", x, y);
            Console.ReadLine();
        }
        static void  Add(int x, int y, out int ans)
        {
        ans = x + y;
        //x=11;
        //y=12;
        //return ans;
        }*/
        /* {
             Console.WriteLine("*******So fun ))))********");
             double average;
             average = CalcAverage(4.0, 5.1, 6.2, 7.7, 0.55, 12.0);
             //double[] data = { 4.0, 5.1, 6.2, 7.7, 0.55, 12.0 };
             //average = CalcAverage(data);
             Console.WriteLine("Average of data is: {0}", average);

             //Console.WriteLine("average of data is: {0}", CalcAverage());

         }
         static double CalcAverage( params double[] values)    
             {
             Console.WriteLine("You sent me {0} doubles.", values.Length);
             double sum = 0;
             if (values.Length == 0)
                 return sum;
             for (int i = 0; i < values.Length; i++)
                 sum += values[i];
             return (sum / values.Length);
             }*/
        /*   {
               Console.WriteLine("**********************FM***************************");
               EnterLogData("Oh no!");
               EnterLogData("Ooooooo!", "CFO");
               Console.ReadLine();
           }
           static void EnterLogData( string message, string owner = " Programmer")
           {
               Console.Beep();
               Console.WriteLine("Error: {0}", message);
               Console.WriteLine("Owner of Error: {0}", owner);
           }*/
        {
            Console.WriteLine("==========================Enother methods==========================");
            DisplayFanceMessage(message: "Wow!!!!!!", textColor: ConsoleColor.DarkCyan, backgroundColor: ConsoleColor.White);
            DisplayFanceMessage(ConsoleColor.Green, ConsoleColor.DarkBlue, message: "Testing....");
            DisplayFanceMessage(textColor: ConsoleColor.DarkYellow);

            //DisplayFanceMessage(backgroundColor: ConsoleColor.Green, message: "Testing....", textColor: ConsoleColor.DarkBlue);
            Console.ReadLine();
        }
        static void DisplayFanceMessage(ConsoleColor textColor = ConsoleColor.Red, ConsoleColor backgroundColor = ConsoleColor.Magenta, string message = "Testing, testing")
            {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ReadLine();
            Console.Beep();
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
            Console.WriteLine(message);
        }
}
}
