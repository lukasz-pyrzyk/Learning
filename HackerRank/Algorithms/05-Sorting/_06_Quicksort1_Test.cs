using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _05_Sorting
{
    [TestFixture]
    public class _06_Quicksort1_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\n4 5 3 7 2\r\n", "3 2 4 5 7\r\n");
        }

        protected override void RunLogic()
        {
            _06_Quicksort1.Main();
        }
    }
}
