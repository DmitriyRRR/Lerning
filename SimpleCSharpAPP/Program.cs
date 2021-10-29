using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static void ShowEnviromentalDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Driver: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.UserName);
        }
        static int Main(string[] args)
        {
            Console.WriteLine("+++++++My Frist C# App++++++");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            //for (int i = 0; i < args.Length; i++)//with "for"
            //    Console.WriteLine("Arg:{0}", args[i]);
            //foreach (string arg in args)//with "foreach"
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            ShowEnviromentalDetails();
            Console.ReadLine();
            return -1;

        }
    }
}
