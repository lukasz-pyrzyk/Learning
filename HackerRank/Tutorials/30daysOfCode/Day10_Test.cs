using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _30daysOfCode
{
    [TestFixture]
    public class Day10_Test : BaseFixture
    {
        protected override void RunLogic()
        {
            Day10.Main();
        }

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5", "1");
            yield return new TestData("6", "2");
        }
    }
}
