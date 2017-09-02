using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _03_AppleAndOrange_Test : BaseFixture
    {
        private string StdIn => "7 11\r\n"
                                        + "5 15\r\n"
                                        + "3 2\r\n"
                                        + "-2 2 1\r\n"
                                        + "5 -6\r\n";


        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData(StdIn, "1\r\n1\r\n");
        }

        protected override void RunLogic()
        {
            _03_AppleAndOrange.Main();
        }
    }
}
