using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Warnup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            Console.ReadLine(); // skip first line

            IEnumerable<int> height = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x));

            int max = 0;
            int count = 0;
            foreach (int h in height)
            {
                if (h > max)
                {
                    max = h;
                    count = 1;
                }
                else if (h == max)
                    count++;
            }

            Console.WriteLine(count);
        }
    }

    [TestFixture]
    public class BirthdayCakeCandles_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4\r\n3 2 1 3\r\n", "2\r\n");
        }

        protected override void RunLogic()
        {
            BirthdayCakeCandles.Main();
        }
    }
}