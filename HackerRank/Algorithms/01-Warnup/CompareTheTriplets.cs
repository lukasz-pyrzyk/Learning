using System;

namespace _01_Warnup
{
    class CompareTheTriplets
    {

        private static void Compare(int av, int bv, ref int a, ref int b)
        {
            if (av > bv) a++;
            else if (av < bv) b++;
        }

        public static void Main()
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int a = 0, b = 0;
            Compare(a0, b0, ref a, ref b);
            Compare(a1, b1, ref a, ref b);
            Compare(a2, b2, ref a, ref b);

            Console.WriteLine($"{a} {b}");
        }
    }
}
