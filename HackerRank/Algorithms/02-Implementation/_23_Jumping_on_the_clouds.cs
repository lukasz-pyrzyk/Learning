using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string
    /// </summary>
    class _23_Jumping_on_the_clouds
    {
        public static void Main()
        {
            int clouds = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, int.Parse);

            int jumps = 0;
            int position = 0;
            while (true)
            {
                int jumpDistance = 1;
                if (position + 2 != clouds && c[position + 2] == 0)
                {
                    jumpDistance = 2;
                }

                position += jumpDistance;
                jumps++;
                if (position == clouds - 1)
                {
                    break;
                }
            }

            Console.WriteLine(jumps);
        }
    }
}
