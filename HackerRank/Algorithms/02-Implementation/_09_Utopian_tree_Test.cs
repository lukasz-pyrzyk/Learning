using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _09_Utopian_tree_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("3\r\n0\r\n1\r\n4\r\n", "1\r\n2\r\n7\r\n");
            yield return new TestData("2\r\n4\r\n3\r\n", "7\r\n6\r\n");
        }

        protected override void RunLogic()
        {
            _09_Utopian_tree.Main();
        }
    }
}
