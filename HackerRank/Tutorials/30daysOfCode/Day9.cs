using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-recursion
    /// </summary>
    public class Day9
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(n);
            Console.Write(result);
        }

        private static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
