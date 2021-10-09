using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int st, en, cnt = 0;
            Console.WriteLine("starting value");
            st = int.Parse(Console.ReadLine());
            Console.WriteLine("ending Probelm");
            en = int.Parse(Console.ReadLine());
            for (int i = 1; i < en; i++)
            {
                for (int j = 1; j < en; j++)
                {
                    if (i % j == 0)

                    {
                        cnt++;
                    }

                }
                if (cnt == 2)
                {
                    Console.WriteLine(i);

                }
                cnt = 0;
            }
        }
    }
}
    




