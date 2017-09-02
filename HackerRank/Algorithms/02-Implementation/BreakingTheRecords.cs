using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records
    /// </summary>
    class BreakingTheRecords
    {
        private static int[] GetRecord(int[] scores)
        {
            int min = scores[0], max = scores[0];
            int[] results = new int[2];
            for (var itr = 1; itr < scores.Length; itr++)
            {
                var score = scores[itr];
                if (score > max)
                {
                    max = score;
                    results[0]++;
                }
                else if (score < min)
                {
                    min = score;
                    results[1]++;
                }
            }

            return results;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = GetRecord(s);
            Console.WriteLine(string.Join(" ", result));
        }
    }

    [TestFixture]
    public class BreakingTheRecordsTests : BaseFixture
    {
        protected override void RunLogic()
        {
            BreakingTheRecords.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("9\r\n10 5 20 20 4 5 2 25 1\r\n", "2 4\r\n");
            yield return new TestData("10\r\n3 4 21 36 10 28 35 5 24 42\r\n", "4 0\r\n");
        }
    }
}
