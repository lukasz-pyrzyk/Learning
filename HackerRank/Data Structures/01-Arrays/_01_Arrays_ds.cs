using System;

namespace _01_Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/arrays-ds
    /// </summary>
    public class _01_Arrays_ds
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if(i != 0) Console.Write(' ');
            }
        }
    }
}
