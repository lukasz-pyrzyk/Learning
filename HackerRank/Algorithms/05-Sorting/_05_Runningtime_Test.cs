using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _05_Sorting
{
    [TestFixture]
    public class _05_Runningtime_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\n2 1 3 1 2\r\n", "4\r\n");
        }

        protected override void RunLogic()
        {
            _05_Runningtime.Main();
        }
    }
}
