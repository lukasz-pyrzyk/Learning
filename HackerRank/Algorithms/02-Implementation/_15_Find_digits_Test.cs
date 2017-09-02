using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _15_Find_digits_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("2\r\n12\r\n1012\r\n", "2\r\n3\r\n");
        }

        protected override void RunLogic()
        {
            _15_Find_digits.Main();
        }
    }
}
