using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _24_Equality_in_a_array_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\n3 3 2 1 3\r\n", "2\r\n");
            yield return new TestData("6\r\n0 0 0 0 0 0\r\n", "0\r\n");
        }

        protected override void RunLogic()
        {
            _24_Equality_in_a_array.Main();
        }
    }
}
