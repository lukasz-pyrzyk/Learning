using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Warnup
{
    class CircularArrayRotation
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int position = m - k;
                position = position % n; // check for array overflow
                position = position + n;
                position = position % n; // check for array overflow
                Console.WriteLine(a[position]);
            }
        }
    }

    [TestFixture]
    public class CircularArrayRotationTests : BaseFixture
    {
        public string StdIn => "3 2 3\r\n" +
                                        "1 2 3\r\n" +
                                        "0\r\n" +
                                        "1\r\n" +
                                        "2";

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData(StdIn, "2\r\n3\r\n1\r\n");
        }

        protected override void RunLogic()
        {
            CircularArrayRotation.Main();
        }
    }
}
