using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/permutation-equation
    /// </summary>
    public class SequenceEquation
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            DoOptimal(n);
            //DoClassic(n);
        }

        private static void DoClassic(int n)
        {
            var args = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
            var results = new int[n + 1];
            Array.Copy(args, 0, results, 1, args.Length);

            results = Invert(results, 1);
            results = Invert(results, 1);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(results[i]);
            }
        }

        private static int[] Invert(int[] array, int index)
        {
            var newArray = new int[array.Length];

            for (int j = index; j < array.Length; j++)
            {
                newArray[array[j]] = j;
            }

            return newArray;
        }

        #region optimal
        private static void DoOptimal(int n)
        {
            var invertedResults = new int[n + 1];
            int x = 1;
            foreach (var number in Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)))
            {
                invertedResults[number] = x;
                x++;
            }

            for (int j = 1; j <= n; j++)
            {
                x = invertedResults[j];
                Console.WriteLine(invertedResults[x]);
            }
        }
        #endregion

        [TestFixture]
        public class SequenceEquationTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("3\r\n2 3 1\r\n", "2\r\n3\r\n1\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}