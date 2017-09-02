using System;
using System.Text;

namespace _30daysOfCode
{
    public class Day7
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i > 0) Console.Write(" ");
            }
        }
    }
}
