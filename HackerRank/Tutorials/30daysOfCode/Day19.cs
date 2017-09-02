using System;
using System.Collections.Generic;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-interfaces
    /// </summary>
    class Day19
    {
        internal class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) sum += i;
                }

                return sum;
            }
        }

        internal interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
