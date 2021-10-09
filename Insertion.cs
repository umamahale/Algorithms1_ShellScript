using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortarray = new int[10] { 23, 34, 65, 33, 67, 98, 44, 55, 69, 11 };
            int n = 10, value, flag, i, j, k;
            Console.WriteLine("Before sorting");
            for (  i = 0; i < n; i++)
            {
                Console.Write(sortarray[i] + "");
            }
            for (i = 0; i < n; i++)
            {
                value = sortarray[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < sortarray[j])
                    {

                        sortarray[j + 1] = sortarray[j]
                       = j--;
                        sortarray[j + 1] = value;
                    }
                    else flag = 1;
                }
                Console.WriteLine("after sorting");
                for (k = 0; k < n; k++)
                {
                    Console.WriteLine(sortarray[k] + "");

                }



            }
        }
    }
}
