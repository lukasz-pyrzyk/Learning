using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/electronics-shop
    /// </summary>
    public class ElectronicsShop
    {
        public static void Main()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, int.Parse);
            string[] pendrives_temp = Console.ReadLine().Split(' ');
            int[] pendrives = Array.ConvertAll(pendrives_temp, int.Parse);

            int result = Calculate(s, keyboards, pendrives);
            Console.WriteLine(result);
        }

        private static int Calculate(int money, int[] keyboards, int[] pendrives)
        {
            int max = -1;
            foreach (int keyboard in keyboards)
            {
                foreach (int pendrive in pendrives)
                {
                    int sum = keyboard + pendrive;
                    if (sum <= money && sum > max)
                    {
                        max = sum;
                    }
                }
            }

            return max;
        }
    }

    [TestFixture]
    public class ElectronicsShopTests : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("10 2 3\r\n3 1\r\n5 2 8\r\n", "9\r\n");
            yield return new TestData("5 1 1\r\n4\r\n5\r\n", "-1\r\n");
        }

        protected override void RunLogic()
        {
            ElectronicsShop.Main();
        }
    }
}