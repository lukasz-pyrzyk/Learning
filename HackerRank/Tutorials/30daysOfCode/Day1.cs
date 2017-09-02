using System;

namespace _30daysOfCode
{
    public class Day1
    {
        public static void Main()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            i += Convert.ToInt32(Console.ReadLine());
            d += Convert.ToDouble(Console.ReadLine());
            s += Console.ReadLine();

            Console.WriteLine(i);
            Console.WriteLine(d.ToString("0.0"));
            Console.WriteLine(s);
        }
    }
}
