using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/divisible-sum-pairs
    /// </summary>
    class DivisibleSumPairs
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int results = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((a[i] + a[j]) % k == 0)
                    {
                        results++;
                    }
                }
            }

            Console.WriteLine(results);
        }

        [TestFixture]
        public class DivisibleSumPairsTests : BaseFixture
        {
            protected override void RunLogic()
            {
                DivisibleSumPairs.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6 3\r\n1 3 2 6 1 2\r\n", "5\r\n");
            }
        }
    }
}
