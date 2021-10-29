using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Lerning, don't wait for perfect time*********\n");
            //QueryOverStrings();
            //ImmediateExecution();
            //IEnumerable<string> subset = QueryOverStrings_2();
            foreach (string item in QueryOverStrings_3())
            {
                Console.WriteLine( item);
            }
            Console.ReadLine();
        }
        static void QueryOverStrings()
        {
            string[] currentBikes = { "BMC/brocken", "Felt Q220", "White wmn", "Early Rider 16 Belter", "Specialized Venge", "Ciocc"};
            Console.WriteLine(currentBikes[0].Length);
            IEnumerable<string> subset =from g in currentBikes where g.Contains("a") orderby g select g;
            foreach (string s in subset)
                Console.WriteLine($"Item: {s}");
        }
        static void  ImmediateExecution()
        {
            int[] numbers = { 11, 12, 234, 555, 4, 1, 66, 33, 6 };
            
            int[] subsetAsIntArray = (from i in numbers where i < 7 select i).ToArray<int>();
            foreach (var s in subsetAsIntArray)
                Console.WriteLine(s);
            Console.WriteLine("**************");
            List<int> subsetAsListOfInts = (from i in numbers where i < 17 select i).ToList<int>();
            foreach (int s in subsetAsListOfInts)
                Console.WriteLine(s);
        }

        static IEnumerable<string> QueryOverStrings_2()
        {
            string[] currentBikes = { "BMC/brocken roadbike", "Felt Q220", "White wmn", "Early Rider 16 Belter", "Specialized Venge roadbike", "Ciocc roadbike" };
            IEnumerable<string> theRoadBike = from g in currentBikes where g.Contains("road") select g;
            return theRoadBike;
        }
        static string[] QueryOverStrings_3()
        {
            string[] currentBikes = { "BMC/brocken roadbike", "Felt Q220", "White wmn", "Early Rider 16 Belter", "Specialized Venge roadbike", "Ciocc roadbike" };
            var theRoadBike = from g in currentBikes where g.Contains("road") select g;
            return theRoadBike.ToArray();
        }
    
    
    }
}
