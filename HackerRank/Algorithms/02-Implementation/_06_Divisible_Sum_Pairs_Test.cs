using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _06_Divisible_Sum_Pairs_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6 3\r\n1 3 2 6 1 2\r\n", "5");
        }

        protected override void RunLogic()
        {
            _06_Divisible_Sum_Pairs.Main();
        }
    }
}
