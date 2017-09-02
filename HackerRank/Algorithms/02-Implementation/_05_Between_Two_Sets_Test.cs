using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _05_Between_Two_Sets_Test : BaseFixture
    {
        private string StdIn => "2 3\r\n"
                                        + "2 4\r\n"
                                        + "16 32 96\r\n";

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData(StdIn, "3");
        }

        protected override void RunLogic()
        {
            _05_Between_Two_Sets.Main();
        }
    }
}
