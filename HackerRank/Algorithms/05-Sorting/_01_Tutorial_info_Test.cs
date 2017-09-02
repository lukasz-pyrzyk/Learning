using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _05_Sorting
{
    [TestFixture]
    public class _01_Tutorial_info_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4\r\n6\r\n1 4 5 7 9 12\r\n", "1\r\n");
            yield return new TestData("23\r\n12\r\n1 3 5 7 9 11 13 15 17 19 21 23\r\n", "11\r\n");
        }

        protected override void RunLogic()
        {
            _01_Tutorial_info.Main();
        }
    }
}
