using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/equality-in-a-array
    /// </summary>
    class _24_Equality_in_a_array
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            var dic = new Dictionary<int, int>();
            foreach (int value in values)
            {
                if (!dic.ContainsKey(value)) dic[value] = 1;
                else dic[value]++;
            }

            int max = dic.Max(x => x.Value);

            Console.WriteLine(n - max);
        }
    }
}
