using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sherlock-and-squares
    /// </summary>
    class _18_Sherlock_and_squares
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int l = Convert.ToInt32(values[0]);
                int p = Convert.ToInt32(values[1]);

                double lsqrl = Math.Sqrt(l);
                double psqrl = Math.Sqrt(p);

                int from = (int)Math.Ceiling(lsqrl);
                int to = (int)Math.Floor(psqrl);

                Console.WriteLine(to - from + 1);
            }
        }
    }
}
