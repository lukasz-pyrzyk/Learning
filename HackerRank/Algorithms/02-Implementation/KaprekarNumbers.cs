using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kaprekar-numbers
    /// </summary>
    public class KaprekarNumbers
    {
        private static bool IsKaprekar(int number)
        {
            checked
            {
                ulong square = (ulong)number * (ulong)number;
                string squareString = square.ToString();

                string lp = squareString.Substring(0, squareString.Length / 2);
                string rp = squareString.Substring(squareString.Length / 2);

                int l = !string.IsNullOrEmpty(lp) ? Convert.ToInt32(lp) : 0;
                int p = !string.IsNullOrEmpty(rp) ? Convert.ToInt32(rp) : 0;

                return l + p == number;
            }
        }

        public static void Main()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            var results = new List<int>();
            for (int i = p; i <= q; i++)
            {
                if (IsKaprekar(i))
                {
                    results.Add(i);
                }
            }

            Console.WriteLine(results.Any() ? string.Join(" ", results) : "INVALID RANGE");
        }

        [TestFixture]
        public class KaprekarNumbersTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("1\r\n100\r\n", "1 9 45 55 99\r\n");
                yield return new TestData("100\r\n300\r\n", "297\r\n");
                yield return new TestData("1\r\n99999\r\n", "1 9 45 55 99 297 703 999 2223 2728 4950 5050 7272 7777 9999 17344 22222 77778 82656 95121 99999\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}