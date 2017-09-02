using System;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited
    /// </summary>
    class _14_jumping_on_the_clouds_revisited
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, int.Parse);

            int energy = 100;
            int currentCloud = 0;
            do
            {
                currentCloud = (currentCloud + k) % n;
                int cloud = c[currentCloud];
                if (cloud == 1)
                {
                    energy -= 2;
                }

                energy--;

            } while (currentCloud != 0);

            Console.Write(energy);
        }
    }
}
