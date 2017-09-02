using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day22_Test : BaseFixture
    {
        protected override void RunLogic()
        {
            Day22.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("7\r\n"
                                    + "3\r\n"
                                    + "5\r\n"
                                    + "2\r\n"
                                    + "1\r\n"
                                    + "4\r\n"
                                    + "6\r\n"
                                    + "7\r\n", 
                                    "3\r\n");
        }
    }
}
