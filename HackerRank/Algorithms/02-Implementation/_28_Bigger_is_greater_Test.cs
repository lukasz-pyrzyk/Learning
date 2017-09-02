using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _28_Bigger_is_greater_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("5\r\nab\r\nbb\r\nhefg\r\ndhck\r\ndkhc\r\n", "ba\r\nno answer\r\nhegf\r\ndhkc\r\nhcdk\r\n");
        }

        protected override void RunLogic()
        {
            _28_Bigger_is_greater.Main();
        }
    }
}
