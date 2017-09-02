using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day25_Test : BaseFixture

    {
        protected override void RunLogic()
        {
            Day25.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("3\r\n12\r\n5\r\n7\r\n", "Not prime\r\nPrime\r\nPrime\r\n");
        }
    }
}
