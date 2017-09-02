using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/append-and-delete
    /// </summary>
    class _17_Append_and_delete
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 0; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                {
                    break;
                }
            }

            int d = s.Length - i;
            int a = t.Length - i;

            int difference = k - d - a;
            if (difference < 0) // if we have to make more operations than K
            {
                Console.WriteLine("No");
            }
            else
            {
                if (difference % 2 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine(difference >= 2 * i ? "Yes" : "No");
                }
            }
        }
    }
}
