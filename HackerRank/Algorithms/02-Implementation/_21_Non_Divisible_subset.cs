using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/non-divisible-subset
    /// </summary>
    class _21_Non_Divisible_subset
    {
        public static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(temp[1]);

            temp = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(temp, Convert.ToInt32);

            int[] divs = new int[k];
            for (int i = 0; i < values.Length; ++i)
            {
                divs[values[i] % k] += 1;
            }

            int count = divs[0] < 1 ? divs[0] : 1;

            for (int i = 1; i < k / 2 + 1; i++)
            {
                if (i != k - i)
                {
                    count += divs[i] > divs[k - i] ? divs[i] : divs[k - i];
                }
            }

            if (k % 2 == 0) count++;

            Console.WriteLine(count);
        }
    }
}
