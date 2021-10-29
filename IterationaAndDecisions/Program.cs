using System;

namespace IterationaAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            Once:
                try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                goto Once;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Cycling!");
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:

                    Console.WriteLine("Another day, another dollar.");
                    break;
            
            }
        }
    }
}
