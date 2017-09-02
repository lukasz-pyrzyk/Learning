using System;

namespace _01_Warnup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/solve-me-first
    /// </summary>
    public class SolveMeFirst
    {
        private static int solveMeFirst(int a, int b)
        {
            return a + b;
        }

        public static void Main()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
