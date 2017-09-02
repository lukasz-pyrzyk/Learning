using System;
using System.Collections.Generic;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree
    /// </summary>
    class _09_Utopian_tree
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var tree = new UtopianTree();
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int height = tree.ProcessCycles(n);
                Console.WriteLine(height);
            }
        }

        class UtopianTree
        {
            public int ProcessCycles(int cycles)
            {
                int height = 1;

                for (int i = 0; i < cycles; i++)
                {
                    if (i % 2 == 0)
                    {
                        height *= 2;
                    }
                    else
                    {
                        height += 1;
                    }
                }

                return height;
            }
        }
    }
}
