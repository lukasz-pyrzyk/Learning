using System;
using System.Collections.Generic;
using System.Linq;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/counting-valleys
    /// </summary>
    class CountingValleys
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string steps = Console.ReadLine();

            int level = 0;
            int valleys = 0;
            foreach (var step in steps)
            {
                switch (step)
                {
                    case 'U':
                        level++;
                        break;
                    case 'D':
                        if (level == 0)
                        {
                            valleys++;
                        }

                        level--;
                        break;
                }
            }

            Console.WriteLine(valleys);
        }

        [TestFixture]
        public class CountingValleysTests : BaseFixture
        {
            protected override void RunLogic()
            {
                CountingValleys.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("8\r\nUDDDUDUU\r\n", "1\r\n");
            }
        }
    }
}
