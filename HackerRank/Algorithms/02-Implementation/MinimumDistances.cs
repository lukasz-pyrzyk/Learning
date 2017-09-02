using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/minimum-distances
    /// </summary>
    public class MinimumDistances
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var values = new Dictionary<int, List<int>>();

            int position = 0;
            foreach (var number in Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)))
            {
                if (values.ContainsKey(number))
                    values[number].Add(position);
                else
                    values.Add(number, new List<int> { position });

                position++;
            }

            int min = int.MaxValue;
            foreach (List<int> positions in values.Values.Where(x => x.Count > 1))
            {
                for (int i = 0; i < positions.Count - 1; i++)
                {
                    for (int j = i + 1; j < positions.Count; j++)
                    {
                        min = Math.Min(min, Math.Abs(positions[j] - positions[i]));
                    }
                }
            }

            if (min == int.MaxValue)
                min = -1;


            Console.WriteLine(min);
        }

        [TestFixture]
        public class MinimumDistancesTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n7 1 3 4 1 7\r\n", "3\r\n");
                yield return new TestData("6\r\n7 6 5 4 3 2\r\n", "-1\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}