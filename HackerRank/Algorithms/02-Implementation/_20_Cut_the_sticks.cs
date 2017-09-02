using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cut-the-sticks
    /// </summary>
    class _20_Cut_the_sticks
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            Array.Sort(arr);
            int removed = 0;
            for (int i = 0; i < n && removed != arr.Length; i++)
            {
                Console.WriteLine(arr.Length - removed);

                int min = arr[removed];
                for (int j = removed; j < arr.Length; j++)
                {
                    arr[j] -= min;
                    if (arr[j] == 0)
                    {
                        removed++;
                    }
                }
            }
        }
    }
}
