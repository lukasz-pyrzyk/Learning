using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day11_Test : BaseFixture
    {
        protected override void RunLogic()
        {
            Day11.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("1 1 1 0 0 0\r\n" +
                                        "0 1 0 0 0 0\r\n" +
                                        "1 1 1 0 0 0\r\n" +
                                        "0 0 2 4 4 0\r\n" +
                                        "0 0 0 2 0 0\r\n" +
                                        "0 0 1 2 4 0\r\n",
                                        "19");


            yield return new TestData("-1 -1 0 -9 -2 -2\r\n" +
                                        "-2 -1 -6 -8 -2 -5\r\n" +
                                        "-1 -1 -1 -2 -3 -4\r\n" +
                                        "-1 -9 -2 -4 -4 -5\r\n" +
                                        "-7 -3 -3 -2 -9 -9\r\n" +
                                        "-1 -3 -1 -2 -4 -5\r\n",
                                        "-6");
        }
    }
}
