using System;

namespace _01_Warnup
{
    class AveryBigSum
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            long sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
