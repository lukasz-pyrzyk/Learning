using System;
using System.Collections;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    public class LonelyBits
    {
        static int lonelyinteger(int[] a)
        {
            int value = 0;
            foreach (int i in a)
            {
                value = value ^ i;
            }

            return value;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = lonelyinteger(a);
            Console.WriteLine(result);
        }


        [TestFixture]
        public class TheTimeInWordsTests : BaseFixture
        {
            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("1\r\n1\r\n", "1\r\n");
                yield return new TestData("3\r\n1 1 2\r\n", "2\r\n");
                yield return new TestData("5\r\n0 0 1 2 1\r\n", "2\r\n");
            }

            protected override void RunLogic()
            {
                Main();
            }
        }
    } 
}
