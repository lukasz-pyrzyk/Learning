using System;

namespace _30daysOfCode
{
    public class Day5
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {i * n}");
            }
        }
    }
}
