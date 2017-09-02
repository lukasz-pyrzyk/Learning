using System;
using System.Collections.Generic;

namespace _30daysOfCode
{
    public class Day8
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> data = new Dictionary<string, int>(n);

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                data.Add(values[0], Convert.ToInt32(values[1]));
            }

            for (int i = 0; i < n; i++)
            {
                string request = Console.ReadLine();

                int number;
                Console.WriteLine(data.TryGetValue(request, out number) ? $"{request}={number}" : "Not found");
            }
        }
    }
}
