using System;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string
    /// </summary>
    class _22_Repeated_string
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            int inWord = s.Count(x => x.Equals('a'));

            long repeatedFull = n / s.Length;
            long repeatedPart = n % s.Length;

            long result = inWord * repeatedFull;
            for (long i = 0; i < repeatedPart; i++)
            {
                int t = (int)(i % s.Length);
                char c = s[t];
                if (c == 'a') result++;
            }

            Console.WriteLine(result);
        }
    }
}
