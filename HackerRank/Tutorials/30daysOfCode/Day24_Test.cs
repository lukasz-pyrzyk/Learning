using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day24_Test : BaseFixture

    {
        protected override void RunLogic()
        {
            Day24.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n"
                                    + "1\r\n"
                                    + "2\r\n"
                                    + "2\r\n"
                                    + "3\r\n"
                                    + "3\r\n"
                                    + "4\r\n",
                                    "1 2 3 4 ");
        }
    }
}
