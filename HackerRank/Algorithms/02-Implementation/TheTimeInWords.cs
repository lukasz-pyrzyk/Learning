using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-time-in-words
    /// </summary>
    public class TheTimeInWords
    {
        private static Dictionary<int, string> dic = new Dictionary<int, string>
        {
            { 0, "" },
            { 1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" },
            {10, "ten" },
            {11, "eleven" },
            {12, "twelve" },
            {13, "thirteen" },
            {14, "fourteen" },
            {15, "fifteen" },
            {16, "sixteen" },
            {17, "seventeen" },
            {18, "eighteen" },
            {19, "nineteen" },
            {20, "twenty" },
        };

        public static void Main()
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            string result = Calculate(h, m);

            Console.WriteLine(result);
        }

        private static string Calculate(int h, int m)
        {
            if (m <= 30)
            {
                string hour = dic[h];
                if (m == 0) return $"{hour} o' clock";
                if (m == 15) return $"quarter past {hour}";
                if (m == 30) return $"half past {hour}";

                if (dic.ContainsKey(m)) return $"{dic[m]} {PluralMinutes(m)} past {hour}";

                int individuals = m % 10;
                return $"twenty {dic[individuals]} minutes past {hour}";

            }
            else
            {
                string hour = dic[h + 1];
                if (m == 45) return $"quarter to {hour}";
                int missingMinutes = 60 - m;
                int individuals = missingMinutes % 10;

                if (dic.ContainsKey(missingMinutes)) return $"{dic[missingMinutes]} {PluralMinutes(missingMinutes)} to {hour}";

                return $"twenty {dic[individuals]} minutes to {hour}";
            }
        }

        private static string PluralMinutes(int minutes) => minutes > 1 ? "minutes" : "minute";


        [TestFixture]
        public class TheTimeInWordsTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("5\r\n00\r\n", "five o' clock\r\n");
                yield return new TestData("5\r\n01\r\n", "one minute past five\r\n");
                yield return new TestData("5\r\n02\r\n", "two minutes past five\r\n");
                yield return new TestData("5\r\n16\r\n", "sixteen minutes past five\r\n");
                yield return new TestData("5\r\n26\r\n", "twenty six minutes past five\r\n");
                yield return new TestData("5\r\n30\r\n", "half past five\r\n");
                yield return new TestData("5\r\n40\r\n", "twenty minutes to six\r\n");
                yield return new TestData("5\r\n45\r\n", "quarter to six\r\n");
                yield return new TestData("5\r\n15\r\n", "quarter past five\r\n");
                yield return new TestData("5\r\n47\r\n", "thirteen minutes to six\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    }
}