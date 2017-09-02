using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/divisible-sum-pairs
    /// </summary>
    class _06_Divisible_Sum_Pairs
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            var count = 0;
            var counts = new int[k];
            for (var i = 0; i < n; i++)
            {
                // the idea is that if (a1 + a2) % k == 0
                // then (a1 % k + a2 % k) should be equal to k (or 0)
                var bucket = a[i] % k;
                // adding all new combinations with arr[i] to the count
                // also handling bucket == 0 with % k here
                count += counts[(k - bucket) % k];
                counts[bucket]++;
            }

            Console.Write(count);
        }
    }
}
