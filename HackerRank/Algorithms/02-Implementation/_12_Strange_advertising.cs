using System;

namespace _02_Implementation
{
    /// <summary>
    /// _12_Strange_advertising
    /// </summary>
    class _12_Strange_advertising
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int people = 5;
            for (int i = 0; i < n; i++)
            {
                people = (int)Math.Floor(people / (decimal)2);
                sum += people;
                people *= 3;
            }

            Console.Write(sum);
        }

    }
}
