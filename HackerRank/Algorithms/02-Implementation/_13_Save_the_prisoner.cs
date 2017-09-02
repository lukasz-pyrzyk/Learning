using System;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/save-the-prisoner
    /// </summary>
    class _13_Save_the_prisoner
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                int n = values[0];
                int m = values[1];
                int s = values[2];


                int poisoned = (s + m - 1) % n;
                if (poisoned == 0)
                    poisoned = n;

                Console.Write(poisoned + "\r\n");
            }
        }
    }
}
