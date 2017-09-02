using System;
using System.Numerics;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/extra-long-factorials
    /// </summary>
    class _16_Extra_long_factorials
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger result = Factorial(n);
            Console.WriteLine(result);
        }

        private static BigInteger Factorial(BigInteger n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
