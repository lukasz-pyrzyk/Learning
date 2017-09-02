using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _05_Sorting
{
    [TestFixture]
    public class _04_Correctness_invariant_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n1 4 3 5 6 2\r\n", "1 2 3 4 5 6\r\n");
        }

        protected override void RunLogic()
        {
            _04_Correctness_invariant.Main();
        }
    }
}
