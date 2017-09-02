using System;

namespace _01_Warnup
{
    class PlusMinus
    {

        private static void Print(int number, int total)
        {
            double v = number / (double)total;
            Console.WriteLine(v.ToString("0.000000"));
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int positive = 0, negative = 0, zeroes = 0;
            foreach (var i in arr)
            {
                if (i > 0) positive++;
                else if (i < 0) negative++;
                else zeroes++;
            }

            int total = arr.Length;
            Print(positive, total);
            Print(negative, total);
            Print(zeroes, total);
        }
    }
}
