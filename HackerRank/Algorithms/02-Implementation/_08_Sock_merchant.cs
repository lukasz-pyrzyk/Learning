using System;
using System.Collections.Generic;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant
    /// </summary>
    class _08_Sock_merchant
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int pairs = 0;
            HashSet<int> socks = new HashSet<int>();
            for (int i = 0; i < c.Length; i++)
            {
                int socket = c[i];
                if (socks.Contains(socket))
                {
                    socks.Remove(socket);
                    pairs++;
                }
                else
                {
                    socks.Add(socket);
                }
            }

            Console.Write(pairs);
        }
    }
}
