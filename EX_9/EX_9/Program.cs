using System;

namespace EX_9
{
    class Program
    {
        static void Main(string[] args)
        {
           string str =  Console.ReadLine();
            char[] arr;
            string temp;
            char[] arr_a = { 'a', 'i', 'e', 'o', 'u', 'y' };
            int count_a = 0;

            arr = (str.ToLower()).ToCharArray();
            
                //for (int i = 0; i < (arr.Length); i++)
                //{
                //    Console.Write($" '{arr[i]}' ");   // a, i, e, o, u, y
                
                //}
                
                foreach(char c in arr)
                     {
                        temp = c.ToString();
                        if ((temp.IndexOfAny(arr_a))!=(-1))
                        {
                            count_a++;
                        }
                     }
            Console.WriteLine("Vowel letters in string: "+ count_a);
            
        }
    }
}
