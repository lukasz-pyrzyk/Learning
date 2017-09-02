using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/fair-rations
    /// </summary>
    public class FairRations
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');

            int[] numbers = new int[B_temp.Length];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(B_temp[i]);
                numbers[i] = number;
                sum += number;
            }

            if (sum % 2 == 0)
            {
                int added = 0;
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        numbers[i]++;
                        numbers[i + 1]++;

                        added += 2;
                    }
                }

                Console.WriteLine(added);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }


        [TestFixture]
        public class FairRationsTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("5\r\n2 3 4 5 6\r\n", "4\r\n");
                yield return new TestData("2\r\n1 2\r\n", "NO\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}