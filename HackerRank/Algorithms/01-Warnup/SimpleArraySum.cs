using System;

namespace _01_Warnup
{
    /// <summary>
    ///https://www.hackerrank.com/challenges/solve-me-first
    /// </summary>
    class SimpleArraySum
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
