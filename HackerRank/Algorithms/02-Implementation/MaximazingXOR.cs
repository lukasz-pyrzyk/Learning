using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    public class MaximazingXOR
    {
        static int maxXorFast(int l, int r)
        {
            int x = l ^ r;
            int a = 0;
            while (Math.Pow(2, a) < x) a++;
            return (int)Math.Pow(2, a) - 1;
        }

        static int maxXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = l; j <= r; j++)
                {
                    max = Math.Max(max, (i ^ j));
                }
            }

            return max;
        }

        static void Main()
        {
            var _l = Convert.ToInt32(Console.ReadLine());
            var _r = Convert.ToInt32(Console.ReadLine());

            var res = maxXorFast(_l, _r);
            Console.WriteLine(res);
        }

        [TestFixture]
        public class TheTimeInWordsTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("10\r\n15\r\n", "7\r\n");
                yield return new TestData("1\r\n10\r\n", "15\r\n");
                yield return new TestData("10\r\n20\r\n", "31\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}
