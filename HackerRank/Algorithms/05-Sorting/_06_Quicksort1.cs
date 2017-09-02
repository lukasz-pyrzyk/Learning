using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/quicksort1
    /// </summary>
    class _06_Quicksort1
    {
        private static void Partition(int[] ar)
        {
            var left = new LinkedList<int>();
            var right = new LinkedList<int>();

            int p = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                int val = ar[i];
                if (val < p)
                {
                    left.AddLast(val);
                }
                else if (val > p)
                {
                    right.AddLast(val);
                }
            }

            Console.WriteLine($"{string.Join(" ", left)} {p} {string.Join(" ", right)}");
        }

        public static void Main()
        {
            var _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            Partition(_ar);
        }
    }
}
