using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _20_Cut_the_sticks_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n5 4 4 2 2 8\r\n", "6\r\n4\r\n2\r\n1\r\n");
            yield return new TestData("8\r\n1 2 3 4 3 3 2 1\r\n", "8\r\n6\r\n4\r\n1\r\n");
        }

        protected override void RunLogic()
        {
            _20_Cut_the_sticks.Main();
        }
    }
}
