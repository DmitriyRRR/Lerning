using System;

namespace Delegate_0
{
    delegate void Message();
    delegate int Operatin(int x, int y);
    class Program
    {
        delegate void Message();

        static void Main(string[] args)
        {
            Message mes1 = Hello;
            mes1 += HowAreYou;  // теперь mes1 указывает на два метода
            mes1(); // вызываются оба метода - Hello и HowAreYou
            Message mes2 = HowAreYou;
            Console.WriteLine();
            mes1 -= HowAreYou;
            mes2();
            mes1();
            Console.Read();
        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
    }
}
