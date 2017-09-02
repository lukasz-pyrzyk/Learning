using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-exceptions-string-to-integer
    /// </summary>
    public class Day16
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            try
            {
                int parsed = int.Parse(s);
                Console.WriteLine(parsed);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}