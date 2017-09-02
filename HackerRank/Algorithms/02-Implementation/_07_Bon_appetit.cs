using System;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/bon-appetit
    /// </summary>
    class _07_Bon_appetit
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Convert.ToInt32);
            int charge = Convert.ToInt32(Console.ReadLine());

            int sharedCost = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i != k)
                {
                    sharedCost += a[i];
                }
            }

            int should = sharedCost/2;
            if (should == charge)
            {
                Console.Write("Bon Appetit");
            }
            else
            {
                Console.Write(charge - should);
            }
        }
    }
}
