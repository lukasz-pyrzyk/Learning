using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _14_jumping_on_the_clouds_revisited_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("8 2\r\n0 0 1 0 0 1 1 0\r\n", "92");
        }

        protected override void RunLogic()
        {
            _14_jumping_on_the_clouds_revisited.Main();
        }
    }
}
