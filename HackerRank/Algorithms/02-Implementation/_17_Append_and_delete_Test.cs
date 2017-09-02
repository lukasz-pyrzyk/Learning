using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _17_Append_and_delete_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("hackerhappy\r\nhackerrank\r\n9\r\n", "Yes\r\n");
            yield return new TestData("abcd\r\nabcdert\r\n10\r\n", "No\r\n");
        }

        protected override void RunLogic()
        {
            _17_Append_and_delete.Main();
        }
    }
}
