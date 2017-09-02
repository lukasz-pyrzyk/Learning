using System;

namespace _02_Implementation
{
    public class _01_MiniMaxSum
    {
        public static void Main()
        {
            string[] tempValues = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(tempValues, Int32.Parse);
            Array.Sort(values);

            long min = 0, max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                if (i != 0) max += value;
                if (i != values.Length - 1) min += value;
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}