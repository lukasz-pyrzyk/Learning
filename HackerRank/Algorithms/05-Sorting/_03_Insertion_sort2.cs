using System;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/insertionsort2
    /// </summary>
    class _03_Insertion_sort2
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

        private static void InsertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int j = i;
                while (j - 1 >= 0 && A[j] < A[j - 1])
                {
                    int current = A[j];
                    A[j] = A[j - 1];
                    A[j - 1] = current;
                    j--;
                }

                Print(A);
            }
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
