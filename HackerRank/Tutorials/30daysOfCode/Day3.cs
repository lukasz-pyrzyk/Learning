using System;

namespace _30daysOfCode
{
    public class Day3
    {
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0)
            {
                Console.Write("Weird");
            }
            else
            {
                if (InRange(N, 2, 5))
                {
                    Console.Write("Not Weird");
                }
                else if (InRange(N, 6, 20))
                {
                    Console.Write("Weird");
                }
                else if (N > 20)
                {
                    Console.Write("Not Weird");
                }
            }
        }

        private static bool InRange(int n, int min, int max) => n >= min && n <= max;
    }
}
