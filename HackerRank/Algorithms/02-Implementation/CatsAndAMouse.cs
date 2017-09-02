using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cats-and-a-mouse
    /// </summary>
    public class CatsAndAMouse
    {
        public static void Main()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_x[0]);
                int b = Convert.ToInt32(tokens_x[1]);
                int mouse = Convert.ToInt32(tokens_x[2]);

                int aDistance = Math.Abs(mouse - a);
                int bDistance = Math.Abs(mouse - b);

                if(aDistance == bDistance) Console.WriteLine("Mouse C");
                else if(aDistance < bDistance) Console.WriteLine("Cat A");
                else Console.WriteLine("Cat B");
            }
        }
    }

    [TestFixture]
    public class CatsAndAMouseTests : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("3\r\n1 2 3\r\n1 3 2\r\n2 1 3\r\n", "Cat B\r\nMouse C\r\nCat A\r\n");
        }

        protected override void RunLogic()
        {
            CatsAndAMouse.Main();
        }
    }
}