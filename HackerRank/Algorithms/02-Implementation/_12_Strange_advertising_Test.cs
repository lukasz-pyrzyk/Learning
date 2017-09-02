using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _12_Strange_advertising_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("3\r\n", "9");
        }

        protected override void RunLogic()
        {
            _12_Strange_advertising.Main();
        }
    }
}
