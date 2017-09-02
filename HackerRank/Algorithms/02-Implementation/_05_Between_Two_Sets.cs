using System;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/between-two-sets
    /// </summary>
    class _05_Between_Two_Sets
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, int.Parse);

            int min = a[0];
            int max = b[b.Length - 1];

            int count = 0;
            for (int i = min; i <= max; i++)
            {
                if (a.All(x => i % x == 0) & b.All(x => x % i == 0)) count++;
            }

            Console.Write(count);
        }
    }
}
