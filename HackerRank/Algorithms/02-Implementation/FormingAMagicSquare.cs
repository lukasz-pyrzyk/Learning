using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/magic-square-forming
    /// </summary>
    public class FormingAMagicSquare
    {
        public static void Main()
        {
            int[][] finalPatterns = {
                new[] {8, 1, 6, 3, 5, 7, 4, 9, 2},
                new[] {4, 3, 8, 9, 5, 1, 2, 7, 6},
                new[] {2, 9, 4, 7, 5, 3, 6, 1, 8},
                new[] {6, 7, 2, 1, 5, 9, 8, 3, 4},
                new[] {6, 1, 8, 7, 5, 3, 2, 9, 4},
                new[] {8, 3, 4, 1, 5, 9, 6, 7, 2},
                new[] {4, 9, 2, 3, 5, 7, 8, 1, 6},
                new[] {2, 7, 6, 9, 5, 1, 4, 3, 8}
            };

            int[] costs = new int[finalPatterns.Length];

            int position = 0;
            for (int i = 0; i < 3; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x));

                foreach (int received in numbers)
                {
                    for (int j = 0; j < costs.Length; j++)
                    {
                        int expected = finalPatterns[j][position];

                        if (received != expected)
                        {
                            costs[j] += Math.Abs(expected - received);
                        }
                    }

                    position++;
                }
            }

            Console.WriteLine(costs.Min());
        }

        [TestFixture]
        public class FormingAMagicSquareTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("4 9 2\r\n3 5 7\r\n8 1 5\r\n", "1\r\n");
                yield return new TestData("4 5 8\r\n2 4 1\r\n1 9 7\r\n", "14\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}