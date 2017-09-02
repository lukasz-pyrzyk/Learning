using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/migratory-birds
    /// </summary>
    class MigratoryBirds
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] types_temp = Console.ReadLine().Split(' ');
            int[] types = Array.ConvertAll(types_temp, int.Parse);

            var birds = new Dictionary<int, int>();
            foreach (int type in types)
            {
                if (birds.ContainsKey(type))
                {
                    birds[type]++;
                }
                else
                {
                    birds.Add(type, 1);
                }
            }

            int id = int.MaxValue;
            int max = 0;
            foreach (var bird in birds)
            {
                if (bird.Value >= max)
                {
                    if (bird.Value == max && bird.Key < id)
                    {
                        id = bird.Key;
                    }
                    else
                    {
                        id = bird.Key;
                    }

                    max = bird.Value;
                }
            }

            Console.WriteLine(id);
        }

        [TestFixture]
        public class MigratoryBirdsTests : BaseFixture
        {
            protected override void RunLogic()
            {
                MigratoryBirds.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n1 4 4 4 5 3\r\n", "4\r\n");
            }
        }
    }
}
