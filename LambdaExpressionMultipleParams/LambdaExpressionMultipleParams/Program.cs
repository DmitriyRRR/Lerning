using System;

namespace LambdaExpressionMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) => { Console.WriteLine($"Message:{msg}, Result: {result}"); });
            m.Add(10, 10);

            VerisimpleDelegate d = new VerisimpleDelegate(() => { return "Enjoy!) ";});
            Console.WriteLine(d());
            Console.ReadLine();
        }
    }
    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;
        public void SetMathHandler (MathMessage target) { mmDelegate = target;}
        public void Add (int x, int y) { mmDelegate?.Invoke("Adding haas  completed!", x + y); }
    }
    public delegate string VerisimpleDelegate();
}
