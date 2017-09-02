using System;
using System.Linq;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-sorting
    /// </summary>
    class Day20
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int swaps = Sort(ar);
            Console.WriteLine($"Array is sorted in {swaps} swaps.");
            Console.WriteLine($"First Element: {ar[0]}");
            Console.WriteLine($"Last Element: {ar[ar.Length - 1]}");
        }

        private static int Sort(int[] ar)
        {
            int swaps = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length - 1; j++)
                {
                    int current = ar[j];
                    int next = ar[j + 1];
                    if (current > next)
                    {
                        ar[j] = next;
                        ar[j + 1] = current;
                        swaps++;
                    }
                }

                if (swaps == 0) break;
            }

            return swaps;
        }
    }
}
