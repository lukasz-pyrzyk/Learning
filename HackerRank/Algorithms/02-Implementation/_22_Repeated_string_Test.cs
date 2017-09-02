using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _22_Repeated_string_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("aba\r\n10\r\n", "7\r\n");
            yield return new TestData("a\r\n1000000000000\r\n", "1000000000000\r\n");
        }

        protected override void RunLogic()
        {
            _22_Repeated_string.Main();
        }
    }
}
