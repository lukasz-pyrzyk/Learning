using System;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    class _01_Tutorial_info
    {
        public static void Main()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int result = BinarySearch(i, values);
            Console.WriteLine(result);
        }

        private static int BinarySearch(int key, int[] values)
        {
            int left = 0;
            int right = values.Length - 1;
            while (left <= right)
            {
                int pivot = (left + right) / 2;
                if (values[pivot] > key)
                    right = pivot - 1;
                else if (values[pivot] < key)
                    left = pivot + 1;
                else return pivot;
            }

            return -1; // not found
        }
    }
}
