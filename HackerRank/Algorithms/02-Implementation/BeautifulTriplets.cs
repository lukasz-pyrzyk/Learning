using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/beautiful-triplets
    /// </summary>
    public class BeautifulTriplets
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(' ').ToArray();
            int d = Convert.ToInt32(line[1]);

            int results = 0;
            var numbers = new HashSet<int>();
            foreach (var k in Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)))
            {
                numbers.Add(k);
                int j = k - d;
                int i = j - d;
                if (numbers.Contains(i) && numbers.Contains(j))
                {
                    results++;
                }
            }

            Console.WriteLine(results);
        }

        [TestFixture]
        public class BeautifulTripletsTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("7 3\r\n1 2 4 5 7 8 10\r\n", "3\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}