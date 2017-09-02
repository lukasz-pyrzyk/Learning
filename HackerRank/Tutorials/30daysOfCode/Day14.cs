using System;
using System.Linq;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-scope
    /// </summary>
    public class Day14
    {
        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            public Difference(int[] a)
            {
                elements = a;
            }

            public void computeDifference()
            {
                int max = int.MinValue;
                int min = int.MaxValue;

                for (int i = 0; i < elements.Length; i++)
                {
                    int v = elements[i];
                    if (v > max) max = v;
                    if (v < min) min = v;
                }

                maximumDifference = Math.Abs(max - min);
            }
        }

        class Solution
        {
            static void Main(string[] args)
            {
                Convert.ToInt32(Console.ReadLine());

                int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                Difference d = new Difference(a);

                d.computeDifference();

                Console.Write(d.maximumDifference);
            }
        }
    }
}
