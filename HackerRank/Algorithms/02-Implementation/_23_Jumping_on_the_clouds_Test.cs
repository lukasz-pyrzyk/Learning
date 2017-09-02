using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _23_Jumping_on_the_clouds_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("7\r\n0 0 1 0 0 1 0\r\n", "4\r\n");
            yield return new TestData("6\r\n0 0 0 0 1 0\r\n", "3\r\n");
        }

        protected override void RunLogic()
        {
            _23_Jumping_on_the_clouds.Main();
        }
    }
}
