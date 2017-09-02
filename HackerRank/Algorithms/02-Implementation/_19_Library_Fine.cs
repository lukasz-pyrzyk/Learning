using System;

namespace _02_Implementation
{
    /// <summary>
    /// _https://www.hackerrank.com/challenges/library-fine
    /// </summary>
    class _19_Library_Fine
    {
        public static void Main()
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);

            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);

            DateTime actual = new DateTime(y1, m1, d1);
            DateTime expected = new DateTime(y2, m2, d2);

            int fine;
            if (actual <= expected) fine = 0;
            else if (actual.Month == expected.Month && actual.Year == expected.Year)
            {
                int daysBetween = actual.DayOfYear - expected.DayOfYear;
                fine = 15 * daysBetween;
            }
            else if (actual.Month >= expected.Month && actual.Year == expected.Year)
            {
                int monthBetween = actual.Month - expected.Month;
                fine = 500*monthBetween;
            }
            else fine = 10000;

            Console.WriteLine(fine);
        }
    }
}
