using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-regex-patterns
    /// </summary>
    class Day28
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var names = new List<string>();
            var regex = new Regex("[a-z]@gmail.com", RegexOptions.Compiled);
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                string firstName = values[0];
                string email = values[1];

                if (regex.IsMatch(email))
                    names.Add(firstName);
            }

            foreach (var name in names.OrderBy(x => x))
            {
                Console.WriteLine(name);
            }
        }
    }
}
