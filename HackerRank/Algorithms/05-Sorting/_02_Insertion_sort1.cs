using System;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/insertionsort1
    /// </summary>
    class _02_Insertion_sort1
    {
        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[n];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < n; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            InsertionSort(_ar);
        }

        private static void InsertionSort(int[] ar)
        {
            int position = ar.Length - 1;
            int toSort = ar[position];
            while (position != 0 && ar[position - 1] > toSort)
            {
                ar[position] = ar[position - 1];
                Print(ar);
                position--;
            }
            ar[position] = toSort;
            Print(ar);
        }

        private static void Print(int[] ar)
        {
            foreach (int t in ar)
            {
                Console.Write(t);
                Console.Write(' ');
            }

            Console.Write("\r\n");
        }
    }
}
