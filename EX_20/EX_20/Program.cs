using System;

namespace EX_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool notEntered = true;
            while (notEntered)
            {
                string keyboardInput = Console.ReadLine();
                if (int.TryParse(keyboardInput, out number))
                {
                    notEntered = false;
                }
            }

            Console.WriteLine(number);

            int sum = 0;

            float mlt = 0.00000000000000000000000000001f;

            if (number >= 0)
            {
                int[] fibanacchi = new int[(number - 1)];
                fibanacchi[2] = fibanacchi[(2 - 1)] + fibanacchi[(2 - 2)];

                for (int n = 0; n < (number - 1); n++)
                {
                    if (n < 2)
                        fibanacchi[n] = 1;
                    
                    else
                        fibanacchi[n] = fibanacchi[(n - 2)] + fibanacchi[(n - 1)];
                }
                foreach (int fff in fibanacchi) Console.Write(fff+ " ");
                for (int i = 0; i < (number - 1); i++)
                {
                    sum += fibanacchi[i];
                    mlt *= fibanacchi[i];
                }

                Console.WriteLine();
                Console.WriteLine(sum);
                Console.WriteLine(mlt + "  *e30");

            }
            else
            {
                Console.WriteLine("Wrong number");
            }

        }
    }
}
