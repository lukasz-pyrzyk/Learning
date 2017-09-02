using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-hurdle-race
    /// </summary>
    public class TheHurdleRace
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);

            int max = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                int next = height[i + 1];

                int toDrink = next - k;
                if (toDrink > 0 && toDrink > max)
                {
                    max = toDrink;
                }
            }

            Console.WriteLine(max);
        }

        [TestFixture]
        public class TheHurdleRaceTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("5 4\r\n1 6 3 5 2\r\n", "2\r\n");
                yield return new TestData("5 7\r\n2 5 4 5 2\r\n", "0\r\n");
                yield return new TestData("100 53\r\n86 4 83 20 6 81 58 59 53 2 54 62 25 35 79 64 27 49 32 95 100 20 58 39 92 30 67 89 58 81 100 66 73 29 75 81 70 55 18 28 7 35 98 52 30 11 69 48 84 54 13 14 15 86 34 82 92 26 8 53 62 57 50 31 61 85 88 5 80 64 90 52 47 43 40 93 69 70 16 43 7 25 99 12 63 99 71 76 55 17 90 43 27 20 42 84 39 96 75 1\r\n", "47\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}