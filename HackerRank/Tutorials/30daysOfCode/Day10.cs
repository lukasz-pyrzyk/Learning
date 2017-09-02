using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-binary-numbers
    /// </summary>
    public class Day10
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Calculate(n);

            Console.Write(result);
        }

        private static int Calculate(int n)
        {
            int max = 0;
            int current = 0;
            while (n > 0)
            {
                int r = n % 2;
                if (r == 1)
                {
                    current++;
                }
                else
                {
                    current = 0;
                }

                if(current > max)
                    max = current;

                n /= 2;
            }

            return max;
        }
    }
}
