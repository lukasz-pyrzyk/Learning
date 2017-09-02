using System;
using System.Linq;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/correctness-invariant
    /// </summary>
    class _04_Correctness_invariant
    {
        public static void Main()
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();

            InsertionSort(_ar);
        }

        public static void InsertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j]) // bug was in >> instead of >
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }

            Console.WriteLine(string.Join(" ", A));
        }
    }
}
