using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/acm-icpc-team
    /// </summary>
    class _25_Acm_icpc_team
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int peoples = Convert.ToInt32(line[0]);
            int topics = Convert.ToInt32(line[1]);
            string[] topicList = new string[peoples];

            for (int i = 0; i < peoples; i++)
            {
                topicList[i] = Console.ReadLine();
            }

            int max = 0, pairs = 0;
            for (int i = 0; i < peoples; i++)
            {
                for (int j = i + 1; j < peoples; j++)
                {
                    int counts = 0;
                    for (int k = 0; k < topics; k++)
                    {
                        if (topicList[i][k] == '1' || topicList[j][k] == '1') counts++;
                    }
                    if (counts > max)
                    {
                        max = counts;
                        pairs = 1;
                    }
                    else if (counts == max) pairs++;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(pairs);
        }
    }
}
