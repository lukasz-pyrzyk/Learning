using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/picking-numbers
    /// </summary>
    public class PickingNumbers
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var sortedValues = new int[100];

            foreach (string number in Console.ReadLine().Split(' '))
            {
                int x = Convert.ToInt32(number);
                sortedValues[x]++;
            }

            int max = 0;
            for (int i = 0; i < sortedValues.Length - 1; i++)
            {
                int diff = sortedValues[i] + sortedValues[i + 1];
                if (diff > max) max = diff;
            }

            Console.WriteLine(max);
        }

        [TestFixture]
        public class PickingNumbersTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n4 6 5 3 3 1\r\n", "3\r\n");
                yield return new TestData("6\r\n1 2 2 3 1 2\r\n", "5\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}