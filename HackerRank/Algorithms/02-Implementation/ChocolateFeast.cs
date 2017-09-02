using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/chocolate-feast
    /// </summary>
    public class ChocolateFeast
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int money = Convert.ToInt32(tokens_n[0]);
                int cost = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int bought = money / cost;
                int eaten = bought;
                int wrappers = bought;

                while (wrappers >= m)
                {
                    int chocolatesFromWrappers = wrappers / m;
                    wrappers = wrappers % m;
                    eaten += chocolatesFromWrappers;
                    wrappers += chocolatesFromWrappers;
                }

                Console.WriteLine(eaten);
            }
        }


        [TestFixture]
        public class ChocolateFeastTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("3\r\n10 2 5\r\n12 4 4\r\n6 2 2\r\n", "6\r\n3\r\n5\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}