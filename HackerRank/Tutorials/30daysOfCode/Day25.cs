using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-running-time-and-complexity
    /// </summary>
    class Day25
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                bool prime = true;

                if (value != 1)
                {
                    int maxDiv = (int) Math.Floor(Math.Sqrt(value));

                    for (int j = 2; j <= maxDiv; j++)
                    {
                        if (value%j == 0) prime = false;
                    }
                }
                else
                {
                    prime = false;
                }

                Console.WriteLine(prime ? "Prime" : "Not prime");
            }
        }
    }
}
