using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/drawing-book
    /// </summary>
    class DrawingBook
    {
        private static int Solve(int total, int page)
        {
            int result;
            if (page - 1 < total - page) // before a half
            {
                result = page / 2;
            }
            else
            {
                result = (total - page) / 2; // after a half
            }

            return result;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = Solve(n, p);
            Console.WriteLine(result);
        }

        [TestFixture]
        public class DrawingBookTests : BaseFixture
        {
            protected override void RunLogic()
            {
                DrawingBook.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n2\r\n", "1\r\n");
                yield return new TestData("6\r\n3\r\n", "1\r\n");
                yield return new TestData("100\r\n4\r\n", "2\r\n");
                yield return new TestData("100\r\n5\r\n", "2\r\n");
                yield return new TestData("5\r\n5\r\n", "0\r\n");
                yield return new TestData("5\r\n4\r\n", "0\r\n");
                yield return new TestData("99\r\n99\r\n", "0\r\n");
                yield return new TestData("99\r\n98\r\n", "0\r\n");
                yield return new TestData("99\r\n97\r\n", "1\r\n");
                yield return new TestData("99\r\n96\r\n", "1\r\n");
            }
        }
    }
}
