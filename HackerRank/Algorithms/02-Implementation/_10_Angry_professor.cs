using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/angry-professor
    /// </summary>
    class _10_Angry_professor
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                uint studentsBefore = 0;
                foreach (int time in a)
                {
                    if (time <= 0) studentsBefore++;
                }

                string decission = studentsBefore < k ? "YES" : "NO";
                Console.WriteLine(decission);
            }
        }
    }
}
