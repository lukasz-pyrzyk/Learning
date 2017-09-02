using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies
    /// </summary>
    class _11_Beautiful_days_at_the_movies
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(s[0]);
            int j = Convert.ToInt32(s[1]);
            int k = Convert.ToInt32(s[2]);

            int beaufitulDays = 0;
            for (int day = i; day <= j; day++)
            {
                int reversed = Reverse(day);
                bool isBeautiful = Math.Abs(day - reversed) % k == 0;
                if (isBeautiful) beaufitulDays++;

            }

            Console.Write(beaufitulDays);
        }

        private static int Reverse(int i)
        {
            int reversed = 0;
            int n = i;

            while (n > 0)
            {
                int rem = n % 10;
                reversed = (reversed * 10) + rem;
                n = n / 10;
            }

            return reversed;
        }
    }
}
