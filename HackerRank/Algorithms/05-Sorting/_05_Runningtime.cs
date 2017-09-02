using System;
using System.Linq;

namespace _05_Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/runningtime
    /// </summary>
    class _05_Runningtime
    {
        public static void Main()
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();

            InsertionSort(_ar);
        }

        public static void InsertionSort(int[] ar)
        {
            int shifts = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                int j = i;
                while (j - 1 >= 0 && ar[j] < ar[j - 1])
                {
                    shifts++;
                    int current = ar[j];
                    ar[j] = ar[j - 1];
                    ar[j - 1] = current;
                    j--;
                }
            }

            Console.WriteLine(shifts);
        }
    }
}
