using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _16_Extra_long_factorials_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("25\r\n", "15511210043330985984000000\r\n");
        }

        protected override void RunLogic()
        {
            _16_Extra_long_factorials.Main();
        }
    }
}
