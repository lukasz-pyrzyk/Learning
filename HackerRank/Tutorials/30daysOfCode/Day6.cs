using System;
using System.Text;

namespace _30daysOfCode
{
    public class Day6
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                StringBuilder odd = new StringBuilder();
                StringBuilder even = new StringBuilder();
                for (int j = 0; j < line.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        odd.Append(line[j]);
                    }
                    else
                    {
                        even.Append(line[j]);
                    }
                }
                Console.WriteLine($"{even.ToString()} {odd.ToString()}");
            }
        }
    }
}
