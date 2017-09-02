using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day23_Test : BaseFixture
    {
        protected override void RunLogic()
        {
            Day23.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n"
                                    + "3\r\n"
                                    + "5\r\n"
                                    + "4\r\n"
                                    + "7\r\n"
                                    + "2\r\n"
                                    + "1\r\n",
                                    "3 2 5 1 4 7 ");
        }
    }
}
