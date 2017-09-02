using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("1 2 3 4 5\r\n", "10 14\r\n");
        }

        protected override void RunLogic()
        {
            _01_MiniMaxSum.Main();
        }
    }
}
