using System;

namespace EX_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = "Искать такси";
            string SecondString = "Искать такси";
            string ThirdString = "What you see!?";
            string TempString = ThirdString.ToLower().Replace(" ","");
            Console.WriteLine(TempString);
            int cnt = (TempString.Length-1);
            int mid = 0;
            String res = "Polindrom";

            if (cnt % 2 != 0) mid = (cnt - 1) / 2; // если нечетное количество символов
            else mid = (cnt / 2)-1; // если четное просто делим пополам минус один - подсчет индексов с 0 до (длина строки  деленая на 2 минус 1)

           
                for (int i=0; (i<mid)&& (cnt > mid); i++)
                {
                    if (TempString[i]==TempString[cnt])
                    {
                    cnt--;

                    }
                    else
                    {
                    res = "No polindrom";
                    }
                }
            Console.WriteLine(res);

            //Console.WriteLine(String.Compare(FirstString, SecondString));


            //string title = "A Tale of Two Cities";
            //CharEnumerator chEnum = title.GetEnumerator();
            //int ctr = 1;
            //string outputLine1 = null;
            //string outputLine2 = null;
            //string outputLine3 = null;

            //while (chEnum.MoveNext())
            //{
            //    outputLine1 += ctr < 10 || ctr % 10 != 0 ? "  " : (ctr / 10) + " ";
            //    outputLine2 += (ctr % 10) + " ";
            //    outputLine3 += chEnum.Current + " ";
            //    ctr++;
            //}

            //Console.WriteLine("The length of the string is {0} characters:",
            //                  title.Length);
            //Console.WriteLine(outputLine1);
            //Console.WriteLine(outputLine2);
            //Console.WriteLine(outputLine3);
        }
    }
}
