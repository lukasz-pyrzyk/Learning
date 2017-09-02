using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/day-of-the-programmer
    /// </summary>
    public class DayOfTheProgrammer
    {
        static string Solve(int year)
        {
            if (year < 1918)
            {
                return year % 4 != 0 ? $"13.09.{year}" : $"12.09.{year}";
            }

            if (year == 1918)
            {
                return $"26.09.{year}";
            }

            return new DateTime(year, 01, 01).AddDays(255).ToString("dd.MM.yyyy");
        }

        static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = Solve(year);
            Console.WriteLine(result);
        }

        [TestFixture]
        public class DayOfTheProgrammerTest : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("2017\r\n", "13.09.2017\r\n");
                yield return new TestData("2016\r\n", "12.09.2016\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}