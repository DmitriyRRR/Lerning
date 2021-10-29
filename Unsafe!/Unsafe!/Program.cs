using System;

namespace Unsafe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Unsafe********");
            int i = 12, f = 2;
            Console.WriteLine("Safe------------");
            Console.WriteLine($"i = {i}, f = {f}");
            SafeSwap(ref i, ref f);
            Console.WriteLine($"After swap i {i}, f {f}");
            Console.WriteLine("Unsafe===========");
            Console.WriteLine($"i = {i}, f = {f}");
            unsafe { UnsafeSwap(&i, &f); }
            Console.WriteLine($"After swap i {i}, f {f}");
            Console.ReadLine();

        }
        public static void  SafeSwap(ref int i, ref int f)
        {
            int temp = i;
            i = f;
            f = temp;
        }
        public unsafe static void UnsafeSwap(int* i, int* f)
        {
            int temp = *i;
            *i = *f;
            *f = temp;
        }
    }
}
