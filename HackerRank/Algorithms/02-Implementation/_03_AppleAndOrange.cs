using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/apple-and-orange
    /// </summary>
    class _03_AppleAndOrange
    {
        public static void Main()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apples = Array.ConvertAll(apple_temp, int.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] oranges = Array.ConvertAll(orange_temp, int.Parse);

            int applesCount = 0, orangesCount = 0;
            foreach (int d in apples)
            {
                if (IsBetween(d + a, s, t)) applesCount++;
            }

            foreach (int d in oranges)
            {
                if (IsBetween(d + b, s, t)) orangesCount++;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }


        private static bool IsBetween(long value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
