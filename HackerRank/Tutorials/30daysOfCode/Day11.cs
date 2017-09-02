using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-2d-arrays
    /// </summary>
    public class Day11
    {
        public static void Main()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, int.Parse);
            }

            int result = int.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[0].Length - 2; j++)
                {
                    int value = arr[i][j];
                    value += arr[i][j + 1];
                    value += arr[i][j + 2];
                    value += arr[i + 1][j + 1];
                    value += arr[i + 2][j];
                    value += arr[i + 2][j + 1];
                    value += arr[i + 2][j + 2];

                    result = Math.Max(result, value);
                }
            }

            Console.Write(result);
        }
    }
}
